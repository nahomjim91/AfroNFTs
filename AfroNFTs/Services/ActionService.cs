using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AfroNFTs.Services
{
    /*
     create table actions( id int primary key identity, 
                     whenn datetime not null,
                     act int not null,
                     s_one int,
                     s_two int);
    alter table actions add userId int not null
alter table actions add userType tinyint not null
);
     */
    public class Action
    {
        public int id;
        public DateTime when;
        public int action;
        public int sateOne;
        public int sateTwo;
        public int userId;
        public bool  userType;
    }
    public class ActionService : IDisposable
    {
        public List<Action> getAllActions()
        {
            var li = new List<Action>();
            var sql = "select * from actions where userId = " + userId;

            try
            {
                var reader = (new SqlCommand(sql, _con).ExecuteReader());
                while (reader.Read())
                {
                    var act = new Action();
                    act.id = (int)reader["id"];
                    act.when = (DateTime)reader["whenn"];
                    act.action = (int)reader["act"];
                    act.sateOne = (int)reader["s_one"];
                    act.sateTwo = (int)reader["s_two"];
                    act.userId = userId;
                    act.userType = userType;
                }
                reader.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
            return li;
        }
        private SqlConnection _con;
        private int userId;
        private bool userType;
        public ActionService(bool userType, int userId)
        {
            this.userId = userId;
            this.userType = userType;
            try
            {
                _con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbService"].ConnectionString);
                _con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool registerAction(
            int act, int s_one, int s_two 
        )
        {
            int ty = userType ? 1 : 0;
            var sql = "insert into actions(s_one, s_two, act, whenn, userId, userType)" +
                      $" values({s_one}, {s_two}, {act}, {new DateTime()}, {userId}, {ty})";
            try
            {
                int rows = (new SqlCommand(sql, _con).ExecuteNonQuery());
                if (rows == 0) return false;
                
                return true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public void Dispose()
        {
            _con.Close();
           // throw new NotImplementedException();
        }
    }
}
