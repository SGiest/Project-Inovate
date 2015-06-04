namespace HomeWizardF
{
    public class Response
    {   //Author: Sieger
        //JSON Data from https://cloud.homewizard.com/account/login List<Response> of class AuthOnline
        public string serial { get; set; }
        public string name { get; set; }
        public bool online { get; set; }
        public int hops { get; set; }
        public bool local { get; set; }
        public string host { get; set; }
    }
}
