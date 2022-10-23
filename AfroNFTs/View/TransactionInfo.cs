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
    public partial class TransactionInfo : UserControl
    {
        public TransactionInfo(decimal price, string userName, string title)
        {
            InitializeComponent();
            titleLabel.Text = title;
            priceLabel.Text = price.ToString();
            usersNameLabel.Text = userName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
