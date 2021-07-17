using Blog.Core;
using KKur.MySQL.Crypt;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog.Framework {
    public partial class CProfile : UserControl {
        public CProfile() {
            InitializeComponent();
        }

        private void CProfile_Load(object sender, EventArgs e) {
            loadUserProfile();

            sfButton_profile_save.Enabled = false;
        }

        private void loadUserProfile() {
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getUserProfileByID(out MySqlDataReader DR, Account.ID);
                while (DR.Read()) {
                    textBoxExt_nickname.Text = DR[1].ToString();
                    textBoxExt_email.Text = DR[2].ToString();
                    textBoxExt_phoneNumber.Text = DR[3].ToString();

                    if (!DR[5].ToString().Equals(string.Empty)) {
                        dateTimePicker_birthday.Value = DateTime.Parse(DR[4].ToString());
                    } else {
                        dateTimePicker_birthday.Value = dateTimePicker_birthday.MinDate;
                    }

                    string sex = null;
                    if (!DR[5].ToString().Equals(string.Empty)) { 
                        if ((bool)DR[5]) {
                            sex = "Man";
                        } else {
                            sex = "Woman";
                        }
                    } else {
                        sex = string.Empty;
                    }
                    sfComboBox_age.Text = sex;
                }
                DR.Close();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfButton_profile_save_Click(object sender, EventArgs e) {
                string SQL = "UPDATE Users SET Nickname = @nickname, Email = @email, PhoneNumber = @phoneNumber, Birthday = @birthday, Sex = {0} WHERE ID = {1}";
                
                string sex;
                if (!sfComboBox_age.Text.Equals(string.Empty)) {
                    if (sfComboBox_age.Text.Equals("Man")) {
                        sex = "1";
                    } else {
                        sex = "0";
                    }
                } else {
                    sex = "DEFAULT";
                }

                SQL = string.Format(SQL, sex, Account.ID);

            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                MySqlCommand CMD = new MySqlCommand(SQL, blogMySQL.MySQL.Connection);

                if (textBoxExt_nickname.Text.Length <= 30) {
                    if (KKur.MySQL.Validate.Validate.nickname(textBoxExt_nickname.Text)) {
                        CMD.Parameters.AddWithValue("@nickname", textBoxExt_nickname.Text);
                    } else {
                        throw new Exception("Sorry, the nickname is invalid.");
                    }
                } else {
                    throw new Exception("Sorry, the nickname can be empty, but not longer than 30 characters.");
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

                if (textBoxExt_phoneNumber.Text.Length >= 7 && textBoxExt_phoneNumber.Text.Length <= 20) {
                    if (KKur.MySQL.Validate.Validate.phoneNumber(textBoxExt_phoneNumber.Text)) {
                        CMD.Parameters.AddWithValue("@phoneNumber", textBoxExt_phoneNumber.Text);
                    } else {
                        throw new Exception("Sorry, the phone number is invalid.");
                    }
                } else {
                    throw new Exception("Sorry, the phone number is invalid. It should be 7-20 characters long.");
                }

                CMD.Parameters.AddWithValue("@birthday", dateTimePicker_birthday.Value);

                if (CMD.ExecuteNonQuery() == 1) {
                    MessageBox.Show("Update succeeded.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sfButton_profile_save.Enabled = false;
                    Account.Nickname = textBoxExt_nickname.Text;
                    CHeader.IsAccountNameNeedRefresh = true;
                } else {
                    throw new Exception("Sorry, update failed.");
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxExt_profile_TextChanged(object sender, EventArgs e) {
            sfButton_profile_save.Enabled = true;
        }

        private void dateTimePicker_birthday_ValueChanged(object sender, EventArgs e) {
            sfButton_profile_save.Enabled = true;
        }

        private void sfComboBox_age_SelectedIndexChanged(object sender, EventArgs e) {
            sfButton_profile_save.Enabled = true;
        }

        private void sfButton_securitySetting_Save_Click(object sender, EventArgs e) {
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getUserProfileByID(out MySqlDataReader DR, Account.ID);
                string password = string.Empty;

                while (DR.Read()) {
                    password = DR[0].ToString();
                }
                DR.Close();

                if (Crypt.stringHashSHA1(textBoxExt_oldPassword.Text).Equals(password)) {
                    if (textBoxExt_newPassword.TextLength >= 8 && textBoxExt_newPassword.TextLength <= 40) {
                        if (KKur.MySQL.Validate.Validate.password(textBoxExt_newPassword.Text)) {
                            if (textBoxExt_confirmNewPassword.Text.Equals(textBoxExt_newPassword.Text)) {
                                string SQL = "UPDATE Users SET Password = @password WHERE ID = {0}";
                                SQL = string.Format(SQL, Account.ID);
                                MySqlCommand CMD = new MySqlCommand(SQL, blogMySQL.MySQL.Connection);
                                CMD.Parameters.AddWithValue("@password", Crypt.stringHashSHA1(textBoxExt_newPassword.Text));
                                if (CMD.ExecuteNonQuery() == 1) {
                                    MessageBox.Show("Update succeeded.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    textBoxExt_oldPassword.Clear();
                                    textBoxExt_newPassword.Clear();
                                    textBoxExt_confirmNewPassword.Clear();
                                    sfButton_securitySetting_Save.Enabled = false;
                                } else {
                                    throw new Exception("Sorry, update failed.");
                                }
                            } else {
                                throw new Exception("Sorry, the confirm password do not match.");
                            }
                        } else {
                            throw new Exception("Sorry, the new password is invalid");
                        }
                    } else {
                        throw new Exception("Sorry, the new password is invalid. It should be 8-40 characters long.");
                    }
                } else {
                    throw new Exception("Sorry, please enter your old password correctly.");
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxExt_securitySetting_TextChanged(object sender, EventArgs e) {
            sfButton_securitySetting_Save.Enabled = true;
        }
    }
}
