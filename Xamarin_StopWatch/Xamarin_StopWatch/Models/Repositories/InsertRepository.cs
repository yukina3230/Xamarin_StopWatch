using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Xamarin_StopWatch.Models.Interfaces;

namespace Xamarin_StopWatch.Models.Repositories
{
    public class InsertRepository
    {
        string _name;
        int _quantity;
        string url = APIHelper.API_Url;
        private readonly IMessage _messageService;

        public InsertRepository(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public async void InsertToDb()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
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
                    await _messageService.ShowAsync("Success");
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
        }
    }
}
