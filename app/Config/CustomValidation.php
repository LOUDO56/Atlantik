<?php

namespace Config;

use App\Models\UserModel;

class CustomValidation
{
    public function accountAvalaible(string $str, ?string &$error = null): bool
    {
        $model = model(UserModel::class);

        if(!$model->userExists($str)){
            return true;
        }


        $error = 'Cet email est déjà utilisé.';

        return false;
    }

    public function accountExists(string $str, ?string &$error = null): bool
    {
        $model = model(UserModel::class);

        if($model->userExists($str)){
            return true;
        }


        $error = 'Cet email est associé a aucun compte.';

        return false;
    }

    public function validateUser(string $str, string $field, array $data)
    {
        $model = model(UserModel::class);
        $user = $model->where(['MEL' => $data['email']])->first();
        if(!$user){
            return false;
        }
        return password_verify($data['password'], $user['MOTDEPASSE']);
    }

    public function frenchNumber(string $str, ?string &$error = null): bool
    {
        $regex = "/^(?:(?:(?:\+|00)33[ ]?(?:\(0\)[ ]?)?)|0){1}[1-9]{1}([ .-]?)(?:\d{2}\1?){3}\d{2}$/";

        if(preg_match($regex, $str)){
            return true;
        }

        $error = 'Ce numéro de téléphone n\'est pas valide.';

        return false;

    }

}