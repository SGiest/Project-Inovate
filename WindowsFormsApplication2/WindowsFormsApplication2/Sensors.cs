using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace WindowsFormsApplication2
{
    public class Sensors
    {
        public string status { get; set; }
        public string version { get; set; }
        public SensorsResponse response { get; set; }

        public static string Session { get; set; }
        public static string Serial { get; set; }

        public static Sensors sensorlist()
        {
            if (Discover.Local == false)
            {
                var url = "https://cloud.homewizard.com/forward/";
                var session = Session;
                var serial = Serial;

                var myUri = new Uri(url);
                var myWebRequest = WebRequest.Create(myUri + session + "/" + serial + "/get-sensors");
                var myHttpWebRequest = (HttpWebRequest) myWebRequest;

                var myWebResponse = myWebRequest.GetResponse();

                var responseStream = myWebResponse.GetResponseStream();
                var myStreamReader = new StreamReader(responseStream, Encoding.Default);

                var pageContent = myStreamReader.ReadToEnd();
                Console.WriteLine(pageContent);

                var sensor = JsonConvert.DeserializeObject<Sensors>(pageContent);
                return sensor;
            }
            else
            {
                var ip = AuthOffline.IP;
                var pass = AuthOffline.Pass;

                var myWebRequest = WebRequest.Create("http://" + ip + "/" + pass + "/get-sensors");
                var myHttpWebRequest = (HttpWebRequest) myWebRequest;

                var myWebResponse = myWebRequest.GetResponse();

                var responseStream = myWebResponse.GetResponseStream();
                var myStreamReader = new StreamReader(responseStream, Encoding.Default);

                var pageContent = myStreamReader.ReadToEnd();
                Console.WriteLine(pageContent);

                var sensor = JsonConvert.DeserializeObject<Sensors>(pageContent);
                return sensor;
            }
        }
    }
}