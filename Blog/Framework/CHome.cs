using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using Blog.Core;

namespace Blog.Framework {
    public partial class CHome : UserControl {
        public CHome() {
            InitializeComponent();
        }

        public void addAside() {
            CAside aside = new CAside();
            aside.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Add(aside);
        }

        public void addLatestBlogList() {
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getBlogArticles(out MySqlDataReader DR);
                while (DR.Read()) {
                    groupView_latestBlogList.GroupViewItems.Add(
                        new Syncfusion.Windows.Forms.Tools.GroupViewItem() {
                            Text = DR[2].ToString() + "          |- " + "View:" + DR[4] + "  ^  " + "LK:" + DR[5] + "  ^  " + "Date:" + DR[3] + "-|",
                            Tag = DR[0]
                        }
                    );
                }
                DR.Close();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupView_latestBlogList_GroupViewItemDoubleClick(Syncfusion.Windows.Forms.Tools.GroupView sender, Syncfusion.Windows.Forms.Tools.GroupViewItemDoubleClickEventArgs e) {
            string itemName = sender.GroupViewItems[sender.SelectedItem].Tag.ToString();
            CEditor.BlogArticleID = Convert.ToUInt32(itemName);

            ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.Editor;
        }

        private void CHome_Load(object sender, EventArgs e) {
            addAside();
            addLatestBlogList();
        }
    }
}
