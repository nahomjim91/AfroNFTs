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
using AfroNFTs.Models;

namespace AfroNFTs
{
    public partial class mainPage : Form
    {   
        public static List<string> colorList = new List<string>()
        {
            /*"#064663","#041c32","#04293a","#160040","#1c0c5b","#4E1A6C","#56103C",
            "#56171F  "*/
            "#120A0A" , "#0B121E" , "#2A200E" , "#1C311B" , "#140F21" , "#0A191C" ,
            "#200C18" , "#0C201C"
        };

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm;
      public  bool PageType = false; //by defualt user
        public static int userID;
         
        public mainPage()
        {
            InitializeComponent();
            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea ;
            OpenchildFrom(new StartPage(), aboutbtn);

        }
       
        private void ActivateButton(object senderBtn )
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


        public   void OpenchildFrom(Form childForm , object btnSender)
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
           // childForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dashbord_pan.Controls.Add(childForm);
            this.dashbord_pan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
       
        public void GoToDashbord(bool pageType)
        {
            this.PageType = pageType;
            if (PageType)
            {
                MyPagebtn.Visible = true;
                Creatpagebtn.Visible = true;
            }
            else
            {
                MyPagebtn.Visible = false;

                //Buybtn.Visible = true;
            }
            aboutbtn.Visible = true;
            accountBtn.Visible = true;
            Dashboardbtn.Visible = true;
            iconPic_current.Visible = true;
            CurrntPage.Visible = true;
            popChar.Visible = true;
            balanceBtn.Visible = true;
            transactionsBtn.Visible = true;
           if(!pageType)  myNFTsButton.Visible = true;

            Dashboardbtn_Click(Dashboardbtn, EventArgs.Empty);
        }
        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            if(PageType)
                OpenchildFrom( new AdminDashBord(PageType),  sender);
            else
                OpenchildFrom(new UserDashBord(PageType), sender);
        }


        


        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            OpenchildFrom(new StartPage() , aboutbtn);
            
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


        private void accountBtn_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new AccountPage(PageType , userID), sender);
        }

        

        private void aboutbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void postbtn_Click_1(object sender, EventArgs e)
        {
            OpenchildFrom(new CreatePage(PageType), sender);
        }

        //public delegate void MainPageEventHandler(object sender, EventArgs args);

        //public event MainPageEventHandler 

        private void Siginupb_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new SiginUp(), sender);
            Dashboardbtn.Visible = false;
            accountBtn.Visible = false;
            aboutbtn.Visible = false;
            Creatpagebtn.Visible = false;
            MyPagebtn.Visible = false;
            iconPic_current.Visible = false;
            CurrntPage.Visible = false;
            popChar.Visible = false;
            Creatpagebtn.Visible = false;
            myNFTsButton.Visible = false;
            accountBtn.Visible = false;
            transactionsBtn.Visible = false;

        }

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            OpenchildFrom(new Login(), sender);
            Dashboardbtn.Visible = false;
            accountBtn.Visible = false;
            aboutbtn.Visible = false;
            Creatpagebtn.Visible = false;
            MyPagebtn.Visible = false;
            iconPic_current.Visible = false;
            CurrntPage.Visible = false;
            popChar.Visible = false;
            Creatpagebtn.Visible = false;
            balanceBtn.Visible = false;
            myNFTsButton.Visible = false;
        }

        private void dashbord_pan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyPagebtn_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new MyPages(PageType), sender);
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new Balance(mainPage.userID, PageType), sender);
        }

        private void myNFTsButton_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new MyNFTS(userID), sender);
        }

        private void transactionsBtn_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new Transactions(PageType), sender);
        }
    }
}
