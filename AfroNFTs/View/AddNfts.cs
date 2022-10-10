using AfroNFTs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 

namespace AfroNFTs.View
{
    public partial class AddNfts : Form
    {
        private byte[] imgByte;

        private static int IDNFTs = 0;
        public AddNfts()
        {
            InitializeComponent();
            IDNFTs++;   

        }

        private void NFTSpic_Click(object sender, EventArgs e)
        {
                string sFile;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                imgByte = null;
                openFileDialog1.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sFile = openFileDialog1.FileName;
                    NFTSpic.Image = System.Drawing.Bitmap.FromFile(sFile);
                    NFTSpic.SizeMode = PictureBoxSizeMode.StretchImage;
                    using (MemoryStream mStream = new MemoryStream())
                    {
                        NFTSpic.Image.Save(mStream, NFTSpic.Image.RawFormat);
                        imgByte = mStream.ToArray();
                    }
                }
            string str = "";
            str += imgByte;
            MessageBox.Show(str);
        }

        private void submitteBtn_Click(object sender, EventArgs e)
        {

            NFTsClass nfts = new NFTsClass();
           // nfts.NftsPicture = this.NFTSpic.Image;
            nfts.IDNFTs = IDNFTs;
            nfts.description = this.txtDescriptionNFTs.Text;
            nfts.NFTsName = this.txtNameNFTS.Text;
            nfts.NFTsprice = double.Parse(this.txtPriceNFTs.Text);
            nfts.Group = this.txtGroupNFTs.Text;

            nfts.save();
        }
    }
}
