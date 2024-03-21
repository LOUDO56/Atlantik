<?php

namespace App\Controllers;

use App\Models\LivreModel;
use CodeIgniter\Exceptions\PageNotFoundException;

class Livre extends BaseController
{
    public function show($nolivre = null)
    {
        $model = model(LivreModel::class);

        $data['livre'] = $model->getInfoLivre($nolivre);

        if (empty($data['livre'])) {
            throw new PageNotFoundException('Ce livre n\'existe pas.');
        }

        $data['title'] = $data['livre']['titre'];
        $data['resume'] = $data['livre']['resume'];

        return view('templates/header', $data)
            . view('livre/view')
            . view('templates/footer');
            
    }
}

?>