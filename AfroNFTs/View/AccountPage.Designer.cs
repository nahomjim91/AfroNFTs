namespace AfroNFTs.View
{
    partial class AccountPage
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
            this.Emaillab = new System.Windows.Forms.Label();
            this.LastNamelab = new System.Windows.Forms.Label();
            this.FirstNamelab = new System.Windows.Forms.Label();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NumOfNFTs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalWorth = new System.Windows.Forms.Label();
            this.profileImagepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileImagepic)).BeginInit();
            this.SuspendLayout();
            // 
            // Emaillab
            // 
            this.Emaillab.AutoSize = true;
            this.Emaillab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.Emaillab.Location = new System.Drawing.Point(32, 294);
            this.Emaillab.Name = "Emaillab";
            this.Emaillab.Size = new System.Drawing.Size(67, 24);
            this.Emaillab.TabIndex = 13;
            this.Emaillab.Text = "Email :";
            // 
            // LastNamelab
            // 
            this.LastNamelab.AutoSize = true;
            this.LastNamelab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.LastNamelab.Location = new System.Drawing.Point(32, 266);
            this.LastNamelab.Name = "LastNamelab";
            this.LastNamelab.Size = new System.Drawing.Size(103, 24);
            this.LastNamelab.TabIndex = 12;
            this.LastNamelab.Text = "Last name :";
            // 
            // FirstNamelab
            // 
            this.FirstNamelab.AutoSize = true;
            this.FirstNamelab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.FirstNamelab.Location = new System.Drawing.Point(30, 242);
            this.FirstNamelab.Name = "FirstNamelab";
            this.FirstNamelab.Size = new System.Drawing.Size(100, 24);
            this.FirstNamelab.TabIndex = 11;
            this.FirstNamelab.Text = "Frist name ";
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(98)))));
            this.editBtn.BackgroundImage = global::AfroNFTs.Properties.Resources.edit;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.editBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editBtn.IconColor = System.Drawing.Color.Black;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.Location = new System.Drawing.Point(693, 29);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(33, 31);
            this.editBtn.TabIndex = 15;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(389, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Number of NFTs own : ";
            // 
            // NumOfNFTs
            // 
            this.NumOfNFTs.AutoSize = true;
            this.NumOfNFTs.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfNFTs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.NumOfNFTs.Location = new System.Drawing.Point(594, 242);
            this.NumOfNFTs.Name = "NumOfNFTs";
            this.NumOfNFTs.Size = new System.Drawing.Size(49, 24);
            this.NumOfNFTs.TabIndex = 17;
            this.NumOfNFTs.Text = "num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(389, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Worth NFTs own : ";
            // 
            // TotalWorth
            // 
            this.TotalWorth.AutoSize = true;
            this.TotalWorth.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWorth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.TotalWorth.Location = new System.Drawing.Point(594, 268);
            this.TotalWorth.Name = "TotalWorth";
            this.TotalWorth.Size = new System.Drawing.Size(49, 24);
            this.TotalWorth.TabIndex = 19;
            this.TotalWorth.Text = "num";
            // 
            // profileImagepic
            // 
            this.profileImagepic.Image = global::AfroNFTs.Properties.Resources.gettyimages_165604915_170667a;
            this.profileImagepic.Location = new System.Drawing.Point(163, 12);
            this.profileImagepic.Name = "profileImagepic";
            this.profileImagepic.Size = new System.Drawing.Size(220, 182);
            this.profileImagepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profileImagepic.TabIndex = 20;
            this.profileImagepic.TabStop = false;
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(778, 519);
            this.Controls.Add(this.profileImagepic);
            this.Controls.Add(this.TotalWorth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumOfNFTs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.Emaillab);
            this.Controls.Add(this.LastNamelab);
            this.Controls.Add(this.FirstNamelab);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(794, 558);
            this.MinimumSize = new System.Drawing.Size(617, 390);
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            ((System.ComponentModel.ISupportInitialize)(this.profileImagepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Emaillab;
        private System.Windows.Forms.Label LastNamelab;
        private System.Windows.Forms.Label FirstNamelab;
        private FontAwesome.Sharp.IconButton editBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumOfNFTs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalWorth;
        private System.Windows.Forms.PictureBox profileImagepic;
    }
}