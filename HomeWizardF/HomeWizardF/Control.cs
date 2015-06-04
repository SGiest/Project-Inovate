using System;
using System.IO;
using System.Net;
using System.Text;

namespace WindowsFormsApplication2
{
    public class Control
    {
        public static void controlSchakelaar(string Id, string Status)
        {   //Author Sieger
            
            // set vars
            var url = "https://cloud.homewizard.com/forward/";
            string session = Sensors.Session;
            string serial = Sensors.Serial;
            
            // Creaste WebRequest
            var myUri = new Uri(url);
            var myWebRequest =
                WebRequest.Create(myUri + session + "/" + serial + "/sw/" + Id + "/" + Status + "/" );
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;

            //Create Reader for Debugging
            var myWebResponse = myWebRequest.GetResponse();
            var responseStream = myWebResponse.GetResponseStream();
            var myStreamReader = new StreamReader(responseStream, Encoding.Default);
            var pageContent = myStreamReader.ReadToEnd();
            Console.WriteLine(pageContent);
        }

        public static void controlHue(string Id, string Status, int Hue, int Sat, int Bri)
        {   //Author: Sieger
            
            // set vars
            var url = "https://cloud.homewizard.com/forward/";
            string session = Sensors.Session;
            string serial = Sensors.Serial;
            
            //Create URL
            var myUri = new Uri(url);
            var myWebRequest = WebRequest.Create(myUri + session + "/" + serial + "/sw/" + Id + "/" + Status + "/" + Hue + "/" + Sat +"/" + Bri + "/");
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;

            //Create Reader for Debugging
            var myWebResponse = myWebRequest.GetResponse();
            var responseStream = myWebResponse.GetResponseStream();
            var myStreamReader = new StreamReader(responseStream, Encoding.Default);
            var pageContent = myStreamReader.ReadToEnd();
            Console.WriteLine(pageContent);
        }
    }
}
