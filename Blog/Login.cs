using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Syncfusion.WinForms.Controls;

using MySql.Data.MySqlClient;

using KKur.MySQL.Crypt;

using Blog.Core;
using Account = Blog.Core.Account;
using System.Net;

namespace Blog {
    public partial class Login : SfForm {
        public Login() {
            InitializeComponent();
        }

        private void sfButton_login_Click(object sender, EventArgs e) {
            try {
                if (!textBoxExt_username.Text.Equals(string.Empty)) {
                    string getIDByUsernameSQL = "SELECT ID FROM Users WHERE Username = @username LIMIT 1";
                    BlogMySQL blogMySQL = new BlogMySQL();
                    MySqlCommand getIDByUsernameCMD = new MySqlCommand(getIDByUsernameSQL, blogMySQL.MySQL.Connection);
                    getIDByUsernameCMD.Parameters.AddWithValue("@username", textBoxExt_username.Text);
                    UInt32 ID = Convert.ToUInt32(getIDByUsernameCMD.ExecuteScalar());
                    if (ID > 0) {
                        if (!textBoxExt_password.Text.Equals(string.Empty)) {
                            string getPasswordByUsernameSQL = "SELECT Password, Nickname FROM Users WHERE Username = @username LIMIT 1";
                            MySqlCommand CMD = new MySqlCommand(getPasswordByUsernameSQL, blogMySQL.MySQL.Connection);
                            CMD.Parameters.AddWithValue("@username", textBoxExt_username.Text);
                            MySqlDataReader DR = CMD.ExecuteReader();
                            string passwordSHA1 = Crypt.stringHashSHA1(textBoxExt_password.Text);
                            while (DR.Read()) {
                                if (passwordSHA1.Equals(DR[0].ToString())) {
                                    Account.ID = ID;
                                    Account.Username = textBoxExt_username.Text;
                                    Account.Nickname = DR[1].ToString();

                                    string getLogCount = "SELECT Count(*) FROM User_Login_Logs WHERE UserID = @userID AND LoginIP = @loginIP";
                                    BlogMySQL getLogCountBlogMySQL = new BlogMySQL();
                                    MySqlCommand getLogCountCMD = new MySqlCommand(getLogCount, getLogCountBlogMySQL.MySQL.Connection);
                                    getLogCountCMD.Parameters.AddWithValue("@userID", ID);
                                    getLogCountCMD.Parameters.AddWithValue("@loginIP", IPAddress.Loopback);
                                    object count = getLogCountCMD.ExecuteScalar();
                                    UInt32 logCount = Convert.ToUInt32(count);
                                    if (logCount > 0) {
                                        string updateLog = "UPDATE User_Login_Logs SET AutoLogin = @autoLogin, UserPassword = @userPassword, LoginDate = CURRENT_TIMESTAMP WHERE UserID = @userID AND LoginIP = @loginIP";
                                        BlogMySQL updateLogBlogMySQL = new BlogMySQL();
                                        MySqlCommand updateLogCMD = new MySqlCommand(updateLog, updateLogBlogMySQL.MySQL.Connection);
                                        updateLogCMD.Parameters.AddWithValue("@autoLogin", checkBoxAdv_rememberMe.Checked);
                                        updateLogCMD.Parameters.AddWithValue("@userPassword", passwordSHA1);
                                        updateLogCMD.Parameters.AddWithValue("@userID", ID);
                                        updateLogCMD.Parameters.AddWithValue("@loginIP", IPAddress.Loopback);
                                        updateLogCMD.ExecuteNonQuery();
                                    } else {
                                        string insertUserLoginLogsSQL = "INSERT INTO User_Login_Logs(UserID, LoginIP, AutoLogin, UserPassword) VALUES (@userID, @loginIP, @autoLogin, @userPassword)";
                                        BlogMySQL insertUserLoginLogsBlogMySQL = new BlogMySQL();
                                        MySqlCommand insertUserLoginLogsCMD = new MySqlCommand(insertUserLoginLogsSQL, insertUserLoginLogsBlogMySQL.MySQL.Connection);
                                        insertUserLoginLogsCMD.Parameters.AddWithValue("@userID", ID);
                                        insertUserLoginLogsCMD.Parameters.AddWithValue("@loginIP", IPAddress.Loopback);
                                        if (checkBoxAdv_rememberMe.Checked) {
                                            insertUserLoginLogsCMD.Parameters.AddWithValue("@autoLogin", true);
                                        } else {
                                            insertUserLoginLogsCMD.Parameters.AddWithValue("@autoLogin", false);
                                        }
                                        insertUserLoginLogsCMD.Parameters.AddWithValue("@userPassword", passwordSHA1);
                                        insertUserLoginLogsCMD.ExecuteNonQuery();
                                    }

                                    ApplicationStatus.ApplicationProcess = ApplicationProcess.MainForm;
                                    Close();
                                } else {
                                    DR.Close();
                                    throw new Exception("Sorry, the password is wrong.");
                                }
                            }
                        } else {
                            throw new Exception("Sorry, the password cannot be empty.");
                        }
                    } else {
                        throw new Exception("Sorry, the user does not exist.");
                    }
                } else {
                    throw new Exception("Sorry, the username cannot be empty.");
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ApplicationStatus.ApplicationProcess = ApplicationProcess.Signup;
            Close();
        }

        private void timer_autoLogin_Tick(object sender, EventArgs e) {
            timer_autoLogin.Enabled = true;
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getUserLoginLogByLoginIP(out MySqlDataReader DR, IPAddress.Loopback.ToString());
                while (DR.Read()) {
                    if (Convert.ToBoolean(DR[1])) {
                        if (!DR[2].ToString().Equals(string.Empty)) {
                            Account.ID = Convert.ToUInt32(DR[0]);

                            BlogMySQL getUserBlogMySQL = new BlogMySQL();
                            getUserBlogMySQL.getUserByID(out MySqlDataReader getUserDR, Convert.ToUInt32(DR[0]));
                            while (getUserDR.Read()) {
                                Account.Username = getUserDR[0].ToString();
                                Account.Nickname = getUserDR[1].ToString();
                            }
                            getUserDR.Close();

                            ApplicationStatus.ApplicationProcess = ApplicationProcess.MainForm;
                            Close();
                        } else {
                            BlogMySQL getUserBlogMySQL = new BlogMySQL();
                            getUserBlogMySQL.getUserByID(out MySqlDataReader getUserDR, Convert.ToUInt32(DR[0]));

                            while (getUserDR.Read()) {
                                textBoxExt_username.Text = getUserDR[0].ToString();
                                textBoxExt_username.SelectionStart = textBoxExt_username.TextLength;
                            }
                            getUserDR.Close();
                        }
                    }
                }
                DR.Close();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer_autoLogin.Enabled = false;
        }

        private void Login_Load(object sender, EventArgs e) {
            checkedRememberMe();
        }

        private void checkedRememberMe() {
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getUserLoginLogByLoginIP(out MySqlDataReader DR, IPAddress.Loopback.ToString());
                while (DR.Read()) {
                    if (Convert.ToBoolean(DR[1])) {
                        checkBoxAdv_rememberMe.Checked = true;
                    }
                }
                DR.Close();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
