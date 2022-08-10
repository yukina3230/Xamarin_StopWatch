using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Xamarin_StopWatch.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private string _Time;
        public string Time { get => _Time; set { _Time = value; OnPropertyChanged(); } }
    }
}
