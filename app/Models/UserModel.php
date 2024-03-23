<?php

namespace App\Models;

use CodeIgniter\Model;

class UserModel extends Model
{
    protected $table = 'client';


    public function validateUser($email, $password)
    {
        $user = $this->where(['MEL' => $email])->first();
        if(!$user){
            return false;
        }
        return password_verify($password, $user['MOTDEPASSE']);

    }

    public function getUserData($email)
    {
        return $this->where(['MEL' => $email])->first();
    }

}


