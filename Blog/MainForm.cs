using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Blog.Framework;
using Blog.Core;
using MySql.Data.MySqlClient;
using System.Net;

namespace Blog {
    public partial class MainForm : SfForm {
        private ApplicationWorkProcess _priorApplicationWorkProcess;
        private ApplicationWorkProcess _applicationWorkProcess;

        public MainForm() {
            InitializeComponent();

            _applicationWorkProcess = ApplicationWorkProcess.Idle;
            _priorApplicationWorkProcess = ApplicationWorkProcess.Idle;

            ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.Home;
        }

        private void gotoHome() {
            Panel mask = new Panel();
            mask.BackColor = Color.White;
            mask.Dock = DockStyle.Fill;
            Controls.Add(mask);

            CHeader header = new CHeader {
                Dock = DockStyle.Top
            };

            CHome home = new CHome {
                Dock = DockStyle.Fill
            };

            Controls.Add(home);
            Controls.Add(header);

            Controls.Remove(mask);
        }

        private void gotoProfile() {
            Panel mask = new Panel();
            mask.BackColor = Color.White;
            mask.Dock = DockStyle.Fill;
            Controls.Add(mask);

            CHeader header = new CHeader {
                Dock = DockStyle.Top
            };

            CProfile profile = new CProfile {
                Dock = DockStyle.Fill
            };

            Controls.Add(profile);
            Controls.Add(header);

            Controls.Remove(mask);
        }

        private void gotoEditor() {
            Panel mask = new Panel();
            mask.BackColor = Color.White;
            mask.Dock = DockStyle.Fill;
            Controls.Add(mask);

            CHeader header = new CHeader {
                Dock = DockStyle.Top
            };

            CEditor editor = new CEditor {
                Dock = DockStyle.Fill
            };

            editor.Visible = true;

            Controls.Add(editor);
            Controls.Add(header);

            Controls.Remove(mask);
        }

        private void gotoArchiveListByDate() {
            Panel mask = new Panel();
            mask.BackColor = Color.White;
            mask.Dock = DockStyle.Fill;
            Controls.Add(mask);

            CHeader header = new CHeader {
                Dock = DockStyle.Top
            };

            CArchiveListByDate archiveListByDate = new CArchiveListByDate {
                Dock = DockStyle.Fill
            };

            Controls.Add(archiveListByDate);
            Controls.Add(header);

            CAside aside = new CAside {
                Dock = DockStyle.Fill
            };
            SplitContainer splitContainer = (SplitContainer)archiveListByDate.Controls["gradientPanelExt_container"].Controls["splitContainer"];
            splitContainer.Panel2.Controls.Add(aside);

            Controls.Remove(mask);
        }

        private void showSignout() {
            try {
                string updateLog = "UPDATE User_Login_Logs SET UserPassword = DEFAULT, LoginDate = CURRENT_TIMESTAMP WHERE UserID = @userID AND LoginIP = @loginIP";
                BlogMySQL updateLogBlogMySQL = new BlogMySQL();
                MySqlCommand updateLogCMD = new MySqlCommand(updateLog, updateLogBlogMySQL.MySQL.Connection);
                updateLogCMD.Parameters.AddWithValue("@userID", Account.ID);
                updateLogCMD.Parameters.AddWithValue("@loginIP", IPAddress.Loopback);
                updateLogCMD.ExecuteNonQuery();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Signout signout = new Signout();
            DialogResult dialogResult = signout.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                ApplicationStatus.ApplicationProcess = ApplicationProcess.Signout;
            } else if (dialogResult == DialogResult.Cancel) {
                _applicationWorkProcess = _priorApplicationWorkProcess;
                ApplicationWorkStatus.ApplicationWorkProcess = _priorApplicationWorkProcess;
            }
        }

        private void timer_applicationWorkStatus_Tick(object sender, EventArgs e) {
            if (_applicationWorkProcess != ApplicationWorkStatus.ApplicationWorkProcess) {
                _priorApplicationWorkProcess = _applicationWorkProcess;
                _applicationWorkProcess = ApplicationWorkStatus.ApplicationWorkProcess;
                switchWorkProcess();
            }

            if (CHeader.IsAccountNameNeedRefresh) {
                this.Controls["CHeader"].Controls["gradientPanelExt_container"].Controls["splitButton_account"].Text
                    = Account.Nickname.Equals(string.Empty) ? Account.Username : Account.Nickname;
                CHeader.IsAccountNameNeedRefresh = false;
            }
        }

        private void switchWorkProcess() {
            switch (_applicationWorkProcess) {
                case ApplicationWorkProcess.Home:
                    this.Controls.Clear();
                    gotoHome();
                    break;

                case ApplicationWorkProcess.Profile:
                    this.Controls.Clear();
                    gotoProfile();
                    break;

                case ApplicationWorkProcess.Editor:
                    this.Controls.Clear();
                    gotoEditor();
                    break;

                case ApplicationWorkProcess.Signout:
                    showSignout();
                    break;

                case ApplicationWorkProcess.ArchiveListByDate:
                    this.Controls.Clear();
                    gotoArchiveListByDate();
                    _applicationWorkProcess = ApplicationWorkProcess.Idle;
                    _priorApplicationWorkProcess = _applicationWorkProcess;
                    ApplicationWorkStatus.ApplicationWorkProcess = ApplicationWorkProcess.Idle;
                    break;

                case ApplicationWorkProcess.Idle:
                    break;

                default:
                    break;
            }
        }
    }
}
