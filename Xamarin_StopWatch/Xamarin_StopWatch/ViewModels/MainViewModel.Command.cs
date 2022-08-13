using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using Xamarin_StopWatch.Models.Repositories;
using Xamarin_StopWatch.Models.Services;

namespace Xamarin_StopWatch.ViewModels
{
    public partial class MainViewModel
    {
        //public RelayCommand<object> StartCommand { get; }
        public RelayCommand<object> InsertCommand { get; }

        //private void StartExecute()
        //{
        //    DataRepository data = new DataRepository();

        //    Time = data.GetData();
        //}

        private void InsertExecute()
        {
            try
            {
                InsertService insertService = new InsertService(Name, Quantity);
                insertService.Insert();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        //private bool StartCanExecute() => true;
        private bool InsertCanExecute() => true;
    }
}
