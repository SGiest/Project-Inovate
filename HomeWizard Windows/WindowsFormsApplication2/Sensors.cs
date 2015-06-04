using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace WindowsFormsApplication2
{
    public class Sensors
    {   //Author Sieger
        //JSON Data from cloud.homewizerd.com/session/serial/get-sensor
        public string status { get; set; }
        public string version { get; set; }
        public SensorsResponse response { get; set; }

        public static string Session { get; set; }
        public static string Serial { get; set; }

        public static Sensors sensorlist()
        {       //Author: Sieger
                //Set vars
                var url = "https://cloud.homewizard.com/forward/";
                var session = Session;
                var serial = Serial;
                
                //Create webrequest to resive sensor information
                var myUri = new Uri(url);
                var myWebRequest = WebRequest.Create(myUri + session + "/" + serial + "/get-sensors");
                var myHttpWebRequest = (HttpWebRequest) myWebRequest;

                //Create Reader for JSON DATA
                var myWebResponse = myWebRequest.GetResponse();
                var responseStream = myWebResponse.GetResponseStream();
                var myStreamReader = new StreamReader(responseStream, Encoding.Default);
                var pageContent = myStreamReader.ReadToEnd();
                Console.WriteLine(pageContent);
                
                // convert JSON to C#
                var sensor = JsonConvert.DeserializeObject<Sensors>(pageContent);

                //Set JSON Data
                return sensor;
            
        }
    }
}
           