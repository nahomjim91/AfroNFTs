namespace AfroNFTs.View
{
    partial class MyPages
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
            this.FL = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FL
            // 
            this.FL.AutoScroll = true;
            this.FL.Location = new System.Drawing.Point(11, 11);
            this.FL.Margin = new System.Windows.Forms.Padding(2);
            this.FL.Name = "FL";
            this.FL.Size = new System.Drawing.Size(756, 497);
            this.FL.TabIndex = 0;
            // 
            // MyPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(10)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(778, 519);
            this.Controls.Add(this.FL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyPages";
            this.Text = "MyPages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FL;
    }
}