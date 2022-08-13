using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CommunityToolkit.Mvvm.Input;

namespace Xamarin_StopWatch.ViewModels
{
    public partial class MainViewModel
    {
        public MainViewModel()
        {
            //StartCommand = new RelayCommand<object>(o => StartExecute(), o => StartCanExecute());
            InsertCommand = new RelayCommand<object>(o => InsertExecute(), o => InsertCanExecute());
        }
    }
}
