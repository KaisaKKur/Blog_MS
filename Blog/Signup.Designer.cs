
namespace Blog {
    partial class Signup {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.linkLabel_login = new System.Windows.Forms.LinkLabel();
            this.autoLabel_welcome = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel_verificationCode = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel_username = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel_email = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel_password = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel_confirmPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel_hasAAccount = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxExt_verificationCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt_username = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt_email = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt_password = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt_confirmPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.sfButton_signup = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_verificationCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_confirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_login
            // 
            this.linkLabel_login.AutoSize = true;
            this.linkLabel_login.Location = new System.Drawing.Point(307, 486);
            this.linkLabel_login.Name = "linkLabel_login";
            this.linkLabel_login.Size = new System.Drawing.Size(101, 23);
            this.linkLabel_login.TabIndex = 6;
            this.linkLabel_login.TabStop = true;
            this.linkLabel_login.Text = "Log in here!";
            this.linkLabel_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_login_LinkClicked);
            // 
            // autoLabel_welcome
            // 
            this.autoLabel_welcome.AutoSize = false;
            this.autoLabel_welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel_welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel_welcome.ForeColor = System.Drawing.Color.DarkOrchid;
            this.autoLabel_welcome.Location = new System.Drawing.Point(2, 2);
            this.autoLabel_welcome.Name = "autoLabel_welcome";
            this.autoLabel_welcome.Size = new System.Drawing.Size(430, 90);
            this.autoLabel_welcome.TabIndex = 13;
            this.autoLabel_welcome.Text = "Welcome";
            this.autoLabel_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabel_verificationCode
            // 
            this.autoLabel_verificationCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_verificationCode.Location = new System.Drawing.Point(66, 106);
            this.autoLabel_verificationCode.Name = "autoLabel_verificationCode";
            this.autoLabel_verificationCode.Size = new System.Drawing.Size(140, 23);
            this.autoLabel_verificationCode.TabIndex = 14;
            this.autoLabel_verificationCode.Text = "Verification Code";
            // 
            // autoLabel_username
            // 
            this.autoLabel_username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_username.Location = new System.Drawing.Point(66, 178);
            this.autoLabel_username.Name = "autoLabel_username";
            this.autoLabel_username.Size = new System.Drawing.Size(87, 23);
            this.autoLabel_username.TabIndex = 15;
            this.autoLabel_username.Text = "Username";
            // 
            // autoLabel_email
            // 
            this.autoLabel_email.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_email.Location = new System.Drawing.Point(66, 246);
            this.autoLabel_email.Name = "autoLabel_email";
            this.autoLabel_email.Size = new System.Drawing.Size(51, 23);
            this.autoLabel_email.TabIndex = 16;
            this.autoLabel_email.Text = "Email";
            // 
            // autoLabel_password
            // 
            this.autoLabel_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_password.Location = new System.Drawing.Point(66, 316);
            this.autoLabel_password.Name = "autoLabel_password";
            this.autoLabel_password.Size = new System.Drawing.Size(80, 23);
            this.autoLabel_password.TabIndex = 17;
            this.autoLabel_password.Text = "Password";
            // 
            // autoLabel_confirmPassword
            // 
            this.autoLabel_confirmPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_confirmPassword.Location = new System.Drawing.Point(66, 387);
            this.autoLabel_confirmPassword.Name = "autoLabel_confirmPassword";
            this.autoLabel_confirmPassword.Size = new System.Drawing.Size(146, 23);
            this.autoLabel_confirmPassword.TabIndex = 18;
            this.autoLabel_confirmPassword.Text = "Confirm Password";
            // 
            // autoLabel_hasAAccount
            // 
            this.autoLabel_hasAAccount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_hasAAccount.Location = new System.Drawing.Point(211, 486);
            this.autoLabel_hasAAccount.Name = "autoLabel_hasAAccount";
            this.autoLabel_hasAAccount.Size = new System.Drawing.Size(126, 23);
            this.autoLabel_hasAAccount.TabIndex = 19;
            this.autoLabel_hasAAccount.Text = "Has a account?";
            // 
            // textBoxExt_verificationCode
            // 
            this.textBoxExt_verificationCode.BeforeTouchSize = new System.Drawing.Size(455, 472);
            this.textBoxExt_verificationCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt_verificationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt_verificationCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_verificationCode.Location = new System.Drawing.Point(66, 133);
            this.textBoxExt_verificationCode.Name = "textBoxExt_verificationCode";
            this.textBoxExt_verificationCode.Size = new System.Drawing.Size(298, 30);
            this.textBoxExt_verificationCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt_verificationCode.TabIndex = 0;
            this.textBoxExt_verificationCode.ThemeName = "Metro";
            // 
            // textBoxExt_username
            // 
            this.textBoxExt_username.BeforeTouchSize = new System.Drawing.Size(455, 472);
            this.textBoxExt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_username.Location = new System.Drawing.Point(66, 204);
            this.textBoxExt_username.Name = "textBoxExt_username";
            this.textBoxExt_username.Size = new System.Drawing.Size(298, 30);
            this.textBoxExt_username.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt_username.TabIndex = 1;
            this.textBoxExt_username.ThemeName = "Metro";
            // 
            // textBoxExt_email
            // 
            this.textBoxExt_email.BeforeTouchSize = new System.Drawing.Size(455, 472);
            this.textBoxExt_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt_email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_email.Location = new System.Drawing.Point(66, 273);
            this.textBoxExt_email.Name = "textBoxExt_email";
            this.textBoxExt_email.Size = new System.Drawing.Size(298, 30);
            this.textBoxExt_email.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt_email.TabIndex = 2;
            this.textBoxExt_email.ThemeName = "Metro";
            // 
            // textBoxExt_password
            // 
            this.textBoxExt_password.BeforeTouchSize = new System.Drawing.Size(455, 472);
            this.textBoxExt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_password.Location = new System.Drawing.Point(66, 342);
            this.textBoxExt_password.Name = "textBoxExt_password";
            this.textBoxExt_password.PasswordChar = '●';
            this.textBoxExt_password.Size = new System.Drawing.Size(298, 30);
            this.textBoxExt_password.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt_password.TabIndex = 3;
            this.textBoxExt_password.ThemeName = "Metro";
            this.textBoxExt_password.UseSystemPasswordChar = true;
            // 
            // textBoxExt_confirmPassword
            // 
            this.textBoxExt_confirmPassword.BeforeTouchSize = new System.Drawing.Size(455, 472);
            this.textBoxExt_confirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_confirmPassword.Location = new System.Drawing.Point(66, 413);
            this.textBoxExt_confirmPassword.Name = "textBoxExt_confirmPassword";
            this.textBoxExt_confirmPassword.PasswordChar = '●';
            this.textBoxExt_confirmPassword.Size = new System.Drawing.Size(298, 30);
            this.textBoxExt_confirmPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt_confirmPassword.TabIndex = 4;
            this.textBoxExt_confirmPassword.ThemeName = "Metro";
            this.textBoxExt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // sfButton_signup
            // 
            this.sfButton_signup.AccessibleName = "Button";
            this.sfButton_signup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton_signup.ForeColor = System.Drawing.Color.AliceBlue;
            this.sfButton_signup.Location = new System.Drawing.Point(66, 469);
            this.sfButton_signup.Name = "sfButton_signup";
            this.sfButton_signup.Size = new System.Drawing.Size(148, 40);
            this.sfButton_signup.Style.BackColor = System.Drawing.Color.Orchid;
            this.sfButton_signup.Style.FocusedBackColor = System.Drawing.Color.Gold;
            this.sfButton_signup.Style.FocusedForeColor = System.Drawing.Color.DimGray;
            this.sfButton_signup.Style.ForeColor = System.Drawing.Color.AliceBlue;
            this.sfButton_signup.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.sfButton_signup.Style.PressedBackColor = System.Drawing.Color.DarkTurquoise;
            this.sfButton_signup.Style.PressedForeColor = System.Drawing.Color.Gray;
            this.sfButton_signup.TabIndex = 5;
            this.sfButton_signup.Text = "Sign up";
            this.sfButton_signup.Click += new System.EventHandler(this.sfButton_signup_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(434, 573);
            this.Controls.Add(this.sfButton_signup);
            this.Controls.Add(this.textBoxExt_confirmPassword);
            this.Controls.Add(this.textBoxExt_password);
            this.Controls.Add(this.textBoxExt_email);
            this.Controls.Add(this.textBoxExt_username);
            this.Controls.Add(this.textBoxExt_verificationCode);
            this.Controls.Add(this.autoLabel_hasAAccount);
            this.Controls.Add(this.autoLabel_confirmPassword);
            this.Controls.Add(this.autoLabel_password);
            this.Controls.Add(this.autoLabel_email);
            this.Controls.Add(this.autoLabel_username);
            this.Controls.Add(this.autoLabel_verificationCode);
            this.Controls.Add(this.autoLabel_welcome);
            this.Controls.Add(this.linkLabel_login);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.Color.GhostWhite;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.BackColor = System.Drawing.Color.White;
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.TextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text = "Blog Signup";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_verificationCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_confirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel_login;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_welcome;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_verificationCode;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_username;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_email;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_password;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_confirmPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_hasAAccount;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_verificationCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_username;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_email;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_password;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_confirmPassword;
        private Syncfusion.WinForms.Controls.SfButton sfButton_signup;
    }
}