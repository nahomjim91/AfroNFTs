using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AfroNFTs.Services;
using AfroNFTs.Models;

namespace AfroNFTs.View
{
    public partial class AdminDashBord : Form
    {
        bool pageType = false;
        public AdminDashBord(bool pageType)
        {
            InitializeComponent();
            this.pageType = pageType;

            double nftLen = 0;
            double page = 0;
            double likes = 0;
            double disLikes = 0;
            double comments = 0;
            double percomments = 0;
            decimal balance = 0;
            double perNftsLike = 0; 
            double perNftsDislike = 0;
            using(var ctx = new DbService())
            {
           //     if (mainPage.userID == null) MessageBox.Show("#LOL!");
                 
                var admin = ctx.adminTB.Single(ad => ad.Id == mainPage.userID);
                if (admin == null)
                {
                    MessageBox.Show("Admin is null!! " + mainPage.userID);
                    //  int nftLen
                }
                else
                {
                    nftLen = ctx.nftTB.Where(Nf => Nf.OwnerID == admin.Id).Count();
                    page = admin.pages.Count();
                    balance = admin.balance;
                    using(var aS = new ActionService(1))
                    {
                        likes = aS.getLikesNo(mainPage.userID);
                        disLikes = aS.getDislikesNo(mainPage.userID);
                        comments = aS.getCommentsNo(mainPage.userID);
                    }
                    percomments = (comments / nftLen);
                    perNftsDislike = (disLikes / nftLen);
                    perNftsLike = (perNftsLike / nftLen);
                }
            }
            this.txtNumberOfLike.Text = likes.ToString();
            this.txtNumberofDislike.Text = disLikes.ToString();
            this.txtNumberOfNFTs.Text = nftLen.ToString();
            this.txtPageNumber.Text = page.ToString();
            this.txtBalance.Text = balance.ToString();
            this.txtNumberOfComments.Text = comments.ToString();
            this.txtNofPerLike.Text = perNftsLike.ToString();
            this.txtNofDislikePerNFTs.Text = perNftsDislike.ToString();
            this.txtNumberOfCommentPer.Text = percomments.ToString();
            
        }

    }
}
