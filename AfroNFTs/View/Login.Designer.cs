namespace AfroNFTs
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Pswordtxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Siginupbtn = new System.Windows.Forms.Button();
            this.Pswordlab = new System.Windows.Forms.Label();
            this.Emaillab = new System.Windows.Forms.Label();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.forgottenPasswordButton = new FontAwesome.Sharp.IconButton();
            this.showPasswordButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Clearbtn.CausesValidation = false;
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.Snow;
            this.Clearbtn.Location = new System.Drawing.Point(237, 404);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(126, 37);
            this.Clearbtn.TabIndex = 21;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            // 
            // Pswordtxt
            // 
            this.Pswordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Pswordtxt.Location = new System.Drawing.Point(170, 245);
            this.Pswordtxt.Name = "Pswordtxt";
            this.Pswordtxt.PasswordChar = '*';
            this.Pswordtxt.Size = new System.Drawing.Size(159, 20);
            this.Pswordtxt.TabIndex = 19;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(168)))));
            this.Emailtxt.Location = new System.Drawing.Point(170, 208);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(159, 20);
            this.Emailtxt.TabIndex = 18;
            // 
            // Siginupbtn
            // 
            this.Siginupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.Siginupbtn.CausesValidation = false;
            this.Siginupbtn.FlatAppearance.BorderSize = 0;
            this.Siginupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Siginupbtn.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siginupbtn.ForeColor = System.Drawing.Color.Snow;
            this.Siginupbtn.Location = new System.Drawing.Point(35, 404);
            this.Siginupbtn.Name = "Siginupbtn";
            this.Siginupbtn.Size = new System.Drawing.Size(126, 37);
            this.Siginupbtn.TabIndex = 17;
            this.Siginupbtn.Text = "Log in";
            this.Siginupbtn.UseVisualStyleBackColor = false;
            this.Siginupbtn.Click += new System.EventHandler(this.Siginupbtn_Click);
            // 
            // Pswordlab
            // 
            this.Pswordlab.AutoSize = true;
            this.Pswordlab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pswordlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.Pswordlab.Location = new System.Drawing.Point(21, 237);
            this.Pswordlab.Name = "Pswordlab";
            this.Pswordlab.Size = new System.Drawing.Size(94, 24);
            this.Pswordlab.TabIndex = 15;
            this.Pswordlab.Text = "Password :";
            // 
            // Emaillab
            // 
            this.Emaillab.AutoSize = true;
            this.Emaillab.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.Emaillab.Location = new System.Drawing.Point(50, 208);
            this.Emaillab.Name = "Emaillab";
            this.Emaillab.Size = new System.Drawing.Size(67, 24);
            this.Emaillab.TabIndex = 14;
            this.Emaillab.Text = "Email :";
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(79)))), ((int)(((byte)(34)))));
            this.isAdminCheckBox.Location = new System.Drawing.Point(28, 342);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(93, 17);
            this.isAdminCheckBox.TabIndex = 28;
            this.isAdminCheckBox.Text = "I am an Admin";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // forgottenPasswordButton
            // 
            this.forgottenPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.forgottenPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgottenPasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(163)))), ((int)(((byte)(110)))));
            this.forgottenPasswordButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.forgottenPasswordButton.IconColor = System.Drawing.Color.LightSeaGreen;
            this.forgottenPasswordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.forgottenPasswordButton.Location = new System.Drawing.Point(170, 283);
            this.forgottenPasswordButton.Name = "forgottenPasswordButton";
            this.forgottenPasswordButton.Size = new System.Drawing.Size(159, 35);
            this.forgottenPasswordButton.TabIndex = 29;
            this.forgottenPasswordButton.Text = "Forgotten Password?";
            this.forgottenPasswordButton.UseVisualStyleBackColor = false;
            this.forgottenPasswordButton.Click += new System.EventHandler(this.forgottenPasswordButton_Click);
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showPasswordButton.IconColor = System.Drawing.Color.Black;
            this.showPasswordButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.showPasswordButton.IconSize = 30;
            this.showPasswordButton.Location = new System.Drawing.Point(335, 245);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(32, 20);
            this.showPasswordButton.TabIndex = 30;
            this.showPasswordButton.UseVisualStyleBackColor = true;
            this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(5)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(442, 512);
            this.Controls.Add(this.showPasswordButton);
            this.Controls.Add(this.forgottenPasswordButton);
            this.Controls.Add(this.isAdminCheckBox);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Pswordtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Siginupbtn);
            this.Controls.Add(this.Pswordlab);
            this.Controls.Add(this.Emaillab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "AfroNFTs";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.TextBox Pswordtxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Button Siginupbtn;
        private System.Windows.Forms.Label Pswordlab;
        private System.Windows.Forms.Label Emaillab;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private FontAwesome.Sharp.IconButton showPasswordButton;
        private FontAwesome.Sharp.IconButton forgottenPasswordButton;
    }
}