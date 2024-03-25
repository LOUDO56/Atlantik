<?php

namespace App\Controllers;
use App\Models\UserModel;

class ClientController extends BaseController
{
    public function logout()
    {
        $session = session();

        if($session->get('is_logged')){
            $session->destroy();
        }

        $session->close();

        return redirect()->to('/');
    }

    public function editUserInformationForm($error = [])
    {
        helper('form');

        $session = session();
        if(!$session->has('is_logged')){
            $session->close();
            return redirect()->to('/login');
        }

        $post['error'] = $error;

        return view('templates/header') .
            view('profile/editprofile', $post);
    }

    public function editUserInformation()
    {
        helper('form');

        $session = session();

        $post = $this->request->getPost();

        $model = model(UserModel::class);

        $rules = [
            'nom' => 'required',
            'prenom'  => 'required',
            'email' => [
                'rules' => 'required|valid_email',
                'errors' => [
                    'valid_email' => 'Veuillez mettre un email valide.'
                ]
            ],
            'password' => 'permit_empty|min_length[4]',
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

        // Eviter l'erreur de l'email déjà présent si l'utilisateur ne souhaite pas changer d'email
        if($post['email'] !== $session->get('email')){
            $rules['email']['rules'] .= '|accountAvalaible';
        }

        if (!$this->validate($rules)) {
            return $this->editUserInformationForm($this->validator->getErrors());
        }

        // Si l'utilisateur met un nouveau mot de passe, on le change
        if(!empty($post['password'])){
            $model->set(['MOTDEPASSE' => password_hash($post['password'], PASSWORD_DEFAULT)]);
            $model->where('NOCLIENT', $model->getClientId($session->get('email')));
            $model->update();
        }

        // Ensuite on change modifie les autres informations
        $model->set([
            'NOM' => $post['nom'],
            'PRENOM' => $post['prenom'],
            'ADRESSE' => $post['adresse'],
            'CODEPOSTAL' => $post['codePostal'],
            'VILLE' => $post['ville'],
            'TELEPHONEFIXE' => !empty($post['telFixe']) ? $post['telFixe'] : null,
            'TELEPHONEMOBILE' => $post['telPortable'],
            'MEL' => $post['email'],
        ]);


        $model->where('NOCLIENT', $model->getClientId($session->get('email')));
        $model->update();

        // Et on redéfini la session
        $session->set([
            'nom' => $post['nom'],
            'prenom' => $post['prenom'],
            'adresse' => $post['adresse'],
            'codePostal' => $post['codePostal'],
            'ville' => $post['ville'],
            'telFixe' => $post['telFixe'],
            'telPortable' => $post['telPortable'],
            'email' => $post['email'],
        ]);
        $session->close();

        return view('templates/header') .
            view('connection/success');

    }


}