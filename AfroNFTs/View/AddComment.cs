﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AfroNFTs.Services;
namespace AfroNFTs.View
{
    public partial class AddComment : Form
    {
        private int objectId;
        public AddComment(int  objectId)
        {
            this.objectId = objectId;
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using(var commentService = new CommentService())
            {
                commentService.writeComment(mainPage.userID, objectId, richTextBox1.Text);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
