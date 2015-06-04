using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApplication2
{
    public class Discover
    {   // Author: Jeroen

        //JSON data from http://gateway.homewizard.nl/discovery.php
        public string status { get; set; }
        public string ip { get; set; }

        public static bool Local { get; set; }


        public static Discover discover()
        {   
            // Create WebRequest
            Uri discoverUrl = new Uri(@"http://gateway.homewizard.nl/discovery.php");
            WebRequest request = WebRequest.Create(discoverUrl);

            //Create Reader for JSON Data
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse) response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            Console.WriteLine(responseFromServer);

            // convert JSON to C#
            var discoveryHomeWizardData = JsonConvert.DeserializeObject<Discover>(responseFromServer);

            reader.Close();
            response.Close();

            return discoveryHomeWizardData;

        }
    }
}
