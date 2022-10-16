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
            this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.radioBtnUser = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProviderSignUP = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.termsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSignUP)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNamelab
            // 
            this.FirstNamelab.AutoSize = true;
            this.FirstNamelab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.FirstNamelab.Location = new System.Drawing.Point(33, 196);
            this.FirstNamelab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNamelab.Name = "FirstNamelab";
            this.FirstNamelab.Size = new System.Drawing.Size(131, 29);
            this.FirstNamelab.TabIndex = 0;
            this.FirstNamelab.Text = "Frist name :";
            // 
            // LastNamelab
            // 
            this.LastNamelab.AutoSize = true;
            this.LastNamelab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.LastNamelab.Location = new System.Drawing.Point(33, 225);
            this.LastNamelab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNamelab.Name = "LastNamelab";
            this.LastNamelab.Size = new System.Drawing.Size(128, 29);
            this.LastNamelab.TabIndex = 1;
            this.LastNamelab.Text = "Last name :";
            // 
            // Emaillab
            // 
            this.Emaillab.AutoSize = true;
            this.Emaillab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.Emaillab.Location = new System.Drawing.Point(33, 265);
            this.Emaillab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Emaillab.Name = "Emaillab";
            this.Emaillab.Size = new System.Drawing.Size(81, 29);
            this.Emaillab.TabIndex = 2;
            this.Emaillab.Text = "Email :";
            // 
            // Pswordlab
            // 
            this.Pswordlab.AutoSize = true;
            this.Pswordlab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pswordlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.Pswordlab.Location = new System.Drawing.Point(33, 297);
            this.Pswordlab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pswordlab.Name = "Pswordlab";
            this.Pswordlab.Size = new System.Drawing.Size(120, 29);
            this.Pswordlab.TabIndex = 3;
            this.Pswordlab.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(31, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
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
            this.Siginupbtn.Location = new System.Drawing.Point(38, 505);
            this.Siginupbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Siginupbtn.Name = "Siginupbtn";
            this.Siginupbtn.Size = new System.Drawing.Size(168, 46);
            this.Siginupbtn.TabIndex = 5;
            this.Siginupbtn.Text = "Sigin up";
            this.Siginupbtn.UseVisualStyleBackColor = false;
            this.Siginupbtn.Click += new System.EventHandler(this.Siginupbtn_Click);
            // 
            // Fnametxt
            // 
            this.Fnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Fnametxt.Location = new System.Drawing.Point(259, 201);
            this.Fnametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.Size = new System.Drawing.Size(211, 22);
            this.Fnametxt.TabIndex = 6;
            // 
            // LNametxt
            // 
            this.LNametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.LNametxt.Location = new System.Drawing.Point(259, 233);
            this.LNametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LNametxt.Name = "LNametxt";
            this.LNametxt.Size = new System.Drawing.Size(211, 22);
            this.LNametxt.TabIndex = 7;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Emailtxt.Location = new System.Drawing.Point(259, 265);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(211, 22);
            this.Emailtxt.TabIndex = 8;
            // 
            // Pswordtxt
            // 
            this.Pswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Pswordtxt.Location = new System.Drawing.Point(259, 297);
            this.Pswordtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pswordtxt.Name = "Pswordtxt";
            this.Pswordtxt.Size = new System.Drawing.Size(211, 22);
            this.Pswordtxt.TabIndex = 9;
            // 
            // ConfirmPswordtxt
            // 
            this.ConfirmPswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.ConfirmPswordtxt.Location = new System.Drawing.Point(259, 330);
            this.ConfirmPswordtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmPswordtxt.Name = "ConfirmPswordtxt";
            this.ConfirmPswordtxt.Size = new System.Drawing.Size(211, 22);
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
            this.Clearbtn.Location = new System.Drawing.Point(390, 505);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(168, 46);
            this.Clearbtn.TabIndex = 11;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.radioBtnAdmin.Location = new System.Drawing.Point(317, 559);
            this.radioBtnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Size = new System.Drawing.Size(108, 31);
            this.radioBtnAdmin.TabIndex = 27;
            this.radioBtnAdmin.TabStop = true;
            this.radioBtnAdmin.Text = "ADMIN";
            this.radioBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // radioBtnUser
            // 
            this.radioBtnUser.AutoSize = true;
            this.radioBtnUser.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.radioBtnUser.Location = new System.Drawing.Point(156, 559);
            this.radioBtnUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnUser.Name = "radioBtnUser";
            this.radioBtnUser.Size = new System.Drawing.Size(84, 31);
            this.radioBtnUser.TabIndex = 26;
            this.radioBtnUser.TabStop = true;
            this.radioBtnUser.Text = "USER";
            this.radioBtnUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.termsCheckBox);
            this.groupBox1.Controls.Add(this.adminCheckBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(38, 372);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(554, 113);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // errorProviderSignUP
            // 
            this.errorProviderSignUP.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.textBox1.Location = new System.Drawing.Point(259, 171);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Frist name :";
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(15, 37);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(153, 20);
            this.adminCheckBox.TabIndex = 0;
            this.adminCheckBox.Text = "I want to be an admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // termsCheckBox
            // 
            this.termsCheckBox.AutoSize = true;
            this.termsCheckBox.Location = new System.Drawing.Point(15, 87);
            this.termsCheckBox.Name = "termsCheckBox";
            this.termsCheckBox.Size = new System.Drawing.Size(230, 20);
            this.termsCheckBox.TabIndex = 1;
            this.termsCheckBox.Text = "I accepts the terms and conditions";
            this.termsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SiginUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(4)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(605, 647);
            this.Controls.Add(this.radioBtnUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioBtnAdmin);
            this.Controls.Add(this.label2);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.RadioButton radioBtnUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProviderSignUP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.CheckBox termsCheckBox;
    }
}

