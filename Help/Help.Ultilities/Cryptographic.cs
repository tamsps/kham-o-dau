using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Help.Ultilities
{
    public class Cryptographic
    {
        private readonly string key = "kk@1kgev$3m99a**i^mm";

        private byte[] EncryptStringMD5(string inputString)
        {
            return new MD5CryptoServiceProvider().ComputeHash(UTF8Encoding.UTF8.GetBytes(inputString));
        }

        private byte[] Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
                keyArray = EncryptStringMD5(key);
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            return cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        }


        private byte[] Decrypt(string toDecrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
                keyArray = EncryptStringMD5(key);
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            return cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        }

        public string EncryptString(string inputString)
        {
            byte[] rs = Encrypt(inputString, true);
            return Convert.ToBase64String(rs, 0, rs.Length);
        }

        public string DecryptString(string inputString)
        {
            byte[] rs = Decrypt(inputString, true);
            return UTF8Encoding.UTF8.GetString(rs);
        }
    }
}
