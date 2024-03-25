<div class="d-flex justify-content-center align-items-center vh-100 flex-column">
    <h3 class="fw-bold mb-3">Modifier les informations</h3>
    <form action="/editprofile" method="post">
        <?= csrf_field() ?>
        <?php $session = session();?>
        <div class="row">
            <div class="col mb-2">
                <label for="nom" class="form-label">Nom <span class="text-danger">*</span></label>
                <input type="text" class="form-control" id="nom" name="nom" autocomplete="off" value="<?= $session->get('nom') ?>" required>
            </div>

            <div class="col mb-2">
                <label for="prenom" class="form-label">Prenom <span class="text-danger">*</span></label>
                <input type="text" class="form-control" id="prenom" name="prenom" autocomplete="off" value="<?= $session->get('prenom') ?>" required>
            </div>
        </div>
        <div class="row">
            <div class="col mb-2">
                <label for="email" class="form-label">Email <span class="text-danger">*</span></label>
                <input type="text" class="form-control <?php if(isset($error['email'])) echo "is-invalid"?>" id="email" name="email" autocomplete="off" value="<?php if(isset($error['email'])) echo set_value('email'); else echo $session->get('email');?>" required>
                <?php if(isset($error['email'])): ?>
                    <div class="invalid-feedback">
                        <?php echo $error['email']?>
                    </div>
                <?php endif;?>

            </div>

            <div class="col mb-2">
                <label for="password" class="form-label">Nouveau mot de passe</label>
                <input type="password" class="form-control" id="password" name="password" minlength="4" autocomplete="off">
            </div>
        </div>

        <div class="mb-2">
            <label for="adresse" class="form-label">Adresse <span class="text-danger">*</span></label>
            <input type="text" class="form-control" id="adresse" name="adresse" autocomplete="off" value="<?= $session->get('adresse') ?>" required>
        </div>

        <div class="mb-2">
            <label for="codePostal" class="form-label">Code Postal <span class="text-danger">*</span></label>
            <input type="number" class="form-control" id="codePostal" name="codePostal" min="10000" max="99999" autocomplete="off" value="<?= $session->get('codePostal') ?>" required>
        </div>

        <div class="mb-2">
            <label for="ville" class="form-label">Ville <span class="text-danger">*</span></label>
            <input type="text" class="form-control" id="ville" name="ville" autocomplete="off" value="<?= $session->get('ville') ?>" required>
        </div>
        
        <div class="mb-2">
            <label for="telPortable" class="form-label">Téléphone Portable <span class="text-danger">*</span></label>
            <input type="text" class="form-control <?php if(isset($error['telPortable'])) echo "is-invalid"?>" id="telPortable" name="telPortable" autocomplete="off" value="<?php if(isset($error['telPortable'])) echo set_value('telPortable'); else echo $session->get('telPortable');?>" required>
            <?php if(isset($error['telPortable'])): ?>
                <div class="invalid-feedback">
                    <?php echo $error['telPortable']?>
                </div>
            <?php endif;?>
        </div>

        <div class="mb-3">
            <label for="telFixe" class="form-label">Téléphone Fixe</label>
            <input type="text" class="form-control <?php if(isset($error['telFixe'])) echo "is-invalid"?>" id="telFixe" name="telFixe" autocomplete="off" value="<?php if(isset($error['telFixe'])) echo set_value('telFixe'); else echo $session->get('telFixe');?>">
            <?php if(isset($error['telFixe'])): ?>
                <div class="invalid-feedback">
                    <?php echo $error['telFixe']?>
                </div>
            <?php endif;?>
        </div>

        <?php if($session->has('success')):?>
            <div class="alert alert-success">
                Les informations ont été mis à jour!
            </div>
        <?php endif;?>
        <div class="text-center">
            <button type="submit" class="btn btn-primary">Modifier</button>
        </div>
    </form>
    <?php $session->close();?>
</div>