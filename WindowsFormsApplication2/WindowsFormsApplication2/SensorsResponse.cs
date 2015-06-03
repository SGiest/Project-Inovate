using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class SensorsResponse
    {
        public int preset { get; set; }
        public string time { get; set; }
        public List<Switch> switches { get; set; }
        public List<object> uvmeters { get; set; }
        public List<object> windmeters { get; set; }
        public List<object> rainmeters { get; set; }
        public List<Thermometer> thermometers { get; set; }
        public List<object> weatherdisplays { get; set; }
        public List<object> energymeters { get; set; }
        public List<object> energylinks { get; set; }
        public List<object> heatlinks { get; set; }
        public List<Hue> hues { get; set; }
        public List<object> scenes { get; set; }
        public List<object> kakusensors { get; set; }
        public List<Camera> cameras { get; set; }
    }
}
