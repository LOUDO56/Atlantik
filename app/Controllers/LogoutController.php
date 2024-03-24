<?php

namespace App\Controllers;

use App\Models\UserModel;

class LogoutController extends BaseController
{
    public function index()
    {
        $session = session();

        if($session->get('is_logged')){
            $session->destroy();
        }

        $session->close();

        return redirect()->to('/');
    }
}