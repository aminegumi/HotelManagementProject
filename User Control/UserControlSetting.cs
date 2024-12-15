using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelRes1.User_Control
{
    public partial class UserControlSetting : UserControl
    {
        DbConnector db;
        private string ID = "";
        public UserControlSetting()
        {
            InitializeComponent();
            db = new DbConnector();
        }


        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }

        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {

            Clear();
            Clear1();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchUser("SELECT* FROM user_table", dataGridViewUser);
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageUpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all the fields", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check = db.AddUser(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
                if (check)
                {
                    MessageBox.Show("User added successfully", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }

            }
        }

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearchUser($"SELECT* FROM user_table WHERE User_Name LIKE '%{textBoxSearchUsername.Text}%'", dataGridViewUser);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID !="")
            {
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    check = db.UpdateUser(ID,textBoxUsername1.Text.Trim(), textBoxPassword1.Text.Trim());
                    if (check)
                    {
                        MessageBox.Show("User updated successfully", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please first select row from table.", "Selection of row", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes) // Fix: Change dialogResult check to Yes
                    {
                        check = db.DeleteUser(ID);
                        if (check)
                        {
                            MessageBox.Show("User deleted successfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information); // Fix: Change message box title to "Delete User"
                            Clear1();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table.", "Selection of row", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();
            }
        }

        
    }
}
