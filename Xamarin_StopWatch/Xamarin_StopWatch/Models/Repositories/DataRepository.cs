using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
//using Xamarin_StopWatch.Components.Libraries;

namespace Xamarin_StopWatch.Models.Repositories
{
    public class DataRepository
    {
        const string url = @"http://10.1.0.112/api/Test";

        public string GetData()
        {
            string data;
            HttpClient client = new HttpClient();
            HttpResponseMessage response;

            client.BaseAddress = new Uri(url);
            response = client.GetAsync(url).Result;
            data = response.Content.ReadAsStringAsync().Result;

            return data;
        }
    }
}
