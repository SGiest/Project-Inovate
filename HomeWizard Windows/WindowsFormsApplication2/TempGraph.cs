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
    class TempGraph
    {
        public string status { get; set; }
        public string version { get; set; }
        public List<Graph> response { get; set; }

        public static TempGraph tempGraph(string Id, string Period )
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

            //Create Reader for JSON DATA
            var myWebResponse = myWebRequest.GetResponse();
            var responseStream = myWebResponse.GetResponseStream();
            var myStreamReader = new StreamReader(responseStream, Encoding.Default);
            var pageContent = myStreamReader.ReadToEnd();
            Console.WriteLine(pageContent);

            // convert JSON to C#
            var graph = JsonConvert.DeserializeObject<TempGraph>(pageContent);

            //Set JSON Data
            return graph;
        }
    }
}
