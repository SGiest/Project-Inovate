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
    public class Discover
    {

        public string status { get; set; }
        public string ip { get; set; }

        public static bool Local { get; set; }


        public static Discover discover()
        {
            Uri discoverUrl = new Uri(@"http://gateway.homewizard.nl/discovery.php");

            WebRequest request = WebRequest.Create(discoverUrl);

            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse) response).StatusDescription);
            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            Console.WriteLine(responseFromServer);

            var discoveryHomeWizardData = JsonConvert.DeserializeObject<Discover>(responseFromServer);

            reader.Close();
            response.Close();

            return discoveryHomeWizardData;

        }
    }
}
