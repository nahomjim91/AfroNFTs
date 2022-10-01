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
                flowLayoutPanel1.Controls.Add(nfts);
            }


        }

    }
}
