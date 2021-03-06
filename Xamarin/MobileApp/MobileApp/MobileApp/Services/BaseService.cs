using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Services
{
    public class BaseService
    {
        protected HttpResponseMessage GetData(string url)
        {
            var httpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (o, cert, chain, errors) => true
            };
            HttpClient httpClient = new HttpClient(httpHandler);

            var response =
                httpClient.GetAsync(url).Result;

            return response;
        }

        protected async Task<HttpResponseMessage> PostDataAsync(string url, Dictionary<string, string> dictionary)
        {
            var httpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (o, cert, chain, errors) => true
            };
            HttpClient httpClient = new HttpClient(httpHandler);

            var response = await httpClient.PostAsync(url, new FormUrlEncodedContent(dictionary));
            return response;
        }

        protected static string ToJson<T>(T t)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            string result;
            try
            {
                result = JsonConvert.SerializeObject(t, settings);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        protected static T FromJson<T>(string json)
        {
            T t = default(T);
            try
            {
                t = JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return t;
        }
    }
}
