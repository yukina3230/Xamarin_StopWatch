using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin_StopWatch.Models.Interfaces;

namespace Xamarin_StopWatch.Models.Services
{
    public class MessageService : IMessage
    {
        public async Task ShowAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert("", message, "OK");
        }
    }
}
