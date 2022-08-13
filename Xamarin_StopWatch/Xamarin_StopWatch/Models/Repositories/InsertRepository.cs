using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Xamarin_StopWatch.Models.Repositories
{
    public class InsertRepository
    {
        string _name;
        int _quantity;
        string url = APIHelper.API_Url + "Insert/";

        public InsertRepository(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public void InsertToDb()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "name", _name },
                { "quantity", _quantity.ToString() }
            };
            var content = new FormUrlEncodedContent(values);

            client.PostAsync(url, content);
        }
    }
}
