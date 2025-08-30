using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.util
{
    public class Hash
    {
        public static string makeHash(string senha, string salt)
        {
            // Combine a senha com o salt
            string senhaComSalt = senha + salt;

            // Create a SHA256  
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senhaComSalt));

                // Convert byte array to a string  
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string generateSalt(int size)
        {
            // Tamanho do salt em bytes
            byte[] saltBytes = new byte[size];

            // Instância de um gerador de números aleatórios seguro
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // Preenche o array de bytes com valores aleatórios
                rng.GetBytes(saltBytes);
            }

            // Converte o array de bytes em uma string hexadecimal
            string salt = BitConverter.ToString(saltBytes).Replace("-", "");

            return salt;
        }

        public static bool verifyPassword(string senha, string salt, string hash)
        {
            // Combine a senha com o salt
            string senhaComSalt = senha + salt;

            // Create a SHA256  
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senhaComSalt));

                // Convert byte array to a string  
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                // Compare the hashed password with the provided hash
                return builder.ToString() == hash;
            }
        }
    }
}
