<?php

namespace App\Models;

use CodeIgniter\Model;


class TarifLiaisonModel extends Model
{

    protected $table = 'liaison';

    public function tarifLiaisonExists($noliaison): bool
    {
        return $this->where(['NOLIAISON' => $noliaison])->first() !== null;
    }

    public function getTarifParUneLiaison(int $noliaison)
    {
        return $this->select('categorie.LIBELLE as "CATEGORIE", type.LETTRECATEGORIE as "TYPE", type.LIBELLE, DATEDEBUT, DATEFIN, TARIF')
            ->join('port as portdepart', 'liaison.NOPORT_DEPART = portdepart.NOPORT')
            ->join('port as portarrive', 'liaison.NOPORT_ARRIVEE = portarrive.NOPORT')
            ->join('tarifer', 'liaison.NOLIAISON = tarifer.NOLIAISON')
            ->join('periode', 'tarifer.NOPERIODE = periode.NOPERIODE')
            ->join('type', 'tarifer.LETTRECATEGORIE = type.LETTRECATEGORIE')
            ->join('categorie', 'type.LETTRECATEGORIE = categorie.LETTRECATEGORIE')
            ->where(['liaison.NOLIAISON' => $noliaison])
            ->get()
            ->getResult();
    }

}