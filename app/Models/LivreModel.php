<?php

namespace App\Models;

use CodeIgniter\Model;

class LivreModel extends Model
{
    protected $table = 'livre';

    public function getInfoLivre($nolivre)
    {
        return $this->where(['nolivre' => $nolivre])->first();
    }
}


?>