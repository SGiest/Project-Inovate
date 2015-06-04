using System.Text;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace HomeWizardF
{
    class Hash
    {
        public static string GetSha1(string value)
        {
            HashAlgorithmProvider hashProvider = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha1);
            IBuffer hash = hashProvider.HashData(CryptographicBuffer.ConvertStringToBinary(value, BinaryStringEncoding.Utf8));
            string hashValue = CryptographicBuffer.EncodeToBase64String(hash);

            return hashValue;
        }
    }
}
