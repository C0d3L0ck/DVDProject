using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace ProyectoIUJO
{
    class EncryptMD5
    {
        public string Encrypt(string mensaje)
        {
            string hash = "e0b5b7c68f2b7b3a6d3d5f9a0b4e2ba9e9d2c2f0e5b4c1ad3303c6661308be3e8c6ae1dc00d1b7b1e6ece6b9f8d8c6d0f8f2d128c1a3c617dfc63c5e68a779a0d3";
            byte[] data = UTF8Encoding.UTF8.GetBytes(mensaje);

            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0 , data.Length);

            return Convert.ToBase64String(result);
        }

        public string Decrypt(string mensajeEn)
        {
            string hash = "e0b5b7c68f2b7b3a6d3d5f9a0b4e2ba9e9d2c2f0e5b4c1ad3303c6661308be3e8c6ae1dc00d1b7b1e6ece6b9f8d8c6d0f8f2d128c1a3c617dfc63c5e68a779a0d3";
            byte[] data = Convert.FromBase64String(mensajeEn);

            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripledes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripledes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}
