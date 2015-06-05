using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeWizardF
{
    public class Discover
    {   // Author: Jeroen

        //JSON data from http://gateway.homewizard.nl/discovery.php
        public string status { get; set; }
        public string ip { get; set; }

        public static bool Local { get; set; }


        public static async Task<Discover> discover()
        {   
            // Set vars
            string url = "http://gateway.homewizard.nl/discovery.php";
            
            //make WebRequest
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
           
            //using (Stream reqStream = await myWebRequest.GetRequestStreamAsync())
            //{
            //    byte[] xmlBytes = Encoding.UTF8.GetBytes(url);
            //}
            WebResponse myWebResponse = await myWebRequest.GetResponseAsync();
            using (StreamReader myStreamReader = new StreamReader(myWebResponse.GetResponseStream()))
            {
                string json = myStreamReader.ReadToEnd();
                // convert JSON to C#
                var discover = JsonConvert.DeserializeObject<Discover>(json);

                //Set JSON Data
                return discover;
            }
        }
    }
}
