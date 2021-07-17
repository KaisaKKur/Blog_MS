
namespace Blog {
    partial class Login {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.linkLabel_signup = new System.Windows.Forms.LinkLabel();
            this.autoLabel_welcome = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel_password = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxExt_username = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt_password = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel_username = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfButton_login = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel_noAccount = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.checkBoxAdv_rememberMe = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.timer_autoLogin = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv_rememberMe)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_signup
            // 
            this.linkLabel_signup.AutoSize = true;
            this.linkLabel_signup.Location = new System.Drawing.Point(309, 267);
            this.linkLabel_signup.Name = "linkLabel_signup";
            this.linkLabel_signup.Size = new System.Drawing.Size(112, 23);
            this.linkLabel_signup.TabIndex = 4;
            this.linkLabel_signup.TabStop = true;
            this.linkLabel_signup.Text = "Sign up here!";
            this.linkLabel_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_signup_LinkClicked);
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
            this.autoLabel_welcome.Size = new System.Drawing.Size(522, 121);
            this.autoLabel_welcome.TabIndex = 9;
            this.autoLabel_welcome.Text = "Welcome";
            this.autoLabel_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLabel_password
            // 
            this.autoLabel_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_password.Location = new System.Drawing.Point(94, 186);
            this.autoLabel_password.Name = "autoLabel_password";
            this.autoLabel_password.Size = new System.Drawing.Size(80, 23);
            this.autoLabel_password.TabIndex = 11;
            this.autoLabel_password.Text = "Password";
            // 
            // textBoxExt_username
            // 
            this.textBoxExt_username.BeforeTouchSize = new System.Drawing.Size(205, 30);
            this.textBoxExt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_username.Location = new System.Drawing.Point(168, 124);
            this.textBoxExt_username.Name = "textBoxExt_username";
            this.textBoxExt_username.Size = new System.Drawing.Size(205, 30);
            this.textBoxExt_username.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt_username.TabIndex = 0;
            this.textBoxExt_username.ThemeName = "Metro";
            // 
            // textBoxExt_password
            // 
            this.textBoxExt_password.BeforeTouchSize = new System.Drawing.Size(205, 30);
            this.textBoxExt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_password.Location = new System.Drawing.Point(168, 179);
            this.textBoxExt_password.Name = "textBoxExt_password";
            this.textBoxExt_password.PasswordChar = '●';
            this.textBoxExt_password.Size = new System.Drawing.Size(205, 30);
            this.textBoxExt_password.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt_password.TabIndex = 1;
            this.textBoxExt_password.ThemeName = "Metro";
            this.textBoxExt_password.UseSystemPasswordChar = true;
            // 
            // autoLabel_username
            // 
            this.autoLabel_username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_username.Location = new System.Drawing.Point(94, 131);
            this.autoLabel_username.Name = "autoLabel_username";
            this.autoLabel_username.Size = new System.Drawing.Size(87, 23);
            this.autoLabel_username.TabIndex = 15;
            this.autoLabel_username.Text = "Username";
            // 
            // sfButton_login
            // 
            this.sfButton_login.AccessibleName = "Button";
            this.sfButton_login.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.sfButton_login.ForeColor = System.Drawing.Color.AliceBlue;
            this.sfButton_login.Location = new System.Drawing.Point(94, 253);
            this.sfButton_login.Name = "sfButton_login";
            this.sfButton_login.Size = new System.Drawing.Size(126, 37);
            this.sfButton_login.Style.BackColor = System.Drawing.Color.Orchid;
            this.sfButton_login.Style.FocusedBackColor = System.Drawing.Color.MistyRose;
            this.sfButton_login.Style.FocusedForeColor = System.Drawing.Color.DimGray;
            this.sfButton_login.Style.ForeColor = System.Drawing.Color.AliceBlue;
            this.sfButton_login.Style.HoverBackColor = System.Drawing.Color.SkyBlue;
            this.sfButton_login.Style.HoverForeColor = System.Drawing.Color.DimGray;
            this.sfButton_login.Style.PressedBackColor = System.Drawing.Color.PaleGreen;
            this.sfButton_login.Style.PressedForeColor = System.Drawing.Color.Gray;
            this.sfButton_login.TabIndex = 3;
            this.sfButton_login.Text = "Log in";
            this.sfButton_login.Click += new System.EventHandler(this.sfButton_login_Click);
            // 
            // autoLabel_noAccount
            // 
            this.autoLabel_noAccount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.autoLabel_noAccount.Location = new System.Drawing.Point(226, 267);
            this.autoLabel_noAccount.Name = "autoLabel_noAccount";
            this.autoLabel_noAccount.Size = new System.Drawing.Size(107, 23);
            this.autoLabel_noAccount.TabIndex = 17;
            this.autoLabel_noAccount.Text = "No account?";
            // 
            // checkBoxAdv_rememberMe
            // 
            this.checkBoxAdv_rememberMe.BeforeTouchSize = new System.Drawing.Size(87, 36);
            this.checkBoxAdv_rememberMe.BorderColor = System.Drawing.SystemColors.GrayText;
            this.checkBoxAdv_rememberMe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBoxAdv_rememberMe.HotBorderColor = System.Drawing.SystemColors.GrayText;
            this.checkBoxAdv_rememberMe.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.checkBoxAdv_rememberMe.Location = new System.Drawing.Point(306, 212);
            this.checkBoxAdv_rememberMe.Name = "checkBoxAdv_rememberMe";
            this.checkBoxAdv_rememberMe.ShadowColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv_rememberMe.Size = new System.Drawing.Size(87, 36);
            this.checkBoxAdv_rememberMe.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv_rememberMe.TabIndex = 2;
            this.checkBoxAdv_rememberMe.Text = "记住我";
            this.checkBoxAdv_rememberMe.ThemeName = "Metro";
            // 
            // timer_autoLogin
            // 
            this.timer_autoLogin.Enabled = true;
            this.timer_autoLogin.Interval = 24;
            this.timer_autoLogin.Tick += new System.EventHandler(this.timer_autoLogin_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(526, 353);
            this.Controls.Add(this.autoLabel_noAccount);
            this.Controls.Add(this.autoLabel_username);
            this.Controls.Add(this.checkBoxAdv_rememberMe);
            this.Controls.Add(this.textBoxExt_password);
            this.Controls.Add(this.textBoxExt_username);
            this.Controls.Add(this.autoLabel_password);
            this.Controls.Add(this.autoLabel_welcome);
            this.Controls.Add(this.linkLabel_signup);
            this.Controls.Add(this.sfButton_login);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.Color.GhostWhite;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.BackColor = System.Drawing.Color.White;
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.DarkGray;
            this.Style.TitleBar.TextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text = "Blog Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv_rememberMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel_signup;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_welcome;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_password;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_username;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_password;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_username;
        private Syncfusion.WinForms.Controls.SfButton sfButton_login;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_noAccount;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv_rememberMe;
        private System.Windows.Forms.Timer timer_autoLogin;
    }
}