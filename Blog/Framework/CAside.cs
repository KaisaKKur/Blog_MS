using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KKur.MySQL.DateTime;
using DateTime = KKur.MySQL.DateTime.DateTime;

namespace Blog.Framework {
    public partial class CAside : UserControl {
        public CAside() {
            InitializeComponent();
        }

        private void linkLabel_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/Kaisa-K-Kur");
        }

        private void linkLabel_twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string _403_html = Application.StartupPath + "/Error/403.html";
            if (File.Exists(_403_html)) {
                System.Diagnostics.Process.Start(_403_html);
            }
        }

        private void linkLabel_archiveDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string[] date = ((LinkLabel)sender).Text.Split(' ');
            UInt16 monthStart = DateTime.properNounToDigit(date[0]);
            UInt16 yearStart = Convert.ToUInt16(date[1]);
            UInt16 skip = 1;
            UInt16 monthEnd = (UInt16)((monthStart + skip) <= 12 ? (monthStart + skip) : 1);
            UInt16 yearEnd = (UInt16)(monthStart < monthEnd ? yearStart : yearStart + 1);
            string archiveDateStart = yearStart + "-" + monthStart + "-" + "1";
            string archiveDateEnd = yearEnd + "-" + monthEnd + "-" + "1";

            CArchiveListByDate.StartEnd = archiveDateStart;
            CArchiveListByDate.EndDate = archiveDateEnd;
            ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.ArchiveListByDate;
        }
    }
}
