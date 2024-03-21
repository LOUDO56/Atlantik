<?php

namespace App\Controllers;

use App\Model\SignupModel;

class Signup extends BaseController
{
    public function index()
    {

        helper('form');

        return view('templates/header') . 
            view('connection/signup');
    
    }

    public function register()
    {
        helper('form');

        $post = $this->request->getPost();

        $model = model(SignupModel::class);

        $model->save([
            'nom' => $post['nom'],
            'prenom' => $post['prenom'],
            'email' => $post['email'],
            'mdp' => md5($post['mdp']),
            'adresse' => $post['adresse'],
            'codePostal' => $post['codePostal'],
            'ville' => $post['ville'],
            'telFixe' => $post['telFixe'],
            'telPortable' => $post['telPortable']
        ]);

        return view('templates/header') .
            view('connection/success');



    }

}
