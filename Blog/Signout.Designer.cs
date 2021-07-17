
namespace Blog {
    partial class Signout {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signout));
            this.label_goodbye = new System.Windows.Forms.Label();
            this.button_signout = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_goodbye
            // 
            this.label_goodbye.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_goodbye.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_goodbye.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label_goodbye.Location = new System.Drawing.Point(2, 2);
            this.label_goodbye.Name = "label_goodbye";
            this.label_goodbye.Size = new System.Drawing.Size(454, 135);
            this.label_goodbye.TabIndex = 0;
            this.label_goodbye.Text = "Goodbye";
            this.label_goodbye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_signout
            // 
            this.button_signout.BackColor = System.Drawing.Color.Orchid;
            this.button_signout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signout.ForeColor = System.Drawing.Color.White;
            this.button_signout.Location = new System.Drawing.Point(214, 157);
            this.button_signout.Name = "button_signout";
            this.button_signout.Size = new System.Drawing.Size(111, 40);
            this.button_signout.TabIndex = 1;
            this.button_signout.Text = "Sign out";
            this.button_signout.UseVisualStyleBackColor = false;
            this.button_signout.Click += new System.EventHandler(this.button_signout_Click);
            // 
            // button_no
            // 
            this.button_no.BackColor = System.Drawing.Color.Orchid;
            this.button_no.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_no.ForeColor = System.Drawing.Color.White;
            this.button_no.Location = new System.Drawing.Point(97, 157);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(111, 40);
            this.button_no.TabIndex = 0;
            this.button_no.Text = "NO!!!";
            this.button_no.UseVisualStyleBackColor = false;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
            // 
            // Signout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(458, 275);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_signout);
            this.Controls.Add(this.label_goodbye);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Signout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style.BackColor = System.Drawing.Color.GhostWhite;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.BackColor = System.Drawing.Color.White;
            this.Style.TitleBar.CloseButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.MaximizeButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.MinimizeButtonForeColor = System.Drawing.Color.DimGray;
            this.Style.TitleBar.TextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text = "Blog Signout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_goodbye;
        private System.Windows.Forms.Button button_signout;
        private System.Windows.Forms.Button button_no;
    }
}