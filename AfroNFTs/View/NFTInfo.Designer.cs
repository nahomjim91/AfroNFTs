namespace AfroNFTs.View
{
    partial class NFTInfo
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
            this.NFTPic = new System.Windows.Forms.PictureBox();
            this.Name = new System.Windows.Forms.Label();
            this.descritpion = new System.Windows.Forms.Label();
            this.likeButton = new FontAwesome.Sharp.IconButton();
            this.dislikeButton = new FontAwesome.Sharp.IconButton();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NFTPic)).BeginInit();
            this.SuspendLayout();
            // 
            // NFTPic
            // 
            this.NFTPic.Image = global::AfroNFTs.Properties.Resources.gettyimages_165604915_170667a;
            this.NFTPic.Location = new System.Drawing.Point(-32, 0);
            this.NFTPic.Margin = new System.Windows.Forms.Padding(4);
            this.NFTPic.MaximumSize = new System.Drawing.Size(307, 266);
            this.NFTPic.MinimumSize = new System.Drawing.Size(307, 266);
            this.NFTPic.Name = "NFTPic";
            this.NFTPic.Size = new System.Drawing.Size(307, 266);
            this.NFTPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NFTPic.TabIndex = 6;
            this.NFTPic.TabStop = false;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(18, 274);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 7;
            this.Name.Text = "Name";
            // 
            // descritpion
            // 
            this.descritpion.AutoSize = true;
            this.descritpion.Location = new System.Drawing.Point(18, 309);
            this.descritpion.Name = "descritpion";
            this.descritpion.Size = new System.Drawing.Size(43, 16);
            this.descritpion.TabIndex = 8;
            this.descritpion.Text = "Descr";
            // 
            // likeButton
            // 
            this.likeButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.likeButton.IconColor = System.Drawing.Color.Black;
            this.likeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.likeButton.Location = new System.Drawing.Point(21, 363);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(75, 23);
            this.likeButton.TabIndex = 9;
            this.likeButton.Text = "Like";
            this.likeButton.UseVisualStyleBackColor = true;
            // 
            // dislikeButton
            // 
            this.dislikeButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.dislikeButton.IconColor = System.Drawing.Color.Black;
            this.dislikeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dislikeButton.Location = new System.Drawing.Point(150, 363);
            this.dislikeButton.Name = "dislikeButton";
            this.dislikeButton.Size = new System.Drawing.Size(75, 23);
            this.dislikeButton.TabIndex = 10;
            this.dislikeButton.Text = "DisLike";
            this.dislikeButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(150, 309);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 16);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price";
            // 
            // NFTInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dislikeButton);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.descritpion);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.NFTPic);
            this.Name.Text = "NFTInfo";
            this.Size = new System.Drawing.Size(238, 458);
            ((System.ComponentModel.ISupportInitialize)(this.NFTPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NFTPic;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label descritpion;
        private FontAwesome.Sharp.IconButton likeButton;
        private FontAwesome.Sharp.IconButton dislikeButton;
        private System.Windows.Forms.Label priceLabel;
    }
}
