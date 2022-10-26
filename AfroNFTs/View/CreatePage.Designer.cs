namespace AfroNFTs.View
{
    partial class CreatePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePage));
            this.Titeltxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descrTxt = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.pageImagepic = new System.Windows.Forms.PictureBox();
            this.submitteBtn1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageImagepic)).BeginInit();
            this.SuspendLayout();
            // 
            // Titeltxt
            // 
            this.Titeltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Titeltxt.Location = new System.Drawing.Point(138, 136);
            this.Titeltxt.Name = "Titeltxt";
            this.Titeltxt.Size = new System.Drawing.Size(159, 20);
            this.Titeltxt.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(27, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Titel :";
            // 
            // descrTxt
            // 
            this.descrTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descrTxt.Location = new System.Drawing.Point(22, 209);
            this.descrTxt.MaximumSize = new System.Drawing.Size(550, 215);
            this.descrTxt.MinimumSize = new System.Drawing.Size(250, 215);
            this.descrTxt.Name = "descrTxt";
            this.descrTxt.Size = new System.Drawing.Size(312, 215);
            this.descrTxt.TabIndex = 38;
            this.descrTxt.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.descriptionLabel.Location = new System.Drawing.Point(27, 169);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(100, 24);
            this.descriptionLabel.MinimumSize = new System.Drawing.Size(30, 24);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 24);
            this.descriptionLabel.TabIndex = 37;
            this.descriptionLabel.Text = "Description";
            // 
            // pageImagepic
            // 
            this.pageImagepic.Image = global::AfroNFTs.Properties.Resources.gettyimages_165604915_170667a;
            this.pageImagepic.Location = new System.Drawing.Point(492, 70);
            this.pageImagepic.Name = "pageImagepic";
            this.pageImagepic.Size = new System.Drawing.Size(220, 182);
            this.pageImagepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pageImagepic.TabIndex = 46;
            this.pageImagepic.TabStop = false;
            this.pageImagepic.Click += new System.EventHandler(this.pageImagepic_Click);
            // 
            // submitteBtn1
            // 
            this.submitteBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.submitteBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitteBtn1.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.submitteBtn1.ForeColor = System.Drawing.Color.White;
            this.submitteBtn1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submitteBtn1.IconColor = System.Drawing.Color.Black;
            this.submitteBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submitteBtn1.Location = new System.Drawing.Point(560, 277);
            this.submitteBtn1.Name = "submitteBtn1";
            this.submitteBtn1.Size = new System.Drawing.Size(110, 34);
            this.submitteBtn1.TabIndex = 45;
            this.submitteBtn1.Text = "Submit";
            this.submitteBtn1.UseVisualStyleBackColor = false;
            this.submitteBtn1.Click += new System.EventHandler(this.submitteBtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(465, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Clike The Image To Add Page Image";
            // 
            // CreatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(6)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(765, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pageImagepic);
            this.Controls.Add(this.submitteBtn1);
            this.Controls.Add(this.descrTxt);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.Titeltxt);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreatePage";
            this.Text = "CreatePage";
            ((System.ComponentModel.ISupportInitialize)(this.pageImagepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Titeltxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descrTxt;
        private System.Windows.Forms.Label descriptionLabel;
        private FontAwesome.Sharp.IconButton submitteBtn1;
        private System.Windows.Forms.PictureBox pageImagepic;
        private System.Windows.Forms.Label label1;
    }
}