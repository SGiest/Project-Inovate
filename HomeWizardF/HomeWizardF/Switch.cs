namespace WindowsFormsApplication2
{
    public class Switch
    {   //Author: Sieger
        //JSON Data from cloud.homewizerd.com/session/serial/get-sensor list<Response> of class SensorsResponse
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
