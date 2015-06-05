using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace HomeWizardF
{
    class TempGraph
    {
        public string status { get; set; }
        public string version { get; set; }
        public List<Graph> response { get; set; }

        public static async void tempGraph(string Id, string Period )
        {
            //Author: Sieger
            //Set vars
            var url = "https://cloud.homewizard.com/forward/";
            var session = Sensors.Session;
            var serial = Sensors.Serial;

            //Create webrequest to resive sensor information
            var myUri = new Uri(url);
            var myWebRequest = WebRequest.Create(myUri + session + "/" + serial + "/te/graph" + Id + "/" + Period);
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;

            WebResponse myWebResponse = await myWebRequest.GetResponseAsync();
            using (StreamReader myStreamReader = new StreamReader(myWebResponse.GetResponseStream()))
            {
                string json = myStreamReader.ReadToEnd();
                // convert JSON to C#
                var grahp = JsonConvert.DeserializeObject<Discover>(json);
            }
        }
    }
}
