using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using Xamarin_StopWatch.Models.Repositories;

namespace Xamarin_StopWatch.ViewModels
{
    public partial class MainViewModel
    {
        public RelayCommand<object> StartCommand { get; }

        private void StartExecute()
        {
            DataRepository data = new DataRepository();

            Time = data.GetData();
        }

        private bool StartCanExecute() => true;
    }
}
