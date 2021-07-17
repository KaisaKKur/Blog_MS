using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Blog.Core;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Blog.AdminGroup {
    public partial class Admin : SfForm {
        private readonly TCP _TCP;
        private readonly Thread _server;
        private readonly Thread _client;
        private const string _space = "                    ";

        public Admin() {
            InitializeComponent();

            _TCP = new TCP();

            _server = new Thread(_TCP.server);
            _server.Start();

            _TCP.onReceivedMessage += _TCP_onReceivedMessage;

            _client = new Thread(_TCP.client);
            _client.Start();
        }

        private void _TCP_onReceivedMessage(TCP TCP, string receivedMessage) {
            try {
                UInt32 userID1 = Convert.ToUInt32(receivedMessage.Split(new char[] { ':' }, 3)[0]);
                UInt32 userID2 = Convert.ToUInt32(receivedMessage.Split(new char[] { ':' }, 3)[1]);
                string SQL = "INSERT INTO User_Chats(UserID1, UserID2, Chat) VALUES ({0}, {1}, '{2}')";
                SQL = string.Format(SQL, userID1, userID2, receivedMessage);
                BlogMySQL blogMySQL = new BlogMySQL();
                MySqlCommand CMD = new MySqlCommand(SQL, blogMySQL.MySQL.Connection);
                if (CMD.ExecuteNonQuery() > 0) {
                }

                string username = blogMySQL.getUsernameByID(userID1);

                if (username.Equals(this.Text)) {
                    if (userID2 == Account.ID) {
                        string nickname = blogMySQL.getNicknameByID(userID1);
                        string name;
                        if (nickname.Equals(string.Empty)) {
                            name = username;
                        } else {
                            name = nickname;
                        }
                        textBoxExt_chat.Text += name + ": " + receivedMessage.Split(new char[] { ':' }, 3)[2] + _space + "--- On: " + DateTime.Now.ToString() + "\r\n";
                    }
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfButton_send_Click(object sender, EventArgs e) {
            if (!this.Text.Equals("Admin")) {
                BlogMySQL getUersIDBlogMySQL = new BlogMySQL();
                UInt32 userID = getUersIDBlogMySQL.getUserIDByUsername(this.Text);
                _TCP.sendString(Account.ID + ":" + userID + ":" + textBoxExt_editor.Text);
                string name;
                if (Account.Nickname.Equals(string.Empty)) {
                    name = Account.Username;
                } else {
                    name = Account.Nickname;
                }
                textBoxExt_chat.Text += name + ": " + textBoxExt_editor.Text + _space + "--- On: " + DateTime.Now.ToString() + "\r\n";
            }
        }

        private void AdminGroupChat_FormClosed(object sender, FormClosedEventArgs e) {
            if (_server.IsAlive) {
                _server.Abort();
            }

            if (_client.IsAlive) {
                _client.Abort();
            }

            if (_TCP != null) {
                _TCP.destroy();
            }
        }

        private void Admin_Load(object sender, EventArgs e) {
            loadUsers();
        }

        private void loadUsers() {
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getUsernames(out MySqlDataReader DR);
                UInt32 i = 0;
                while (DR.Read()) {
                    if (!DR[0].ToString().Equals(Account.Username)) {
                        SfButton sfButton = new SfButton {
                            Location = new Point(0, (int)(i * 50)),
                            Size = new Size(225, 50),
                            Name = DR[0].ToString(),
                            Text = DR[1].ToString().Equals(string.Empty) ? DR[0].ToString() : DR[1].ToString(),
                            Anchor = AnchorStyles.Left | AnchorStyles.Right
                        };
                        sfButton.Click += SfButton_user_Click;
                        gradientPanel_user.Controls.Add(sfButton);
                        i++;
                    }
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SfButton_user_Click(object sender, EventArgs e) {
            try {
                if (!this.Text.Equals(((SfButton)sender).Name)) {
                    textBoxExt_chat.Clear();
                    this.Text = ((SfButton)sender).Name;

                    BlogMySQL blogMySQL = new BlogMySQL();
                    blogMySQL.getUserChatsByUsername(out MySqlDataReader DR, ((SfButton)sender).Name);

                    BlogMySQL getNickname = new BlogMySQL();
                    while (DR.Read()) {
                        UInt32 userID = Convert.ToUInt32(DR[0].ToString().Split(new char[] { ':' }, 3)[0]);
                        string nickname = getNickname.getNicknameByID(userID);
                        string username = getNickname.getUsernameByID(userID);
                        string message = DR[0].ToString().Split(new char[] { ':' }, 3)[2];
                        string name;
                        if (nickname.Equals(string.Empty)) {
                            name = username;
                        } else {
                            name = nickname;
                        }
                        textBoxExt_chat.Text += name + ": " + message + _space + "--- On: " + DR[1] + "\r\n";
                    }
                    DR.Close();
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
