using System.Drawing;

namespace AfroNFTs
{
    partial class SiginUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiginUp));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.termsCheckBox = new System.Windows.Forms.CheckBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProviderSignUP = new System.Windows.Forms.ErrorProvider(this.components);
            this.showConfirm = new FontAwesome.Sharp.IconButton();
            this.showPassword = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSignUP)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNamelab
            // 
            this.FirstNamelab.AutoSize = true;
            this.FirstNamelab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.FirstNamelab.Location = new System.Drawing.Point(26, 162);
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
            this.LastNamelab.Location = new System.Drawing.Point(26, 185);
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
            this.Emaillab.Location = new System.Drawing.Point(26, 213);
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
            this.Pswordlab.Location = new System.Drawing.Point(26, 238);
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
            this.label1.Location = new System.Drawing.Point(23, 264);
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
            this.Siginupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Siginupbtn.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siginupbtn.ForeColor = System.Drawing.Color.Snow;
            this.Siginupbtn.Location = new System.Drawing.Point(27, 447);
            this.Siginupbtn.Name = "Siginupbtn";
            this.Siginupbtn.Size = new System.Drawing.Size(126, 37);
            this.Siginupbtn.TabIndex = 5;
            this.Siginupbtn.Text = "Sign Up";
            this.Siginupbtn.UseVisualStyleBackColor = false;
            this.Siginupbtn.Click += new System.EventHandler(this.Siginupbtn_Click);
            // 
            // Fnametxt
            // 
            this.Fnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Fnametxt.Location = new System.Drawing.Point(186, 168);
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.Size = new System.Drawing.Size(159, 20);
            this.Fnametxt.TabIndex = 6;
            // 
            // LNametxt
            // 
            this.LNametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.LNametxt.Location = new System.Drawing.Point(186, 191);
            this.LNametxt.Name = "LNametxt";
            this.LNametxt.Size = new System.Drawing.Size(159, 20);
            this.LNametxt.TabIndex = 7;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Emailtxt.Location = new System.Drawing.Point(186, 218);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(159, 20);
            this.Emailtxt.TabIndex = 8;
            // 
            // Pswordtxt
            // 
            this.Pswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Pswordtxt.Location = new System.Drawing.Point(186, 244);
            this.Pswordtxt.Name = "Pswordtxt";
            this.Pswordtxt.PasswordChar = '*';
            this.Pswordtxt.Size = new System.Drawing.Size(159, 20);
            this.Pswordtxt.TabIndex = 9;
            // 
            // ConfirmPswordtxt
            // 
            this.ConfirmPswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.ConfirmPswordtxt.Location = new System.Drawing.Point(186, 270);
            this.ConfirmPswordtxt.Name = "ConfirmPswordtxt";
            this.ConfirmPswordtxt.PasswordChar = '*';
            this.ConfirmPswordtxt.Size = new System.Drawing.Size(159, 20);
            this.ConfirmPswordtxt.TabIndex = 10;
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Clearbtn.CausesValidation = false;
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.Snow;
            this.Clearbtn.Location = new System.Drawing.Point(298, 447);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(126, 37);
            this.Clearbtn.TabIndex = 11;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.termsCheckBox);
            this.groupBox1.Controls.Add(this.adminCheckBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(27, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 92);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // termsCheckBox
            // 
            this.termsCheckBox.AutoSize = true;
            this.termsCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.termsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.termsCheckBox.Location = new System.Drawing.Point(11, 43);
            this.termsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.termsCheckBox.Name = "termsCheckBox";
            this.termsCheckBox.Size = new System.Drawing.Size(219, 21);
            this.termsCheckBox.TabIndex = 1;
            this.termsCheckBox.Text = "I accepts the terms and conditions";
            this.termsCheckBox.UseVisualStyleBackColor = true;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.adminCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.adminCheckBox.Location = new System.Drawing.Point(11, 18);
            this.adminCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(148, 21);
            this.adminCheckBox.TabIndex = 0;
            this.adminCheckBox.Text = "I want to be an admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProviderSignUP
            // 
            this.errorProviderSignUP.ContainerControl = this;
            // 
            // showConfirm
            // 
            this.showConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showConfirm.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showConfirm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(26)))), ((int)(((byte)(9)))));
            this.showConfirm.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.showConfirm.IconSize = 30;
            this.showConfirm.Location = new System.Drawing.Point(350, 271);
            this.showConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.showConfirm.Name = "showConfirm";
            this.showConfirm.Size = new System.Drawing.Size(31, 19);
            this.showConfirm.TabIndex = 29;
            this.showConfirm.UseVisualStyleBackColor = true;
            this.showConfirm.Click += new System.EventHandler(this.showConfirm_Click);
            // 
            // showPassword
            // 
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.showPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(26)))), ((int)(((byte)(9)))));
            this.showPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.showPassword.IconSize = 30;
            this.showPassword.Location = new System.Drawing.Point(350, 244);
            this.showPassword.Margin = new System.Windows.Forms.Padding(2);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(31, 21);
            this.showPassword.TabIndex = 30;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // SiginUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(454, 526);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.showConfirm);
            this.Controls.Add(this.groupBox1);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiginUp";
            this.Text = "AfroNFTs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSignUP)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProviderSignUP;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.CheckBox termsCheckBox;
        private FontAwesome.Sharp.IconButton showPassword;
        private FontAwesome.Sharp.IconButton showConfirm;
    }
}

