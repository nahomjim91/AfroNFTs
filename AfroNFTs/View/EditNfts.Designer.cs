namespace AfroNFTs.View
{
    partial class EditNfts
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
            this.txtPriceNFTs = new System.Windows.Forms.TextBox();
            this.txtNameNFTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBtn1 = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPriceNFTs
            // 
            this.txtPriceNFTs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPriceNFTs.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.txtPriceNFTs.Location = new System.Drawing.Point(163, 108);
            this.txtPriceNFTs.Name = "txtPriceNFTs";
            this.txtPriceNFTs.Size = new System.Drawing.Size(178, 25);
            this.txtPriceNFTs.TabIndex = 10;
            // 
            // txtNameNFTS
            // 
            this.txtNameNFTS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNameNFTS.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.txtNameNFTS.Location = new System.Drawing.Point(163, 68);
            this.txtNameNFTS.Name = "txtNameNFTS";
            this.txtNameNFTS.Size = new System.Drawing.Size(178, 26);
            this.txtNameNFTS.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(86, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name NFTS";
            // 
            // EditBtn1
            // 
            this.EditBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.EditBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn1.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.EditBtn1.ForeColor = System.Drawing.Color.White;
            this.EditBtn1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EditBtn1.IconColor = System.Drawing.Color.Black;
            this.EditBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditBtn1.Location = new System.Drawing.Point(163, 152);
            this.EditBtn1.Name = "EditBtn1";
            this.EditBtn1.Size = new System.Drawing.Size(110, 34);
            this.EditBtn1.TabIndex = 46;
            this.EditBtn1.Text = "Done";
            this.EditBtn1.UseVisualStyleBackColor = false;
            this.EditBtn1.Click += new System.EventHandler(this.EditBtn1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditNfts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(403, 192);
            this.Controls.Add(this.EditBtn1);
            this.Controls.Add(this.txtPriceNFTs);
            this.Controls.Add(this.txtNameNFTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditNfts";
            this.Text = "EditNfts";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPriceNFTs;
        private System.Windows.Forms.TextBox txtNameNFTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton EditBtn1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}