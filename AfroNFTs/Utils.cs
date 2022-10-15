using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace AfroNFTs.Utils
{
    public static class PasswordUtils
    {
        public static string HashPassword(string password)
        {
            byte [] passwordInByte = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashed = new MD5CryptoServiceProvider().ComputeHash(passwordInByte);
            string hashedString = "";
            foreach(byte b in hashed)
            {
                hashedString += b;
            }
            return hashedString;
        }
    }
}
