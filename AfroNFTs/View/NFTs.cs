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

namespace AfroNFTs.View
{
    public partial class NFTs : UserControl
    {
        private Image _NftsPicture;

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

        public NFTs()
        {
            InitializeComponent();
        }
    }
}
