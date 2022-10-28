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
        List<string> colorList = new List<string>()
        {
             "#593765" , "#643765" , "#57673B" , "#3B675B" , "#67673B"
        };
        private Color SelectColorSelection() // rondom color selection
        {
            Random ren = new Random();
            int index = ren.Next(colorList.Count);
            string color = colorList[index];

            return ColorTranslator.FromHtml(color);
        }
        public TransactionInfo(decimal price, string userName, string title)
        {
            InitializeComponent();

            char x = userName[0];
            this.iconButton1.Text = x.ToString().ToUpper();
            this.BackColor = SelectColorSelection();
            this.iconButton1.BackColor = SelectColorSelection();
            titleLabel.Text = title;
            priceLabel.Text = price.ToString();
            usersNameLabel.Text = userName;
        }

    }
}
