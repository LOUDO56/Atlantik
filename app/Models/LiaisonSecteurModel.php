<?php

namespace App\Models;

use CodeIgniter\Model;
use App\Models\SecteurModel;


class LiaisonSecteurModel extends Model
{

    public function getLiaisonParSecteur(): array
    {

        $liaison = [];
        $secteurTable = $this->db->table('secteur');
        $liaisonTable = $this->db->table('liaison');

        foreach($secteurTable->select('*')->get()->getResult() as $secteur)
        {
            $liaisonSecteur = $liaisonTable
                ->select('*, portdepart.NOM AS NomPortDepart, portarrive.NOM AS NomPortArrivee, secteur.NOM AS NomSecteur')
                ->join('port as portdepart', 'liaison.NOPORT_DEPART = portdepart.NOPORT')
                ->join('port as portarrive', 'liaison.NOPORT_ARRIVEE = portarrive.NOPORT')
                ->join('secteur', 'liaison.NOSECTEUR = secteur.NOSECTEUR')
                ->where('secteur.NOSECTEUR', $secteur->NOSECTEUR)
                ->get()
                ->getResult();

            if(count($liaisonSecteur) !== 0){
                array_push($liaison, $liaisonSecteur);
            }

        }

        return $liaison;
    }

}