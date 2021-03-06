using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;

namespace MobileApp.Services
{
    public class GivePointPlayerService : BaseService
    {
        public ObservableCollection<CriterePoint> GetCritèrePoint(bool jeune)
        {
            ObservableCollection<CriterePoint> list = new ObservableCollection<CriterePoint>();
            string url = "https://10.4.101.4:8484/public/api/get-all-categorie-point/";
            if (jeune)
            {
                url += "1";
            }
            else
            {
                url += "0";
            }
            HttpResponseMessage response = GetData(url);
            if (response.IsSuccessStatusCode)
            {
                List<CriterePoint> listApi =
                    FromJson<List<CriterePoint>>(response.Content.ReadAsStringAsync().Result);
                foreach (var item in listApi)
                {
                    list.Add(new CriterePoint { Description = item.Description, EstJeune = item.EstJeune, NombrePoint = item.NombrePoint });
                }
            }
            return list;
        }
        public ObservableCollection<User> GetPlayers(bool jeune)
        {
            ObservableCollection<User> list = new ObservableCollection<User>();
            string url = "https://10.4.101.4:8484/public/api/get-all-player/";
            if (jeune)
            {
                url += "1";
            }
            else
            {
                url += "0";
            }
            HttpResponseMessage response = GetData(url);
            if (response.IsSuccessStatusCode)
            {
                List<User> listApi =
                    FromJson<List<User>>(response.Content.ReadAsStringAsync().Result);
                foreach (var item in listApi)
                {
                    list.Add(new User { EstJeune = item.EstJeune, Login = item.Login });
                }
            }
            return list;
        }
        public bool GivePointToAPlayerAsync(User user, CriterePoint criterePoint)
        {
            string url = "https://10.4.101.4:8484/public/api/give-point-player";
            var dictionary = new Dictionary<string, string>
            {
                { "idPlayer", user.Id.ToString() },
                { "idCritere", criterePoint.Id.ToString() }
            };
            var response = PostDataAsync(url, dictionary);
            response.Wait();

            var responseMessage = response.Result.Content.ReadAsStringAsync();
            responseMessage.Wait();

            if (responseMessage.Result != "ok")
            {
                return false;
            }

            return true;
        }
        //public ObservableCollection<CriterePoint> GetCritèrePoint(bool jeune)
        //{
        //    ObservableCollection<CriterePoint> list = new ObservableCollection<CriterePoint>();
        //    if (jeune)
        //    {
        //        list.Add(new CriterePoint { Description = "Carton jaune", EstJeune = true, NombrePoint = -10 });
        //    }
        //    else
        //    {
        //        list.Add(new CriterePoint { Description = "Emmener enfants", EstJeune = false, NombrePoint = 20 });
        //        list.Add(new CriterePoint { Description = "Carton jaune", EstJeune = false, NombrePoint = -20 });
        //    }
        //    return list;
        //}
        //public ObservableCollection<User> GetPlayers(bool jeune)
        //{
        //    ObservableCollection<User> list = new ObservableCollection<User>();
        //    if (jeune)
        //    {
        //        list.Add(new User { EstJeune = true, Login = "Celia" });
        //        list.Add(new User { EstJeune = true, Login = "Lili" });
        //    }
        //    else
        //    {
        //        list.Add(new User { EstJeune = false, Login = "Alexandre" });
        //        list.Add(new User { EstJeune = false, Login = "Theo" });
        //    }
        //    return list;
        //}
        //public bool GivePointToAPlayer(User user, int nombrePoints, CriterePoint criterePoint)
        //{
        //    new GagnerOuPerdre 
        //    { 
        //        User = user, 
        //        NombrePoint = nombrePoints, 
        //        CriterePoint = criterePoint, 
        //        Date = DateTime.Now, 
        //        Valider = true 
        //    };
        //    return true;
        //}
    }
}
