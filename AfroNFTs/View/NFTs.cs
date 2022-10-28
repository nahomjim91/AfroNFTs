using FontAwesome.Sharp;
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
using AfroNFTs.Utils;
using AfroNFTs.Models;
namespace AfroNFTs.View
{
    public partial class NFTs : UserControl

    {
        public event EventHandler NFTsDetail ;

        public int NftsId;
        private Image _NftsPicture;
        public bool isAvel;
        public Image NftsPicture
        {
            get { return _NftsPicture; }
            set { _NftsPicture = value; pictureBoxNFTs.Image = value; }
        }


        private string _NFTsName;

        public string NFTsName
        {
            get { return _NFTsName; }
            set { _NFTsName = value; labNFTsName.Text = value; }
        }

        private double _NFTsprice;

        public double NFTsprice
        {
            get { return _NFTsprice; }
            set { _NFTsprice = value; labPrice.Text = value.ToString() + "$"; }
        }

        private double _NFTsRate;

        public double NFTsRate
        {
            get { return _NFTsRate; }
            set { _NFTsRate = value; ; }
        }
        bool pagetype = false;
        int userUsingId;
        bool visbleOfAddCommentBtn = true;
        
        public int Likes
        {
            set
            {
                likesLabel.Text = value.ToString();
            }
        }
        public int DisLikes
        {
            set
            {
                dislikesLabel.Text = value.ToString();
            }
        }
        int ownerId;
        public NFTs(bool pg, int Id , bool haveTovisbile , bool btnenabelity)
        {
            DbService dbService = new DbService();
            this.visbleOfAddCommentBtn = haveTovisbile;
            this.userUsingId = mainPage.userID;
            pagetype = pg;
            NftsId = Id;
            InitializeComponent();
            ownerId = dbService.nftTB.Find(Id).OwnerID;
            this.iconButton4.Visible = visbleOfAddCommentBtn;
            this.buyButton.Visible = haveTovisbile;
            this.iconButton1.Enabled = btnenabelity;
            this.iconButton2.Enabled = btnenabelity;


        }

        private void seeDetailbtn_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new PreposOfPage(pagetype,  NftsId), sender);
        }


        private void buyButton_Click(object sender, EventArgs e)
        {
            if (isAvel)
            {
                try
                {

                    using (var ctx = new DbService())
                    {
                        var user = ctx.normalUserTB.Find(mainPage.userID);
                        if (decimal.Parse(labPrice.Text) > user.balance)
                        {
                            AppEventUtils.ShowInfoMessage(this, "You cannot buy this please recharge!");
                            return;
                        }
                        var nft = ctx.nftTB.Find(this.NftsId);

                        if (nft == null)
                        {
                            AppEventUtils.ShowInfoMessage(this, "The NFT ID is not given");
                            return;
                        }
                        if (nft.OwnerID == mainPage.userID) return;


                        using (var transcationService = new TranscationService(mainPage.userID, !pagetype))
                        {
                            transcationService.register(nft.OwnerID, nft.NFTsName, nft.NFTsprice);
                        }
                        using (var transcationService = new TranscationService(nft.OwnerID, pagetype))
                        {
                            transcationService.register(mainPage.userID, nft.NFTsName, nft.NFTsprice);
                        }
                        decimal price = 0;
                        using (var reactionService = new ReactionService())
                        {
                            price = reactionService.getPrice(NftsId, (decimal)nft.NFTsprice);
                        }
                        var admin = ctx.adminTB.Single(n => n.Id == nft.OwnerID); ;
                        admin.balance += (decimal)price;
                        user.balance -= (decimal)price;
                        nft.userType = "User";
                        nft.isAvelebel = false;
                        nft.OwnerID = mainPage.userID;

                        ctx.SaveChanges();


                        AppEventUtils.ShowInfoMessage(this, "Bought!");



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sorry sir is NFTS is not avalable for Sell!!");
            }
            
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (ownerId == mainPage.userID) return;
            try
            {
                using (var reactionService = new ReactionService())
                {
                   // MessageBox.Show(NftsId.ToString());
                    reactionService.like(mainPage.userID, NftsId, () =>
                    {
                        Task.Delay(3000);

                        if (!pagetype) Program.main.OpenchildFrom(new UserDashBord(false), sender);
                    });
                }
                using(var ac = new ActionService(pagetype, mainPage.userID))
                {
                    using (var ctx = new DbService())
                    {
                        var nft = ctx.nftTB.Single(Nfts => Nfts.NFtsClassId == NftsId);
                        ac.registerAction("Li", nft.OwnerID);
                    }
                   
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new CommentPage(NftsId), sender);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            if (ownerId == mainPage.userID) return;
            Program.main.OpenchildFrom(new AddComment(NftsId , this._NftsPicture), sender);
            using (var ac = new ActionService(pagetype, mainPage.userID))
            {
                using (var ctx = new DbService())
                {
                    var nft = ctx.nftTB.Find(NftsId);
                    ac.registerAction("co", nft.OwnerID);
                }

            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {

            if (ownerId == mainPage.userID) return;

            try
            {
                using (var reactionService = new ReactionService())
                {
                    MessageBox.Show(NftsId.ToString());
                    reactionService.dislike(mainPage.userID, NftsId, () =>
                    {
                        Task.Delay(3000);
                       if(!pagetype) Program.main.OpenchildFrom(new UserDashBord(false), sender);
                    });
                }
                using (var ac = new ActionService(pagetype, mainPage.userID))
                {
                    using (var ctx = new DbService())
                    {
                        var nft = ctx.nftTB.Single(Nfts => Nfts.NFtsClassId == NftsId);
                        if (nft == null) return;
                        ac.registerAction("Di", nft.OwnerID);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
