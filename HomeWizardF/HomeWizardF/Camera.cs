using System.Collections.Generic;

namespace WindowsFormsApplication2
{
    public class Camera
    {   //Author Sieger
        //JSON Data from cloud.homewizerd.com/session/serial/get-sensor List<Camara> from class SensorsResponse
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
