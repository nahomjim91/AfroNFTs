using AfroNFTs.Models;
using AfroNFTs.Services;
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

namespace AfroNFTs.View
{
    public partial class PageDetails : Form
    {

        private int pageId;
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        public PageDetails(int pd)
        {
            MessageBox.Show(pd.ToString());
            pageId = pd;
            InitializeComponent();
            List<NFTsClass> nftss;
            try
            {
                using (var ctx = new DbService())
                {
                    this.pageTitel.Text = (ctx.pageTB.Find(pd)).title;
                }
            }catch(Exception y)
            {
                MessageBox.Show(y.Message);
            }
           
            using (var pageService = new PageService(pd))
            {

                nftss = pageService.GetAllNfts();
            }

                foreach (var item in nftss)
                {
                    NFTs nfts = new NFTs(true);
                // nfts.NftsPicture = byteArrayToImage(item.NftsPicture);
                    nfts.NftsId = item.pageId;
                    nfts.NFTsName = item.NFTsName;
                    nfts.NFTsRate = item.NFTsRate;
                    nfts.NFTsprice = item.NFTsprice;
                    flowLayoutPanel1.Controls.Add(nfts);

                }
        }


        private void DeletePagebtn1_Click(object sender, EventArgs e)
        {
            try
                {
                using (var ctx = new DbService())
                    {
                        var page = ctx.pageTB.Find(pageId);
                        MessageBox.Show("PageId: " + page.PageId);
                        ctx.pageTB.Remove(page);
                    using (var pgService = new PageService(page.PageId))
                    {
                        pgService.deleteAllNfts();
                    }
                        ctx.SaveChanges();
                    Program.main.OpenchildFrom(new MyPages(true), sender);
                }
                }catch(Exception g)
                {
                    MessageBox.Show(g.Message);
                }
        }

        private void AddNFTsbtn2_Click(object sender, EventArgs e)
        {
            Program.main.OpenchildFrom(new AddNfts(pageId), sender);
        }
    }
}
