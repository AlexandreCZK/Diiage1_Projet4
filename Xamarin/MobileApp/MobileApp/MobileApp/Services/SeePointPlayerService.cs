using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;

namespace MobileApp.Services
{
    public class SeePointPlayerService : BaseService
    {
        public ObservableCollection<GagnerOuPerdre> GetGagnerOuPerdre(User user)
        {
            string url = $"https://10.4.101.4:8484/public/api/get-all-point/{user.Id}";
            ObservableCollection<GagnerOuPerdre> list = new ObservableCollection<GagnerOuPerdre>();

            HttpResponseMessage response = GetData(url);
            if (response.IsSuccessStatusCode)
            {
                List<GagnerOuPerdre> listApi = 
                    FromJson<List<GagnerOuPerdre>>(response.Content.ReadAsStringAsync().Result);
                foreach (var item in listApi)
                {
                    list.Add(new GagnerOuPerdre { NbPoint = item.NbPoint, CriterePoint = item.CriterePoint });
                }
            }

            return list;
        }
        //public ObservableCollection<GagnerOuPerdre> GetGagnerOuPerdre(User user)
        //{
        //    ObservableCollection<GagnerOuPerdre> list = new ObservableCollection<GagnerOuPerdre>();

        //    list.Add(new GagnerOuPerdre { NombrePoint = +10, CriterePoint = new CriterePoint { Description = "Emener enfants" } });
        //    list.Add(new GagnerOuPerdre { NombrePoint = -10, CriterePoint = new CriterePoint { Description = "Carton jaune" } });

        //    return list;
        //}
    }
}
