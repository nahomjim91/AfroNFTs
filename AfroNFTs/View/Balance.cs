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

namespace AfroNFTs.View
{
    public partial class Balance : Form
    {
        private int userId;
        private bool isAdmin = false;
        private decimal balance = 0;
        private User user;

        public Balance(int userId, bool isAdmin)
        {
            this.userId = userId;
            InitializeComponent();
            try
            {
                using (var ctx = new DbService())
                {

                    if (isAdmin)
                    {
                        iconButton1.Visible = false;
                        ammountToRecharge.Visible = false;
                        this.user = ctx.adminTB.Find(userId);
                        this.balance = user.balance;
                    }
                    else
                    {
                        this.user = ctx.normalUserTB.Find(userId);
                        this.balance = user.balance;
                    }
                    this.balanceLabel.Text = this.balance.ToString();
                }
               
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var ammountToAdd = decimal.Parse(ammountToRecharge.Text);
                if (!isAdmin)
                {
                    
                    using(var ctx = new DbService())
                    {
                        this.user = ctx.normalUserTB.Find(userId);
                        NormalUser u = (NormalUser)user;
                        u.balance = balance + ammountToAdd;
                       
                        ctx.SaveChanges();
                    }
                    using(var actionService = new Services.ActionService( false, mainPage.userID))
                    {

                        actionService.registerAction("rec", 0);
                    }
                    Program.main.OpenchildFrom(new Balance(mainPage.userID, false), sender); ;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
