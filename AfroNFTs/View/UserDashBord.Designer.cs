namespace AfroNFTs
{
    partial class UserDashBord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashBord));
            this.txtSerachNFTS = new System.Windows.Forms.TextBox();
            this.labLinkWorth = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtSerachNFTS
            // 
            this.txtSerachNFTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerachNFTS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSerachNFTS.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerachNFTS.Location = new System.Drawing.Point(92, 23);
            this.txtSerachNFTS.MaximumSize = new System.Drawing.Size(192, 26);
            this.txtSerachNFTS.MinimumSize = new System.Drawing.Size(91, 26);
            this.txtSerachNFTS.Name = "txtSerachNFTS";
            this.txtSerachNFTS.Size = new System.Drawing.Size(192, 26);
            this.txtSerachNFTS.TabIndex = 6;
            // 
            // labLinkWorth
            // 
            this.labLinkWorth.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.labLinkWorth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labLinkWorth.AutoSize = true;
            this.labLinkWorth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labLinkWorth.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F);
            this.labLinkWorth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.labLinkWorth.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labLinkWorth.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.labLinkWorth.Location = new System.Drawing.Point(607, 23);
            this.labLinkWorth.MaximumSize = new System.Drawing.Size(125, 22);
            this.labLinkWorth.MinimumSize = new System.Drawing.Size(125, 22);
            this.labLinkWorth.Name = "labLinkWorth";
            this.labLinkWorth.Size = new System.Drawing.Size(125, 22);
            this.labLinkWorth.TabIndex = 21;
            this.labLinkWorth.TabStop = true;
            this.labLinkWorth.Text = "amount money";
            this.labLinkWorth.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 67);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(750, 500);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(236, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 440);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.iconButton1.ForeColor = System.Drawing.Color.RosyBrown;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.Location = new System.Drawing.Point(290, 23);
            this.iconButton1.MaximumSize = new System.Drawing.Size(43, 26);
            this.iconButton1.MinimumSize = new System.Drawing.Size(43, 26);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 26);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // UserDashBord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(778, 519);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labLinkWorth);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtSerachNFTS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDashBord";
            this.Text = "UserDashBord";
            this.Load += new System.EventHandler(this.UserDashBord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerachNFTS;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.LinkLabel labLinkWorth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}