using AfroNFTs.View;
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
    public partial class UserDashBord : Form
    {
        public UserDashBord()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            for(int i = 0; i < 3; i++)
            {
                NFTs nfts = new NFTs();
                nfts.Click += Deitail_click;
                flowLayoutPanel1.Controls.Add(nfts);

            }


        }

       public void Deitail_click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }

    }
}
