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
    public partial class UserControlReservation : UserControl
    {
        DbConnector db;
        private string RID = "", No;
        public UserControlReservation()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            textBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;

            if (comboBoxNo.SelectedIndex == 0 || comboBoxType.SelectedIndex == 0 || textBoxClientID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check = db.AddReservation(comboBoxNo.SelectedItem.ToString(), comboBoxType.SelectedItem.ToString(), textBoxClientID.Text.Trim(), dateTimePickerIn.Text, dateTimePickerOut.Text);
                db.UpdateRoomFree(comboBoxNo.SelectedItem.ToString());
                if (check)
                {
                    MessageBox.Show("Reservation added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }

            }
        }

        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchReservation("SELECT * FROM Reservation_Table", dataGridViewReservation);
        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientID.Clear();
        }

        private void textBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearchReservation("SELECT * FROM Reservation_Table WHERE Reservation_Client_ID LIKE '%" + textBoxSearchClientID.Text + "%'", dataGridViewReservation);
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                //comboBoxNo1.SelectedItem = row.Cells[2].Value.ToString();
                No = row.Cells[2].Value.ToString();
                comboBoxNo1.SelectedItem = row.Cells[2].Value.ToString(); ;
                textBoxClientID1.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn1.Text = row.Cells[4].Value.ToString();
                dateTimePickerOut1.Text = row.Cells[5].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {
                if (comboBoxNo1.SelectedIndex == 0 || comboBoxType1.SelectedIndex == 0 || textBoxClientID1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBoxType1.SelectedItem == null || comboBoxNo1.SelectedItem == null)
                    {
                        MessageBox.Show("Please select valid options from the dropdowns.", "Require selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                    if(No != comboBoxNo1.SelectedItem.ToString())
                    {
                        check = db.UpdateReservation(RID, comboBoxType1.SelectedItem.ToString(), comboBoxNo1.SelectedItem.ToString(), textBoxClientID1.Text.Trim(), dateTimePickerIn1.Text, dateTimePickerOut1.Text);
                        db.UpdateRoomFreeToYes(No);
                        db.UpdateRoomFree(comboBoxNo1.SelectedItem.ToString());
                    }else
                    {
                        check = db.UpdateReservation(RID, comboBoxType1.SelectedItem.ToString(), No, textBoxClientID1.Text.Trim(), dateTimePickerIn1.Text, dateTimePickerOut1.Text);
                    }
                    
                    if (check)
                    {
                        MessageBox.Show("Reservation updated successfully", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table.", "Selection of row", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == 0 || textBoxClientID1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this reservation?", "Cancel Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        check = db.DeleteReservation(RID);
                        db.UpdateRoomFreeToYes(No);
                        if (check)
                        {
                            MessageBox.Show("Reservation canceled successfully", "Cancel Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tabPageUpdateAndCancelReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + comboBoxType1.SelectedItem.ToString() + "'AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo1);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + comboBoxType.SelectedItem.ToString() + "'AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo);
        }
    }
}
