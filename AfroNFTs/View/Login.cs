using AfroNFTs.Models;
using AfroNFTs.Utils;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfroNFTs
{
    public partial class Login : Form
    {
        bool b = false;
        public Login()
        {
            InitializeComponent();
        }

        public bool hasError()
        {
            bool hasError = true;   
           
            if (string.IsNullOrEmpty(Emailtxt.Text))
            {
                errorProviderLogin.SetError(Emailtxt, "Required");
                hasError = false;
            }
            if (string.IsNullOrEmpty(Pswordtxt.Text))
            {
                errorProviderLogin.SetError(Pswordtxt, "Required");
                hasError = false;
            }
            
            return hasError;
        }


            private void Siginupbtn_Click(object sender, EventArgs e)
        {
            // throw new NFTAppException("Error");   
            if (!hasError())
            {

            }
            else{
               errorProviderLogin.Clear();
                var checed = groupBox1.Controls.OfType<RadioButton>().
                                       FirstOrDefault(r => { return r.Checked == true; });
              // b = checed.Text == "ADMIN" ? true : false;
                DbService dbService = new DbService();
                Admin admin = new Admin();
                NormalUser normalUser = new NormalUser();
                var result = MessageBox.Show("Are you Admin?", "yes or no", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    b = true;
                }
                else
                {
                    b = false;
                }

                if (b)
                {
                    try
                    {
                        var user = dbService.adminTB.Single((a) => a.email == Emailtxt.Text);
                        if(!PasswordUtils.isPasswordCorrect( Pswordtxt.Text, user.password))
                        {
                            MessageBox.Show("Error in password");
                            errorProviderLogin.SetError(Pswordtxt, "wrong Password");
                            return;
                        }
                        mainPage.userID = user.Id;
                        MessageBox.Show(user.Id.ToString());

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("This user does not exist");
                        return;
                    }
                   

                }
                else
                {
                    try
                    {
                        var user = dbService.normalUserTB.Single((a) => a.email == Emailtxt.Text);
                        if (!PasswordUtils.isPasswordCorrect(Pswordtxt.Text, user.password))
                        {
                            MessageBox.Show("Error in password");
                            errorProviderLogin.SetError(Pswordtxt, "wrong Password");
                            return;
                        }
                        mainPage.userID = user.Id;
                        MessageBox.Show(user.Id.ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This user does not exist");
                        return;
                    }
                }
                Program.main.popChar.IconChar = IconChar.A;
                Program.main.GoToDashbord(b);
            }
           
        }
    }
}
