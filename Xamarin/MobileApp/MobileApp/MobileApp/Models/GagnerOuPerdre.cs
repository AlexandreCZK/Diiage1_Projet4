using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Models
{
    public class GagnerOuPerdre
    {
        public DateTime Date { get; set; }
        public int NbPoint { get; set; }
        public bool Valider { get; set; }
        public User User { get; set; }
        public CriterePoint CriterePoint { get; set; }
        public GagnerOuPerdre()
        {

        }
        public GagnerOuPerdre(DateTime date, int nombrePoint, bool valider, User user, CriterePoint criterePoint)
        {
            Date = date;
            NbPoint = nombrePoint;
            Valider = valider;
            User = user;
            CriterePoint = criterePoint;
        }
    }
}
