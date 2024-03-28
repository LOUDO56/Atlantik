<div class="container py-5 mt-5">
    <table class="table table-success">
        <thead>
            <tr>
                <th>Catégorie</th>
                <th>Type</th>
                <th>Periode</th>
                <th>Tarif</th>
            </tr>	
        </thead>
        <tbody>
            <?php $categorie = ""?>
            <?php foreach($datas as $data):?>
                <tr>
                    <td><?= $data->LETTRECATEGORIE . " " . $data->CATEGORIE?></td>
                    <td><?= $data->LETTRECATEGORIE . $data->NOTYPE . " - " . $data->LIBELLE?></td>
                    <td><?= $data->DATEDEBUT . " " . $data->DATEFIN?></td>
                    <td><?= $data->TARIF?></td>
                </tr>
                <?php $categorie = $data->CATEGORIE?>
            <?php endforeach?>
        </tbody>
    </table>
</div>
