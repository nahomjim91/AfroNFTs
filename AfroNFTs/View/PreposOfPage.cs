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
using AfroNFTs.Services;
using AfroNFTs.Utils;

namespace AfroNFTs.View
{
    public partial class PreposOfPage : Form
    {
        bool pageType;
        int id;
        NFTsClass nft;


        public PreposOfPage(bool pageType, int id)
        {
            MessageBox.Show("I am Here!!" + id.ToString());

            this.pageType = pageType;
            this.id = id;
            InitializeComponent();




            // if (pageType) { }
            using (var ctx = new DbService())
            {
                try
                {
                    nft = ctx.nftTB.Single(obj => obj.NFtsClassId == id);
                    if (nft.OwnerID == mainPage.userID)
                    {
                        this.isAvel.Visible = true;
                        this.editBtn.Visible = true;
                        this.sellOrBuyBtn.Visible =false;
                    }
                    else
                    {
                        this.sellOrBuyBtn.Visible = true;
                        this.editBtn.Visible = false;
                        this.isAvel.Visible = false;
                    }
                    MessageBox.Show(nft.OwnerID.ToString() + "     " + id);
                    this.descriptionNFTs1.NFTsName = nft.NFTsName;
                    this.descriptionNFTs1.NftsPicture = Utils.ConverterImage.byteArrayToImage(nft.NftsPicture);
                    //this.descriptionNFTs1.NftsPicture.
                    this.descriptionNFTs1.NFTsprice = nft.NFTsprice;
                    this.descriptionNFTs1.NFTsRate = nft.NFTsRate;
                    this.descriptionNFTs1.Description = nft.description;
                    this.descriptionNFTs1.Group = nft.Group;
                    this.isAvel.Checked = nft.isAvelebel;

                    if (this.isAvel.Checked)
                    {
                        label1.Text = "This NFT is availibil for sell";
                    }
                    else
                    {
                        label1.Text = "This NFT is not availibil for sell";
                    }
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message);
                }

            }
        }

        private void sellOrBuyBtn_Click(object sender, EventArgs e)
        {
            if (isAvel.Checked)
            {
                try
                {

                    using (var ctx = new DbService())
                    {
                        
                        var user = ctx.normalUserTB.SingleOrDefault(n => n.Id== mainPage.userID);
                        if (decimal.Parse(descriptionNFTs1.NFTsprice.ToString()) > user.balance)
                        {
                            AppEventUtils.ShowInfoMessage(this, "You cannot buy this please recharge!");
                            return;
                        }
                        var nft = ctx.nftTB.Find(this.id);

                        if (nft == null)
                        {
                            AppEventUtils.ShowInfoMessage(this, "The NFT ID is not given");
                            return;
                        }
                        if (nft.OwnerID == mainPage.userID) return;


                        using (var transcationService = new TranscationService(mainPage.userID, !pageType))
                        {
                            transcationService.register(nft.OwnerID, nft.NFTsName, nft.NFTsprice);
                        }
                        using (var transcationService = new TranscationService(nft.OwnerID, pageType))
                        {
                            transcationService.register(mainPage.userID, nft.NFTsName, nft.NFTsprice);
                        }
                        decimal price = 0;
                        using (var reactionService = new ReactionService())
                        {
                            price = reactionService.getPrice(id, (decimal)nft.NFTsprice);
                        }
                        var admin = ctx.adminTB.Single(n => n.Id == nft.OwnerID);
                        admin.balance += (decimal)price;
                        user.balance -= (decimal)price;
                        nft.userType = "User";
                        nft.isAvelebel = false;
                        nft.OwnerID = mainPage.userID;

                        ctx.SaveChanges();


                        AppEventUtils.ShowInfoMessage(this, "Bought!");
                        if(pageType)
                            Program.main.OpenchildFrom(new MyPages(true), sender);
                        else
                            Program.main.OpenchildFrom(new MyNFTS(mainPage.userID), sender);



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Sorry !! sir this NFTs is not for Sell!!!");
            }


        }
    
        
       

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (nft.OwnerID == mainPage.userID)
            {
                Program.main.OpenchildFrom(new EditNfts( pageType, id), sender);
            }
        }

        private void isAvel_CheckedChanged(object sender, EventArgs e)
        {

            using (var ctx = new DbService())
            {
                try
                {
                    var nft = ctx.nftTB.Single(obj => obj.NFtsClassId == id);
                    nft.isAvelebel = isAvel.Checked;
                    if (this.isAvel.Checked)
                    {
                        label1.Text = "This NFT is availibil for sell";
                    }
                    else
                    {
                        label1.Text = "This NFT is not availibil for sell";
                    }
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new CommentPage(id), sender);
        }

        private void isAvel_CheckedChanged(object sender, MouseEventArgs e)
        {
            using (var ctx = new DbService())
            {
                try
                {
                    var nft = ctx.nftTB.Single(obj => obj.NFtsClassId == id);
                    nft.isAvelebel = isAvel.Checked;
                    if (this.isAvel.Checked)
                    {
                        label1.Text = "This NFT is availibil for sell";
                    }
                    else
                    {
                        label1.Text = "This NFT is not availibil for sell";
                    }
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
