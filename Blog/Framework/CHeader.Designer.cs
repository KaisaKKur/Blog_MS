
using System.Windows.Forms;

namespace Blog.Framework {
    partial class CHeader {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            Syncfusion.Windows.Forms.Tools.Office2016WhiteSplitButtonRenderer office2016WhiteSplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.Office2016WhiteSplitButtonRenderer();
            this.splitButton_account = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.toolstripitem_profile = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem_editor = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem_admins = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.toolstripitem_signout = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.linkLabel_home = new System.Windows.Forms.LinkLabel();
            this.linkLabel_logo = new System.Windows.Forms.LinkLabel();
            this.gradientPanelExt_container = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_container)).BeginInit();
            this.gradientPanelExt_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitButton_account
            // 
            this.splitButton_account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButton_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitButton_account.BeforeTouchSize = new System.Drawing.Size(122, 33);
            this.splitButton_account.DropDownIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton_account.DropDownItems.Add(this.toolstripitem_profile);
            this.splitButton_account.DropDownItems.Add(this.toolstripitem_editor);
            this.splitButton_account.DropDownItems.Add(this.toolstripitem_admins);
            this.splitButton_account.DropDownItems.Add(this.toolstripitem_signout);
            this.splitButton_account.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton_account.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitButton_account.Location = new System.Drawing.Point(763, 15);
            this.splitButton_account.MinimumSize = new System.Drawing.Size(84, 26);
            this.splitButton_account.Name = "splitButton_account";
            office2016WhiteSplitButtonRenderer1.SplitButton = this.splitButton_account;
            this.splitButton_account.Renderer = office2016WhiteSplitButtonRenderer1;
            this.splitButton_account.ShowDropDownOnButtonClick = true;
            this.splitButton_account.Size = new System.Drawing.Size(122, 33);
            this.splitButton_account.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Office2016White;
            this.splitButton_account.TabIndex = 6;
            this.splitButton_account.Text = "Account";
            this.splitButton_account.ThemeName = "Office2016White";
            this.splitButton_account.ThemeStyle.BorderColor = System.Drawing.Color.Snow;
            this.splitButton_account.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.splitButton_account.DropDowItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.splitButton_account_DropDowItemClicked);
            // 
            // toolstripitem_profile
            // 
            this.toolstripitem_profile.BackColor = System.Drawing.SystemColors.Window;
            this.toolstripitem_profile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolstripitem_profile.Name = "toolstripitem_profile";
            this.toolstripitem_profile.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem_profile.Text = "Profile";
            // 
            // toolstripitem_editor
            // 
            this.toolstripitem_editor.BackColor = System.Drawing.SystemColors.Window;
            this.toolstripitem_editor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolstripitem_editor.Name = "toolstripitem_editor";
            this.toolstripitem_editor.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem_editor.Text = "Editor";
            // 
            // toolstripitem_admins
            // 
            this.toolstripitem_admins.Name = "toolstripitem_admins";
            this.toolstripitem_admins.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem_admins.Text = "管理员";
            // 
            // toolstripitem_signout
            // 
            this.toolstripitem_signout.BackColor = System.Drawing.SystemColors.Window;
            this.toolstripitem_signout.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolstripitem_signout.Name = "toolstripitem_signout";
            this.toolstripitem_signout.Size = new System.Drawing.Size(23, 23);
            this.toolstripitem_signout.Text = "Sign out";
            // 
            // linkLabel_home
            // 
            this.linkLabel_home.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabel_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_home.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkLabel_home.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel_home.Location = new System.Drawing.Point(23, 15);
            this.linkLabel_home.Name = "linkLabel_home";
            this.linkLabel_home.Size = new System.Drawing.Size(65, 33);
            this.linkLabel_home.TabIndex = 0;
            this.linkLabel_home.TabStop = true;
            this.linkLabel_home.Text = "Home";
            this.linkLabel_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_home_LinkClicked);
            // 
            // linkLabel_logo
            // 
            this.linkLabel_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.linkLabel_logo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_logo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel_logo.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel_logo.Location = new System.Drawing.Point(399, 14);
            this.linkLabel_logo.Name = "linkLabel_logo";
            this.linkLabel_logo.Size = new System.Drawing.Size(95, 33);
            this.linkLabel_logo.TabIndex = 7;
            this.linkLabel_logo.TabStop = true;
            this.linkLabel_logo.Text = "KKur";
            this.linkLabel_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_logo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_home_LinkClicked);
            // 
            // gradientPanelExt_container
            // 
            this.gradientPanelExt_container.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelExt_container.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt_container.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanelExt_container.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt_container.Controls.Add(this.linkLabel_logo);
            this.gradientPanelExt_container.Controls.Add(this.linkLabel_home);
            this.gradientPanelExt_container.Controls.Add(this.splitButton_account);
            this.gradientPanelExt_container.CornerRadius = 10;
            this.gradientPanelExt_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelExt_container.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelExt_container.Name = "gradientPanelExt_container";
            this.gradientPanelExt_container.Size = new System.Drawing.Size(909, 64);
            this.gradientPanelExt_container.TabIndex = 7;
            // 
            // CHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.gradientPanelExt_container);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CHeader";
            this.Size = new System.Drawing.Size(909, 61);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_container)).EndInit();
            this.gradientPanelExt_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem_profile;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem_editor;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem_signout;
        private Syncfusion.Windows.Forms.Tools.SplitButton splitButton_account;
        private System.Windows.Forms.LinkLabel linkLabel_home;
        private System.Windows.Forms.LinkLabel linkLabel_logo;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt_container;
        private Syncfusion.Windows.Forms.Tools.toolstripitem toolstripitem_admins;
    }
}

