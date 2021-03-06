using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double PrixCotisation { get; set; }
        public List<User> Users { get; set; }
        public Categorie()
        {
            Users = new List<User>();
        }
        public Categorie(int id, string descritpion, double cotisation)
        {
            Id = id;
            Description = descritpion;
            PrixCotisation = cotisation;
        }
    }
}
