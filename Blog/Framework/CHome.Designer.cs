
namespace Blog.Framework {
    partial class CHome {
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
            this.gradientPanelExt_container = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox_latestBlogList = new System.Windows.Forms.GroupBox();
            this.groupView_latestBlogList = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.gradientPanelExt_accessory = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.autoLabel_title = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_container)).BeginInit();
            this.gradientPanelExt_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox_latestBlogList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_accessory)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelExt_container
            // 
            this.gradientPanelExt_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanelExt_container.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelExt_container.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt_container.BorderColor = System.Drawing.Color.Gray;
            this.gradientPanelExt_container.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt_container.Controls.Add(this.splitContainer);
            this.gradientPanelExt_container.Controls.Add(this.gradientPanelExt_accessory);
            this.gradientPanelExt_container.Controls.Add(this.autoLabel_title);
            this.gradientPanelExt_container.CornerRadius = 4;
            this.gradientPanelExt_container.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelExt_container.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanelExt_container.Name = "gradientPanelExt_container";
            this.gradientPanelExt_container.Size = new System.Drawing.Size(909, 557);
            this.gradientPanelExt_container.TabIndex = 7;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(28, 76);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox_latestBlogList);
            this.splitContainer.Size = new System.Drawing.Size(857, 456);
            this.splitContainer.SplitterDistance = 527;
            this.splitContainer.TabIndex = 4;
            // 
            // groupBox_latestBlogList
            // 
            this.groupBox_latestBlogList.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox_latestBlogList.Controls.Add(this.groupView_latestBlogList);
            this.groupBox_latestBlogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_latestBlogList.Location = new System.Drawing.Point(0, 0);
            this.groupBox_latestBlogList.Name = "groupBox_latestBlogList";
            this.groupBox_latestBlogList.Size = new System.Drawing.Size(527, 456);
            this.groupBox_latestBlogList.TabIndex = 5;
            this.groupBox_latestBlogList.TabStop = false;
            this.groupBox_latestBlogList.Text = "Latest Blog List";
            // 
            // groupView_latestBlogList
            // 
            this.groupView_latestBlogList.BackColor = System.Drawing.Color.MintCream;
            this.groupView_latestBlogList.BeforeTouchSize = new System.Drawing.Size(521, 427);
            this.groupView_latestBlogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupView_latestBlogList.ButtonView = true;
            this.groupView_latestBlogList.CanOverrideStyle = true;
            this.groupView_latestBlogList.ClipSelectionBounds = true;
            this.groupView_latestBlogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupView_latestBlogList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupView_latestBlogList.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupView_latestBlogList.HighlightItemColor = System.Drawing.Color.DarkGreen;
            this.groupView_latestBlogList.HighlightTextColor = System.Drawing.Color.Green;
            this.groupView_latestBlogList.IntegratedScrolling = true;
            this.groupView_latestBlogList.Location = new System.Drawing.Point(3, 26);
            this.groupView_latestBlogList.MetroBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupView_latestBlogList.Name = "groupView_latestBlogList";
            this.groupView_latestBlogList.SelectedHighlightItemColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupView_latestBlogList.SelectedHighlightTextColor = System.Drawing.Color.DarkCyan;
            this.groupView_latestBlogList.SelectedItemColor = System.Drawing.Color.DarkSlateGray;
            this.groupView_latestBlogList.SelectedTextColor = System.Drawing.Color.DarkMagenta;
            this.groupView_latestBlogList.SelectingItemColor = System.Drawing.Color.SlateGray;
            this.groupView_latestBlogList.SelectingTextColor = System.Drawing.Color.Teal;
            this.groupView_latestBlogList.Size = new System.Drawing.Size(521, 427);
            this.groupView_latestBlogList.SmallImageView = true;
            this.groupView_latestBlogList.TabIndex = 2;
            this.groupView_latestBlogList.Text = "groupView1";
            this.groupView_latestBlogList.ThemeName = "Default";
            this.groupView_latestBlogList.ThemesEnabled = true;
            this.groupView_latestBlogList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupView_latestBlogList.ThemeStyle.DragDropIndicatorColor = System.Drawing.Color.Turquoise;
            this.groupView_latestBlogList.ThemeStyle.ScrollButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupView_latestBlogList.ThemeStyle.ScrollButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupView_latestBlogList.ThemeStyle.ScrollButtonPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupView_latestBlogList.GroupViewItemDoubleClick += new Syncfusion.Windows.Forms.Tools.GroupViewItemDoubleClickEventHandler(this.groupView_latestBlogList_GroupViewItemDoubleClick);
            // 
            // gradientPanelExt_accessory
            // 
            this.gradientPanelExt_accessory.BackColor = System.Drawing.Color.LavenderBlush;
            this.gradientPanelExt_accessory.Border = new System.Windows.Forms.Padding(4);
            this.gradientPanelExt_accessory.BorderGap = 4;
            this.gradientPanelExt_accessory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt_accessory.Collapsed = true;
            this.gradientPanelExt_accessory.CornerRadius = 10;
            this.gradientPanelExt_accessory.ExpandLocation = new System.Drawing.Point(28, 56);
            this.gradientPanelExt_accessory.ExpandSize = new System.Drawing.Size(322, 84);
            this.gradientPanelExt_accessory.Location = new System.Drawing.Point(28, 56);
            this.gradientPanelExt_accessory.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanelExt_accessory.Name = "gradientPanelExt_accessory";
            this.gradientPanelExt_accessory.Size = new System.Drawing.Size(322, 27);
            this.gradientPanelExt_accessory.TabIndex = 1;
            // 
            // autoLabel_title
            // 
            this.autoLabel_title.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoLabel_title.Location = new System.Drawing.Point(28, 25);
            this.autoLabel_title.Name = "autoLabel_title";
            this.autoLabel_title.Size = new System.Drawing.Size(322, 28);
            this.autoLabel_title.TabIndex = 0;
            this.autoLabel_title.Text = "From KKur Code Code Coding !!!";
            // 
            // CHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.gradientPanelExt_container);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CHome";
            this.Size = new System.Drawing.Size(909, 557);
            this.Load += new System.EventHandler(this.CHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_container)).EndInit();
            this.gradientPanelExt_container.ResumeLayout(false);
            this.gradientPanelExt_container.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox_latestBlogList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_accessory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt_container;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_title;
        private Syncfusion.Windows.Forms.Tools.GroupView groupView_latestBlogList;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt_accessory;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox_latestBlogList;
    }
}

