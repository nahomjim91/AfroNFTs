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
    public partial class PreposOfPage : Form
    {
        bool pageType;
        public PreposOfPage(bool pageType)
        {
            this.pageType = pageType;
            InitializeComponent();

            /*
             *
            if(sellPage){
            funcBtn.text = "Sell";
            typeOfuserLabel.visable = fales;
            editBtn.visable = true ; 
            } 
             * 
             * */
        }

        private void sellOrBuyBtn_Click(object sender, EventArgs e)
        {

        }

        private void descriptionNFTs1_Load(object sender, EventArgs e)
        {

        }
    }
}
