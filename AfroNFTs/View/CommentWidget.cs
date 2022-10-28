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
        List<string> colorList = new List<string>() {
            "#593765" , "#643765" , "#57673B" , "#3B675B" , "#67673B"
        };

        private Color SelectColorSelection() // rondom color selection
        {
            Random ren = new Random();
            int index = ren.Next(colorList.Count);
            string color = colorList[index];

            return ColorTranslator.FromHtml(color);
        }
        public CommentWidget(int fromUserId, string comment , char x)
        {
            InitializeComponent();
            this.iconButton1.Text = x.ToString().ToUpper();
            this.BackColor = SelectColorSelection();
            this.iconButton1.BackColor = SelectColorSelection();
            

            this.commentLabel.Text = comment;
            this.userIdLabel.Text = fromUserId.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
