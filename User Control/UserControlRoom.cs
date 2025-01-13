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
    public partial class UserControlRoom : UserControl
    {

        DbConnector db;
        private string No = "", Free = "";

        public UserControlRoom()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            textBoxPhoneNo.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            tabControlRoom.SelectedTab = tabPageAddRoom;
            textBoxPrice.Clear();
        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            textBoxPhoneNo1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            No = "";
            textBoxPrice1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked)
                Free = "Yes";
            if (radioButtonNo.Checked)
                Free = "No";
            bool check;

            if (comboBoxType.SelectedIndex == 0 || textBoxPhoneNo.Text.Trim() == string.Empty || Free == "" || textBoxPrice.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check = db.AddRoom(comboBoxType.SelectedItem.ToString(), textBoxPhoneNo.Text.Trim(), Free, textBoxPrice.Text.Trim());

                if (check)
                {
                    MessageBox.Show("Room added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }

            }
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchRoom("SELECT * FROM Room_Table", dataGridViewRoom);
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoomNo.Clear();
        }

        private void textBoxSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearchRoom("SELECT * FROM Room_Table WHERE Room_Number LIKE '%" + textBoxSearchRoomNo.Text + "%'", dataGridViewRoom);
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPhoneNo1.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if (Free == "Yes")
                    radioButtonYes1.Checked = true;
                if (Free == "No")
                    radioButtonNo1.Checked = true;
                textBoxPrice1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";
            bool check;
            if (No != "")
            {
                if (comboBoxType1.SelectedIndex == -1 || textBoxPhoneNo1.Text.Trim() == string.Empty || Free == "" || textBoxPrice1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    check = db.UpdateRoom(No, comboBoxType1.SelectedItem.ToString(), textBoxPhoneNo1.Text.Trim(), Free, textBoxPrice1.Text.Trim());
                    if (check)
                    {
                        MessageBox.Show("Room updated successfully", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";
            bool check;
            if (No != "")
            {
                if (comboBoxType1.SelectedIndex == 0 || textBoxPhoneNo1.Text.Trim() == string.Empty || Free == "" || textBoxPrice1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        check = db.DeleteClient(No);
                        if (check)
                        {
                            MessageBox.Show("Room deleted successfully", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
        }

        private void tabPageUpdateAndDeleteRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonExportClient_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (.csv)|.csv|All files (.)|.";
                sfd.Title = "Export to CSV";
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    StringBuilder csv = new StringBuilder();

                    // Add headers
                    for (int i = 0; i < dataGridViewRoom.Columns.Count; i++)
                    {
                        csv.Append(dataGridViewRoom.Columns[i].HeaderText);
                        if (i < dataGridViewRoom.Columns.Count - 1)
                            csv.Append(";");
                    }
                    csv.AppendLine();

                    // Add rows data
                    foreach (DataGridViewRow row in dataGridViewRoom.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            csv.Append(row.Cells[i].Value.ToString());
                            if (i < row.Cells.Count - 1)
                                csv.Append(";");
                        }
                        csv.AppendLine();
                    }

                    // Write to file
                    File.WriteAllText(sfd.FileName, csv.ToString());
                    MessageBox.Show("Data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
