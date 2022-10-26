namespace AfroNFTs.View
{
    partial class Balance
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
            this.label1 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.ammountToRecharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance Left:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.balanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.balanceLabel.Location = new System.Drawing.Point(135, 83);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(56, 24);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "label2";
            // 
            // ammountToRecharge
            // 
            this.ammountToRecharge.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.ammountToRecharge.Location = new System.Drawing.Point(108, 135);
            this.ammountToRecharge.Margin = new System.Windows.Forms.Padding(2);
            this.ammountToRecharge.Name = "ammountToRecharge";
            this.ammountToRecharge.Size = new System.Drawing.Size(381, 24);
            this.ammountToRecharge.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ammount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(135, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = " Recharge Balance";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.iconButton1.ForeColor = System.Drawing.Color.Snow;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(77, 189);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(374, 30);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Recharge!";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ammountToRecharge);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Balance";
            this.Text = "Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox ammountToRecharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}