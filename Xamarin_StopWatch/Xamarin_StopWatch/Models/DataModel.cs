using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_StopWatch.Models
{
    public class DataModel
    {
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ReasonId { get; set; }
    }
}
