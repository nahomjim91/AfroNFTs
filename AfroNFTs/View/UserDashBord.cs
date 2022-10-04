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
            //for test 
            foreach (var item in NFTsClass.getAllNFTs())
            {
                NFTs nfts = new NFTs();
                nfts.NftsPicture = item.NftsPicture;
                nfts.NFTsName = item.NFTsName;
                nfts.NFTsRate = item.NFTsRate;
                nfts.NFTsprice = item.NFTsprice;
                nfts.Click += new System.EventHandler(Deitail_click);
                flowLayoutPanel1.Controls.Add(nfts);

            }


        }

       public void Deitail_click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }

    }
}
