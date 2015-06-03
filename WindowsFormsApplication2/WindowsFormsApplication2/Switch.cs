using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Switch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string favorite { get; set; }
        public int? hue_id { get; set; }
        public int? light_id { get; set; }
        public Color color { get; set; }
    }
}
