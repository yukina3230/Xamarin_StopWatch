using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_StopWatch.ViewModels;

namespace Xamarin_StopWatch
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
