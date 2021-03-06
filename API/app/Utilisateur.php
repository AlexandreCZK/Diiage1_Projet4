<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Utilisateur extends Model
{
    //
    protected $table = 'user';

 public function utilisateurcategorie(){
  return $this->belongsTo('App\Categorie', 'ID_APPARTENIR','ID');   
 }
 public function utilisateurcriterepoint()
 {
     return $this->belongsToMany('App\Critere', 'gagnerperdre', 'ID', 'ID_CRITEREPOINT','ID','ID')->withPivot('DATEOPTENTION', 'NOMBREPOINT','VALIDER');
 }
}   