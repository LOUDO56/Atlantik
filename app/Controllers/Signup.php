<?php

namespace App\Controllers;

use App\Models\ClientModel;

class Signup extends BaseController
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

        if (!$this->validateData($data, [
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
            'telFixe' => [
                'rules' => 'required_with[min_length[10]|max_length[10]]',
                'errors' => [
                    'min_length' => 'Ce numéro de téléphone n\'est pas valide.',
                    'max_length' => 'Ce numéro de téléphone n\'est pas valide.',
                ]
            ],
        ])) {
            
            return $this->index($this->validator->getErrors());
        }

        $post = $this->validator->getValidated();

        $model = model(ClientModel::class);

        $model->save([
            'NOM' => $post['nom'],
            'PRENOM' => $post['prenom'],
            'ADRESSE' => $post['adresse'],
            'CODEPOSTAL' => $post['codePostal'],
            'VILLE' => $post['ville'],
            'TELEPHONEFIXE' => !empty($post['telFixe']) ? $post['telFixe'] : null,
            'TELEPHONEMOBILE' => $post['telPortable'],
            'MEL' => $post['email'],
            'MOTDEPASSE' => md5($post['password']),
        ]);

        return view('templates/header') .
            view('connection/success');

    }

}
