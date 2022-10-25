namespace AfroNFTs.View
{
    partial class PageDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNFTsbtn2 = new FontAwesome.Sharp.IconButton();
            this.DeletePagebtn1 = new FontAwesome.Sharp.IconButton();
            this.pageTitel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AddNFTsbtn2
            // 
            this.AddNFTsbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.AddNFTsbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNFTsbtn2.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.AddNFTsbtn2.ForeColor = System.Drawing.Color.White;
            this.AddNFTsbtn2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddNFTsbtn2.IconColor = System.Drawing.Color.Black;
            this.AddNFTsbtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddNFTsbtn2.Location = new System.Drawing.Point(660, 235);
            this.AddNFTsbtn2.Name = "AddNFTsbtn2";
            this.AddNFTsbtn2.Size = new System.Drawing.Size(87, 34);
            this.AddNFTsbtn2.TabIndex = 43;
            this.AddNFTsbtn2.Text = "Add NFTs";
            this.AddNFTsbtn2.UseVisualStyleBackColor = false;
            this.AddNFTsbtn2.Click += new System.EventHandler(this.AddNFTsbtn2_Click);
            // 
            // DeletePagebtn1
            // 
            this.DeletePagebtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.DeletePagebtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePagebtn1.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.DeletePagebtn1.ForeColor = System.Drawing.Color.White;
            this.DeletePagebtn1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DeletePagebtn1.IconColor = System.Drawing.Color.Black;
            this.DeletePagebtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeletePagebtn1.Location = new System.Drawing.Point(660, 103);
            this.DeletePagebtn1.Name = "DeletePagebtn1";
            this.DeletePagebtn1.Size = new System.Drawing.Size(87, 34);
            this.DeletePagebtn1.TabIndex = 44;
            this.DeletePagebtn1.Text = "Delete Page";
            this.DeletePagebtn1.UseVisualStyleBackColor = false;
            this.DeletePagebtn1.Click += new System.EventHandler(this.DeletePagebtn1_Click);
            // 
            // pageTitel
            // 
            this.pageTitel.AutoSize = true;
            this.pageTitel.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.pageTitel.Location = new System.Drawing.Point(23, 26);
            this.pageTitel.Name = "pageTitel";
            this.pageTitel.Size = new System.Drawing.Size(83, 22);
            this.pageTitel.TabIndex = 46;
            this.pageTitel.Text = "PageTitel";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(57)))), ((int)(((byte)(121)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 51);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(750, 500);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(236, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(642, 406);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // PageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(855, 458);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pageTitel);
            this.Controls.Add(this.DeletePagebtn1);
            this.Controls.Add(this.AddNFTsbtn2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PageDetails";
            this.Text = "PageDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton AddNFTsbtn2;
        private FontAwesome.Sharp.IconButton DeletePagebtn1;
        private System.Windows.Forms.Label pageTitel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}