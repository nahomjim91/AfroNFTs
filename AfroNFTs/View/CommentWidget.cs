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
    public partial class CommentWidget : UserControl
    {
        public CommentWidget(int fromUserId, string comment)
        {
            InitializeComponent();
            this.commentLabel.Text = comment;
            this.userIdLabel.Text = fromUserId.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
