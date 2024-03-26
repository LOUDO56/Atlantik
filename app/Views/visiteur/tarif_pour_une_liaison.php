<div class="container py-5 mt-5">
    <table class="table table-success">
        <thead>
            <th>Catégorie</th>
            <th>Type</th>
            <th>Période</th>
        </thead>
        <tbody>
            <?php foreach($datas as $data):?>
                <tr>
                    <td><?= $data->CATEGORIE?></td>
                </tr>
            <?php endforeach?>
        </tbody>
    </table>
</div>
