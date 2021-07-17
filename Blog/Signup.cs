using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blog.Core;
using KKur.MySQL.Crypt;
using MySql.Data.MySqlClient;
using Syncfusion.WinForms.Controls;

namespace Blog {
    public partial class Signup : SfForm {
        public Signup() {
            InitializeComponent();
        }

        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ApplicationStatus.ApplicationProcess = ApplicationProcess.Login;
            Close();
        }

        private void sfButton_signup_Click(object sender, EventArgs e) {
            try {
                bool isPass = false;
                BlogMySQL getVerificationCode = new BlogMySQL();
                getVerificationCode.getVerificationCode(out MySqlDataReader DR);
                while (DR.Read()) {
                    if (textBoxExt_verificationCode.Text.Equals(DR[0].ToString())) {
                        isPass = true;
                        break;
                    }
                }
                DR.Close();

                if (isPass) {
                    string SQL = "INSERT INTO Users(Username, Password, Email) VALUES (@username, @password, @email)";
                    BlogMySQL blogMySQL = new BlogMySQL();
                    MySqlCommand CMD = new MySqlCommand(SQL, blogMySQL.MySQL.Connection);

                    if (textBoxExt_username.TextLength >= 6 && textBoxExt_username.Text.Length <= 30) {
                        if (KKur.MySQL.Validate.Validate.username(textBoxExt_username.Text)) {
                            string isTaken = "SELECT COUNT(Username) FROM Users WHERE Username = @username";
                            BlogMySQL isTakenBlogMySQL = new BlogMySQL();
                            MySqlCommand isTakenCMD = new MySqlCommand(isTaken, isTakenBlogMySQL.MySQL.Connection);
                            isTakenCMD.Parameters.AddWithValue("@username", textBoxExt_username.Text);
                            object isTakenUsername = isTakenCMD.ExecuteScalar();
                            if (Convert.ToUInt16(isTakenUsername) == 0) {
                                CMD.Parameters.AddWithValue("@username", textBoxExt_username.Text);
                            } else {
                                throw new Exception("Sorry, the username is taken.");
                            }
                        } else {
                            throw new Exception("Sorry, the username is invalid.");
                        }
                    } else {
                        throw new Exception("Sorry, the username cannot be empty, and it should be 6-40 characters long.");
                    }

                    if (textBoxExt_email.Text.Length <= 40) {
                        if (KKur.MySQL.Validate.Validate.email(textBoxExt_email.Text)) {
                            CMD.Parameters.AddWithValue("@email", textBoxExt_email.Text);
                        } else {
                            throw new Exception("Sorry, the email is invalid.");
                        }
                    } else {
                        throw new Exception("Sorry, the email can not longer than 40 characters.");
                    }

                    if (KKur.MySQL.Validate.Validate.password(textBoxExt_password.Text)) {
                        if (textBoxExt_confirmPassword.Text.Equals(textBoxExt_password.Text)) {
                            CMD.Parameters.AddWithValue("@password", Crypt.stringHashSHA1(textBoxExt_password.Text));
                        } else {
                            throw new Exception("Sorry, the confirm password do not match.");
                        }
                    } else {
                        throw new Exception("Sorry, the password is invalid. It should be 8-40 characters long.");
                    }

                    if (CMD.ExecuteNonQuery() == 1) {
                        MessageBox.Show("Sign up succeeded. Welcome!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Account.ID = (UInt32)CMD.LastInsertedId;
                        Account.Username = textBoxExt_username.Text;
                        ApplicationStatus.ApplicationProcess = ApplicationProcess.MainForm;
                    }
                } else {
                    throw new Exception("Sorry, the verification code do not match.");
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
