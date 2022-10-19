using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration ;
using System.Data.SqlClient;

using AfroNFTs.Models;
namespace AfroNFTs.View
{
    public partial class MyPages : Form
    {
        public MyPages()
        {
            InitializeComponent();

            try
            {
                using(var ctx = new DbService())
                {
                    var adminId = mainPage.userID;
                    var admin = ctx.adminTB.Find(adminId);

                    //  var totalPages = ctx.pageTB.Where(page => page.adminId == adminId);
                    MessageBox.Show("INT LEN: " + admin.pages.ToList().Count());

                    string conStr = ConfigurationManager.ConnectionStrings["DbService"].ConnectionString;

                    using (var con = new SqlConnection(conStr))
                    {
                        var sql = "SELECT * from pages where Admin_Id = " + adminId;
                        con.Open();
                        var cmd = new SqlCommand(sql, con);

                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var p = new NFTPage();
                            p.NftsPicture = null;
                            p.NFTsName = reader["title"].ToString();
                            p.Click += (object sender, EventArgs a) =>
                            {
                                Program.main.dashbord_pan.Controls.Add(new PageDetails());
                            };

                            FL.Controls.Add(p);
                        }
                    }

                    foreach(var nftPage in admin.pages.ToList())

                    {
                        //MessageBox.Show("LOOP");
                        var p = new NFTPage();
                        p.NftsPicture = null;
                        p.NFTsName = nftPage.title;
                        
                        FL.Controls.Add(p);
                    }

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
