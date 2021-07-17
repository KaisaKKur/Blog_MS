
using System.Collections;
using System.Collections.Generic;

namespace Blog.Framework {
    partial class CEditor {
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CEditor));
            this.autoLabel_category = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gradientPanelExt_container = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.sfComboBox_comments = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel_comments = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox_tags = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel_tags = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox_category = new Syncfusion.WinForms.ListView.SfComboBox();
            this.sfButton_save = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox_content = new System.Windows.Forms.GroupBox();
            this.textBoxExt_content = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.sfButton_delete = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton_new = new Syncfusion.WinForms.Controls.SfButton();
            this.textBoxExt_title = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel_title = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox_blogList = new System.Windows.Forms.GroupBox();
            this.sfListView_blogList = new Syncfusion.WinForms.ListView.SfListView();
            this.gradientPanelExt_blogListTitle = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.autoLabel_blogListTitle = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_container)).BeginInit();
            this.gradientPanelExt_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox_comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox_tags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox_category)).BeginInit();
            this.groupBox_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_content)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_title)).BeginInit();
            this.groupBox_blogList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_blogListTitle)).BeginInit();
            this.gradientPanelExt_blogListTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoLabel_category
            // 
            this.autoLabel_category.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel_category.ForeColor = System.Drawing.Color.DimGray;
            this.autoLabel_category.Location = new System.Drawing.Point(21, 72);
            this.autoLabel_category.Name = "autoLabel_category";
            this.autoLabel_category.Size = new System.Drawing.Size(88, 25);
            this.autoLabel_category.TabIndex = 5;
            this.autoLabel_category.Text = "Category";
            // 
            // gradientPanelExt_container
            // 
            this.gradientPanelExt_container.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelExt_container.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt_container.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt_container.Controls.Add(this.splitContainer);
            this.gradientPanelExt_container.CornerRadius = 4;
            this.gradientPanelExt_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelExt_container.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelExt_container.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gradientPanelExt_container.Name = "gradientPanelExt_container";
            this.gradientPanelExt_container.Size = new System.Drawing.Size(909, 557);
            this.gradientPanelExt_container.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.sfComboBox_comments);
            this.splitContainer.Panel1.Controls.Add(this.autoLabel_comments);
            this.splitContainer.Panel1.Controls.Add(this.sfComboBox_tags);
            this.splitContainer.Panel1.Controls.Add(this.autoLabel_tags);
            this.splitContainer.Panel1.Controls.Add(this.sfComboBox_category);
            this.splitContainer.Panel1.Controls.Add(this.sfButton_save);
            this.splitContainer.Panel1.Controls.Add(this.groupBox_content);
            this.splitContainer.Panel1.Controls.Add(this.sfButton_delete);
            this.splitContainer.Panel1.Controls.Add(this.sfButton_new);
            this.splitContainer.Panel1.Controls.Add(this.textBoxExt_title);
            this.splitContainer.Panel1.Controls.Add(this.autoLabel_category);
            this.splitContainer.Panel1.Controls.Add(this.autoLabel_title);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox_blogList);
            this.splitContainer.Panel2.Controls.Add(this.gradientPanelExt_blogListTitle);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(16, 10, 16, 16);
            this.splitContainer.Size = new System.Drawing.Size(909, 557);
            this.splitContainer.SplitterDistance = 566;
            this.splitContainer.TabIndex = 9;
            // 
            // sfComboBox_comments
            // 
            this.sfComboBox_comments.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
            this.sfComboBox_comments.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.RightBottom;
            this.sfComboBox_comments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfComboBox_comments.Location = new System.Drawing.Point(102, 503);
            this.sfComboBox_comments.MaxDropDownItems = 10;
            this.sfComboBox_comments.Name = "sfComboBox_comments";
            this.sfComboBox_comments.ShowToolTip = true;
            this.sfComboBox_comments.Size = new System.Drawing.Size(24, 32);
            this.sfComboBox_comments.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfComboBox_comments.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfComboBox_comments.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfComboBox_comments.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox_comments.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfComboBox_comments.TabIndex = 11;
            // 
            // autoLabel_comments
            // 
            this.autoLabel_comments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel_comments.ForeColor = System.Drawing.Color.DimGray;
            this.autoLabel_comments.Location = new System.Drawing.Point(21, 510);
            this.autoLabel_comments.Name = "autoLabel_comments";
            this.autoLabel_comments.Size = new System.Drawing.Size(102, 25);
            this.autoLabel_comments.TabIndex = 16;
            this.autoLabel_comments.Text = "Comments";
            // 
            // sfComboBox_tags
            // 
            this.sfComboBox_tags.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.MultiSelection;
            this.sfComboBox_tags.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfComboBox_tags.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfComboBox_tags.Location = new System.Drawing.Point(247, 65);
            this.sfComboBox_tags.Name = "sfComboBox_tags";
            this.sfComboBox_tags.ShowToolTip = true;
            this.sfComboBox_tags.Size = new System.Drawing.Size(283, 32);
            this.sfComboBox_tags.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfComboBox_tags.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfComboBox_tags.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfComboBox_tags.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox_tags.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sfComboBox_tags.TabIndex = 14;
            // 
            // autoLabel_tags
            // 
            this.autoLabel_tags.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel_tags.ForeColor = System.Drawing.Color.DimGray;
            this.autoLabel_tags.Location = new System.Drawing.Point(205, 72);
            this.autoLabel_tags.Name = "autoLabel_tags";
            this.autoLabel_tags.Size = new System.Drawing.Size(49, 25);
            this.autoLabel_tags.TabIndex = 15;
            this.autoLabel_tags.Text = "Tags";
            // 
            // sfComboBox_category
            // 
            this.sfComboBox_category.DataSource = ((object)(resources.GetObject("sfComboBox_category.DataSource")));
            this.sfComboBox_category.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfComboBox_category.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox_category.Location = new System.Drawing.Point(102, 65);
            this.sfComboBox_category.Name = "sfComboBox_category";
            this.sfComboBox_category.Size = new System.Drawing.Size(83, 32);
            this.sfComboBox_category.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfComboBox_category.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox_category.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox_category.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox_category.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfComboBox_category.TabIndex = 13;
            // 
            // sfButton_save
            // 
            this.sfButton_save.AccessibleName = "Button";
            this.sfButton_save.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.sfButton_save.Location = new System.Drawing.Point(434, 503);
            this.sfButton_save.Name = "sfButton_save";
            this.sfButton_save.Size = new System.Drawing.Size(96, 32);
            this.sfButton_save.Style.BackColor = System.Drawing.Color.RoyalBlue;
            this.sfButton_save.Style.FocusedBackColor = System.Drawing.Color.DodgerBlue;
            this.sfButton_save.Style.FocusedForeColor = System.Drawing.Color.LightSlateGray;
            this.sfButton_save.Style.ForeColor = System.Drawing.Color.LightGray;
            this.sfButton_save.Style.HoverBackColor = System.Drawing.Color.SlateBlue;
            this.sfButton_save.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfButton_save.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sfButton_save.Style.PressedForeColor = System.Drawing.Color.Chartreuse;
            this.sfButton_save.TabIndex = 12;
            this.sfButton_save.Text = "Save";
            this.sfButton_save.Click += new System.EventHandler(this.sfButton_save_Click);
            // 
            // groupBox_content
            // 
            this.groupBox_content.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox_content.Controls.Add(this.textBoxExt_content);
            this.groupBox_content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_content.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_content.Location = new System.Drawing.Point(21, 110);
            this.groupBox_content.Name = "groupBox_content";
            this.groupBox_content.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_content.Size = new System.Drawing.Size(509, 387);
            this.groupBox_content.TabIndex = 10;
            this.groupBox_content.TabStop = false;
            this.groupBox_content.Text = "With Content";
            // 
            // textBoxExt_content
            // 
            this.textBoxExt_content.BeforeTouchSize = new System.Drawing.Size(272, 32);
            this.textBoxExt_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExt_content.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_content.Location = new System.Drawing.Point(6, 26);
            this.textBoxExt_content.Multiline = true;
            this.textBoxExt_content.Name = "textBoxExt_content";
            this.textBoxExt_content.Size = new System.Drawing.Size(497, 355);
            this.textBoxExt_content.TabIndex = 9;
            // 
            // sfButton_delete
            // 
            this.sfButton_delete.AccessibleName = "Button";
            this.sfButton_delete.BackColor = System.Drawing.Color.Red;
            this.sfButton_delete.Enabled = false;
            this.sfButton_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.sfButton_delete.ForeColor = System.Drawing.Color.Gainsboro;
            this.sfButton_delete.Location = new System.Drawing.Point(434, 27);
            this.sfButton_delete.Name = "sfButton_delete";
            this.sfButton_delete.Size = new System.Drawing.Size(96, 32);
            this.sfButton_delete.Style.BackColor = System.Drawing.Color.Red;
            this.sfButton_delete.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sfButton_delete.Style.FocusedForeColor = System.Drawing.Color.BlueViolet;
            this.sfButton_delete.Style.ForeColor = System.Drawing.Color.Gainsboro;
            this.sfButton_delete.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfButton_delete.Style.HoverForeColor = System.Drawing.Color.DarkSlateGray;
            this.sfButton_delete.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sfButton_delete.Style.PressedForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sfButton_delete.TabIndex = 7;
            this.sfButton_delete.Text = "Delete";
            this.sfButton_delete.UseVisualStyleBackColor = false;
            this.sfButton_delete.Click += new System.EventHandler(this.sfButton_delete_Click);
            // 
            // sfButton_new
            // 
            this.sfButton_new.AccessibleName = "Button";
            this.sfButton_new.BackColor = System.Drawing.Color.Green;
            this.sfButton_new.Enabled = false;
            this.sfButton_new.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.sfButton_new.ForeColor = System.Drawing.Color.LightGray;
            this.sfButton_new.Location = new System.Drawing.Point(341, 27);
            this.sfButton_new.Name = "sfButton_new";
            this.sfButton_new.Size = new System.Drawing.Size(96, 32);
            this.sfButton_new.Style.BackColor = System.Drawing.Color.Green;
            this.sfButton_new.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sfButton_new.Style.FocusedForeColor = System.Drawing.Color.DarkSeaGreen;
            this.sfButton_new.Style.ForeColor = System.Drawing.Color.LightGray;
            this.sfButton_new.Style.HoverBackColor = System.Drawing.Color.Lime;
            this.sfButton_new.Style.PressedBackColor = System.Drawing.Color.Aqua;
            this.sfButton_new.Style.PressedForeColor = System.Drawing.Color.RosyBrown;
            this.sfButton_new.TabIndex = 6;
            this.sfButton_new.Text = "New";
            this.sfButton_new.UseVisualStyleBackColor = false;
            this.sfButton_new.Click += new System.EventHandler(this.sfButton_new_Click);
            // 
            // textBoxExt_title
            // 
            this.textBoxExt_title.BeforeTouchSize = new System.Drawing.Size(272, 32);
            this.textBoxExt_title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt_title.Location = new System.Drawing.Point(63, 27);
            this.textBoxExt_title.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxExt_title.Name = "textBoxExt_title";
            this.textBoxExt_title.Size = new System.Drawing.Size(272, 32);
            this.textBoxExt_title.TabIndex = 5;
            // 
            // autoLabel_title
            // 
            this.autoLabel_title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel_title.ForeColor = System.Drawing.Color.DimGray;
            this.autoLabel_title.Location = new System.Drawing.Point(21, 34);
            this.autoLabel_title.Name = "autoLabel_title";
            this.autoLabel_title.Size = new System.Drawing.Size(48, 25);
            this.autoLabel_title.TabIndex = 4;
            this.autoLabel_title.Text = "Title";
            // 
            // groupBox_blogList
            // 
            this.groupBox_blogList.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox_blogList.Controls.Add(this.sfListView_blogList);
            this.groupBox_blogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_blogList.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_blogList.Location = new System.Drawing.Point(16, 94);
            this.groupBox_blogList.Name = "groupBox_blogList";
            this.groupBox_blogList.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_blogList.Size = new System.Drawing.Size(307, 447);
            this.groupBox_blogList.TabIndex = 10;
            this.groupBox_blogList.TabStop = false;
            this.groupBox_blogList.Text = "Blog List";
            // 
            // sfListView_blogList
            // 
            this.sfListView_blogList.AccessibleName = "ScrollControl";
            this.sfListView_blogList.BackColor = System.Drawing.SystemColors.Window;
            this.sfListView_blogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfListView_blogList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfListView_blogList.ItemHeight = 30D;
            this.sfListView_blogList.Location = new System.Drawing.Point(6, 29);
            this.sfListView_blogList.Name = "sfListView_blogList";
            this.sfListView_blogList.Size = new System.Drawing.Size(295, 412);
            this.sfListView_blogList.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sfListView_blogList.TabIndex = 0;
            this.sfListView_blogList.Text = "sfListView1";
            this.sfListView_blogList.DrawItem += new System.EventHandler<Syncfusion.WinForms.ListView.Events.DrawItemEventArgs>(this.sfListView_blogList_DrawItem);
            this.sfListView_blogList.DoubleClick += new System.EventHandler(this.sfListView_blogList_DoubleClick);
            // 
            // gradientPanelExt_blogListTitle
            // 
            this.gradientPanelExt_blogListTitle.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelExt_blogListTitle.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt_blogListTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt_blogListTitle.Controls.Add(this.autoLabel_blogListTitle);
            this.gradientPanelExt_blogListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelExt_blogListTitle.Location = new System.Drawing.Point(16, 10);
            this.gradientPanelExt_blogListTitle.Name = "gradientPanelExt_blogListTitle";
            this.gradientPanelExt_blogListTitle.Size = new System.Drawing.Size(307, 84);
            this.gradientPanelExt_blogListTitle.TabIndex = 9;
            // 
            // autoLabel_blogListTitle
            // 
            this.autoLabel_blogListTitle.AutoSize = false;
            this.autoLabel_blogListTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoLabel_blogListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel_blogListTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.autoLabel_blogListTitle.Location = new System.Drawing.Point(0, 0);
            this.autoLabel_blogListTitle.Name = "autoLabel_blogListTitle";
            this.autoLabel_blogListTitle.Size = new System.Drawing.Size(307, 84);
            this.autoLabel_blogListTitle.TabIndex = 9;
            this.autoLabel_blogListTitle.Text = "All My Heart Blood";
            this.autoLabel_blogListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.gradientPanelExt_container);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CEditor";
            this.Size = new System.Drawing.Size(909, 557);
            this.Load += new System.EventHandler(this.CEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_container)).EndInit();
            this.gradientPanelExt_container.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox_comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox_tags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox_category)).EndInit();
            this.groupBox_content.ResumeLayout(false);
            this.groupBox_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_content)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt_title)).EndInit();
            this.groupBox_blogList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt_blogListTitle)).EndInit();
            this.gradientPanelExt_blogListTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_category;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt_container;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox_blogList;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt_blogListTitle;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_blogListTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_content;
        private Syncfusion.WinForms.Controls.SfButton sfButton_delete;
        private Syncfusion.WinForms.Controls.SfButton sfButton_new;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt_title;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_title;
        private Syncfusion.WinForms.Controls.SfButton sfButton_save;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox_comments;
        private System.Windows.Forms.GroupBox groupBox_content;
        private Syncfusion.WinForms.ListView.SfListView sfListView_blogList;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox_tags;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_tags;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox_category;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel_comments;
    }
}
