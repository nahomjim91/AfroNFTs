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
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        public UserDashBord(bool pageType, string searchTerm="")
        {
          //  MessageBox.Show(pageType.ToString());
         //   MessageBox.Show(mainPage.userID.ToString());
            InitializeComponent();
            this.pageType = pageType;

            flowLayoutPanel1.Controls.Clear();

            //for test 

            using (var ctx = new DbService()) {
                try
                {
                    /*var nftss = ctx.nftTB.Where(
                        nft => nft.isAvelebel == false && nft.NFTsName.Contains(searchTerm)
                                                      && nft.userType == "Admin"
                                                      && nft.description.Contains(searchTerm)*/
                    var nftss = ctx.nftTB.Where(
                        nft => nft.isAvelebel == false && nft.NFTsName.Contains(searchTerm)
                                                      && nft.description.Contains(searchTerm)
                    );
                    foreach (var item in nftss) 
                    {
                        NFTs nfts = new NFTs(pageType);
                        nfts.NftsId = item.NFtsClassId;
                        nfts.NftsPicture = byteArrayToImage(item.NftsPicture);
                        nfts.NFTsName = item.NFTsName;
                        nfts.NFTsRate = item.NFTsRate;
                      
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
