using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AfroNFTs.Models;
using AfroNFTs.Utils;
namespace AfroNFTs.View
{
    public partial class CreatePage : Form
    {
        public CreatePage()
        {
            InitializeComponent();
        }


        private void submitteBtn_Click(object sender, EventArgs e)
        {
            var adminId = mainPage.userID;
            var page = new Page();

            page.title = Titeltxt.Text;
            page.description = descrTxt.Text;


            try
            {
                using(var ctx = new DbService())
                {
                    ctx.pageTB.Add(page);
                    ctx.SaveChanges();

                    var admin = ctx.adminTB.Find(adminId);

                    
                    admin.pages.Add(page);

                    ctx.SaveChanges();
                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Program.main.dashbord_pan.Controls.Add(new MyPages());
        }
    }
}
