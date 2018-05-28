using System;
using System.Security.Cryptography;

namespace Security.Encription
{
    public class EncriptadorIrreversible
    {
        //Iteraciones para la funcion del hasheo (mas grande, mas seguridad pero menos performance)
        private const int iterations = 1000;

        static public string EncriptarIrreversible(string data)
        {
            //Salt es un numero random que se usa para hashear la contraseña, un "condimento"
            byte[] salt = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(salt);
            var pbkdf2 = new Rfc2898DeriveBytes(data, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string saltedHash = Convert.ToBase64String(hashBytes);
            return saltedHash;
        }

    }
}
