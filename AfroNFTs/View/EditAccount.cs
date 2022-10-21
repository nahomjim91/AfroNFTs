using AfroNFTs.Models;
using AfroNFTs.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.System.UserProfile;

using AfroNFTs.Utils;
using System.IO;

namespace AfroNFTs.View
{
    public partial class EditAccount : Form
    {
        bool pageType;
        int id;
        byte[] imgByte;
        public EditAccount(bool pageType ,int id)
        {
            this.pageType = pageType; 
            this.id = id;
            InitializeComponent();
        }

        private void sellOrBuyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbService())
                {
                    if (pageType)
                    {
                        Admin u = ctx.adminTB.Single(admin => admin.Id == id);
                        if (u.password != Utils.PasswordUtils.HashPassword(textBox1.Text))
                        {
                            return;
                        }
                        if(Pswordtxt.Text != ConfirmPswordtxt.Text)
                        {
                            return;
                        }
                        u.firstName = Fnametxt.Text;
                        u.email = Emailtxt.Text;
                        u.lastName = LNametxt.Text;
                        u.password = Utils.PasswordUtils.HashPassword(Pswordtxt.Text);
                        u.profileImage = ImageToByteArray(this.NFTSpic.Image);


                    }
                    else
                    {
                        NormalUser u = ctx.normalUserTB.Single(admin => admin.Id == id);
                        if (u.password != Utils.PasswordUtils.HashPassword(textBox1.Text))
                        {
                            return;
                        }
                        if (Pswordtxt.Text != ConfirmPswordtxt.Text)
                        {
                            return;
                        }
                        u.firstName = Fnametxt.Text;
                        u.email = Emailtxt.Text;
                        u.lastName = LNametxt.Text;
                        u.password = Utils.PasswordUtils.HashPassword(Pswordtxt.Text);
                        u.profileImage = ImageToByteArray(this.NFTSpic.Image);


                    }
                    ctx.SaveChanges();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void ProfileiconPictureBox_Click(object sender, EventArgs e)
        {
            
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
