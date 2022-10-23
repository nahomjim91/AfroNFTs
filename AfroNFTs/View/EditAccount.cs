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

using AForge.Video;
using AForge.Video.DirectShow;


using AfroNFTs.Utils;
using System.IO;

namespace AfroNFTs.View
{
    public partial class EditAccount : Form
    {
        private bool isCameraOn = false;
        bool pageType;
        int id;
        byte[] imgByte;
        VideoCaptureDevice frame;
        FilterInfoCollection devs;

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        public EditAccount(bool pageType ,int id)
        {

         

            this.pageType = pageType; 
            this.id = id;
            InitializeComponent();
            using (var ctx = new DbService())
            {
                User u;
                if (pageType)
                {
                     u = ctx.adminTB.Single(admin => admin.Id == id);
                }
                else
                {
                     u= ctx.normalUserTB.Single(user => user.Id == id);
                }
                Fnametxt.Text = u.firstName;
                LNametxt.Text = u.lastName;
                Emailtxt.Text = u.email;
                NFTSpic.Image = byteArrayToImage(u.profileImage);


            }
        }

       public void startCamera()
        {
            devs = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            frame = new VideoCaptureDevice(devs[0].MonikerString);

            frame.NewFrame += NFrameEvent;
            frame.Start();
            isCameraOn = true;

        }
        public void stopCamera()
        {
            frame.NewFrame -= NFrameEvent;
            frame.Stop();
            isCameraOn = false;

        }
        public void NFrameEvent(object sender,NewFrameEventArgs  args)
        {
            try
            {
               // var mem = ImageToByteArray((Image)args.Frame.Clone());
                using (var ms = new MemoryStream())
                {
                    var img=  ((Image)args.Frame.Clone());
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                  //  imageIn.Save(ms, imageIn.RawFormat);
                    NFTSpic.Image = System.Drawing.Bitmap.FromStream(ms);
                    //return ms.ToArray();
                }
               
                NFTSpic.SizeMode = PictureBoxSizeMode.StretchImage;
              //  NFTSpic.Image = (Image)args.Frame.Clone();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Camera Error: " + ex.Message);
            }
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
                            AppEventUtils.ShowInfoMessage(this, "Error_priveousPassWord");
                            return;
                        }
                        if(Pswordtxt.Text != ConfirmPswordtxt.Text)
                        {

                            AppEventUtils.ShowInfoMessage(this, "Error");
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
                        if (PasswordUtils.isPasswordCorrect(recentlyPassword.Text, u.password))
                        {
                            AppEventUtils.ShowInfoMessage(this, "Error in Recent Password");
                            return;
                        }
                        if (Pswordtxt.Text != ConfirmPswordtxt.Text)
                        {
                            AppEventUtils.ShowInfoMessage(this, "Error the passwords are not the same");
                            return;
                        }
                        u.firstName = Fnametxt.Text;
                        u.email = Emailtxt.Text;
                        u.lastName = LNametxt.Text;
                        u.password = Utils.PasswordUtils.HashPassword(Pswordtxt.Text);
                        u.profileImage = ImageToByteArray(this.NFTSpic.Image);
                        if (isCameraOn)
                        {

                        }
                        

                    }
                    ctx.SaveChanges();
                    Program.main.OpenchildFrom(new AccountPage(pageType, id), sender);

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Save Error: " +  ex.Message);
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

        private void startCameraButton_Click(object sender, EventArgs e)
        {
            snapButton.Visible = true;
            startCamera();
        }

        private void snapButton_Click(object sender, EventArgs e)
        {
            stopCamera();
            //NFTSpic.Image
        }
    }
}
