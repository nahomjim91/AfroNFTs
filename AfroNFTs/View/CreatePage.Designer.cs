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
            this.Titeltxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descrTxt = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.submitteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titeltxt
            // 
            this.Titeltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Titeltxt.Location = new System.Drawing.Point(184, 167);
            this.Titeltxt.Margin = new System.Windows.Forms.Padding(4);
            this.Titeltxt.Name = "Titeltxt";
            this.Titeltxt.Size = new System.Drawing.Size(211, 22);
            this.Titeltxt.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(36, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Titel :";
            // 
            // descrTxt
            // 
            this.descrTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descrTxt.Location = new System.Drawing.Point(29, 257);
            this.descrTxt.Margin = new System.Windows.Forms.Padding(4);
            this.descrTxt.MaximumSize = new System.Drawing.Size(732, 264);
            this.descrTxt.MinimumSize = new System.Drawing.Size(332, 264);
            this.descrTxt.Name = "descrTxt";
            this.descrTxt.Size = new System.Drawing.Size(414, 264);
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
            this.descriptionLabel.Location = new System.Drawing.Point(36, 208);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(133, 30);
            this.descriptionLabel.MinimumSize = new System.Drawing.Size(40, 30);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(128, 30);
            this.descriptionLabel.TabIndex = 37;
            this.descriptionLabel.Text = "Description";
            // 
            // submitteBtn
            // 
            this.submitteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.submitteBtn.CausesValidation = false;
            this.submitteBtn.FlatAppearance.BorderSize = 0;
            this.submitteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitteBtn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitteBtn.ForeColor = System.Drawing.Color.Snow;
            this.submitteBtn.Location = new System.Drawing.Point(529, 421);
            this.submitteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitteBtn.Name = "submitteBtn";
            this.submitteBtn.Size = new System.Drawing.Size(146, 40);
            this.submitteBtn.TabIndex = 39;
            this.submitteBtn.Text = "Submitte";
            this.submitteBtn.UseVisualStyleBackColor = false;
            this.submitteBtn.Click += new System.EventHandler(this.submitteBtn_Click);
            // 
            // CreatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1020, 545);
            this.Controls.Add(this.submitteBtn);
            this.Controls.Add(this.descrTxt);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.Titeltxt);
            this.Controls.Add(this.label4);
            this.Name = "CreatePage";
            this.Text = "CreatePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Titeltxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descrTxt;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button submitteBtn;
    }
}