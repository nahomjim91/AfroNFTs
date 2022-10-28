using AfroNFTs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

 

namespace AfroNFTs.View
{
    public partial class AddNfts : Form
    {
        private byte[] imgByte;
        public int PageId; 
        private static int IDNFTs = 0;
        string GroupName;
        public AddNfts( int pageId , string GroupName)
        {
            this.GroupName = GroupName;
            PageId = pageId;    
            InitializeComponent();
            IDNFTs++;   

        }

        public bool hasError()
        {
            bool hasError = true;
            if (string.IsNullOrEmpty(txtNameNFTS.Text))
            {
                errorProvider.SetError(txtNameNFTS, "Required");
                hasError = false;
            }
            if (string.IsNullOrEmpty(txtDescriptionNFTs.Text))
            {
                errorProvider.SetError(txtDescriptionNFTs, "Required");
                hasError = false;
            }
            
            if (string.IsNullOrEmpty(txtPriceNFTs.Text))
            {
                errorProvider.SetError(txtPriceNFTs, "Required");
                return false;
            }
            if (double.Parse(txtPriceNFTs.Text) < 0)
            {
                try {
                    errorProvider.SetError(txtPriceNFTs, "Required");
                    hasError = false;
                }
                catch (Exception ex)
                {
                    return false;
                }
                
            }
            return hasError;
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

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void DeletePagebtn1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (!hasError())
            {

            }
            else
            {


                NFTsClass nfts = new NFTsClass();
                nfts.NftsPicture = ImageToByteArray(this.NFTSpic.Image);
                nfts.IDNFTs = IDNFTs;
                nfts.description = this.txtDescriptionNFTs.Text;
                nfts.NFTsName = this.txtNameNFTS.Text;
                nfts.NFTsprice = double.Parse(this.txtPriceNFTs.Text);
                nfts.Group = GroupName;
                nfts.OwnerID = mainPage.userID;
                nfts.userType = "Admin";
                nfts.pageId = PageId;
                nfts.save();
                Program.main.OpenchildFrom(new PageDetails(PageId), sender);
            }
        }
    }
}
