﻿using System;
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
    public partial class SellPage : Form
    {
        bool pageType;
        public SellPage(bool pageType)
        {
            this.pageType = pageType;
            InitializeComponent();
        }
    }
}
