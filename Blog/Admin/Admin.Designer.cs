
namespace Blog.AdminGroup {
    partial class Admin {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.toolStripMenuItem_chat = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxExt_chat = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gradientPanel_editor = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.sfButton_send = new Syncfusion.WinForms.Controls.SfButton();
            this.textBoxExt_editor = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox_users = new System.Windows.Forms.GroupBox();
            this.gradientPanel_user = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel_editor)).BeginInit();
            this.gradientPanel_editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_editor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel_user)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem_chat
            // 
            this.toolStripMenuItem_chat.Name = "toolStripMenuItem_chat";
            this.toolStripMenuItem_chat.Size = new System.Drawing.Size(32, 19);
            // 
            // textBoxExt_chat
            // 
            this.textBoxExt_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExt_chat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxExt_chat.BeforeTouchSize = new System.Drawing.Size(455, 472);
            this.textBoxExt_chat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_chat.Location = new System.Drawing.Point(3, 0);
            this.textBoxExt_chat.Multiline = true;
            this.textBoxExt_chat.Name = "textBoxExt_chat";
            this.textBoxExt_chat.Size = new System.Drawing.Size(455, 472);
            this.textBoxExt_chat.TabIndex = 4;
            // 
            // gradientPanel_editor
            // 
            this.gradientPanel_editor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel_editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel_editor.Controls.Add(this.sfButton_send);
            this.gradientPanel_editor.Controls.Add(this.textBoxExt_editor);
            this.gradientPanel_editor.Location = new System.Drawing.Point(3, 478);
            this.gradientPanel_editor.Name = "gradientPanel_editor";
            this.gradientPanel_editor.Size = new System.Drawing.Size(455, 63);
            this.gradientPanel_editor.TabIndex = 3;
            // 
            // sfButton_send
            // 
            this.sfButton_send.AccessibleName = "Button";
            this.sfButton_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfButton_send.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton_send.Location = new System.Drawing.Point(356, 0);
            this.sfButton_send.Name = "sfButton_send";
            this.sfButton_send.Size = new System.Drawing.Size(99, 60);
            this.sfButton_send.TabIndex = 1;
            this.sfButton_send.Text = "发送";
            this.sfButton_send.Click += new System.EventHandler(this.sfButton_send_Click);
            // 
            // textBoxExt_editor
            // 
            this.textBoxExt_editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExt_editor.BeforeTouchSize = new System.Drawing.Size(455, 472);
            this.textBoxExt_editor.Location = new System.Drawing.Point(0, 0);
            this.textBoxExt_editor.Multiline = true;
            this.textBoxExt_editor.Name = "textBoxExt_editor";
            this.textBoxExt_editor.Size = new System.Drawing.Size(350, 60);
            this.textBoxExt_editor.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(2, 2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.groupBox_users);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.textBoxExt_chat);
            this.splitContainer.Panel2.Controls.Add(this.gradientPanel_editor);
            this.splitContainer.Size = new System.Drawing.Size(695, 544);
            this.splitContainer.SplitterDistance = 230;
            this.splitContainer.TabIndex = 5;
            // 
            // groupBox_users
            // 
            this.groupBox_users.Controls.Add(this.gradientPanel_user);
            this.groupBox_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_users.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_users.Location = new System.Drawing.Point(0, 0);
            this.groupBox_users.Name = "groupBox_users";
            this.groupBox_users.Size = new System.Drawing.Size(230, 544);
            this.groupBox_users.TabIndex = 0;
            this.groupBox_users.TabStop = false;
            this.groupBox_users.Text = "Users";
            // 
            // gradientPanel_user
            // 
            this.gradientPanel_user.AutoScroll = true;
            this.gradientPanel_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel_user.Location = new System.Drawing.Point(3, 26);
            this.gradientPanel_user.Name = "gradientPanel_user";
            this.gradientPanel_user.Size = new System.Drawing.Size(224, 515);
            this.gradientPanel_user.TabIndex = 5;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(699, 548);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.BackColor = System.Drawing.Color.GhostWhite;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.TextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminGroupChat_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel_editor)).EndInit();
            this.gradientPanel_editor.ResumeLayout(false);
            this.gradientPanel_editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_editor)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_chat;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_chat;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel_editor;
        private Syncfusion.WinForms.Controls.SfButton sfButton_send;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_editor;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox_users;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel_user;
    }
}