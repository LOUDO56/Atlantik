<?php

namespace Config;

use App\Models\UserModel;

class CustomValidation
{
    public function accountAvalaible(string $str, ?string &$error = null): bool
    {
        $model = model(UserModel::class);

        if(!$model->alreadyExists($str)){
            return true;
        }


        $error = 'Cet email est déjà utilisé.';

        return false;
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