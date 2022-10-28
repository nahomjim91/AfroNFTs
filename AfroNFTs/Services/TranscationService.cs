using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace AfroNFTs.Services
{
    
    /* create table transcations(
                            id int not null primary key identity, 
                            from_user int not null, 
                            from_admin int not null,
                            nft_title varchar(20) not null,
                            price double not null)*/
    
    public class Transcation
    {
        public int id;
        public int userId;
        public int adminId;
        public string nftTitle;
        public double price;
    }
    public class TranscationService :IDisposable
    {
        private SqlConnection _con;
        private int userId;
        private int adminId;
        private bool mode; //true for admin false for normal user mdoe;
        private SqlTransaction _trans;
        public TranscationService(int id, bool mode)
        {
            try
            {
                _con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbService"].ConnectionString);
                _con.Open();
                _trans = _con.BeginTransaction();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.mode = mode;
            if (mode)
                adminId = id;
            else userId = id;
        }

        public void Dispose()
        {
            _trans.Commit();
            _con.Close();
        }

        public bool register(int otherId, string title, double price)
        {
            try
            {
                string sql = "";
                if (mode)
                    //admin mode
                {
                    sql = "insert into transcations(from_user, from_admin, nft_title, price) " +
                        $"values({otherId}, {this.adminId},'{title}', {price} ) "; 
                }
                else
                {
                    sql = "insert into transcations(from_user, from_admin, nft_title,price) " +
                        $"values({otherId}, {this.adminId},'{title}', {price} ) ";
                }
                int row = (new SqlCommand(sql, _con).ExecuteNonQuery());
                if (row == 0) return false;
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Transcations Error#1"+  ex.Message);
                return false;
            }
        }
        public List<Transcation> getAllTrans()
        {
            List<Transcation> list = new List<Transcation>();
            string sql = "";
            if (mode) sql = "select * from transcations where from_admin = " + adminId;
            else sql = "select * from transcations where from_user = " + userId;
            SqlDataAdapter ad = new SqlDataAdapter(sql, _con);
            DataSet s = new DataSet();
            MessageBox.Show(s.ToString());
            ad.Fill(s, "transcations");

            foreach(DataRow row in s.Tables[0].Rows)
            {
                list.Add(new Transcation()
                {
                    adminId = (int)row["from_admin"],
                    userId = (int)row["from_user"],
                    nftTitle = (string)row["nft_title"],
                    price = 1000

                });
                
                
            }
            s.Dispose();
            ad.Dispose();
            return list;
        }
    }
}
