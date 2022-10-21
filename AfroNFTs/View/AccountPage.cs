using AfroNFTs.Models;
using AfroNFTs.Services;
using AfroNFTs.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AfroNFTs.Services;
using System.IO;

namespace AfroNFTs.View
{
    public partial class AccountPage : Form
    {
        public int id;
        public bool pg; 
        public AccountPage( bool pageType ,int id)
        {
            InitializeComponent();
            this.id = id;
            this.pg = pageType;
            try
            {
                using (var ctx = new DbService())
                {
                    if (pg)
                    {
                        Admin u = ctx.adminTB.Single(admin => admin.Id == id);
                        this.FirstNamelab.Text = u.firstName;
                        this.LastNamelab.Text = u.lastName;
                        this.Emaillab.Text = u.email;
                        this.TotalWorth.Text = u.balance.ToString();
                        this.profileImagepic.Image = byteArrayToImage(u.profileImage);
                        using (var userService = new UserService(id))
                        {
                            int nftsCount = userService.GetNFTs().Count();
                            this.NumOfNFTs.Text = nftsCount.ToString();

                        }
                    }
                    else
                    {
                        NormalUser u = ctx.normalUserTB.Single(admin => admin.Id == id);
                        this.FirstNamelab.Text = u.firstName;
                        this.LastNamelab.Text = u.lastName;
                        this.Emaillab.Text = u.email;

                        this.TotalWorth.Text = u.balance.ToString();
                        this.profileImagepic.Image = byteArrayToImage(u.profileImage);
                        using (var userService = new UserService(id))
                        {
                            int nftsCount = userService.GetNFTs().Count();
                            this.NumOfNFTs.Text = nftsCount.ToString();

                        }
                    }

                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }


        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new EditAccount(pg , id), sender);
        }
    }
}
