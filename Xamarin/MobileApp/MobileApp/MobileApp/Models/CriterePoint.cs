using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    public class CriterePoint
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int NombrePoint { get; set; }
        public bool EstJeune { get; set; }
        public List<GagnerOuPerdre> PointsGagnerOuPerdu { get; set; }
        public CriterePoint()
        {
            PointsGagnerOuPerdu = new List<GagnerOuPerdre>();
        }
        public CriterePoint(int id, string description, int nombrePoint, bool estJeune)
        {
            Id = id;
            Description = description;
            NombrePoint = nombrePoint;
            EstJeune = estJeune;
        }
    }
}
