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
            this.pictureBoxNFTs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNFTs)).BeginInit();
            this.SuspendLayout();
            // 
            // labNFTsName
            // 
            this.labNFTsName.AutoSize = true;
            this.labNFTsName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNFTsName.ForeColor = System.Drawing.Color.Coral;
            this.labNFTsName.Location = new System.Drawing.Point(75, 357);
            this.labNFTsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNFTsName.MaximumSize = new System.Drawing.Size(200, 0);
            this.labNFTsName.Name = "labNFTsName";
            this.labNFTsName.Size = new System.Drawing.Size(71, 25);
            this.labNFTsName.TabIndex = 3;
            this.labNFTsName.Text = "label1";
            // 
            // pictureBoxNFTs
            // 
            this.pictureBoxNFTs.Image = global::AfroNFTs.Properties.Resources.gettyimages_165604915_170667a;
            this.pictureBoxNFTs.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNFTs.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxNFTs.Name = "pictureBoxNFTs";
            this.pictureBoxNFTs.Size = new System.Drawing.Size(283, 353);
            this.pictureBoxNFTs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxNFTs.TabIndex = 6;
            this.pictureBoxNFTs.TabStop = false;
            // 
            // NFTPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.pictureBoxNFTs);
            this.Controls.Add(this.labNFTsName);
            this.MaximumSize = new System.Drawing.Size(283, 398);
            this.MinimumSize = new System.Drawing.Size(283, 398);
            this.Name = "NFTPage";
            this.Size = new System.Drawing.Size(283, 398);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNFTs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNFTsName;
        private System.Windows.Forms.PictureBox pictureBoxNFTs;
    }
}
