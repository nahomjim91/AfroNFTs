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
            char c = Fnametxt.Text[0];
           Program.main.popChar.IconChar = IconChar.A;
            Program.main.GoToDashbord();

        }
    }
}
