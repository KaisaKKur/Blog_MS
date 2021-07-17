using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using KKur.MySQL;

namespace Blog.Core {
    class BlogMySQL {
        private KKur.MySQL.Account _account;
        private MySQL _MySQL;

        public BlogMySQL() {
            _account = new KKur.MySQL.Account("localhost", "Kaisa", "KaisaArrived.", "Blog");
            _MySQL = new MySQL(_account);
        }

        /* Property
         */
        public KKur.MySQL.Account Account {
            get => _account;
        }

        public MySQL MySQL {
            get => _MySQL;
        }

        public void getBlogArticleByID(out MySqlDataReader DR, UInt32 blogArticleID) {
            string SQL = "SELECT CategoryID, Title, Content, Date, PageView, LikeCount FROM Blog_Articles WHERE ID = {0} AND UserID = {1} LIMIT 1";
            SQL = string.Format(SQL, blogArticleID, Core.Account.ID);
            try { 
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void getArchiveListBlogByDate(out MySqlDataReader DR, string startDate, string endDate) {
            string SQL = "SELECT ID, CategoryID, Title, Content, Date, PageView, LikeCount FROM Blog_Articles WHERE UserID = {0} AND Date >= '{1}' AND Date <= '{2}' ORDER BY Date DESC";
            SQL = string.Format(SQL, Core.Account.ID, startDate, endDate);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getBlogArticles(out MySqlDataReader DR) {
            string SQL = "SELECT ID, CategoryID, Title, Content, Date, PageView, LikeCount FROM Blog_Articles WHERE UserID = {0} ORDER BY Date DESC";
            SQL = string.Format(SQL, Core.Account.ID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getUserProfileByID(out MySqlDataReader DR, UInt32 userID) {
            string SQL = "SELECT Password, Nickname, Email, PhoneNumber, Birthday, Sex FROM Users WHERE ID = {0} LIMIT 1";
            SQL = string.Format(SQL, userID);
            try { 
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getTagIDsByBlogArticleID(out MySqlDataReader DR, UInt32 blogArticleID) {
            string SQL = "SELECT TagID FROM Blog_Article_Tag WHERE BlogArticleID = {0}";
            SQL = string.Format(SQL, blogArticleID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getCategoryNameByID(out MySqlDataReader DR, UInt32 categoryID) {
            string SQL = "SELECT Name FROM Categories WHERE ID = {0} LIMIT 1";
            SQL = string.Format(SQL, categoryID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getComments(out MySqlDataReader DR, UInt32 blogArticleID) {
            string SQL = "SELECT ID, UserEmail, Content, Date FROM Comments WHERE BlogArticleID = {0} ORDER BY Date DESC";
            SQL = string.Format(SQL, blogArticleID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deleteTagsByBlogArticleID(UInt32 blogArticleID) {
            string SQL = "DELETE FROM Blog_Article_Tag WHERE BlogArticleID = {0}";
            SQL = string.Format(SQL, blogArticleID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                CMD.ExecuteNonQuery();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool deleteBlogArticleByID(UInt32 blogArticleID) {
            string SQL = "DELETE FROM Blog_Articles WHERE ID = {0}";
            SQL = string.Format(SQL, blogArticleID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                if (CMD.ExecuteNonQuery() > 0) {
                    return true;
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool deleteCommentByID(UInt32 commentID) {
            string SQL = "DELETE FROM Comments WHERE ID = {0}";
            SQL = string.Format(SQL, commentID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                if (CMD.ExecuteNonQuery() > 0) {
                    return true;
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public void getVerificationCode(out MySqlDataReader DR) {
            string SQL = "SELECT Code FROM Sign_Up_Verification_Codes WHERE UserID = 1 LIMIT 1";
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public UInt32 getUserIDByUsername(string username) {
            string SQL = "SELECT ID FROM Users WHERE Username = '{0}' LIMIT 1";
            SQL = string.Format(SQL, username);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                object userID = CMD.ExecuteScalar();
                return (UInt32)userID;
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public string getNicknameByID(UInt32 ID) {
            string SQL = "SELECT Nickname FROM Users WHERE ID = '{0}' LIMIT 1";
            SQL = string.Format(SQL, ID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                object userID = CMD.ExecuteScalar();
                return userID.ToString();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public string getUsernameByID(UInt32 ID) {
            string SQL = "SELECT Username FROM Users WHERE ID = '{0}' LIMIT 1";
            SQL = string.Format(SQL, ID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                object userID = CMD.ExecuteScalar();
                return userID.ToString();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public void getUserChatsByUsername(out MySqlDataReader DR, string username) {
            UInt32 userID = getUserIDByUsername(username);
            string SQL = "SELECT Chat, Date FROM User_Chats WHERE (UserID1 = {0} AND UserID2 = {1}) OR (UserID1 = {2} AND UserID2 = {3})";
            SQL = string.Format(SQL, Core.Account.ID, userID, userID, Core.Account.ID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getUsernames(out MySqlDataReader DR) {
            string SQL = "SELECT Username, Nickname FROM Users";
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getUserLoginLogByUserID(out MySqlDataReader DR, UInt32 userID) {
            string SQL = "SELECT LoginIP, AutoLogin, UserPassword, LoginDate FROM User_Login_Logs WHERE UserID = {0}";
            SQL = string.Format(SQL, userID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getUserLoginLogByLoginIP(out MySqlDataReader DR, string loginIP) {
            string SQL = "SELECT UserID, AutoLogin, UserPassword, LoginDate FROM User_Login_Logs WHERE LoginIP = '{0}' ORDER BY LoginDate DESC LIMIT 1";
            SQL = string.Format(SQL, loginIP);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getUserByID(out MySqlDataReader DR, UInt32 userID) {
            string SQL = "SELECT Username, Nickname, Password FROM Users WHERE ID = {0} LIMIT 1";
            SQL = string.Format(SQL, userID);
            try {
                MySqlCommand CMD = new MySqlCommand(SQL, this.MySQL.Connection);
                DR = CMD.ExecuteReader();
            } catch (MySqlException exc) {
                DR = null;
                MessageBox.Show(exc.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
