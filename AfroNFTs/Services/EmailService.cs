using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

                // Your yahoo email address
                oMail.From = from;

                // Set recipient email address
                oMail.To = to;

                // Set email subject
                oMail.Subject = subject;

                // Set email body
                oMail.TextBody = message;

                // Yahoo SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.mail.yahoo.com");

                // For example: your email is "myid@yahoo.com", then the user should be "myid@yahoo.com"
                oServer.User = from;
                oServer.Password = "szhlqxsojmwtddhe";
                

                // Because yahoo deploys SMTP server on 465 port with direct SSL connection.
                // So we should change the port to 465. you can also use 25 or 587
                oServer.Port = 465;
                
                // detect SSL type automatically
                //oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                Console.WriteLine("start to send email over SSL ...");

                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);
                return false;
            }
            catch (Exception ex)
            {
                AppEventUtils.ShowInfoMessage("", ex.Message);
                return false;
            }
        }
    }
}
