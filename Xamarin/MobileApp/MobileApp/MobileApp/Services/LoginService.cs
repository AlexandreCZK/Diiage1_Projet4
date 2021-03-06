using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Services
{
    public class LoginService : BaseService
    {
        public async Task<bool> LoginAsync(string username, string password)
        {
            //LoginAsyncKeyCloack(username, password);

            string url = "https://10.4.101.4:8484/public/api/auth";
            var dictionary = new Dictionary<string, string>
            {
                { "login", username },
                { "mdp", password }
            };

            var responseApi = await PostDataAsync(url, dictionary);
            if (responseApi.IsSuccessStatusCode)
            {
                var response = await responseApi.Content.ReadAsStringAsync();
                App.User = FromJson<User>(response.Replace('[', '\0').Replace(']', '\0'));
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool Login(string username, string password)
        //{
        //    App.User = new Models.User(1, "Login", "Password", 500, false, true, new Models.Categorie());
        //    return true;
        //}
    }
}
