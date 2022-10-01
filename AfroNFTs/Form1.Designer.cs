using System.Drawing;

namespace AfroNFTs
{
    partial class Form1
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
            this.FirstNamelab = new System.Windows.Forms.Label();
            this.LastNamelab = new System.Windows.Forms.Label();
            this.Emaillab = new System.Windows.Forms.Label();
            this.Pswordlab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Siginupbtn = new System.Windows.Forms.Button();
            this.Fnametxt = new System.Windows.Forms.TextBox();
            this.LNametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Pswordtxt = new System.Windows.Forms.TextBox();
            this.ConfirmPswordtxt = new System.Windows.Forms.TextBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // FirstNamelab
            // 
            this.FirstNamelab.AutoSize = true;
            this.FirstNamelab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.FirstNamelab.Location = new System.Drawing.Point(84, 123);
            this.FirstNamelab.Name = "FirstNamelab";
            this.FirstNamelab.Size = new System.Drawing.Size(105, 24);
            this.FirstNamelab.TabIndex = 0;
            this.FirstNamelab.Text = "Frist name :";
            // 
            // LastNamelab
            // 
            this.LastNamelab.AutoSize = true;
            this.LastNamelab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.LastNamelab.Location = new System.Drawing.Point(86, 147);
            this.LastNamelab.Name = "LastNamelab";
            this.LastNamelab.Size = new System.Drawing.Size(103, 24);
            this.LastNamelab.TabIndex = 1;
            this.LastNamelab.Text = "Last name :";
            // 
            // Emaillab
            // 
            this.Emaillab.AutoSize = true;
            this.Emaillab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.Emaillab.Location = new System.Drawing.Point(122, 175);
            this.Emaillab.Name = "Emaillab";
            this.Emaillab.Size = new System.Drawing.Size(67, 24);
            this.Emaillab.TabIndex = 2;
            this.Emaillab.Text = "Email :";
            // 
            // Pswordlab
            // 
            this.Pswordlab.AutoSize = true;
            this.Pswordlab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pswordlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.Pswordlab.Location = new System.Drawing.Point(95, 204);
            this.Pswordlab.Name = "Pswordlab";
            this.Pswordlab.Size = new System.Drawing.Size(94, 24);
            this.Pswordlab.TabIndex = 3;
            this.Pswordlab.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(24, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirm Password :";
            // 
            // Siginupbtn
            // 
            this.Siginupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Siginupbtn.CausesValidation = false;
            this.Siginupbtn.FlatAppearance.BorderSize = 0;
            this.Siginupbtn.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siginupbtn.ForeColor = System.Drawing.Color.Snow;
            this.Siginupbtn.Location = new System.Drawing.Point(49, 278);
            this.Siginupbtn.Name = "Siginupbtn";
            this.Siginupbtn.Size = new System.Drawing.Size(126, 37);
            this.Siginupbtn.TabIndex = 5;
            this.Siginupbtn.Text = "Sigin up";
            this.Siginupbtn.UseVisualStyleBackColor = false;
            // 
            // Fnametxt
            // 
            this.Fnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Fnametxt.Location = new System.Drawing.Point(195, 127);
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.Size = new System.Drawing.Size(159, 20);
            this.Fnametxt.TabIndex = 6;
            // 
            // LNametxt
            // 
            this.LNametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.LNametxt.Location = new System.Drawing.Point(195, 153);
            this.LNametxt.Name = "LNametxt";
            this.LNametxt.Size = new System.Drawing.Size(159, 20);
            this.LNametxt.TabIndex = 7;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Emailtxt.Location = new System.Drawing.Point(195, 179);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(159, 20);
            this.Emailtxt.TabIndex = 8;
            // 
            // Pswordtxt
            // 
            this.Pswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Pswordtxt.Location = new System.Drawing.Point(195, 205);
            this.Pswordtxt.Name = "Pswordtxt";
            this.Pswordtxt.Size = new System.Drawing.Size(159, 20);
            this.Pswordtxt.TabIndex = 9;
            // 
            // ConfirmPswordtxt
            // 
            this.ConfirmPswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.ConfirmPswordtxt.Location = new System.Drawing.Point(195, 232);
            this.ConfirmPswordtxt.Name = "ConfirmPswordtxt";
            this.ConfirmPswordtxt.Size = new System.Drawing.Size(159, 20);
            this.ConfirmPswordtxt.TabIndex = 10;
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Clearbtn.CausesValidation = false;
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.Snow;
            this.Clearbtn.Location = new System.Drawing.Point(288, 278);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(126, 37);
            this.Clearbtn.TabIndex = 11;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(67, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alrady have account ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(205, 450);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 16);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sigin in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(4)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(454, 526);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.ConfirmPswordtxt);
            this.Controls.Add(this.Pswordtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.LNametxt);
            this.Controls.Add(this.Fnametxt);
            this.Controls.Add(this.Siginupbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pswordlab);
            this.Controls.Add(this.Emaillab);
            this.Controls.Add(this.LastNamelab);
            this.Controls.Add(this.FirstNamelab);
            this.Name = "Form1";
            this.Text = "AfroNFTs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNamelab;
        private System.Windows.Forms.Label LastNamelab;
        private System.Windows.Forms.Label Emaillab;
        private System.Windows.Forms.Label Pswordlab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Siginupbtn;
        private System.Windows.Forms.TextBox Fnametxt;
        private System.Windows.Forms.TextBox LNametxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Pswordtxt;
        private System.Windows.Forms.TextBox ConfirmPswordtxt;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

