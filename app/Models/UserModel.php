<?php

namespace App\Models;

use CodeIgniter\Model;

class UserModel extends Model
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


    public function validateUser($email, $password)
    {
        $user = $this->where(['MEL' => $email])->first();
        if(!$user){
            return false;
        }
        return password_verify($password, $user['MOTDEPASSE']);

    }

    public function getClientId($email)
    {
        return $this->where(['MEL' => $email])->first()['NOCLIENT'];
    }

    public function userExists($email)
    {
        return $this->where(['MEL' => $email])->first() !== null;
    }

}


