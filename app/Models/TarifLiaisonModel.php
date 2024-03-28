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
        return $this->select('categorie.LIBELLE as "CATEGORIE", type.LETTRECATEGORIE, type.LIBELLE, type.NOTYPE, DATEDEBUT, DATEFIN, TARIF')
            ->join('port as portdepart', 'liaison.NOPORT_DEPART = portdepart.NOPORT')
            ->join('port as portarrive', 'liaison.NOPORT_ARRIVEE = portarrive.NOPORT')
            ->join('tarifer', 'liaison.NOLIAISON = tarifer.NOLIAISON')
            ->join('periode', 'tarifer.NOPERIODE = periode.NOPERIODE')
            ->join('type', 'tarifer.NOTYPE = type.NOTYPE AND tarifer.LETTRECATEGORIE = type.LETTRECATEGORIE')
            ->join('categorie', 'type.LETTRECATEGORIE = categorie.LETTRECATEGORIE')
            ->where('tarifer.NOLIAISON', $noliaison)
            ->where('periode.DATEDEBUT <= periode.DATEFIN')
            ->orderBy('tarifer.LETTRECATEGORIE, tarifer.NOTYPE')
            ->get()
            ->getResult();
        // La requête de fou

    }

}