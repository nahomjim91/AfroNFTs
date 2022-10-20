using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

using AfroNFTs.Models;
namespace AfroNFTs.Services
{

    public class PageService : IDisposable
    {
        
        private SqlConnection con;
        private int pageId;
     
        public PageService(int id)
        {
            pageId = id;
            con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DbService"].ConnectionString);
            con.Open();
        }
        public  List<NFTsClass> GetAllNfts()
        {
            string sql = "select * from NFTsClasses where PageId = " + pageId;

            List<NFTsClass> list = new List<NFTsClass>() { };
            try
            {
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
                    foreach(byte b in photoString)
                    {
                        photo[len] = b;
                        len++;
                    }

                    nft.NftsPicture = photo;
                    list.Add(nft);
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            //return list;
        }
        public bool deleteAllNfts()
        {
            var sql = "delete from NFTsClasses where pageId = " + pageId ;
            try
            {
                (new SqlCommand(sql, con))
                .ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
         
        }

        public void Dispose()
        {
            con.Close();
        }
    }
}
