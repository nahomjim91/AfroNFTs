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
    public partial class NFTPage : UserControl
    {
        private Image _NftsPicture;
        public int PageId { get; set; }

        public Image NftsPicture
        {
            get { return _NftsPicture; }
            set { _NftsPicture = value; pictureBoxNFTs.Image = value; }
        }


        private string _NFTsName;

        public string NFTsName
        {
            get { return _NFTsName; }
            set { _NFTsName = value; labNFTsName.Text = value; }
        }

        public NFTPage()
        {
            InitializeComponent();
        }

        private void NFTPage_Load(object sender, EventArgs e)
        {

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new PageDetails(PageId) , sender);
        }
    }
}
