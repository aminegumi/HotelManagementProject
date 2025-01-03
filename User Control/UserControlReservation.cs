using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualStudio.Designer.Interfaces;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace HotelRes1.User_Control
{
    public partial class UserControlReservation : UserControl
    {
        DbConnector db;
        private String RID = " ", No;
        public UserControlReservation()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
       
            if (comboBoxRoomType.Items.Count > 0)
            {
                comboBoxRoomType.SelectedIndex = 0;
            }
            else
            {
                comboBoxRoomType.SelectedIndex = -1;
            }

            // Same for comboBoxRoomNo
            if (comboBoxRoomNo.Items.Count > 0)
            {
                comboBoxRoomNo.SelectedIndex = 0;
            }
            else
            {
                comboBoxRoomNo.SelectedIndex = -1; 
            }

            textBoxClientID.Clear();
      
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
        }





        private void DateTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void DateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Clear2()
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = string.Empty;
        }



        //private void UserControlReservation_Load(object sender, EventArgs e)
        //{
        //    comboBoxRoomType.SelectedIndex = 0;
        //    comboBoxRoomNo.SelectedIndex = 0;
        //    comboBoxType1.SelectedIndex = 0;
        //    comboBoxNo1.SelectedIndex = 0;
        //}
        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            if (comboBoxRoomType.Items.Count > 0)
                comboBoxRoomType.SelectedIndex = 0;
            if (comboBoxRoomNo.Items.Count > 0)
                comboBoxRoomNo.SelectedIndex = 0;
            if (comboBoxType1.Items.Count > 0)
                comboBoxType1.SelectedIndex = 0;
            if (comboBoxNo1.Items.Count > 0)
                comboBoxNo1.SelectedIndex = 0;
        }




        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear2();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxClientID.Text.Trim()) ||
                comboBoxRoomType.SelectedItem == null ||
                comboBoxRoomNo.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool check = db.AddReservation(
                    comboBoxRoomType.SelectedItem.ToString(),
                    comboBoxRoomNo.SelectedItem.ToString(),
                    textBoxClientID.Text.Trim(),
                    dateTimePickerIn.Value.ToString("yyyy-MM-dd"),
                    dateTimePickerOut.Value.ToString("yyyy-MM-dd")
                );

                if (check)
                {
                    db.UpdateReservationRoom(comboBoxRoomNo.SelectedItem.ToString(), "No"); 
                    MessageBox.Show("Reservation added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchRoom("SELECT * FROM Reservation_Table", dataGridViewReservation);
        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientID.Clear();
        }

        private void textBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT r.Reservation_ID, r.Reservation_Room_Type, r.Reservation_Room_Number, r.Reservation_Client_ID, " +
                           "r.Reservation_In, r.Reservation_Out, rm.Room_Phone " +
                           "FROM Reservation_table r " +
                           "LEFT JOIN Room_table rm ON r.Reservation_Room_Number = rm.Room_Number " +
                           $"WHERE r.Reservation_Client_ID LIKE '%{textBoxSearchClientID.Text}%'";
            db.DisplayAndSearchReservation(query, dataGridViewReservation);
        }


        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[2].Value.ToString();
                textBoxClientID1.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn1.Text = row.Cells[4].Value.ToString();
                dateTimePickerOut1.Text = row.Cells[5].Value.ToString(); 
            }
        }




        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;

            if (!string.IsNullOrEmpty(RID))
            {
                if (comboBoxType1.SelectedIndex == 0 || comboBoxNo1.SelectedIndex == 0 || string.IsNullOrWhiteSpace(textBoxClientID1.Text))
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    check = db.UpdateReservation(
                        RID,
                        comboBoxType1.SelectedItem.ToString(),
                        comboBoxNo1.SelectedItem.ToString(),
                        textBoxClientID1.Text.Trim(),
                        dateTimePickerIn1.Text,
                        dateTimePickerOut1.Text
                    );

                    if (check)
                    {
                        
                        db.UpdateReservationRoom(No, "Yes");
                        db.UpdateReservationRoom(comboBoxNo1.SelectedItem.ToString(), "No");

                        MessageBox.Show("Reservation updated successfully", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear2();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select a row from the table.", "Row Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == 0  || textBoxClientID1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel this Reservation?", "Delete Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        check = db.DeleteReservation(RID);
                        db.UpdateReservationRoom(No, "Yes");
                        if (check)
                        {
                            MessageBox.Show("Client deleted successfully", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear2();
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
            Clear2();
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)

        {
            db.RoomTypeAndNo(" SELECT Room_Number FROM Room_table WHERE Room_Type = '" + comboBoxRoomType.SelectedItem.ToString() + "'AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo1);

        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRoomType?.SelectedItem != null && db != null)
            {
                string selectedRoomType = comboBoxRoomType.SelectedItem.ToString();
                db.RoomTypeAndNo(selectedRoomType, comboBoxRoomNo);
            }
        }


        private void comboBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo(" SELECT Room_Number FROM room_table WHERE Room_Type = '" + comboBoxRoomType.SelectedItem.ToString() + "'AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo1);

        }
    }
}
