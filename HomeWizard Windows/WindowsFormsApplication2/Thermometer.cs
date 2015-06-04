namespace WindowsFormsApplication2
{
    public class Thermometer
    {   //Author: Sieger
        //JSON Data from cloud.homewizerd.com/session/serial/get-sensor list<Response> of class SensorsResponse
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public int model { get; set; }
        public string lowBattery { get; set; }
        public double version { get; set; }
        public double te { get; set; }
        public int hu { get; set; }
        public double teMax { get; set; }
        public string teMaxTime { get; set; }
        public double teMin { get; set; }
        public string teMinTime { get; set; }
        public int huMax { get; set; }
        public string huMaxTime { get; set; }
        public int huMin { get; set; }
        public string huMinTime { get; set; }
        public string outside { get; set; }
        public string favorite { get; set; }
    }
}
