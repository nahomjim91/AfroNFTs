using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using AfroNFTs.View;
using AfroNFTs;
using FontAwesome.Sharp;



namespace AfroNFTs
{
    public partial class mainPage : Form
    {   
        public static List<string> colorList = new List<string>()
        {
            "#064663","#041c32","#04293a","#160040","#1c0c5b","#4E1A6C","#56103C",
            "#56171F  "
        };

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm;
         
        public mainPage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea ;
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
        private void ActivateButton(object senderBtn)
        {   


            if (senderBtn != null)
            {
                Color color = SelectColorSelection();
               
                DisableButton(); //return to default
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
                iconPic_current.IconColor = Color.Black;
                CurrntPage.Text = currentBtn.Text;
                Headerpan.BackColor = color;
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

        private Color SelectColorSelection() // rondom color selection
        {   
            Random ren = new Random();
            int index = ren.Next(colorList.Count);
            string color = colorList[index];

            return ColorTranslator.FromHtml(color);
        }

        
        public  void OpenchildFrom(Form childForm , object btnSender)
        {
            if(activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender );
            this.dashbord_pan.AutoScroll = true;
            Size damintion = new Size(663, 490);
            this.dashbord_pan.AutoScrollMargin = damintion;
            this.dashbord_pan.AutoScrollMinSize = new Size(5, 5);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.dashbord_pan.Controls.Add(childForm);
            this.dashbord_pan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
       
        public void GoToDashbord()
        {
            Dashboardbtn_Click(Dashboardbtn, EventArgs.Empty);
        }
        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            OpenchildFrom( new UserDashBord(),  sender);
        }


        private void Buybtn_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new BuyPage(), sender);
        }

        


        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPic_current.IconChar = IconChar.Home;
            iconPic_current.IconColor = Color.IndianRed;
            CurrntPage.Text = "Home";
            Headerpan.BackColor = Color.FromArgb(47, 4, 47);
        }

        private void dashbord_pan_MouseDown(object sender, MouseEventArgs e)
        {
               
        }

        private void Headerpan_Paint(object sender, PaintEventArgs e)
        {
            //ReleaseCaptuer();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void selltbtn_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new SellPage(), sender);
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new SearchNFTs(), sender);
        }

        

        private void aboutbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void postbtn_Click_1(object sender, EventArgs e)
        {
            OpenchildFrom(new AddNfts(), sender);
        }
    

        private void Siginupb_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new SiginUp(), sender);
            /*
             if(admin) 
                postbtn.visble = true
             */
            aboutbtn.Visible = true;
            accountBtn.Visible = true;
            selltbtn.Visible = true;
            Buybtn.Visible = true;
            Dashboardbtn.Visible = true;
            iconPic_current.Visible = true;
            CurrntPage.Visible = true;
            popChar.Visible = true;
            
        }

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            OpenchildFrom(new Login(), sender);
            Dashboardbtn.Visible = true;
            accountBtn.Visible = true;
            Buybtn.Visible = true;
            selltbtn.Visible = true;
            aboutbtn.Visible = true;
            /*
             if(admin) 
                postbtn.visble = true
             */

        }
    }
}
