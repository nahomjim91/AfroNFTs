using System;
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
    public partial class SeeComments : Form
    {
        private int objectId;
        public SeeComments(int objectId)
        {
            this.objectId = objectId;
            InitializeComponent();
            
            using (var commentService = new CommentService())
            {
                var comments = commentService.getCommentsOn(objectId);

                foreach(Comment com in comments)
                {
                    var l = new CommentWidget(com.userId, com.comment);
                   
                    l.AutoSize = true;
                  //  l.AutoScrollOffset = new Point(0, 10);
                    this.Controls.Add(l);
                   // MessageBox.Show(com.comment);
                }
            }
        }

        private void SeeComments_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
