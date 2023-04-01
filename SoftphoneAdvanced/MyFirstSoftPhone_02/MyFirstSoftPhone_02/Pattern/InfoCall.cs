using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSoftPhone_02.Pattern
{
    class InfoCall
    {
        public string Call_ID { get; set; }
        public string Caller_Username { get; set; }
        public string Callee_Username { get; set; }
        public string Time_Start { get; set; }
        public string Time_End { get; set; }
        public string Content { get; set; }
        public User Caller_detail { get; set; }
        public User Callee_detail { get; set; }
        public Call_Detail Call_Detail { get; set; }
    }
}
