using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AfroNFTs.Models;
using AfroNFTs.Utils;


namespace AfroNFTs.Services
{
    public static class UserService
    {
        public static bool registerNormalUser(
               string firstName,
               string lastName,
               string email,
               string password
            )
        {
            try
            {
                using (var dbService = new DbService())
                {
                    var normalUser = new NormalUser()
                    {
                        firstName = firstName,
                        lastName = lastName,
                        email = email,
                        password = PasswordUtils.HashPassword(password),
                        balance = 100
                    };
                    dbService.normalUserTB.Add(normalUser);

                    dbService.SaveChanges();


                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return false;
            }
        }
        public static bool registerAdminUser(
              string firstName,
              string lastName,
              string email,
              string password
           )
        {
            try
            {
                using (var dbService = new DbService())
                {
                    var admin = new Admin()
                    {
                        firstName = firstName,
                        lastName = lastName,
                        email = email,
                        password = PasswordUtils.HashPassword(password),
                        balance = 100,

                    };
                    dbService.adminTB.Add(admin);

                    dbService.SaveChanges();


                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return false;
            }
        }
    }
}