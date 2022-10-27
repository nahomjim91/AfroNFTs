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


using AfroNFTs.Models;
using AfroNFTs.Utils;
namespace AfroNFTs.View
{
    public partial class CreatePage : Form
    {
        bool pageType; 
        public CreatePage( bool pg)
        {
            pageType = pg;
            InitializeComponent();
            this.pageImagepic.Image = AfroNFTs.Properties.Resources.th__2_;
        }

        bool hasError()
        {
            bool result = false;
            if (string.IsNullOrEmpty(descrTxt.Text)) {
                result = true; errorProvider1.SetError(descrTxt, "Required");
            }
            if (string.IsNullOrEmpty(Titeltxt.Text))
            {
                result = true; errorProvider1.SetError(Titeltxt, "Required");
            }
            return result;
        }
        private void submitteBtn1_Click(object sender, EventArgs e)
        {
            if (hasError())
            {

            }
            else
            {
                var adminId = mainPage.userID;
                var page = new Page();

                page.title = Titeltxt.Text;
                page.description = descrTxt.Text;
                page.pageImage = Utils.ConverterImage.ImageToByteArray(this.pageImagepic.Image);


                try
                {
                    using (var ctx = new DbService())
                    {
                        ctx.pageTB.Add(page);
                        ctx.SaveChanges();

                        var admin = ctx.adminTB.Find(adminId);


                        admin.pages.Add(page);

                        ctx.SaveChanges();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Program.main.OpenchildFrom(new MyPages(pageType) , sender);
            }

           
        }

        private void pageImagepic_Click(object sender, EventArgs e)
        {

            string sFile;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
             byte [] imgByte = null;
            openFileDialog1.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFile = openFileDialog1.FileName;
                pageImagepic.Image = System.Drawing.Bitmap.FromFile(sFile);
                pageImagepic.SizeMode = PictureBoxSizeMode.StretchImage;
                using (MemoryStream mStream = new MemoryStream())
                {
                    pageImagepic.Image.Save(mStream, pageImagepic.Image.RawFormat);
                    imgByte = mStream.ToArray();
                }
            }
            string str = "";
            str += imgByte;
            MessageBox.Show(str);
        }
    }
}
