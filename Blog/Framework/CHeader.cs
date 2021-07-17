using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KKur.MySQL;

using Blog.Core;
using Account = Blog.Core.Account;

namespace Blog.Framework {
    public partial class CHeader : UserControl {
        private static bool _isAccountNameNeedRefresh;

        /* Property
         */
        public static bool IsAccountNameNeedRefresh {
            get => _isAccountNameNeedRefresh;
            set => _isAccountNameNeedRefresh = value;
        }

        public CHeader() {
            InitializeComponent();

            showAccountName();
            _isAccountNameNeedRefresh = false;
        }

        public void showAccountName() {
            this.Controls["gradientPanelExt_container"].Controls["splitButton_account"].Text
                = Account.Nickname.Equals(string.Empty) ? Account.Username : Account.Nickname;
        }

        private void linkLabel_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.Home;
        }

        private void splitButton_account_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            switchApplicationWorkProcessByDropDowItemText(e.ClickedItem.Text);
        }

        private void switchApplicationWorkProcessByDropDowItemText(string dropDowItemName) {
            switch (dropDowItemName) {
                case "Profile":
                    ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.Profile;
                    break;

                case "Editor":
                    ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.Editor;
                    break;

                case "管理员":
                    ApplicationStatus.ApplicationProcess = ApplicationProcess.AdminChat;
                    break;

                case "Sign out":
                    ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.Signout;
                    break;

                default:
                    break;
            }
        }
    }
}
