using System.Text;
using System.Security.Cryptography;

namespace NewDatabaseProject
{
    class Encryption
    {
        public static string sha256(string hashPassword)
        {
            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(hashPassword));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
