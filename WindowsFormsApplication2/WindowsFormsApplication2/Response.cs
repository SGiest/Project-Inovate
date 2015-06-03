using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApplication2
{
    public class Response
    {
        public string serial { get; set; }
        public string name { get; set; }
        public bool online { get; set; }
        public int hops { get; set; }
        public bool local { get; set; }
        public string host { get; set; }



    }
}
