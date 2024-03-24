<?php

namespace App\Controllers;

use App\Models\UserModel;

class SignupController extends BaseController
{
    public function index($error = [])
    {

        helper('form');

        $data['error'] = $error;

        return view('templates/header') . 
            view('connection/signup', $data);
    
    }

    public function register()
    {
        helper('form');

        $data = $this->request->getPost();

        $model = model(UserModel::class);

        if($model->alreadyExists($data['email'])){
            return $this->index(['email' => 'Cet email est déjà utilisé']);
        }

        $rules = [
            'nom' => 'required',
            'prenom'  => 'required',
            'email' => [
                'rules' => 'required|valid_email',
                'errors' => [
                    'valid_email' => 'Veuillez mettre un email valide.'
                ]
            ],
            'password' => 'required|min_length[4]',
            'adresse' => 'required',
            'codePostal' => 'required|integer|greater_than_equal_to[10000]|less_than_equal_to[99999]',
            'ville' => 'required',
            'telPortable' => [
                'rules' => 'required|min_length[10]|max_length[10]',
                'errors' => [
                    'min_length' => 'Ce numéro de téléphone n\'est pas valide.',
                    'max_length' => 'Ce numéro de téléphone n\'est pas valide.',
                ]
            ],
        ];

        if(!empty($data['telFixe'])){
            $rules['telFixe'] = [
                'rules' => 'min_length[10]|max_length[10]',
                'errors' => [
                    'min_length' => 'Ce numéro de téléphone n\'est pas valide.',
                    'max_length' => 'Ce numéro de téléphone n\'est pas valide.',
                ]
            ];
        }

        if (!$this->validateData($data, $rules)) {
            
            return $this->index($this->validator->getErrors());
        }

        $post = $this->validator->getValidated();

        $model->save([
            'NOM' => $post['nom'],
            'PRENOM' => $post['prenom'],
            'ADRESSE' => $post['adresse'],
            'CODEPOSTAL' => $post['codePostal'],
            'VILLE' => $post['ville'],
            'TELEPHONEFIXE' => !empty($post['telFixe']) ? $post['telFixe'] : null,
            'TELEPHONEMOBILE' => $post['telPortable'],
            'MEL' => $post['email'],
            'MOTDEPASSE' => password_hash($post['password'], PASSWORD_DEFAULT),
        ]);

        return view('templates/header') .
            view('connection/success');

    }

}
