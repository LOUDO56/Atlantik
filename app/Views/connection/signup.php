<div class="d-flex justify-content-center align-items-center vh-100 flex-column">
    <h3 class="fw-bold mb-3">Créer un compte</h3>
    <form action="/signup" method="post">
        <?= csrf_field() ?>
        <div class="row">
            <div class="col mb-2">
                <label for="nom" class="form-label">Nom <span class="text-danger">*</span></label>
                <input type="text" class="form-control" id="nom" name="nom" autocomplete="off" value="<?= set_value('nom') ?>" required>
            </div>

            <div class="col mb-2">
                <label for="prenom" class="form-label">Prenom <span class="text-danger">*</span></label>
                <input type="text" class="form-control" id="prenom" name="prenom" autocomplete="off" value="<?= set_value('prenom') ?>" required>
            </div>
        </div>
        <div class="row">
            <div class="col mb-2">
                <label for="email" class="form-label">Email <span class="text-danger">*</span></label>
                <input type="text" class="form-control <?php if(isset($error['email'])) echo "is-invalid"?>" id="email" name="email" autocomplete="off" value="<?= set_value('email') ?>" required>
                <?php if(isset($error['email'])): ?>
                    <div class="invalid-feedback">
                        <?php echo $error['email']?>
                    </div>
                <?php endif;?>

            </div>

            <div class="col mb-2">
                <label for="password" class="form-label">Mot de passe <span class="text-danger">*</span></label>
                <input type="password" class="form-control" id="password" name="password" minlength="4" autocomplete="off" value="<?= set_value('password') ?>" required>
            </div>
        </div>

        <div class="mb-2">
            <label for="adresse" class="form-label">Adresse <span class="text-danger">*</span></label>
            <input type="text" class="form-control" id="adresse" name="adresse" autocomplete="off" value="<?= set_value('adresse') ?>" required>
        </div>

        <div class="mb-2">
            <label for="codePostal" class="form-label">Code Postal <span class="text-danger">*</span></label>
            <input type="number" class="form-control" id="codePostal" name="codePostal" min="10000" max="99999" autocomplete="off" value="<?= set_value('codePostal') ?>" required>
        </div>

        <div class="mb-2">
            <label for="ville" class="form-label">Ville <span class="text-danger">*</span></label>
            <input type="text" class="form-control" id="ville" name="ville" autocomplete="off" value="<?= set_value('ville') ?>" required>
        </div>
        
        <div class="mb-2">
            <label for="telPortable" class="form-label">Téléphone Portable <span class="text-danger">*</span></label>
            <input type="text" class="form-control <?php if(isset($error['telPortable'])) echo "is-invalid"?>" id="telPortable" name="telPortable" autocomplete="off" value="<?= set_value('telPortable') ?>" required>
            <?php if(isset($error['telPortable'])): ?>
                <div class="invalid-feedback">
                    <?php echo $error['telPortable']?>
                </div>
            <?php endif;?>
        </div>

        <div class="mb-4">
            <label for="telFixe" class="form-label">Téléphone Fixe</label>
            <input type="text" class="form-control <?php if(isset($error['telFixe'])) echo "is-invalid"?>" id="telFixe" name="telFixe" autocomplete="off" value="<?= set_value('telFixe') ?>">
            <?php if(isset($error['telFixe'])): ?>
                <div class="invalid-feedback">
                    <?php echo $error['telFixe']?>
                </div>
            <?php endif;?>
        </div>

        <div class="text-center mb-3">
            <button type="submit" class="btn btn-primary w-100">S'inscrire</button>
        </div>

        <div class="d-flex justify-content-end">
            <a href="/signup" class="link-secondary text-decoration-none">Déjà membre? Se connecter</a>
        </div>
    </form>
</div>