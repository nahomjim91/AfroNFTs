﻿using AfroNFTs.Models;
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
                return hasError;
        }
        private void Siginupbtn_Click(object sender, EventArgs e)
        {
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

                if (isAdmin)
                {
                    UserService.registerAdminUser(
                        Fnametxt.Text,
                        LNametxt.Text,
                        Emailtxt.Text,
                        Pswordtxt.Text
                     );
                    int ID = serviceComtext.adminTB.Count();
                    mainPage.userID = ID;

                }
                else
                {
                    UserService.registerNormalUser(
                        Fnametxt.Text,
                        LNametxt.Text,
                        Emailtxt.Text,
                        Pswordtxt.Text
                    );

                    int ID = serviceComtext.normalUserTB.Count();
                    mainPage.userID = ID;
                }
                Program.main.popChar.IconChar = IconChar.A;
                Program.main.GoToDashbord(isAdmin);
            }
        }
    }
}
