<div class="d-flex justify-content-center align-items-center vh-100">

    <form action="/login" method="post">
        <?= csrf_field() ?>

        <!-- Email input -->
        <div class="form-outline mb-4">
            <label class="form-label" for="form2Example1">Adresse Email</label>
            <input type="email" id="form2Example1" class="form-control <?php if(isset($error['email'])) echo "is-invalid"?>" name="email" value="<?= set_value('email')?>" autocomplete="off" />
            <?php if(isset($error['email'])):?>
                <div class="invalid-feedback">
                    <?= $error['email']?>
                </div>
            <?php endif?>
        </div>

        <!-- Password input -->
        <div class="form-outline mb-4">
            <label class="form-label" for="form2Example2">Mot de passe</label>
            <input type="password" id="form2Example2" class="form-control <?php if(isset($error['password'])) echo "is-invalid"?>" name="password" autocomplete="off"/>
            <?php if(isset($error['password'])):?>
                <div class="invalid-feedback">
                    <?= $error['password']?>
                </div>
            <?php endif?>
        </div>


        <!-- Submit button -->
        <button type="submit" class="btn btn-primary btn-block mb-4">Se connecter</button>
            
        <!-- Register buttons -->
        <div class="text-center">
            <p>Vous n'avez pas de compte? <a href="/signup">Register</a></p>
        </div>
    </form>

</div>