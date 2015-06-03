using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Camera
    {
        public int id { get; set; }
        public int model { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string ip { get; set; }
        public string port { get; set; }
        public int mode { get; set; }
        public Url url { get; set; }
        public List<object> presets { get; set; }
    }
}
