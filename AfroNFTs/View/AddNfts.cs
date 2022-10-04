using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public AddNfts()
        {
            InitializeComponent();
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
    }
}
