using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_StopWatch.Models.Repositories;

namespace Xamarin_StopWatch.Models.Services
{
    public class InsertService
    {
        private string _name;
        private int _quantity;

        public InsertService(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public void Insert()
        {
            InsertRepository insert = new InsertRepository(_name, _quantity);
            insert.InsertToDb();
        }
    }
}
