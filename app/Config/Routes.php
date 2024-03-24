<?php

use CodeIgniter\Router\RouteCollection;

/**
 * @var RouteCollection $routes
 */
$routes->get('/', 'Home::index');

use App\Controllers\SignupController;
use App\Controllers\LoginController;
use App\Controllers\LogoutController;
use App\Controllers\EditProfileController;

$routes->get('signup', [SignupController::class, 'index']);
$routes->post('signup', [SignupController::class, 'register']);

$routes->get('login', [LoginController::class, 'index']);
$routes->post('login', [LoginController::class, 'loginUser']);

$routes->get('logout', [LogoutController::class, 'index']);

$routes->get('editprofile', [EditProfileController::class, 'index']);
$routes->post('editprofile', [EditProfileController::class, 'editUserInformation']);