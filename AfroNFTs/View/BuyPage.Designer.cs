namespace AfroNFTs.View
{
    partial class BuyPage
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
        /// 
        /// 
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CBGroup = new System.Windows.Forms.ComboBox();
            this.CBRate = new System.Windows.Forms.ComboBox();
            this.CBPrice = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtSerachNFTS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 279);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ape",
            "car",
            "dog"});
            this.comboBox1.Location = new System.Drawing.Point(125, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // CBGroup
            // 
            this.CBGroup.FormattingEnabled = true;
            this.CBGroup.Items.AddRange(new object[] {
            "Ape",
            "car",
            "dog"});
            this.CBGroup.Location = new System.Drawing.Point(12, 132);
            this.CBGroup.Name = "CBGroup";
            this.CBGroup.Size = new System.Drawing.Size(107, 21);
            this.CBGroup.TabIndex = 5;
            // 
            // CBRate
            // 
            this.CBRate.FormattingEnabled = true;
            this.CBRate.Items.AddRange(new object[] {
            "Ape",
            "car",
            "dog"});
            this.CBRate.Location = new System.Drawing.Point(578, 132);
            this.CBRate.Name = "CBRate";
            this.CBRate.Size = new System.Drawing.Size(107, 21);
            this.CBRate.TabIndex = 6;
            // 
            // CBPrice
            // 
            this.CBPrice.FormattingEnabled = true;
            this.CBPrice.Items.AddRange(new object[] {
            "Ape",
            "car",
            "dog"});
            this.CBPrice.Location = new System.Drawing.Point(691, 132);
            this.CBPrice.Name = "CBPrice";
            this.CBPrice.Size = new System.Drawing.Size(107, 21);
            this.CBPrice.TabIndex = 7;
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
            this.iconButton1.Location = new System.Drawing.Point(210, 62);
            this.iconButton1.MaximumSize = new System.Drawing.Size(43, 26);
            this.iconButton1.MinimumSize = new System.Drawing.Size(43, 26);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 26);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtSerachNFTS
            // 
            this.txtSerachNFTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerachNFTS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSerachNFTS.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerachNFTS.Location = new System.Drawing.Point(12, 62);
            this.txtSerachNFTS.MaximumSize = new System.Drawing.Size(192, 26);
            this.txtSerachNFTS.MinimumSize = new System.Drawing.Size(91, 26);
            this.txtSerachNFTS.Name = "txtSerachNFTS";
            this.txtSerachNFTS.Size = new System.Drawing.Size(192, 26);
            this.txtSerachNFTS.TabIndex = 21;
            // 
            // BuyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtSerachNFTS);
            this.Controls.Add(this.CBPrice);
            this.Controls.Add(this.CBRate);
            this.Controls.Add(this.CBGroup);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BuyPage";
            this.Text = "BuyPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CBGroup;
        private System.Windows.Forms.ComboBox CBRate;
        private System.Windows.Forms.ComboBox CBPrice;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtSerachNFTS;
    }
}