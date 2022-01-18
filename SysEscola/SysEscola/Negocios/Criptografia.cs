using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;

namespace Negocios
{
   public class Criptografia
    {
        string key;

        private string gerarKey()
        {
            DESCryptoServiceProvider DESCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            return ASCIIEncoding.ASCII.GetString(DESCrypto.Key);
        }

       private string Criptografar(string texto, string strHash)
       {
           TripleDESCryptoServiceProvider TDC = new TripleDESCryptoServiceProvider();
           MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
           byte[] byteHash, byteTexto;
           byteHash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strHash));
           byteTexto = ASCIIEncoding.ASCII.GetBytes(texto);

           md5.Clear();
           TDC.Key = byteHash;
           TDC.Mode = CipherMode.ECB;

           return Convert.ToBase64String(TDC.CreateEncryptor().TransformFinalBlock(byteTexto, 0, byteTexto.Length));
       }

       private string Desriptografar(string texto, string strHash)
       {
           TripleDESCryptoServiceProvider TDC = new TripleDESCryptoServiceProvider();
           MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
           byte[] byteHash, byteTexto;
           byteHash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strHash));
           byteTexto = Convert.FromBase64String(texto);

           md5.Clear();
           TDC.Key = byteHash;
           TDC.Mode = CipherMode.ECB;

           return ASCIIEncoding.ASCII.GetString(TDC.CreateDecryptor().TransformFinalBlock(byteTexto, 0, byteTexto.Length));
       }


    }

}
