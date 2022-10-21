namespace AfroNFTs.View
{
    partial class NFTs
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
            this.labPrice = new System.Windows.Forms.Label();
            this.labNFTsName = new System.Windows.Forms.Label();
            this.labNFTsRate = new System.Windows.Forms.Label();
            this.seeDetailbtn = new FontAwesome.Sharp.IconButton();
            this.pictureBoxNFTs = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buyButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNFTs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.ForeColor = System.Drawing.Color.Coral;
            this.labPrice.Location = new System.Drawing.Point(129, 273);
            this.labPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(71, 25);
            this.labPrice.TabIndex = 1;
            this.labPrice.Text = "label1";
            this.labPrice.Click += new System.EventHandler(this.labPrice_Click);
            // 
            // labNFTsName
            // 
            this.labNFTsName.AutoSize = true;
            this.labNFTsName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNFTsName.ForeColor = System.Drawing.Color.Coral;
            this.labNFTsName.Location = new System.Drawing.Point(4, 270);
            this.labNFTsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNFTsName.MaximumSize = new System.Drawing.Size(200, 0);
            this.labNFTsName.Name = "labNFTsName";
            this.labNFTsName.Size = new System.Drawing.Size(71, 25);
            this.labNFTsName.TabIndex = 2;
            this.labNFTsName.Text = "label1";
            this.labNFTsName.Click += new System.EventHandler(this.labNFTsName_Click);
            // 
            // labNFTsRate
            // 
            this.labNFTsRate.AutoSize = true;
            this.labNFTsRate.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.labNFTsRate.ForeColor = System.Drawing.Color.Coral;
            this.labNFTsRate.Location = new System.Drawing.Point(48, 299);
            this.labNFTsRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNFTsRate.Name = "labNFTsRate";
            this.labNFTsRate.Size = new System.Drawing.Size(39, 25);
            this.labNFTsRate.TabIndex = 4;
            this.labNFTsRate.Text = "0.0";
            this.labNFTsRate.Click += new System.EventHandler(this.labNFTsRate_Click);
            // 
            // seeDetailbtn
            // 
            this.seeDetailbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.seeDetailbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeDetailbtn.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.seeDetailbtn.ForeColor = System.Drawing.Color.White;
            this.seeDetailbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.seeDetailbtn.IconColor = System.Drawing.Color.Black;
            this.seeDetailbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.seeDetailbtn.Location = new System.Drawing.Point(215, 229);
            this.seeDetailbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seeDetailbtn.Name = "seeDetailbtn";
            this.seeDetailbtn.Size = new System.Drawing.Size(88, 37);
            this.seeDetailbtn.TabIndex = 46;
            this.seeDetailbtn.Text = "Details";
            this.seeDetailbtn.UseVisualStyleBackColor = false;
            this.seeDetailbtn.Click += new System.EventHandler(this.seeDetailbtn_Click);
            // 
            // pictureBoxNFTs
            // 
            this.pictureBoxNFTs.Image = global::AfroNFTs.Properties.Resources.gettyimages_165604915_170667a;
            this.pictureBoxNFTs.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNFTs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxNFTs.MaximumSize = new System.Drawing.Size(307, 266);
            this.pictureBoxNFTs.MinimumSize = new System.Drawing.Size(307, 266);
            this.pictureBoxNFTs.Name = "pictureBoxNFTs";
            this.pictureBoxNFTs.Size = new System.Drawing.Size(307, 266);
            this.pictureBoxNFTs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxNFTs.TabIndex = 5;
            this.pictureBoxNFTs.TabStop = false;
            this.pictureBoxNFTs.Click += new System.EventHandler(this.pictureBoxNFTs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AfroNFTs.Properties.Resources.star;
            this.pictureBox1.Location = new System.Drawing.Point(9, 299);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.buyButton.ForeColor = System.Drawing.Color.White;
            this.buyButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buyButton.IconColor = System.Drawing.Color.Black;
            this.buyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buyButton.Location = new System.Drawing.Point(215, 285);
            this.buyButton.Margin = new System.Windows.Forms.Padding(4);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(88, 37);
            this.buyButton.TabIndex = 47;
            this.buyButton.Text = "Buy!";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // NFTs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.seeDetailbtn);
            this.Controls.Add(this.pictureBoxNFTs);
            this.Controls.Add(this.labNFTsRate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labNFTsName);
            this.Controls.Add(this.labPrice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(307, 308);
            this.Name = "NFTs";
            this.Size = new System.Drawing.Size(307, 330);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNFTs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labNFTsName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labNFTsRate;
        private System.Windows.Forms.PictureBox pictureBoxNFTs;
        private FontAwesome.Sharp.IconButton seeDetailbtn;
        private FontAwesome.Sharp.IconButton buyButton;
    }
}
