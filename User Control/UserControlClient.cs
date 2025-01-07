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
    public partial class UserControlClient : UserControl
    {
        DbConnector db;
        private string ID = "";
        public UserControlClient()
        {
            InitializeComponent();
            db = new DbConnector();
        }
        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();
            textBoxEmail.Clear();
            tabSearchlClient.SelectedTab = tabPageAddClient;
        }
        public void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxAddress1.Clear();
            textBoxEmail1.Clear();
            ID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;

            if (textBoxFirstName.Text.Trim() == string.Empty || textBoxLastName.Text == "" || textBoxPhoneNo.Text == "" || textBoxAddress.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check = db.AddClient(textBoxFirstName.Text, textBoxLastName.Text.Trim(), textBoxPhoneNo.Text.Trim(), textBoxAddress.Text.Trim(), textBoxEmail.Text.Trim());

                if (check)
                {
                    MessageBox.Show("Client added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }

            }
        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabSearchlClient_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchClient("SELECT* FROM Client_table", dataGridViewClient);

        }

        private void tabSearchlClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchPhoneNo.Clear();
        }

        private void textBoxSearchPhoneNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearchUser($"SELECT* FROM Client_table WHERE Client_Phone LIKE '%{textBoxSearchPhoneNo.Text}%'", dataGridViewClient);

        }

        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == string.Empty || textBoxLastName1.Text.Trim() == string.Empty || textBoxPhoneNo1.Text.Trim() == string.Empty || textBoxAddress1.Text.Trim() == string.Empty || textBoxEmail1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    check = db.UpdateClient(ID, textBoxFirstName1.Text.Trim(), textBoxLastName1.Text.Trim(), textBoxPhoneNo1.Text.Trim(), textBoxAddress1.Text.Trim(), textBoxEmail1.Text.Trim());
                    if (check)
                    {
                        MessageBox.Show("Client updated successfully", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (textBoxFirstName1.Text.Trim() == string.Empty || textBoxLastName1.Text.Trim() == string.Empty || textBoxPhoneNo1.Text.Trim() == string.Empty || textBoxAddress1.Text.Trim() == string.Empty || textBoxEmail1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        check = db.DeleteClient(ID);
                        if (check)
                        {
                            MessageBox.Show("Client deleted successfully", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonDelete_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxFirstName1.Text = row.Cells[1].Value.ToString();
                textBoxLastName1.Text = row.Cells[2].Value.ToString();
                textBoxPhoneNo1.Text = row.Cells[3].Value.ToString();
                textBoxAddress1.Text = row.Cells[4].Value.ToString();
                textBoxEmail1.Text = row.Cells[5].Value.ToString();
            }
        }

        private void tabPageUpdateAndDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }


        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchClient("SELECT* FROM Client_table", dataGridViewClient);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                db.DisplayAndSearchUser($"SELECT* FROM Client_table WHERE Client_Email LIKE '%{textBox1.Text}%'", dataGridViewClient);

            }
        }
    }
}
