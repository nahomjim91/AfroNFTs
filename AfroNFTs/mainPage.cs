using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AfroNFTs
{
    public partial class mainPage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public mainPage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
        }
        //Stracte
        private struct RGBcolors 
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 113 ,176);
            public static Color color3 = Color.FromArgb(253, 153 ,114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        //IMethods
        private void ActivateButton(object senderBtn, Color color)
        { 
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // MLeft border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconPic_current.IconChar = currentBtn.IconChar;
                iconPic_current.IconColor = color;
                CurrntPage.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(47, 4, 47);
                currentBtn.ForeColor = Color.IndianRed;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.IndianRed;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

       

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBcolors.color1);
        }

        private void postbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
        }

        private void Buybtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
        }

        private void accoubtbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color5);
        }
    }
}
