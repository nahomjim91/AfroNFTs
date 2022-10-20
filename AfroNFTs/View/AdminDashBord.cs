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
    public partial class AdminDashBord : Form
    {
        bool pageType = false;
        public AdminDashBord(bool pageType)
        {
            InitializeComponent();
            this.pageType = pageType;
        }
    }
}
