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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Siginupbtn_Click(object sender, EventArgs e)
        {
            var checed = groupBox1.Controls.OfType<RadioButton>().
                                        FirstOrDefault(r => { return r.Checked == true; });
            bool b = checed.Text == "ADMIN" ? true : false;
            Program.main.popChar.IconChar = IconChar.A;
            Program.main.GoToDashbord(b);
        }
    }
}
