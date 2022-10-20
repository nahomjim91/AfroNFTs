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
namespace AfroNFTs.View
{
    public partial class PreposOfPage : Form
    {
        bool pageType;
        int id;
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        public PreposOfPage(bool pageType , int id)
        {
            this.pageType = pageType;
            this.id = id;   
            InitializeComponent();
            NFTsClass nft;
            if(pageType){
               using(var ctx = new DbService())
                {
                    try
                    {
                        nft = ctx.nftTB.Find(id);
                        this.descriptionNFTs1.NFTsName = nft.NFTsName;
                        this.descriptionNFTs1.NftsPicture = byteArrayToImage(nft.NftsPicture);
                        this.descriptionNFTs1.NFTsprice = nft.NFTsprice;
                        this.descriptionNFTs1.NFTsRate = nft.NFTsRate;
                        this.descriptionNFTs1.Description = nft.description;
                        this.descriptionNFTs1.Group = nft.Group;
                    }
                    catch(Exception b)
                    {
                        MessageBox.Show(b.Message);
                    }
                }
            } 
        }

        private void sellOrBuyBtn_Click(object sender, EventArgs e)
        {

        }

        private void descriptionNFTs1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            iconButton1.BackgroundImage = AfroNFTs.Properties.Resources.disLike2;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            iconButton2.BackgroundImage = AfroNFTs.Properties.Resources.like2;
        }
    }
}
