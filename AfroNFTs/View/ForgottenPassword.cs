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
    public partial class ForgottenPassword : Form
    {
        public string targetEmail = "";
        public bool isAdmin = false;
        public ForgottenPassword()
        {
            InitializeComponent();
        }


        private void Clearbtn_Click(object sender, EventArgs e) ///set button clicked
        {
            if (string.IsNullOrEmpty(Codetxt.Text) || string.IsNullOrEmpty(psstxt.Text))
            {
                if (string.IsNullOrEmpty(Codetxt.Text))
                    errorProvider1.SetError(Codetxt, "reiqired");
                if (string.IsNullOrEmpty(psstxt.Text))
                    errorProvider1.SetError(psstxt, "reiqired");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    using (var ctx = new DbService())
                    {
                        if (isAdmin)
                        {
                            Admin u = ctx.adminTB.Single(admin => admin.email == targetEmail);
                            u.password = PasswordUtils.HashPassword(psstxt.Text);


                            if (u.generatedNumber != int.Parse(Codetxt.Text))
                            {
                                AppEventUtils.ShowInfoMessage(this, "Invalid code!");
                                return;
                            }


                            ctx.SaveChanges();
                            //     MessageBox.Show("HERE #1 " + u.password + " o: " + Pswordlab.Text);
                        }
                        else
                        {
                            NormalUser u = ctx.normalUserTB.Single(admin => admin.email == targetEmail);
                            u.password = PasswordUtils.HashPassword(psstxt.Text);
                            if (u.generatedNumber != int.Parse(Codetxt.Text))
                            {
                                AppEventUtils.ShowInfoMessage(this, "Invalid code!");
                                return;
                            }
                            ctx.SaveChanges();
                            MessageBox.Show("HERE #2");
                        }

                    }
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.Message);
                }
                this.Close();
            }
        }
    }
}
