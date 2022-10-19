using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


using Microsoft.Toolkit.Uwp.Notifications;
using EASendMail;

using AfroNFTs.Utils;
namespace AfroNFTs.Services
{
    public class EmailService
    {
        public static bool sendMail(
          string to,
          string from,
          string subject,
          string message
            )
        {
            try
            {
                

                SmtpMail oMail = new SmtpMail("TryIt");

                // Your Hotmail email address
                oMail.From = "ebenezertesfaye@outlook.com";
                // Set recipient email address
                oMail.To = to;

                // Set email subject
                oMail.Subject = subject;
                // Set email body
                oMail.TextBody = message;

                // Hotmail SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.office365.com");

                // Hotmail user authentication should use your
                // email address as the user name.
                oServer.User = "ebenezertesfaye@outlook.com";

                // If you got authentication error, try to create an app password instead of your user password.
                // https://support.microsoft.com/en-us/account-billing/using-app-passwords-with-apps-that-don-t-support-two-step-verification-5896ed9b-4263-e681-128a-a6f2979a7944
                oServer.Password = "ebenezerISCOOL1!";

                // Set 587 port, if you want to use 25 port, please change 587 to 25
                oServer.Port = 587;

                // detect SSL/TLS connection automatically
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                Console.WriteLine("start to send email over SSL...");

                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);


                return true;
            }
            catch (Exception ex)
            {
                AppEventUtils.ShowInfoMessage("", ex.Message);
                return false;
            }
        }
    }
}
