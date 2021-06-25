using System;
using System.Collections.Generic;
using System.Text;
using NJUPTDemoApp.Core.Helpers;

namespace NJUPTDemoApp.Core.Models
{
    public class CallLog
    {
        public string SourceRegion { get; set; }

        public string SourcePhone { get; set; }

        public string DestinationRegion { get; set; }

        public string DestinationPhone { get; set; }
        
        public int Time { get; set; }

        public bool IsLocal => DestinationRegion.Equals(SourceRegion);

        public double Charge { get; set; }
    }
}
