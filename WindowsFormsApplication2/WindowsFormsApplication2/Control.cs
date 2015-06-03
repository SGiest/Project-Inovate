using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApplication2
{
    public class Control
    {
        public static void controlSchakelaar(string Id, string Status)
        {
            var url = "https://cloud.homewizard.com/forward/";
            string session = AuthOnline.Session;
            string serial = AuthOnline.Serial;

            var myUri = new Uri(url);
            var myWebRequest =
                WebRequest.Create(myUri + session + "/" + serial + "/sw/" + Id + "/" + Status + "/" );
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;

            var myWebResponse = myWebRequest.GetResponse();

            var responseStream = myWebResponse.GetResponseStream();
            var myStreamReader = new StreamReader(responseStream, Encoding.Default);

            var pageContent = myStreamReader.ReadToEnd();
            Console.WriteLine(pageContent);
        }
        public static void controlHue(string Id, string Status, int Hue, int Sat, int Bri)
        {
            var url = "https://cloud.homewizard.com/forward/";
            string session = AuthOnline.Session;
            string serial = AuthOnline.Serial;
            
            var myUri = new Uri(url);
            var myWebRequest =
                WebRequest.Create(myUri + session + "/" + serial + "/sw/" + Id + "/" + Status + "/" + Hue + "/" + Sat +
                                  "/" + Bri + "/");
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;

            var myWebResponse = myWebRequest.GetResponse();

            var responseStream = myWebResponse.GetResponseStream();
            var myStreamReader = new StreamReader(responseStream, Encoding.Default);

            var pageContent = myStreamReader.ReadToEnd();
            Console.WriteLine(pageContent);
        }
    }
}
