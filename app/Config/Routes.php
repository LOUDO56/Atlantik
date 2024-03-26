<?php

use CodeIgniter\Router\RouteCollection;

/**
 * @var RouteCollection $routes
 */
$routes->get('/', 'Home::index');

// use App\Controllers\SignupController;
// use App\Controllers\LoginController;
// use App\Controllers\LogoutController;
// use App\Controllers\EditProfileController;
use App\Controllers\VisiteurController;
use App\Controllers\ClientController;

$routes->get('signup', [VisiteurController::class, 'registerForm']);
$routes->post('signup', [VisiteurController::class, 'register']);

$routes->get('login', [VisiteurController::class, 'loginForm']);
$routes->post('login', [VisiteurController::class, 'loginUser']);

$routes->get('/liaison', [VisiteurController::class, 'afficherLiaisonSecteur']);

$routes->get('logout', [ClientController::class, 'logout']);

$routes->get('editprofile', [ClientController::class, 'editUserInformationForm']);
$routes->post('editprofile', [ClientController::class, 'editUserInformation']);