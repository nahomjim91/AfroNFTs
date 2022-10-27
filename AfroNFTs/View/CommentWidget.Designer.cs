namespace AfroNFTs.View
{
    partial class CommentWidget
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.iconlab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "From User Id";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F);
            this.commentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.commentLabel.Location = new System.Drawing.Point(176, 54);
            this.commentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(56, 22);
            this.commentLabel.TabIndex = 1;
            this.commentLabel.Text = "label2";
            this.commentLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.label3.Location = new System.Drawing.Point(55, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F);
            this.userIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.userIdLabel.Location = new System.Drawing.Point(225, 20);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(56, 22);
            this.userIdLabel.TabIndex = 3;
            this.userIdLabel.Text = "label4";
            // 
            // iconlab
            // 
            this.iconlab.AutoSize = true;
            this.iconlab.Font = new System.Drawing.Font("Forte", 18.75F);
            this.iconlab.ForeColor = System.Drawing.Color.Black;
            this.iconlab.Location = new System.Drawing.Point(176, 20);
            this.iconlab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.iconlab.Name = "iconlab";
            this.iconlab.Size = new System.Drawing.Size(30, 27);
            this.iconlab.TabIndex = 4;
            this.iconlab.Text = "A";
            // 
            // CommentWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconlab);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CommentWidget";
            this.Size = new System.Drawing.Size(686, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label iconlab;
    }
}
