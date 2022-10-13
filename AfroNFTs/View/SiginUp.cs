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

namespace AfroNFTs
{
    public partial class SiginUp : Form
    {
        
        public SiginUp()
        {
            InitializeComponent();
        }

        private void Siginupbtn_Click(object sender, EventArgs e)
        {
            DbService serviceComtext = new DbService();
            NormalUser N_user = new NormalUser();
            Admin A_user = new Admin();
            
            var checed = groupBox1.Controls.OfType<RadioButton>().
                                        FirstOrDefault(r => { return r.Checked == true; });

            char c = Fnametxt.Text[0];
            bool b = checed.Text == "ADMIN" ? true :false;
            if (b)
            {
                A_user.balance = 100;
                A_user.firstName = Fnametxt.Text;
                A_user.lastName = LNametxt.Text;
                if (string.IsNullOrEmpty(Emailtxt.Text))
                {
                    errorProviderSignUP.SetError(Emailtxt , "reqird");
                }
                else
                {

                    A_user.email = Emailtxt.Text;
                }
                if (Pswordtxt.Text == ConfirmPswordtxt.Text)
                {
                    A_user.password = Pswordtxt.Text;
                    serviceComtext.adminTB.Add(A_user);
                    serviceComtext.SaveChanges();
                    int ID = serviceComtext.adminTB.Count();
                     mainPage.userID = ID;
                 }
                else
                {
                    MessageBox.Show("wrong password");
                }

            }
            else
            {
                N_user.balance = 100;
                N_user.email = Emailtxt.Text;
                N_user.firstName = Fnametxt.Text;
                N_user.lastName = LNametxt.Text;

                if (Pswordtxt.Text == ConfirmPswordtxt.Text)
                {
                    A_user.password = Pswordtxt.Text;
                    serviceComtext.normalUserTB.Add(N_user);
                    serviceComtext.SaveChanges();
                    int ID = serviceComtext.normalUserTB.Count();
                    mainPage.userID = ID;
                }
                else
                {
                    MessageBox.Show("wrong password");
                }
            }
           Program.main.popChar.IconChar = IconChar.A;
            Program.main.GoToDashbord(b);

        }
    }
}
