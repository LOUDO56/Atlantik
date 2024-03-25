<?php

namespace App\Controllers;

use App\Models\UserModel;

class VisiteurController extends BaseController
{

    public function registerForm($error = [])
    {

        helper('form');

        $data['error'] = $error;

        return view('templates/header') . 
            view('templates/navbar') .
            view('connection/signup', $data);
    
    }

    public function register()
    {
        helper('form');

        $post = $this->request->getPost();

        $model = model(UserModel::class);

        $rules = [
            'nom' => 'required',
            'prenom'  => 'required',
            'email' => [
                'rules' => 'required|valid_email|accountAvalaible',
                'errors' => [
                    'valid_email' => 'Veuillez mettre un email valide.'
                ]
            ],
            'password' => 'required|min_length[4]',
            'adresse' => 'required',
            'codePostal' => 'required|integer|greater_than_equal_to[10000]|less_than_equal_to[99999]',
            'ville' => 'required',
            'telPortable' => [
                'rules' => 'required|frenchNumber',
            ],
            'telFixe' => [
                'rules' => 'permit_empty|frenchNumber'
            ]
        ];

        if (!$this->validate($rules)) {
            return $this->registerForm($this->validator->getErrors());
        }

        $userdata = [
            'NOM' => $post['nom'],
            'PRENOM' => $post['prenom'],
            'ADRESSE' => $post['adresse'],
            'CODEPOSTAL' => $post['codePostal'],
            'VILLE' => $post['ville'],
            'TELEPHONEFIXE' => !empty($post['telFixe']) ? $post['telFixe'] : null,
            'TELEPHONEMOBILE' => $post['telPortable'],
            'MEL' => $post['email'],
            'MOTDEPASSE' => password_hash($post['password'], PASSWORD_DEFAULT),
        ];

        $model->save($userdata);
        $this->setLoginSession($userdata);
        return redirect()->to('/');

    }

    public function loginForm($error = null)
    {
        helper('form');
        $data['error'] = $error;
        return view('templates/header') .
            view('templates/navbar') .
            view('connection/login', $data);
    }

    public function loginUser()
    {

        helper('form');

        $email = $this->request->getVar('email');
        $password = $this->request->getVar('password');

        $model = model(UserModel::class);

        if(!$model->userExists($email)) {
            return $this->loginForm(['email' => "Aucun compte est associé à ce mail."]);
        }

        $rules = [
            'email' => 'required|valid_email',
            'password' => 'required|min_length[4]|validateUser[email, password]'
        ];

        $errors = [
            'password' => 'Oups ! Le mot de passe est incorrect.',
        ];

        if(!$this->validate($rules, $errors)){
            return $this->loginForm($errors);
        }

        if($model->validateUser($email, $password)){
            $this->setLoginSession($model->where(['MEL' => $email])->first()); 
            return redirect()->to('/');
        } else {
            return $this->loginForm($errors);
        }

        

    }

    public function setLoginSession($userdata)
    {
        $session = session();
        $session->set([
            'nom' => $userdata['NOM'],
            'prenom' => $userdata['PRENOM'],
            'adresse' => $userdata['ADRESSE'],
            'codePostal' => $userdata['CODEPOSTAL'],
            'ville' => $userdata['VILLE'],
            'telFixe' => $userdata['TELEPHONEFIXE'],
            'telPortable' => $userdata['TELEPHONEMOBILE'],
            'email' => $userdata['MEL'],
            'is_logged' => true
        ]);
        $session->close();
    }

}