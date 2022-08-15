using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_StopWatch.Models.Interfaces
{
    public interface IMessage
    {
        Task ShowAsync(string message);
    }
}
