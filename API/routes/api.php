<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/



Route::get('/get-all-categorie-point/{estJeune}', function ($estJeune) {
    return App\Critere::where('ESTJEUNE', $estJeune)->get()->toJson();
});
Route::get('/get-all-player/{estJeune}', function ($estJeune) {
    return App\Utilisateur::where('ESTJEUNE', $estJeune)->with('utilisateurcriterepoint')->get()->toJson();
});


Route::get('/get-all-point/{id}', function ($id) {
   return App\Utilisateur::find($id)->with('utilisateurcriterepoint')->get()->toJson();
});

Route::post('/auth', function (Request $request) {
    
   return App\Utilisateur::where('LOGIN',$request->get('login'))->where('PASSWORD',$request->get('mdp'))->get()->toJson();
});

Route::post('/give-point-player', function (Request $request) {
    try{
        $u=App\Utilisateur::find($request->get('idPlayer'))->first();
        $c=App\Critere::find($request->get('idCritere'))->first();
        $u->utilisateurcriterepoint()->attach($c);
        return '{"message":"ok"}';
    } catch (Exception $ex) {
        return  '{"message":"ko"}';;
    }
   
});
