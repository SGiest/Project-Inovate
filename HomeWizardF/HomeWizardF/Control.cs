using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace HomeWizardF
{
    public class Control
    {
        public static async void controlSchakelaar(string Id, string Status)
        {   //Author Sieger
            // Set vars
            var url = "https://cloud.homewizard.com/forward/";
            string session = Sensors.Session;
            string serial = Sensors.Serial;

            //make WebRequest
            var myUri = new Uri(url);
            var myWebRequest =
                WebRequest.Create(myUri + session + "/" + serial + "/sw/" + Id + "/" + Status + "/" );
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;

            WebResponse myWebResponse = await myWebRequest.GetResponseAsync();
            using (StreamReader myStreamReader = new StreamReader(myWebResponse.GetResponseStream()))
            {
                string json = myStreamReader.ReadToEnd();
                // convert JSON to C#
                var discover = JsonConvert.DeserializeObject<Discover>(json);
            }
        }

        public static async void controlHue(string Id, string Status, int Hue, int Sat, int Bri)
        {   //Author: Sieger
            
            // set vars
            var url = "https://cloud.homewizard.com/forward/";
            string session = Sensors.Session;
            string serial = Sensors.Serial;
            
            //Create URL
            var myUri = new Uri(url);
            var myWebRequest = WebRequest.Create(myUri + session + "/" + serial + "/sw/" + Id + "/" + Status + "/" + Hue + "/" + Sat +"/" + Bri + "/");
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;

            WebResponse myWebResponse = await myWebRequest.GetResponseAsync();
            using (StreamReader myStreamReader = new StreamReader(myWebResponse.GetResponseStream()))
            {
                string json = myStreamReader.ReadToEnd();
                // convert JSON to C#
                var discover = JsonConvert.DeserializeObject<Discover>(json);
            }
        }
    }
}
