using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int NombrePoint { get; set; }
        public bool EstJeune { get; set; }
        public bool EstFormateur { get; set; }
        public Categorie Categorie { get; set; }
        public List<GagnerOuPerdre> PointsGagnerOuPerdu { get; set; }
        public User()
        {
            PointsGagnerOuPerdu = new List<GagnerOuPerdre>();
        }
        public User(int id, string login, string password, int nombrePoint, bool estJeune, bool estFormateur, Categorie categorie)
        {
            Id = id;
            Login = login;
            Password = password;
            NombrePoint = nombrePoint;
            EstJeune = estJeune;
            EstFormateur = estFormateur;
            Categorie = categorie;
        }
        
    }
}
