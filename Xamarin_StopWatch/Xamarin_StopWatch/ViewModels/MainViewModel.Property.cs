using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;

namespace Xamarin_StopWatch.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private string _Time;
        public string Time { get => _Time; set { _Time = value; OnPropertyChanged(); } }
    }
}
