<?php

namespace App\Controllers;

use App\Models\UserModel;

class LoginController extends BaseController
{

    public function index($error = null)
    {
        helper('form');
        $data['error'] = $error;
        return view('templates/header') .
            view('connection/login', $data);
    }

    public function loginUser()
    {

        helper('form');

        $email = $this->request->getVar('email');
        $password = $this->request->getVar('password');

        $rules = [
            'email' => 'required|valid_email',
            'password' => 'required|min_length[4]'
        ];

        $errors = [
            'password' => 'L\'email ou le mot de passe est incorrect'
        ];

        if(!$this->validate($rules, $errors)){
            return $this->index($errors);
        }

        $model = model(UserModel::class);

        if($model->validateUser($email, $password)){
            $session = session();
            $userdata = $model->where(['MEL' => $email])->first();
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
            return redirect()->to('/');
            
        } else {
            return $this->index($errors);
        }

        

    }


}