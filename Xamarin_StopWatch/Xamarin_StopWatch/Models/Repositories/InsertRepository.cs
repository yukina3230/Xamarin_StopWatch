using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_StopWatch.Models.Repositories
{
    public class InsertRepository
    {
        string _name;
        int _quantity;
        string url = APIHelper.API_Url + "Insert?";

        public InsertRepository(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public async void InsertToDb()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://10.1.0.112/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HttpResponseMessage response = await client.GetAsync("api/GetInfo?id=1");

                //if (response.IsSuccessStatusCode)
                //{
                //    string str = await response.Content.ReadAsAsync<string>();
                //}
                //else
                //{
                //    Console.WriteLine("Internal server Error");
                //}

                TestModel values = new TestModel() { Name = _name, Quantity = _quantity };

                HttpResponseMessage response = await client.PostAsJsonAsync("api/Insert", values);
                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Alert", "You have been alerted", "OK");
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }

                //Dictionary<string, string> values = new Dictionary<string, string>
                //{
                //    { "name", _name },
                //    { "quantity", _quantity.ToString() }
                //};
                //var content = new FormUrlEncodedContent(new[]
                //{
                //    new KeyValuePair<string, string>("name", _name),
                //    new KeyValuePair<string, string>("quantity", _quantity.ToString())
                //});

                //HttpResponseMessage response = await client.PostAsync(url, content);
                //var responseString = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
