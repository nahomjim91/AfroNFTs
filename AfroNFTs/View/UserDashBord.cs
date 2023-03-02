using AfroNFTs.Models;
using AfroNFTs.View;
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

using AfroNFTs.Services;


namespace AfroNFTs
{
    public partial class UserDashBord : Form
    {
        
        bool pageType;
        Random rand = new  Random();
        public UserDashBord(bool pageType, string searchTerm="")
        {
          //  MessageBox.Show(pageType.ToString());
         //   MessageBox.Show(mainPage.userID.ToString());
            InitializeComponent();
            this.pageType = pageType;

            flowLayoutPanel1.Controls.Clear();
            try
            {
                using (var ctx = new DbService())
                {
                    this.labLinkWorth.Text = (ctx.normalUserTB.Find(mainPage.userID)).balance.ToString();
                }
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
            using (var ctx = new DbService()) {
                try
                {
                    /*var nftss = ctx.nftTB.Where(
                        nft => nft.isAvelebel == false && nft.NFTsName.Contains(searchTerm)
                                                      && nft.userType == "Admin"
                                                      && nft.description.Contains(searchTerm)*/
                    var nftss = ctx.nftTB.Where(
                        nft => nft.NFTsName.Contains(searchTerm)
                                                      || nft.description.Contains(searchTerm)
                    ).ToList();
                    
                    for (int i = 0; i <nftss.Count(); i++)
                    {
                        int j = rand.Next(0 , nftss.Count);
                        var item = nftss[j];
                        NFTs nfts = new NFTs(pageType , item.NFtsClassId , true , true);
                        nfts.NftsPicture = Utils.ConverterImage.byteArrayToImage(item.NftsPicture);
                        nfts.NFTsName = item.NFTsName;
                        nfts.NFTsRate = item.NFTsRate;
                        nfts.isAvel = item.isAvelebel;
                        nfts.Click += new System.EventHandler(Deitail_click);

                        using(var reactionService = new ReactionService())
                        {
                            nfts.NFTsprice = (double)reactionService.getPrice(nfts.NftsId, (decimal)item.NFTsprice);
                            int dislikes = reactionService.getDisLikes(nfts.NftsId);
                            int likes = reactionService.getLikes(nfts.NftsId);

                            nfts.Likes = likes;
                            nfts.DisLikes = dislikes;
                           
                        }

                        flowLayoutPanel1.Controls.Add(nfts);
                        
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

       public void Deitail_click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }

        private void UserDashBord_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new UserDashBord(pageType, txtSerachNFTS.Text), sender);
        }
    }
}
