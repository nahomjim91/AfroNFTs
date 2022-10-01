namespace AfroNFTs.View
{
    partial class AddNfts
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
            this.components = new System.ComponentModel.Container();
            this.NFTSpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameNFTS = new System.Windows.Forms.TextBox();
            this.txtPriceNFTs = new System.Windows.Forms.TextBox();
            this.txtGroupNFTs = new System.Windows.Forms.TextBox();
            this.txtDescriptionNFTs = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Siginupbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NFTSpic)).BeginInit();
            this.SuspendLayout();
            // 
            // NFTSpic
            // 
            this.NFTSpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NFTSpic.Image = global::AfroNFTs.Properties.Resources.icons8_insert_raster_image_481;
            this.NFTSpic.Location = new System.Drawing.Point(60, 23);
            this.NFTSpic.Name = "NFTSpic";
            this.NFTSpic.Size = new System.Drawing.Size(233, 229);
            this.NFTSpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NFTSpic.TabIndex = 0;
            this.NFTSpic.TabStop = false;
            this.NFTSpic.Click += new System.EventHandler(this.NFTSpic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name NFTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(12, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(12, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(466, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // txtNameNFTS
            // 
            this.txtNameNFTS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNameNFTS.Font = new System.Drawing.Font("Bookman Old Style", 15.75F);
            this.txtNameNFTS.Location = new System.Drawing.Point(147, 290);
            this.txtNameNFTS.Name = "txtNameNFTS";
            this.txtNameNFTS.Size = new System.Drawing.Size(192, 32);
            this.txtNameNFTS.TabIndex = 5;
            // 
            // txtPriceNFTs
            // 
            this.txtPriceNFTs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPriceNFTs.Font = new System.Drawing.Font("Bookman Old Style", 15.75F);
            this.txtPriceNFTs.Location = new System.Drawing.Point(147, 343);
            this.txtPriceNFTs.Name = "txtPriceNFTs";
            this.txtPriceNFTs.Size = new System.Drawing.Size(192, 32);
            this.txtPriceNFTs.TabIndex = 6;
            // 
            // txtGroupNFTs
            // 
            this.txtGroupNFTs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGroupNFTs.Font = new System.Drawing.Font("Bookman Old Style", 15.75F);
            this.txtGroupNFTs.Location = new System.Drawing.Point(147, 401);
            this.txtGroupNFTs.Name = "txtGroupNFTs";
            this.txtGroupNFTs.Size = new System.Drawing.Size(192, 32);
            this.txtGroupNFTs.TabIndex = 7;
            // 
            // txtDescriptionNFTs
            // 
            this.txtDescriptionNFTs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionNFTs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescriptionNFTs.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionNFTs.Location = new System.Drawing.Point(422, 312);
            this.txtDescriptionNFTs.MaximumSize = new System.Drawing.Size(518, 111);
            this.txtDescriptionNFTs.Multiline = true;
            this.txtDescriptionNFTs.Name = "txtDescriptionNFTs";
            this.txtDescriptionNFTs.Size = new System.Drawing.Size(213, 111);
            this.txtDescriptionNFTs.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Siginupbtn
            // 
            this.Siginupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Siginupbtn.CausesValidation = false;
            this.Siginupbtn.FlatAppearance.BorderSize = 0;
            this.Siginupbtn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siginupbtn.ForeColor = System.Drawing.Color.Snow;
            this.Siginupbtn.Location = new System.Drawing.Point(367, 141);
            this.Siginupbtn.Name = "Siginupbtn";
            this.Siginupbtn.Size = new System.Drawing.Size(126, 37);
            this.Siginupbtn.TabIndex = 18;
            this.Siginupbtn.Text = "Submitte";
            this.Siginupbtn.UseVisualStyleBackColor = false;
            // 
            // AddNfts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(647, 451);
            this.Controls.Add(this.Siginupbtn);
            this.Controls.Add(this.txtDescriptionNFTs);
            this.Controls.Add(this.txtGroupNFTs);
            this.Controls.Add(this.txtPriceNFTs);
            this.Controls.Add(this.txtNameNFTS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NFTSpic);
            this.Name = "AddNfts";
            this.Text = "AddNfts";
            ((System.ComponentModel.ISupportInitialize)(this.NFTSpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NFTSpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameNFTS;
        private System.Windows.Forms.TextBox txtPriceNFTs;
        private System.Windows.Forms.TextBox txtGroupNFTs;
        private System.Windows.Forms.TextBox txtDescriptionNFTs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Siginupbtn;
    }
}