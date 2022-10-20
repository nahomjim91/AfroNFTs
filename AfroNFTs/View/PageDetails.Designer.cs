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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddNFTsbtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(516, 361);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.DeleteBtn.CausesValidation = false;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.Snow;
            this.DeleteBtn.Location = new System.Drawing.Point(523, 63);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(85, 32);
            this.DeleteBtn.TabIndex = 40;
            this.DeleteBtn.Text = "Delete Page";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // AddNFTsbtn1
            // 
            this.AddNFTsbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.AddNFTsbtn1.CausesValidation = false;
            this.AddNFTsbtn1.FlatAppearance.BorderSize = 0;
            this.AddNFTsbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNFTsbtn1.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.AddNFTsbtn1.ForeColor = System.Drawing.Color.Snow;
            this.AddNFTsbtn1.Location = new System.Drawing.Point(525, 167);
            this.AddNFTsbtn1.Name = "AddNFTsbtn1";
            this.AddNFTsbtn1.Size = new System.Drawing.Size(85, 32);
            this.AddNFTsbtn1.TabIndex = 41;
            this.AddNFTsbtn1.Text = "Add NFTs";
            this.AddNFTsbtn1.UseVisualStyleBackColor = false;
            this.AddNFTsbtn1.Click += new System.EventHandler(this.AddNFTsbtn1_Click);
            // 
            // PageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(620, 366);
            this.Controls.Add(this.AddNFTsbtn1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PageDetails";
            this.Text = "PageDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddNFTsbtn1;
    }
}