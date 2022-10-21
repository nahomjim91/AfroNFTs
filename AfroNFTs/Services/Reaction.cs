using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Configuration;


namespace AfroNFTs.Services
{
    public class Reaction
    {
        public int id;
        public int userId;
        public int objectId;
        public string reactionType;
    }
    public class ReactionService: IDisposable
    {
        public delegate void ReactionRefreshPage();
        public ReactionService()
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbService"].ConnectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private int reactionId;
        private SqlConnection con;
        public ReactionService(int id): this()
        {

            reactionId = id;
            
        }
        public  int getLikes(int objectId)
        {
            var sql = "select count(*) as count from reactions where objectid = "+ objectId 
                    + "  and (reaction_type = 'like')";

            try
            {
                int count = (int)(new SqlCommand(sql, con).ExecuteScalar());
                return count;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public decimal getPrice(int objectId, decimal ammount)
        {
            decimal likes = this.getLikes(objectId);
            decimal dislikes = this.getDisLikes(objectId);

            decimal ratio = dislikes == 0 ? (1) : likes / dislikes;

            return (ammount * ratio);
            

        }
        public int getDisLikes(int objectId)
        {
            var sql = "select count(*) as count from reactions where objectid = " + objectId
                   + "  and (reaction_type = 'dislike')";

            try
            {
                int count = (int)(new SqlCommand(sql, con).ExecuteScalar());
                return count;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public  Reaction findByUserAndObjectId(int userId, int objectId)
        {

            var sql = $"select top 1 * from reactions where userid = {userId} and objectid = {objectId}";
            try
            {
                var reader = (new SqlCommand(sql, con).ExecuteReader());

                if (!reader.Read()) {
                    reader.Close();
                    return null; 
                }
                
                Reaction r = new Reaction();
                r.id = (int)reader["id"];
                r.objectId = (int)reader["objectid"];
                r.reactionType = (string)reader["reaction_type"];
                r.userId = (int)reader["userid"];
                reader.Close();
                return r;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
        private  bool reactionExists(int userId, int objectId)
        {
            return findByUserAndObjectId(userId, objectId) != null;
        }

        public bool like(int userId, int objectId, ReactionRefreshPage refresher)
        {
            if(this.reactionExists(userId, objectId))
            {
                MessageBox.Show("Updating reation");
               
                var r = this.updateReaction(userId, objectId, "like");
                refresher();
                return r;
            }
            else

            {
               
                MessageBox.Show("Add reaction");
                var r =  this.addReaction(userId, objectId, "like");
                refresher();
                return r;
            }

        }
        public bool dislike(int userId, int objectId, ReactionRefreshPage refresh)
        {
            if (this.reactionExists(userId, objectId))
            {
               
                var r = this.updateReaction(userId, objectId, "dislike");
                refresh();
                return r;
            }
            else
            {
               
                var r = this.addReaction(userId, objectId, "dislike");
                refresh();
                return r;
            }
        }


        private bool updateReaction(int userId, int objectId, string reaction)
        {
            var sql = $"update reactions set reaction_type= '{reaction}'" +
                $" where userid = {userId} and objectid={objectId}";
            try
            {
                int rows = (new SqlCommand(sql, con).ExecuteNonQuery());
                if (rows == 0) return false;
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        private bool addReaction(int userId, int objectId, string reaction)
        {
            var sql = $"insert into reactions( userid,  objectid, reaction_type)" +
                       $"values({userId}, {objectId}, '{reaction}') "; ;
            try
            {
                int rows = (new SqlCommand(sql, con).ExecuteNonQuery());
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
            MessageBox.Show("Closed!");
            con.Close();
            //throw new NotImplementedException();
        }
    }
}
