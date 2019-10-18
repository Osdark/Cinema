using CinemaODVM.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CinemaODVM.Helpers
{
    public class LoginAPIHelper
    {
        public static T Post<T>(string url, LoginRequest usuario)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://misapis.azurewebsites.net/api/Seguridad");
            var json = JsonConvert.SerializeObject(usuario);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var request = client.PostAsync(url, stringContent).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);
                return response;
            }
            return default(T);
        }
    }
}


