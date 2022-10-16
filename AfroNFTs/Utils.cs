using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using System.Windows.Forms;

namespace AfroNFTs.Utils
{
    public class AppEventUtils
    {
        public delegate void AppEventHandler(object sender, string e);

        public static event AppEventHandler ShowInfoMessageEvent;

        public static void ShowInfoMessage(object sender, string message)
        {
           // MessageBox.Show(message);
            if (ShowInfoMessageEvent != null)
                ShowInfoMessageEvent(sender, message);
        }
    }
    
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
        public static bool isPasswordCorrect(string givenPassword, string hashedPassword)
        {
            string hashedInput = HashPassword(givenPassword);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashedInput, hashedPassword)) return true;
            else return false;
        }
    }
}
