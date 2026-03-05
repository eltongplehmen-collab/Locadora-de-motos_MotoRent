using System.Security.Cryptography;
using System.Text;

namespace Locadora_de_motos_MotoRent.Util
{
    public static class Criptografia
    {
        public static string GerarHash(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }
    }
}