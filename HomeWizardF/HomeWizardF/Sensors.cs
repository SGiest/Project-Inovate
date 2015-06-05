using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeWizardF
{
    public class Sensors
    {   //Author Sieger
        //JSON Data from cloud.homewizerd.com/session/serial/get-sensor
        public string status { get; set; }
        public string version { get; set; }
        public SensorsResponse response { get; set; }

        public static string Session { get; set; }
        public static string Serial { get; set; }

        public static async Task<Sensors> sensorlist()
        {       //Author: Sieger
            //Set vars
                var url = "https://cloud.homewizard.com/forward/";
                var session = Session;
                var serial = Serial;
                
                //Create webrequest to resive sensor information
                var myUri = new Uri(url);
                var myWebRequest = WebRequest.Create(myUri + session + "/" + serial + "/get-sensors");
                var myHttpWebRequest = (HttpWebRequest) myWebRequest;

                WebResponse myWebResponse = await myWebRequest.GetResponseAsync();
                using (StreamReader myStreamReader = new StreamReader(myWebResponse.GetResponseStream()))
                {
                    string json = myStreamReader.ReadToEnd();
                    // convert JSON to C#
                    var sensors = JsonConvert.DeserializeObject<Sensors>(json);
                    return sensors;
                }
            
        }
    }
}
           