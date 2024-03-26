<nav class="navbar bg-dark navbar-expand-sm fixed-top mb-6" data-bs-theme="dark">
    <div class="container-fluid">
        <a class="navbar-brand" href="/">Atlantik</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
                <a class="nav-link" href="/liaison">Liaisons par secteur</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Tarif pour une liaison</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Horaire de traversées</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Réserver</a>
            </li>
        </ul>
            <?php $session = session();?>
            <?php if($session->get('is_logged')): ?>
                <div class="d-flex dropdown">
                    <button class="btn" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                        <img src="<?= base_url('assets/default-pfp.png');?>" alt="default pfp" width="40">
                    </button>
                    <ul class="dropdown-menu dropdown-menu-end ">
                        <li class="fw-bold text-center"><?= $session->get('nom')?> <?= $session->get('prenom')?></li>
                        <li><hr class="dropdown-divider"></li>
                        <li><a href="/editprofile" class="dropdown-item">Modifier</a></li>
                        <li><a href="/logout" class="dropdown-item">Se déconnecter</a></li>
                    </ul>
                </div>
            <?php else:?>
                <div class="d-flex gap-2">
                    <a class="btn btn-light" href="login" >Se connecter</a>
                    <a class="btn btn-primary" href="signup">S'inscrire</a>
                </div>
            <?php endif?>
            <?php $session->close();?>
        </div>
    </div>
</nav>