using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeWizardF
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

        public async Task<AuthOnline> authOnline(string email, string pass)
        {
            // Set vars
            string url = "https://cloud.homewizard.com/account/login";
            
            //make WebRequest
            Uri myUri = new Uri(url);
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            

            //Hash Password and call .tolower() for use in URL
            string hashSha1 = Hash.GetSha1(pass);
            string authInfo = email + ":" + hashSha1.ToLower();
            //authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            authInfo = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(authInfo));
            myWebRequest.Headers["Authorization"] = "Basic " + authInfo;

            using (Stream reqStream = await myWebRequest.GetRequestStreamAsync())
            {
                byte[] xmlBytes = Encoding.UTF8.GetBytes(url);
            }
            WebResponse myWebResponse = await myWebRequest.GetResponseAsync();
            using (StreamReader myStreamReader = new StreamReader(myWebResponse.GetResponseStream()))
            {
                string json = myStreamReader.ReadToEnd();
                // convert JSON to C#
                var auth = JsonConvert.DeserializeObject<AuthOnline>(json);

                //Set JSON Data
                return auth;
            }

            // Create Reader for JSON Data
            //Stream responseStream = myWebResponse.GetResponseStream();
            
           // string pageContent = myStreamReader.ReadToEnd();
        }
    }
}
