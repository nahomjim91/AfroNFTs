using AfroNFTs.Models;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Media.Animation;

using AfroNFTs.Services;
using AfroNFTs.Utils;
using System.IO;

namespace AfroNFTs
{
    public partial class SiginUp : Form
    {



        

        public SiginUp()
        {
            InitializeComponent();
            
        }

        public bool hasError()
        {

            Regex strongPassword = new Regex(@"^(?=(.*[a-z]){1,})(?=(.*[A-Z]){1,})(?=(.*[0-9]){1,})(?=(.*[!@#$%^&*()\-__+.]){1,}).{8,}$");
            Regex emailtxtReg = new Regex( @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            bool hasError = true;
            if (string.IsNullOrEmpty(Emailtxt.Text))
            {
                errorProviderSignUP.SetError(Emailtxt, "Required");
                hasError = false;
            }
            if (string.IsNullOrEmpty(Fnametxt.Text))
            {
                errorProviderSignUP.SetError(Fnametxt, "Required");
                hasError = false;
            }
            if (string.IsNullOrEmpty(LNametxt.Text))
            {
                errorProviderSignUP.SetError(LNametxt, "Required");
                hasError = false;
            }
            if (string.IsNullOrEmpty(Pswordtxt.Text))
            {
                errorProviderSignUP.SetError(Pswordtxt, "Required");
                hasError = false;
            }
            if (string.IsNullOrEmpty(ConfirmPswordtxt.Text))
            {
                errorProviderSignUP.SetError(ConfirmPswordtxt, "Required");
                hasError = false;
            }
            if (!emailtxtReg.IsMatch(Emailtxt.Text))
            {
                MessageBox.Show("sorry!! sir. your email is not valid");
                errorProviderSignUP.SetError(Emailtxt, "Required");
                hasError = false;
            }
            if (Pswordtxt.Text != ConfirmPswordtxt.Text)
            {
                MessageBox.Show("sorry!! sir. your password is not the same");
                errorProviderSignUP.SetError(Pswordtxt, "Required");
                errorProviderSignUP.SetError(ConfirmPswordtxt, "Required");
                hasError = false;
            }
            if (!strongPassword.IsMatch(Pswordtxt.Text))
            {
                AppEventUtils.ShowInfoMessage(this, "Password must contain an uppercase, a lowercase and special characters while being at least 8 chars long");
                errorProviderSignUP.SetError(Pswordtxt, "Password must contain an uppercase, a lowercase and special characters while being at least 8 chars long");


                hasError = false;
            }
                return hasError;
        }
        private void Siginupbtn_Click(object sender, EventArgs e)
        {
            if (!termsCheckBox.Checked)
            {
                AppEventUtils.ShowInfoMessage(this, "Please Accept terms to continue");
                errorProviderSignUP.SetError(termsCheckBox, "Check this!");
                return;
            }
            errorProviderSignUP.Clear();
           // MessageBox.Show("Hello");
           // AppEventUtils.ShowInfoMessage(this, "This is a test");
            if (!hasError() )

            {

            }
            else
            {
                errorProviderSignUP.Clear();
                DbService serviceComtext = new DbService();
                NormalUser N_user = new NormalUser();
                Admin A_user = new Admin();

                bool isAdmin =  false;
               

                
                //This checks if the user is an admin
                if (adminCheckBox.Checked)
                {
                    isAdmin = true;
                }
                else
                {
                    isAdmin = false;
                }
                bool isAllowed = false;
                if (isAdmin)
                {
                    isAllowed = UserService.registerAdminUser(


                        Fnametxt.Text,
                        LNametxt.Text,
                        Emailtxt.Text,
                        Pswordtxt.Text
                     );

                    //   int ID = serviceComtext.adminTB.Count();
                    // mainPage.userID = ID;
                    try
                    {
                        using (var ctx = new DbService())
                        {
                            var user = ctx.adminTB.Single(normalUser => normalUser.email == Emailtxt.Text.Trim());
                            mainPage.userID = user.Id;
                        }
                    }
                    catch (Exception ex)
                    {
                        AppEventUtils.ShowInfoMessage(this, ex.Message);
                        throw new NFTAppException("Error #1");
                    }

                }
                else
                {
                    isAllowed= UserService.registerNormalUser(

                        Fnametxt.Text,
                        LNametxt.Text,
                        Emailtxt.Text,
                        Pswordtxt.Text
                    );


                    try
                    {
                        using (var ctx = new DbService())
                        {
                            var user = ctx.normalUserTB.Single(normalUser =>  normalUser.email == Emailtxt.Text.Trim());
                            mainPage.userID = user.Id;
                        }
                    }
                    catch(Exception ex)
                    {
                        AppEventUtils.ShowInfoMessage(this, ex.Message);
                        throw new NFTAppException("Error #2");
                    }
                    //int ID = serviceComtext.normalUserTB.Count();
                    //mainPage.userID = ID;
                }
                if (isAllowed)
                {
                    //Check if the user is allowed after signing up
                    Program.main.popChar.IconChar = IconChar.A;
                    Program.main.GoToDashbord(isAdmin);

                }
            }
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if(Pswordtxt.PasswordChar == '*')
            {
                Pswordtxt.PasswordChar = '\0';
            }
            else Pswordtxt.PasswordChar= '*';
        }

        private void showConfirm_Click(object sender, EventArgs e)
        {
            if (ConfirmPswordtxt.PasswordChar == '*')
                ConfirmPswordtxt.PasswordChar = '\0';
            else ConfirmPswordtxt.PasswordChar = '*';
        }

        private void SiginUp_Load(object sender, EventArgs e)
        {

        }
    }
}