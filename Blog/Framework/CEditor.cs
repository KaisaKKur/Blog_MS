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
    public partial class CEditor : UserControl {
        class BlogArticleInfo {
            public UInt32 ID { get; set; }
            public string BlogCategory { get; set; }
            public string Title { get; set; }
        }

        class CommentInfo {
            public UInt32 ID { get; set; }
            public string Comment { get; set; }
        }

        private static UInt32 _blogArticleID = 0;

        /* Property
         */
        public static UInt32 BlogArticleID {
            get => _blogArticleID;
            set => _blogArticleID = value;
        }

        public CEditor() {
            InitializeComponent();

            sfComboBox_category.DataSource = new List<string>() {
                "Life",
                "Study",
                "Other"
            };

            sfComboBox_tags.DataSource = new List<string>() {
                "游戏",
                "食品",
                "购物",
                "程序设计",
                "旅游",
                "建模",
                "应用程序"
            };
            sfComboBox_tags.DropDownControl.ShowButtons = false;

            loadBlogArticleList();
        }

        private void CEditor_Load(object sender, EventArgs e) {
            if (_blogArticleID > 0) {
                loadBlogArticleByID();
                loadComments();
                sfButton_new.Enabled = true;
                sfButton_delete.Enabled = true;
            }
        }

        private void loadBlogArticleByID() {
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getBlogArticleByID(out MySqlDataReader DR, _blogArticleID);
                while (DR.Read()) {
                    textBoxExt_title.Text = DR[1].ToString();
                    sfComboBox_category.SelectedIndex = Convert.ToInt32(DR[0]) - 1;
                    textBoxExt_content.Text = DR[2].ToString();
                }
                DR.Close();
                blogMySQL.getTagIDsByBlogArticleID(out MySqlDataReader getTagIDsDR, _blogArticleID);
                while (getTagIDsDR.Read()) {
                    sfComboBox_tags.CheckedItems.Add(((List<string>)(sfComboBox_tags.DataSource))[Convert.ToInt32(getTagIDsDR[0]) - 1]);
                }
                getTagIDsDR.Close();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadBlogArticleList() {
            List<BlogArticleInfo> blogArticleInfos = new List<BlogArticleInfo>();
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getBlogArticles(out MySqlDataReader DR);
                while (DR.Read()) {
                    BlogMySQL getCategoryNameBlogMySQL = new BlogMySQL();
                    getCategoryNameBlogMySQL.getCategoryNameByID(out MySqlDataReader getCategoryNameDR, Convert.ToUInt32(DR[1]));
                    while (getCategoryNameDR.Read()) {
                        blogArticleInfos.Add(new BlogArticleInfo() { ID = Convert.ToUInt32(DR[0]), BlogCategory = getCategoryNameDR[0].ToString(), Title = DR[2].ToString() });
                    }
                    getCategoryNameDR.Close();
                }
                DR.Close();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sfListView_blogList.DataSource = blogArticleInfos;
            sfListView_blogList.DisplayMember = "Title";
            sfListView_blogList.View.GroupDescriptors.Add(
                new Syncfusion.DataSource.GroupDescriptor() { PropertyName = "BlogCategory" }
            );
            sfListView_blogList.Style.GroupItemStyle.Font = new Font("Segoe UI", 12);
            sfListView_blogList.GroupHeaderHeight = 35;
            sfListView_blogList.Style.ItemStyle.Font = new Font("Segoe UI", 11);
            sfListView_blogList.ShowFooter = true;
        }

        private void sfListView_blogList_DrawItem(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e) {
            if (e.ItemType == Syncfusion.WinForms.ListView.Enums.ItemType.Footer) {
                e.Text = "Blog Articles Count : " + sfListView_blogList.View.Items.Count;
            }
        }

        private void loadComments() {
            List<CommentInfo> commentInfos = new List<CommentInfo>();
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                blogMySQL.getComments(out MySqlDataReader DR, _blogArticleID);
                while (DR.Read()) {
                    commentInfos.Add(new CommentInfo() { ID = Convert.ToUInt32(DR[0]), Comment = DR[2].ToString() + "   By " + DR[1].ToString() + " 0n " + DR[3].ToString() });
                }
                DR.Close();
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sfComboBox_comments.DataSource = commentInfos;
            sfComboBox_comments.DisplayMember = "Comment";
            sfComboBox_comments.DropDownListView.ItemHeight = 40;
            sfComboBox_comments.MaxDropDownItems = 10;
            sfComboBox_comments.DropDownControl.OkButton.Text = "Delete";
            sfComboBox_comments.DropDownControl.OkButton.Click += OkButton_Click;
        }

        private void OkButton_Click(object sender, EventArgs e) {
            try {
                bool isDeleteSucceded = false;
                foreach (CommentInfo item in sfComboBox_comments.CheckedItems) {
                    BlogMySQL blogMySQL = new BlogMySQL();
                    if (blogMySQL.deleteCommentByID(item.ID)) {
                        isDeleteSucceded = true;
                    } else {
                        isDeleteSucceded = false;
                        break;
                    }
                }

                if (isDeleteSucceded) {
                    loadComments();
                    sfComboBox_comments.Text = string.Empty;
                    MessageBox.Show("Delete succeeded.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfButton_new_Click(object sender, EventArgs e) {
            _blogArticleID = 0;
            textBoxExt_title.ResetText();
            sfComboBox_category.ResetText();
            sfComboBox_tags.CheckedItems.Clear();
            textBoxExt_content.ResetText();
            sfComboBox_comments.DataSource = null;
            sfButton_new.Enabled = false;
            sfButton_delete.Enabled = false;
        }

        private void sfButton_delete_Click(object sender, EventArgs e) {
            try {
                BlogMySQL blogMySQL = new BlogMySQL();
                if (blogMySQL.deleteBlogArticleByID(_blogArticleID)) {
                    loadBlogArticleList();
                    sfButton_new_Click(sender, EventArgs.Empty);
                    MessageBox.Show("Delete succeeded.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    throw new Exception("Sorry, an error occurred while updating the database.");
                }
            } catch (MySqlException exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sfButton_save_Click(object sender, EventArgs e) {
            if (_blogArticleID == 0) {
                try {
                    string insertBlogArticleSQL = "INSERT INTO Blog_Articles(UserID, CategoryID, Title, Content) VALUES (@userID, @categoryID, @title, @content)";
                    BlogMySQL blogMySQL = new BlogMySQL();
                    MySqlCommand insertBlogArticleCMD = new MySqlCommand(insertBlogArticleSQL, blogMySQL.MySQL.Connection);

                    insertBlogArticleCMD.Parameters.AddWithValue("@userID", Account.ID);

                    if (textBoxExt_title.TextLength >= 1 && textBoxExt_title.TextLength <= 128) {
                        insertBlogArticleCMD.Parameters.AddWithValue("@title", textBoxExt_title.Text);
                    } else {
                        throw new Exception("Sorry, the blog title is invalid. It should be 1-128 characters long.");
                    }

                    if (sfComboBox_category.SelectedIndex >= 0) {
                        insertBlogArticleCMD.Parameters.AddWithValue("@categoryID", sfComboBox_category.SelectedIndex + 1);
                    } else {
                        throw new Exception("Sorry, the blog category cannot be NULL.");
                    }

                    if (textBoxExt_content.TextLength > 0) {
                        insertBlogArticleCMD.Parameters.AddWithValue("@content", textBoxExt_content.Text);
                    } else {
                        throw new Exception("Sorry, the blog title is invalid. It should be 1-更多 characters long.");
                    }

                    if (insertBlogArticleCMD.ExecuteNonQuery() == 1) {
                        _blogArticleID = (UInt32)insertBlogArticleCMD.LastInsertedId;
                    }

                    string insertBlogArticleTagSQL = "INSERT INTO Blog_Article_Tag(TagID, BlogArticleID) VALUES (@tagID, @blogArticleID)";
                    foreach (var item in sfComboBox_tags.CheckedItems) {
                        BlogMySQL insertBlogArticleTag = new BlogMySQL();
                        MySqlCommand insertBlogArticleTagCMD = new MySqlCommand(insertBlogArticleTagSQL, insertBlogArticleTag.MySQL.Connection);
                        insertBlogArticleTagCMD.Parameters.AddWithValue("@tagID", switchTagID(item.ToString()));
                        insertBlogArticleTagCMD.Parameters.AddWithValue("@blogArticleID", _blogArticleID);
                        if (insertBlogArticleTagCMD.ExecuteNonQuery() == 0) {
                            throw new Exception("Sorry, an error occurred while updating the database.");
                        }
                    }

                    MessageBox.Show("Submit succeeded.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadBlogArticleList();
                    sfButton_new.Enabled = true;
                    sfButton_delete.Enabled = true;
                } catch (MySqlException exc) {
                    MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                try {
                    string updateBlogArticleSQL = "UPDATE Blog_Articles SET CategoryID = @categoryID, Title = @title, Content = @content WHERE ID = {0}";
                    updateBlogArticleSQL = string.Format(updateBlogArticleSQL, _blogArticleID);
                    BlogMySQL updateBlogArticle = new BlogMySQL();
                    MySqlCommand updateBlogArticleCMD = new MySqlCommand(updateBlogArticleSQL, updateBlogArticle.MySQL.Connection);

                    if (textBoxExt_title.TextLength >= 1 && textBoxExt_title.TextLength <= 128) {
                        updateBlogArticleCMD.Parameters.AddWithValue("@title", textBoxExt_title.Text);
                    } else {
                        throw new Exception("Sorry, the blog title is invalid. It should be 1-128 characters long.");
                    }

                    if (sfComboBox_category.SelectedIndex >= 0) {
                        updateBlogArticleCMD.Parameters.AddWithValue("@categoryID", sfComboBox_category.SelectedIndex + 1);
                    } else {
                        throw new Exception("Sorry, the blog category cannot be NULL.");
                    }

                    if (textBoxExt_content.TextLength > 0) {
                        updateBlogArticleCMD.Parameters.AddWithValue("@content", textBoxExt_content.Text);
                    } else {
                        throw new Exception("Sorry, the blog title is invalid. It should be 1-更多 characters long.");
                    }

                    if (updateBlogArticleCMD.ExecuteNonQuery() == 1) {
                    }

                    BlogMySQL deleteOldTagsBlogMySQL = new BlogMySQL();
                    deleteOldTagsBlogMySQL.deleteTagsByBlogArticleID(_blogArticleID);

                    string insertBlogArticleTagSQL = "INSERT INTO Blog_Article_Tag(TagID, BlogArticleID) VALUES (@tagID, @blogArticleID)";
                    foreach (var item in sfComboBox_tags.CheckedItems) {
                        BlogMySQL insertBlogArticleTag = new BlogMySQL();
                        MySqlCommand insertBlogArticleTagCMD = new MySqlCommand(insertBlogArticleTagSQL, insertBlogArticleTag.MySQL.Connection);
                        insertBlogArticleTagCMD.Parameters.AddWithValue("@tagID", switchTagID(item.ToString()));
                        insertBlogArticleTagCMD.Parameters.AddWithValue("@blogArticleID", _blogArticleID);
                        if (insertBlogArticleTagCMD.ExecuteNonQuery() == 0) {
                            throw new Exception("Sorry, an error occurred while updating the database.");
                        }
                    }

                    MessageBox.Show("Submit succeeded.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadBlogArticleList();
                } catch (MySqlException exc) {
                    MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private UInt32 switchTagID(string tagName) {
            switch (tagName) {
                case "游戏": return 1;
                case "食品": return 2;
                case "购物": return 3;
                case "程序设计": return 4;
                case "旅游": return 5;
                case "建模": return 6;
                case "应用程序": return 7;                
                default: return 0;
            }
        }

        private void sfListView_blogList_DoubleClick(object sender, EventArgs e) {
            try {
                if (sfListView_blogList.SelectedIndex >= 0) {
                    UInt32 blogArticleID = ((BlogArticleInfo)sfListView_blogList.SelectedItem).ID;
                    _blogArticleID = blogArticleID;
                    sfComboBox_tags.CheckedItems.Clear();
                    loadBlogArticleByID();
                    loadComments();
                }
            } catch (Exception) {
            }
        }
    }
}
