<?php

namespace App\Models;

use CodeIgniter\Model;

class ClientModel extends Model
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

}


?>