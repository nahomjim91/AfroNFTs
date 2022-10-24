using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

using AfroNFTs.Services;
using AfroNFTs.Models;
namespace AfroNFTs.View
{
    public partial class MyNFTS : Form
    {
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        public MyNFTS(int userId)
        {
            InitializeComponent();
            try
            {
               List<NFTsClass> nftsS = new List<NFTsClass>();
                using (var userService = new UserService(userId))
                {
                    nftsS = userService.GetNFTs();
                    if(nftsS != null)
                    {
                       // MessageBox.Show("PA");
                        foreach(var item in nftsS)
                        {
                            NFTs nfts = new NFTs(false , item.NFtsClassId);
                            nfts.NftsPicture = byteArrayToImage(item.NftsPicture);
                            nfts.NFTsName = item.NFTsName;
                            nfts.NFTsRate = item.NFTsRate;
                            nfts.NFTsprice = item.NFTsprice;flowLayoutPanel1.Controls.Add(nfts);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("here " + ex.Message);
            }

        }
    }
}
