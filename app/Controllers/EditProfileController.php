<?php

namespace App\Controllers;
use App\Models\UserModel;

class EditProfileController extends BaseController
{
    public function index($error = [])
    {
        helper('form');

        $session = session();
        if(!$session->has('is_logged')){
            $session->close();
            return redirect()->to('/login');
        }

        $data['error'] = $error;

        return view('templates/header') .
            view('profile/editprofile', $data);
    }

    public function editUserInformation()
    {
        helper('form');

        $data = $this->request->getPost();

        $model = model(UserModel::class);

        if(session()->get('email') != $data['email'] & $model->alreadyExists($data['email'])){
            return $this->index(['email' => 'Cet email est déjà utilisé']);
        }

        $rules = [
            'email' => [
                'rules' => 'valid_email',
                'errors' => [
                    'valid_email' => 'Veuillez mettre un email valide.'
                ]
            ],
            'password' => 'required_with[min_length[4]]',
            'codePostal' => 'integer|greater_than_equal_to[10000]|less_than_equal_to[99999]',
            'telPortable' => [
                'rules' => 'required|min_length[10]|max_length[10]',
                'errors' => [
                    'min_length' => 'Ce numéro de téléphone n\'est pas valide.',
                    'max_length' => 'Ce numéro de téléphone n\'est pas valide.',
                ]
            ]
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

        $session = session();

        $post = $this->validator->getValidated();

        // Si l'utilisateur met un nouveau mot de passe, on le change
        if(!empty($post['password'])){
            $model->set(['MOTDEPASSE' => password_hash($post['password'], PASSWORD_DEFAULT)]);
            $model->where('NOCLIENT', $model->getClientId($session->get('email')));
            $model->update();
        }

        // Ensuite on change modifie les autres informations
        $model->set([
            'NOM' => $data['nom'],
            'PRENOM' => $data['prenom'],
            'ADRESSE' => $data['adresse'],
            'CODEPOSTAL' => $post['codePostal'],
            'VILLE' => $data['ville'],
            'TELEPHONEFIXE' => !empty($post['telFixe']) ? $post['telFixe'] : null,
            'TELEPHONEMOBILE' => $post['telPortable'],
            'MEL' => $post['email'],
        ]);


        $model->where('NOCLIENT', $model->getClientId($session->get('email')));
        $model->update();

        // Et on redéfini la session
        $userdata = $model->where(['MEL' => $post['email']])->first();
        $session->set([
            'nom' => $userdata['NOM'],
            'prenom' => $userdata['PRENOM'],
            'adresse' => $userdata['ADRESSE'],
            'codePostal' => $userdata['CODEPOSTAL'],
            'ville' => $userdata['VILLE'],
            'telFixe' => $userdata['TELEPHONEFIXE'],
            'telPortable' => $userdata['TELEPHONEMOBILE'],
            'email' => $userdata['MEL'],
        ]);
        $session->close();

        return view('templates/header') .
            view('connection/success');

    }

}
