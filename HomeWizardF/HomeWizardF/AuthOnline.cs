using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication2
{
    public class AuthOnline
    {   //Author Jeroen
        //JSON DATA from https://cloud.homewizard.com/account/login
        public string session { get; set; }
        public string email { get; set; }
        public List<Response> response { get; set; }
        public bool cloud { get; set; }
        public string version { get; set; }
        public string status { get; set; }

        public static AuthOnline authOnline(string email, string pass)
        {
            // Set vars
            string url = "https://cloud.homewizard.com/account/login";
            
            //make WebRequest
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest) myWebRequest;

            //Hash Password and call .tolower() for use in URL
            string hashSha1 = Hash.GetSha1(pass);
            string authInfo = email + ":" + hashSha1.ToLower();
            //authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            authInfo = System.Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            myWebRequest.Headers["Authorization"] = "Basic " + authInfo;
            WebResponse myWebResponse = myWebRequest.GetResponse();

            // Create Reader for JSON Data
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);
            string pageContent = myStreamReader.ReadToEnd();
            Console.WriteLine(pageContent);
           
            // convert JSON to C#
            var discoveryHomeWizardOnline = JsonConvert.DeserializeObject<AuthOnline>(pageContent);

            //Set JSON Data
            return discoveryHomeWizardOnline;
        }
    }
}
