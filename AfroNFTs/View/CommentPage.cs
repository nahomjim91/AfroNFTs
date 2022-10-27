using AfroNFTs.Models;
using AfroNFTs.Services;
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
    public partial class CommentPage : Form
    {
        int objectId;
        public CommentPage(int objectId)
        {
            this.objectId = objectId;
            InitializeComponent();
            using (var commentService = new CommentService())
            {
                var comments = commentService.getCommentsOn(objectId);
                DbService dbService = new DbService();
                foreach (Comment com in comments)
                {
                   var user= dbService.normalUserTB.Find(com.userId).firstName;
                    char firstLatter = user[0];
                    
                    var l = new CommentWidget(com.userId, com.comment ,firstLatter );

                    l.AutoSize = true;
                    //  l.AutoScrollOffset = new Point(0, 10);
                    this.flowLayoutPanel1.Controls.Add(l);
                    // this.Controls.Add(l);
                    MessageBox.Show(com.comment);
                }
            }

            this.objectId = objectId;
        }
    }
}
