﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AfroNFTs.Utils;
using AfroNFTs.Models;
namespace AfroNFTs.View
{
    public partial class NFTs : UserControl

    {
        public event EventHandler NFTsDetail ;

        protected virtual void OnClickNFTs(EventArgs e)
        {
            NFTsDetail.Invoke(this, e);
        }
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
            set { _NFTsprice = value; labPrice.Text = value.ToString(); }
        }

        private double _NFTsRate;

        public double NFTsRate
        {
            get { return _NFTsRate; }
            set { _NFTsRate = value; labNFTsRate.Text = value.ToString(); }
        }
        bool pagetype = false;
        int userUsingId;
        public NFTs(bool pg)
        {
            this.userUsingId = mainPage.userID;
            pagetype = pg;
            InitializeComponent();
            if (!isAvel) { pictureBox1.Visible = false; }

        }

        private void seeDetailbtn_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new PreposOfPage(pagetype,  NftsId), sender);
        }

        private void labNFTsName_Click(object sender, EventArgs e)
        {

        }

        private void labNFTsRate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxNFTs_Click(object sender, EventArgs e)
        {

        }

        private void labPrice_Click(object sender, EventArgs e)
        {

        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            try
            {
              
                using(var ctx = new DbService())
                {
                    var user = ctx.normalUserTB.Find(mainPage.userID);
                    if(decimal.Parse(labPrice.Text) > user.balance)
                    {
                        AppEventUtils.ShowInfoMessage(this, "You cannot buy this please recharge!");
                        return;
                    }
                    var nft = ctx.nftTB.Find(this.NftsId);

                    if(nft == null)
                    {
                        AppEventUtils.ShowInfoMessage(this, "The NFT ID is not given");
                        return;
                    }
                    user.balance -= (decimal)nft.NFTsprice;
                    nft.userType = "User";
                    nft.isAvelebel = true;
                    nft.OwnerID = mainPage.userID;

                    ctx.SaveChanges();

                    AppEventUtils.ShowInfoMessage(this, "Bought!");



                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
