using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Xamarin_StopWatch.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        //private string _Time;
        //public string Time { get => _Time; set { _Time = value; OnPropertyChanged(); } }

        private string _Name;
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }

        private int _Quantity;
        public int Quantity { get => _Quantity; set { _Quantity = value; OnPropertyChanged(); } }
    }
}
