using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using AfroNFTs.Models;

namespace AfroNFTs.Services
{
    /*
        create table actions(id int primary key identity, act varchar(4) not null,
                             is_seen tinyint not null default 0)
    alter table actions add wn Datetime
    alter table actions add user_id int not null
    
alter table actions add for_admin int not null
     */
    public class Action
    {
        public int id;
        public string act;
        public bool isSeen;
        public DateTime when;
        public int forAdmin;
        public int userId;


    }
    public class ActionService : IDisposable
    {
        DbService DbService;
        public List<Action> getAllActionsForAdmin(int forAdmin)
        {
            var li = new List<Action>();
           
            var sql = "select * from actions where for_admin = " + forAdmin + " and is_seen = 0";
            MessageBox.Show("sql: " + sql);
            try
            {
                var reader = (new SqlCommand(sql, _con).ExecuteReader());
                while (reader.Read())
                {
                    var act = new Action();
                    act.id = (int)reader["id"];
                  //  act.when = (DateTime)reader["wn"];
                    act.act = (string)reader["act"];
                    act.userId = (int)reader["user_id"];
                   //  act.isSeen = ((int)reader["is_seen"]) == 0? false : true;
                    act.forAdmin = (int)reader["for_admin"];
                    li.Add(act);
                }
                reader.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            MessageBox.Show("Length: " + li.Count());
            return li;
        }
        private SqlConnection _con;
        private int userId;
        private bool userType;
        public ActionService(int adminId)
        {
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
        public bool makeActionSeen(int actionId)
        {
            var sql = "update actions set is_seen = 1 where id = " + actionId;
            try
            {
                int rows = (new SqlCommand(sql, _con).ExecuteNonQuery());
                if (rows == 0) return false;

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool registerAction(
            string action,
            int forAdmin
        )
        {
            
            var sql = "insert into actions(act, user_id, for_admin)" +
                      $" values('{action}', {userId}, {forAdmin})";
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
