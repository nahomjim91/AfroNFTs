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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSignUP)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNamelab
            // 
            this.FirstNamelab.AutoSize = true;
            this.FirstNamelab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.FirstNamelab.Location = new System.Drawing.Point(83, 159);
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
            this.LastNamelab.Location = new System.Drawing.Point(85, 183);
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
            this.Emaillab.Location = new System.Drawing.Point(121, 211);
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
            this.Pswordlab.Location = new System.Drawing.Point(94, 240);
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
            this.Siginupbtn.Location = new System.Drawing.Point(45, 341);
            this.Siginupbtn.Name = "Siginupbtn";
            this.Siginupbtn.Size = new System.Drawing.Size(126, 37);
            this.Siginupbtn.TabIndex = 5;
            this.Siginupbtn.Text = "Sigin up";
            this.Siginupbtn.UseVisualStyleBackColor = false;
            this.Siginupbtn.Click += new System.EventHandler(this.Siginupbtn_Click);
            // 
            // Fnametxt
            // 
            this.Fnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Fnametxt.Location = new System.Drawing.Point(194, 163);
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.Size = new System.Drawing.Size(159, 20);
            this.Fnametxt.TabIndex = 6;
            // 
            // LNametxt
            // 
            this.LNametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.LNametxt.Location = new System.Drawing.Point(194, 189);
            this.LNametxt.Name = "LNametxt";
            this.LNametxt.Size = new System.Drawing.Size(159, 20);
            this.LNametxt.TabIndex = 7;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Emailtxt.Location = new System.Drawing.Point(194, 215);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(159, 20);
            this.Emailtxt.TabIndex = 8;
            // 
            // Pswordtxt
            // 
            this.Pswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Pswordtxt.Location = new System.Drawing.Point(194, 241);
            this.Pswordtxt.Name = "Pswordtxt";
            this.Pswordtxt.Size = new System.Drawing.Size(159, 20);
            this.Pswordtxt.TabIndex = 9;
            // 
            // ConfirmPswordtxt
            // 
            this.ConfirmPswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.ConfirmPswordtxt.Location = new System.Drawing.Point(194, 268);
            this.ConfirmPswordtxt.Name = "ConfirmPswordtxt";
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
            this.Clearbtn.Location = new System.Drawing.Point(279, 341);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(126, 37);
            this.Clearbtn.TabIndex = 11;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.radioBtnAdmin.Location = new System.Drawing.Point(140, 17);
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Size = new System.Drawing.Size(84, 26);
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
            this.radioBtnUser.Location = new System.Drawing.Point(48, 17);
            this.radioBtnUser.Name = "radioBtnUser";
            this.radioBtnUser.Size = new System.Drawing.Size(70, 26);
            this.radioBtnUser.TabIndex = 26;
            this.radioBtnUser.TabStop = true;
            this.radioBtnUser.Text = "USER";
            this.radioBtnUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioBtnUser);
            this.groupBox1.Controls.Add(this.radioBtnAdmin);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(77, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 49);
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
            this.textBox1.Location = new System.Drawing.Point(194, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(83, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Frist name :";
            // 
            // SiginUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(4)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(454, 526);
            this.Controls.Add(this.textBox1);
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
    }
}

