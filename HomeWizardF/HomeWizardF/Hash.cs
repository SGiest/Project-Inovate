using System.Text;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using System.Runtime.InteropServices.WindowsRuntime;

namespace HomeWizardF
{
    class Hash
    {
        public static string GetSha1(string value)
        {
            HashAlgorithmProvider hashProvider = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha1);
            IBuffer hash = hashProvider.HashData(CryptographicBuffer.ConvertStringToBinary(value, BinaryStringEncoding.Utf8));
            //char[] hashValue = (CryptographicBuffer.EncodeToBase64String(hash).Replace("-","").ToCharArray());
            var hashValue = hash.ToArray();
            var hashData = string.Empty;

            foreach (var b in hashValue)
            {
                hashData += b.ToString("X2");
            }
                
            return hashData;
        }
    }
}
