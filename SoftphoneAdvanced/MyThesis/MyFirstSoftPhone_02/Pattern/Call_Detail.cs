using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSoftPhone_02.Pattern
{
    class Call_Detail
    {
        public string Call_ID { get; set; }
        public string Source_IP { get; set; }
        public string Source_Port { get; set; }
        public string Destination_IP { get; set; }
        public string Destination_Port { get; set; }
        public string Sdp_Port { get; set; }
    }
}
