namespace AfroNFTs
{
    partial class mainPage
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
            this.Menupanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Siginupbtn = new System.Windows.Forms.Button();
            this.Logpanel = new System.Windows.Forms.Panel();
            this.Headerpan = new System.Windows.Forms.Panel();
            this.CurrntPage = new System.Windows.Forms.Label();
            this.dashbord_pan = new System.Windows.Forms.Panel();
            this.iconPic_current = new FontAwesome.Sharp.IconPictureBox();
            this.accountBtn = new FontAwesome.Sharp.IconButton();
            this.aboutbtn = new FontAwesome.Sharp.IconButton();
            this.selltbtn = new FontAwesome.Sharp.IconButton();
            this.Buybtn = new FontAwesome.Sharp.IconButton();
            this.postbtn = new FontAwesome.Sharp.IconButton();
            this.Dashboardbtn = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.Menupanel.SuspendLayout();
            this.Logpanel.SuspendLayout();
            this.Headerpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_current)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(11)))), ((int)(((byte)(45)))));
            this.Menupanel.Controls.Add(this.accountBtn);
            this.Menupanel.Controls.Add(this.button1);
            this.Menupanel.Controls.Add(this.Siginupbtn);
            this.Menupanel.Controls.Add(this.aboutbtn);
            this.Menupanel.Controls.Add(this.selltbtn);
            this.Menupanel.Controls.Add(this.Buybtn);
            this.Menupanel.Controls.Add(this.postbtn);
            this.Menupanel.Controls.Add(this.Dashboardbtn);
            this.Menupanel.Controls.Add(this.Logpanel);
            this.Menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanel.Location = new System.Drawing.Point(0, 0);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(151, 577);
            this.Menupanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(77, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Siginupbtn
            // 
            this.Siginupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Siginupbtn.CausesValidation = false;
            this.Siginupbtn.FlatAppearance.BorderSize = 0;
            this.Siginupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Siginupbtn.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siginupbtn.ForeColor = System.Drawing.Color.Snow;
            this.Siginupbtn.Location = new System.Drawing.Point(0, 501);
            this.Siginupbtn.Name = "Siginupbtn";
            this.Siginupbtn.Size = new System.Drawing.Size(71, 34);
            this.Siginupbtn.TabIndex = 6;
            this.Siginupbtn.Text = "Sigin up";
            this.Siginupbtn.UseVisualStyleBackColor = false;
            // 
            // Logpanel
            // 
            this.Logpanel.Controls.Add(this.btnHome);
            this.Logpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logpanel.Location = new System.Drawing.Point(0, 0);
            this.Logpanel.Name = "Logpanel";
            this.Logpanel.Size = new System.Drawing.Size(151, 88);
            this.Logpanel.TabIndex = 0;
            // 
            // Headerpan
            // 
            this.Headerpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(11)))), ((int)(((byte)(45)))));
            this.Headerpan.Controls.Add(this.CurrntPage);
            this.Headerpan.Controls.Add(this.iconPic_current);
            this.Headerpan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpan.Location = new System.Drawing.Point(151, 0);
            this.Headerpan.Name = "Headerpan";
            this.Headerpan.Size = new System.Drawing.Size(779, 48);
            this.Headerpan.TabIndex = 1;
            this.Headerpan.Paint += new System.Windows.Forms.PaintEventHandler(this.Headerpan_Paint);
            // 
            // CurrntPage
            // 
            this.CurrntPage.AutoSize = true;
            this.CurrntPage.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.CurrntPage.ForeColor = System.Drawing.Color.IndianRed;
            this.CurrntPage.Location = new System.Drawing.Point(54, 26);
            this.CurrntPage.Name = "CurrntPage";
            this.CurrntPage.Size = new System.Drawing.Size(50, 17);
            this.CurrntPage.TabIndex = 1;
            this.CurrntPage.Text = "Home";
            // 
            // dashbord_pan
            // 
            this.dashbord_pan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashbord_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashbord_pan.Location = new System.Drawing.Point(151, 48);
            this.dashbord_pan.Name = "dashbord_pan";
            this.dashbord_pan.Size = new System.Drawing.Size(779, 529);
            this.dashbord_pan.TabIndex = 2;
            this.dashbord_pan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dashbord_pan_MouseDown);
            // 
            // iconPic_current
            // 
            this.iconPic_current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(4)))), ((int)(((byte)(47)))));
            this.iconPic_current.ForeColor = System.Drawing.Color.IndianRed;
            this.iconPic_current.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPic_current.IconColor = System.Drawing.Color.IndianRed;
            this.iconPic_current.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic_current.Location = new System.Drawing.Point(6, 12);
            this.iconPic_current.Name = "iconPic_current";
            this.iconPic_current.Size = new System.Drawing.Size(32, 32);
            this.iconPic_current.TabIndex = 0;
            this.iconPic_current.TabStop = false;
            // 
            // accountBtn
            // 
            this.accountBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Rockwell", 12F);
            this.accountBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.accountBtn.IconChar = FontAwesome.Sharp.IconChar.A;
            this.accountBtn.IconColor = System.Drawing.Color.IndianRed;
            this.accountBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountBtn.IconSize = 32;
            this.accountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountBtn.Location = new System.Drawing.Point(0, 314);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.accountBtn.Size = new System.Drawing.Size(151, 48);
            this.accountBtn.TabIndex = 8;
            this.accountBtn.Text = "Account";
            this.accountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutbtn.FlatAppearance.BorderSize = 0;
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.Font = new System.Drawing.Font("Rockwell", 12F);
            this.aboutbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.aboutbtn.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            this.aboutbtn.IconColor = System.Drawing.Color.IndianRed;
            this.aboutbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aboutbtn.IconSize = 32;
            this.aboutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutbtn.Location = new System.Drawing.Point(0, 264);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.aboutbtn.Size = new System.Drawing.Size(151, 50);
            this.aboutbtn.TabIndex = 5;
            this.aboutbtn.Text = "About";
            this.aboutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutbtn.UseVisualStyleBackColor = true;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // selltbtn
            // 
            this.selltbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.selltbtn.FlatAppearance.BorderSize = 0;
            this.selltbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selltbtn.Font = new System.Drawing.Font("Rockwell", 12F);
            this.selltbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.selltbtn.IconChar = FontAwesome.Sharp.IconChar.A;
            this.selltbtn.IconColor = System.Drawing.Color.IndianRed;
            this.selltbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.selltbtn.IconSize = 32;
            this.selltbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selltbtn.Location = new System.Drawing.Point(0, 216);
            this.selltbtn.Name = "selltbtn";
            this.selltbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.selltbtn.Size = new System.Drawing.Size(151, 48);
            this.selltbtn.TabIndex = 4;
            this.selltbtn.Text = "Sell";
            this.selltbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selltbtn.UseVisualStyleBackColor = true;
            this.selltbtn.Click += new System.EventHandler(this.selltbtn_Click);
            // 
            // Buybtn
            // 
            this.Buybtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Buybtn.FlatAppearance.BorderSize = 0;
            this.Buybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buybtn.Font = new System.Drawing.Font("Rockwell", 12F);
            this.Buybtn.ForeColor = System.Drawing.Color.IndianRed;
            this.Buybtn.IconChar = FontAwesome.Sharp.IconChar.BuyNLarge;
            this.Buybtn.IconColor = System.Drawing.Color.IndianRed;
            this.Buybtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Buybtn.IconSize = 32;
            this.Buybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buybtn.Location = new System.Drawing.Point(0, 174);
            this.Buybtn.Name = "Buybtn";
            this.Buybtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Buybtn.Size = new System.Drawing.Size(151, 42);
            this.Buybtn.TabIndex = 3;
            this.Buybtn.Text = "Buy";
            this.Buybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buybtn.UseVisualStyleBackColor = true;
            this.Buybtn.Click += new System.EventHandler(this.Buybtn_Click);
            // 
            // postbtn
            // 
            this.postbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.postbtn.FlatAppearance.BorderSize = 0;
            this.postbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postbtn.Font = new System.Drawing.Font("Rockwell", 12F);
            this.postbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.postbtn.IconChar = FontAwesome.Sharp.IconChar.P;
            this.postbtn.IconColor = System.Drawing.Color.IndianRed;
            this.postbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.postbtn.IconSize = 32;
            this.postbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postbtn.Location = new System.Drawing.Point(0, 131);
            this.postbtn.Name = "postbtn";
            this.postbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.postbtn.Size = new System.Drawing.Size(151, 43);
            this.postbtn.TabIndex = 2;
            this.postbtn.Text = "Post";
            this.postbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.postbtn.UseVisualStyleBackColor = true;
            this.postbtn.Click += new System.EventHandler(this.postbtn_Click);
            // 
            // Dashboardbtn
            // 
            this.Dashboardbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboardbtn.FlatAppearance.BorderSize = 0;
            this.Dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboardbtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.Dashboardbtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Dashboardbtn.IconColor = System.Drawing.Color.IndianRed;
            this.Dashboardbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboardbtn.IconSize = 32;
            this.Dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboardbtn.Location = new System.Drawing.Point(0, 88);
            this.Dashboardbtn.Name = "Dashboardbtn";
            this.Dashboardbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Dashboardbtn.Size = new System.Drawing.Size(151, 43);
            this.Dashboardbtn.TabIndex = 1;
            this.Dashboardbtn.Text = "Dashboard";
            this.Dashboardbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboardbtn.UseVisualStyleBackColor = true;
            this.Dashboardbtn.UseWaitCursor = true;
            this.Dashboardbtn.Click += new System.EventHandler(this.Dashboardbtn_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::AfroNFTs.Properties.Resources.th__2_;
            this.btnHome.Location = new System.Drawing.Point(3, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 88);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 577);
            this.Controls.Add(this.dashbord_pan);
            this.Controls.Add(this.Headerpan);
            this.Controls.Add(this.Menupanel);
            this.MaximumSize = new System.Drawing.Size(946, 616);
            this.Name = "mainPage";
            this.Text = "AfroNFTs";
            this.Menupanel.ResumeLayout(false);
            this.Logpanel.ResumeLayout(false);
            this.Headerpan.ResumeLayout(false);
            this.Headerpan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic_current)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menupanel;
        private FontAwesome.Sharp.IconButton Dashboardbtn;
        private System.Windows.Forms.Panel Logpanel;
        private FontAwesome.Sharp.IconButton aboutbtn;
        private FontAwesome.Sharp.IconButton selltbtn;
        private FontAwesome.Sharp.IconButton Buybtn;
        private FontAwesome.Sharp.IconButton postbtn;
        private System.Windows.Forms.Panel Headerpan;
        private System.Windows.Forms.Label CurrntPage;
        private FontAwesome.Sharp.IconPictureBox iconPic_current;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel dashbord_pan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Siginupbtn;
        private FontAwesome.Sharp.IconButton accountBtn;
    }
}