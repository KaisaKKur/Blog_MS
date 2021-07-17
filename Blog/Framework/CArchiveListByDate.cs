using Blog.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog.Framework {
    public partial class CArchiveListByDate : UserControl {
        public static string _startDate;
        public static string _endDate;

        /* Property
         */
        public static string StartEnd {
            get => _startDate;
            set => _startDate = value;
        }

        public static string EndDate {
            get => _endDate;
            set => _endDate = value;
        }

        public CArchiveListByDate() {
            InitializeComponent();
        }

        private void resetDate() {
            _startDate = string.Empty;
            _endDate = string.Empty;
        }

        private void CArchiveListByDate_Load(object sender, EventArgs e) {
            addAside();
            addArchiveListBlogByDate();
        }

        public void addArchiveListBlogByDate() {
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getArchiveListBlogByDate(out MySqlDataReader DR, _startDate, _endDate);
                while (DR.Read()) {
                    groupView_blogListByArchiveDate.GroupViewItems.Add(
                        new Syncfusion.Windows.Forms.Tools.GroupViewItem() {
                            Text = DR[2].ToString() + "          |- " + "View:" + DR[4] + "  ^  " + "LK:" + DR[5] + "  ^  " + "Date:" + DR[3] + "-|",
                            Tag = DR[0]
                        }
                    );
                }
                DR.Close();
                resetDate();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addAside() {
            CAside aside = new CAside();
            aside.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Add(aside);
        }

        private void groupView_blogListByArchiveDate_GroupViewItemDoubleClick(Syncfusion.Windows.Forms.Tools.GroupView sender, Syncfusion.Windows.Forms.Tools.GroupViewItemDoubleClickEventArgs e) {
            string itemName = sender.GroupViewItems[sender.SelectedItem].Tag.ToString();
            CEditor.BlogArticleID = Convert.ToUInt32(itemName);

            ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.Editor;
        }
    }
}
