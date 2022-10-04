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
    public partial class DescriptionNFTs : UserControl
    {

        private Image _NftsPicture;

        public Image NftsPicture
        {
            get { return _NftsPicture; }
            set { _NftsPicture = value; NFTsiconPictureBox.Image = value; }
        }


        private string _NFTsName;

        public string NFTsName
        {
            get { return _NFTsName; }
            set { _NFTsName = value; nameLable.Text = value; }
        }
        private string _Group;

        public string Group
        {
            get { return _Group; }
            set { _Group = value; GroupLable.Text = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; richTextBox1.Text = value; }
        }


        private double _NFTsprice;

        public double NFTsprice
        {
            get { return _NFTsprice; }
            set { _NFTsprice = value; priceLabel.Text = value.ToString(); }
        }

        private double _NFTsRate;

        public double NFTsRate
        {
            get { return _NFTsRate; }
            set { _NFTsRate = value; rateLabel.Text = value.ToString(); }
        }
        public DescriptionNFTs()
        {
            InitializeComponent();
        }
    }
}
