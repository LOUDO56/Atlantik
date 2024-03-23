<div class="d-flex justify-content-center align-items-center vh-100">

    <form action="/login" method="post">
        <?= csrf_field() ?>

        <!-- Email input -->
        <div class="form-outline mb-4">
            <input type="email" id="form2Example1" class="form-control" name="email" value="<?= set_value('email')?>" />
            <label class="form-label" for="form2Example1">Adresse Email</label>
        </div>

        <!-- Password input -->
        <div class="form-outline mb-4">
            <input type="password" id="form2Example2" class="form-control" name="password" />
            <label class="form-label" for="form2Example2">Mot de passe</label>
        </div>


        <!-- Submit button -->
        <button type="submit" class="btn btn-primary btn-block mb-4">Se connecter</button>

        <?php if(isset($error['password'])):?>
            <div class="alert alert-danger">
                <?= $error['password']?>
            </div>
        <?php endif?>
        <!-- Register buttons -->
        <div class="text-center">
            <p>Vous n'avez pas de compte? <a href="/signup">Register</a></p>
        </div>
    </form>

</div>