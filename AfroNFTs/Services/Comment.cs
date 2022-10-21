using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Windows;

namespace AfroNFTs.Services
{
    public class Comment
    {
        public int id;
        public int objectId;
        public int userId;
        public string comment;
    }
  
    class CommentService : IDisposable
    {
        private SqlConnection con;
        public CommentService()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbService"].ConnectionString);
            con.Open();
        }
        public bool writeComment(int userId, int objectId, string comment)
        {
            try
            {
                var sql = "insert into comments(userid , objectid, comment)"
                        + $"values({userId}, {objectId}, '{comment}')";
                int rows = (new SqlCommand(sql, con).ExecuteNonQuery());
                if (rows == 0) return false;
                else return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("WriteComment Err" + e.Message);
                return false;
            }
        }
        public List<Comment> getCommentsOn(int objectId)
        {
            var list = new List<Comment>();
            var sql = "select * from comments where objectid = " + objectId;

            var reader = (new SqlCommand(sql, con).ExecuteReader());
            while (reader.Read())
            {
                Comment com = new Comment();
                com.id = (int)reader["id"];
                com.objectId = (int)reader["objectid"];
                com.userId = (int)reader["userid"];
                com.comment = (string)reader["comment"];

                list.Add(com);

            }

            reader.Close();

            return list;
        }
        
        public void Dispose()
        {
            con.Close();
        }
    }
}
