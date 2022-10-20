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

using AfroNFTs.Services;
using AfroNFTs.Models;

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
             
              // b = checed.Text == "ADMIN" ? true : false;
                DbService dbService = new DbService();
                Admin admin = new Admin();
                NormalUser normalUser = new NormalUser();
                b = isAdminCheckBox.Checked;

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

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (Pswordtxt.PasswordChar == '*')
                Pswordtxt.PasswordChar = '\0';
            else Pswordtxt.PasswordChar = '*';
        }

        private int generateInt()
        {
            Random random = new Random();

            return random.Next(10000);
        }
        private void forgottenPasswordButton_Click(object sender, EventArgs e)
        {
            var num = generateInt();

            using (var ctx = new DbService())
            {
                try
                {
                    if (isAdminCheckBox.Checked)
                    {
                        Admin u =  ctx.adminTB.Single((admin) => admin.email == Emailtxt.Text);
                        u.generatedNumber = num;
                        ctx.SaveChanges();
                    }
                    else
                    {
                       NormalUser u =  ctx.normalUserTB.Single(user => user.email == Emailtxt.Text);
                        u.generatedNumber = num;
                        ctx.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    AppEventUtils.ShowInfoMessage(this, ex.Message);
                    return;
                }
            }
            
            var result = EmailService.sendMail(
                Emailtxt.Text,
                "ebenezertesfaye@outlook.com",
                "Reset Password",
                "Your key is: " + num + " please don't give this to anyone!"

            );
            if (result) {
                var form = new View.ForgottenPassword();
                form.targetEmail = Emailtxt.Text;
                form.isAdmin = isAdminCheckBox.Checked;
                form.Visible = true;

                AppEventUtils.ShowInfoMessage(this, result.ToString());

            }
            else
            {
                AppEventUtils.ShowInfoMessage(this, "This email does not exist or no internet");
            }
           
        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emaillab_Click(object sender, EventArgs e)
        {

        }
    }
}
