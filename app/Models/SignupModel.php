<?php

namespace App\Models;

use CodeIgniter\Model;

class SignupModel extends Model
{
    protected $table = 'client';
    protected $allowedFields = [
        'NOM',
        'PRENOM',
        'ADRESSE',
        'CODEPOSTAL',
        'VILLE',
        'TELEPHONEFIXE',
        'TELEPHONEMOBILE',
        'MEL',
        'MOTDEPASSE'
    ];


    public function alreadyExists($email)
    {
        return $this->where(['MEL' => $email])->first() !== null;
    }

}


?>