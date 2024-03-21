<div class="d-flex justify-content-center align-items-center vh-100">
    <form action="/signup" method="post">
        <?= csrf_field() ?>
        <div class="row">
            <div class="col mb-2">
                <label for="nom" class="form-label">Nom <span class="text-danger">*</span></label>
                <input type="text" class="form-control" id="nom" name="nom" required>
            </div>

            <div class="col mb-2">
                <label for="prenom" class="form-label">Prenom <span class="text-danger">*</span></label>
                <input type="text" class="form-control" id="prenom" name="prenom" required>
            </div>
        </div>
        <div class="row">
            <div class="col mb-2">
                <label for="email" class="form-label">Email <span class="text-danger">*</span></label>
                <input type="text" class="form-control" id="email" name="email" required>
            </div>

            <div class="col mb-2">
                <label for="password" class="form-label">Mot de passe <span class="text-danger">*</span></label>
                <input type="password" class="form-control" id="password" name="password" required>
            </div>
        </div>

        <div class="mb-2">
            <label for="adresse" class="form-label">Adresse <span class="text-danger">*</span></label>
            <input type="text" class="form-control" id="adresse" name="adresse" required>
        </div>

        <div class="mb-2">
            <label for="codePostal" class="form-label">Code Postal <span class="text-danger">*</span></label>
            <input type="number" class="form-control" id="codePostal" name="codePostal" required>
        </div>

        <div class="mb-2">
            <label for="ville" class="form-label">Ville <span class="text-danger">*</span></label>
            <input type="text" class="form-control" id="ville" name="ville" required>
        </div>

        <div class="mb-2">
            <label for="telFixe" class="form-label">Téléphone Fixe</label>
            <input type="text" class="form-control" id="telFixe" name="telFixe">
        </div>

        <div class="mb-3">
            <label for="telPortable" class="form-label">Téléphone Portable <span class="text-danger">*</span></label>
            <input type="text" class="form-control" id="telPortable" name="telPortable" required>
        </div>

        <div class="text-center">
            <button type="submit" class="btn btn-primary">S'inscrire</button>
        </div>
    </form>
</div>