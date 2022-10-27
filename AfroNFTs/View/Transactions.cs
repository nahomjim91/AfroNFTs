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
using AfroNFTs.Services;
namespace AfroNFTs.View
{
    public partial class Transactions : Form
    {
        public Transactions(bool pageType)
        {
            InitializeComponent();
            using(var transactionService = new TranscationService(mainPage.userID, pageType))
            {
                foreach(Transcation t in transactionService.getAllTrans())
                {
                    string usersName = "";
                    using(var ctx = new DbService())
                    {
                        if (pageType)
                        {
                            var user = ctx.adminTB.Single( n => n.Id== t.adminId);
                            usersName = user.firstName + " " + user.lastName;
                        }
                        else
                        {
                            var user = ctx.normalUserTB.Single(n => n.Id == t.userId); ;
                            usersName = user.firstName + " " + user.lastName;
                        }
                    }
                    this.flowLayoutPanel1.Controls.Add(new TransactionInfo((decimal)t.price,usersName,  t.nftTitle));
                    MessageBox.Show("HEELLO");
                }
            }

        }

        private void Transactions_Load(object sender, EventArgs e)
        {

        }

    }
}
