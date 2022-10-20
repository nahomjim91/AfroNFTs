using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfroNFTs.View
{
    public partial class PageDetails : Form
    {
        public PageDetails()
        {
            InitializeComponent();
        }

        private void AddNFTsbtn1_Click(object sender, EventArgs e)
        {
            Program.main.dashbord_pan.Controls.Add(new AddNfts());
        }
    }
}
