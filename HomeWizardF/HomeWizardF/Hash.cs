using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApplication2
{
    class Hash
    {
        public static string GetSha1(string value)
        {   //Author Jeroen

            //Hash the Password with SHA1
            var data = Encoding.ASCII.GetBytes(value);
            var hashData = new SHA1Managed().ComputeHash(data);
       
            var hash = string.Empty;

            foreach (var b in hashData)
                hash += b.ToString("X2");

            return hash;
        }
    }
}
