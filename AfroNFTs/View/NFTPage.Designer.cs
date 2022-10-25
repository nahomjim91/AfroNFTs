namespace AfroNFTs.View
{
    partial class NFTPage
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
            this.labNFTsName = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBoxNFTs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNFTs)).BeginInit();
            this.SuspendLayout();
            // 
            // labNFTsName
            // 
            this.labNFTsName.AutoSize = true;
            this.labNFTsName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNFTsName.ForeColor = System.Drawing.Color.Coral;
            this.labNFTsName.Location = new System.Drawing.Point(56, 290);
            this.labNFTsName.MaximumSize = new System.Drawing.Size(150, 0);
            this.labNFTsName.Name = "labNFTsName";
            this.labNFTsName.Size = new System.Drawing.Size(57, 21);
            this.labNFTsName.TabIndex = 3;
            this.labNFTsName.Text = "label1";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(128, 290);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(81, 25);
            this.iconButton1.TabIndex = 42;
            this.iconButton1.Text = "See Details";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBoxNFTs
            // 
            this.pictureBoxNFTs.Image = global::AfroNFTs.Properties.Resources.gettyimages_165604915_170667a;
            this.pictureBoxNFTs.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNFTs.Name = "pictureBoxNFTs";
            this.pictureBoxNFTs.Size = new System.Drawing.Size(212, 287);
            this.pictureBoxNFTs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNFTs.TabIndex = 6;
            this.pictureBoxNFTs.TabStop = false;
            // 
            // NFTPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pictureBoxNFTs);
            this.Controls.Add(this.labNFTsName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(212, 323);
            this.MinimumSize = new System.Drawing.Size(212, 323);
            this.Name = "NFTPage";
            this.Size = new System.Drawing.Size(212, 323);
            this.Load += new System.EventHandler(this.NFTPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNFTs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNFTsName;
        private System.Windows.Forms.PictureBox pictureBoxNFTs;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
