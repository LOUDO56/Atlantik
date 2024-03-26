<div class="container py-5 mt-5">
    <table class="table table-primary table-striped">
        <thead>
            
            <th>Secteur</th>
            <th>Code Liaison</th>
            <th>Distance en milles marin</th>
            <th>Port de départ</th>
            <th>Port d'arrivée</th>
        </thead>
        <tbody>
            <?php foreach($liaisons as $liaison):?>
                <?php $i = 0 // Afficher une fois le nom du secteur dans le tableau?> 
                <?php foreach($liaison as $infoLiaison):?>
                    <tr>
                        <th><?php if($i === 0) echo $infoLiaison->NomSecteur?></th>
                        <td><a href="<?= site_url('liaison/'.$infoLiaison->NOLIAISON)?>"><?= $infoLiaison->NOLIAISON?></a></td>
                        <td><?= $infoLiaison->DISTANCE?></td>
                        <td><?= $infoLiaison->NomPortDepart?></td>
                        <td><?= $infoLiaison->NomPortArrivee?></td>
                    </tr>
                    <?php $i += 1?>
                <?php endforeach;?>
                <?php $i = 0?>
            <?php endforeach;?>
        </tbody>
    </table>
</div>