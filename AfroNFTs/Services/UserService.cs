using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

using AfroNFTs.Models;
using AfroNFTs.Utils;
using System.IO;

namespace AfroNFTs.Services
{
    public  class UserService : IDisposable
    {
        private int userId;

        private SqlConnection con;

        public UserService(int id)
        {
            this.userId = id;
            try
            {
                con = new SqlConnection(
                              ConfigurationManager.ConnectionStrings["DbService"].ConnectionString
                );
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       public List<NFTsClass> GetNFTs()
        {
            List<NFTsClass> li = new List<NFTsClass>();

            try
            {
                var sql = "select* from NFTsClasses where OwnerID = " + userId;
                var reader = (new SqlCommand(sql, con)).ExecuteReader();
                while (reader.Read())
                {
                    var nft = new NFTsClass();
                    nft.NFTsprice = double.Parse(reader["NFTSprice"].ToString());
                    nft.description = reader["description"].ToString();
                    nft.NFTsName = reader["NFTsName"].ToString();
                    string photoString = (reader["NftsPicture"].ToString());
                    var photo = new byte[photoString.Length];
                    int len = 0;
                    foreach (byte b in photoString)
                    {
                        photo[len] = b;
                        len++;
                    }

                    nft.NftsPicture = photo;
                    li.Add(nft);
                }
                return li;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return li;
        }
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
                   

                    normalUser.profileImage =Utils.ConverterImage.ImageToByteArray(AfroNFTs.Properties.Resources.th__2_);
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
                    admin.profileImage = Utils.ConverterImage.ImageToByteArray(AfroNFTs.Properties.Resources.th__2_);
                    dbService.adminTB.Add(admin);

                    dbService.SaveChanges();


                }
                return true;
            }
            catch (Exception ex)
            {
                AppEventUtils.ShowInfoMessage("", "Sorry This email is taken");
                return false;
            }
        }

        public void Dispose()
        {
            con.Close();
        }
    }
}