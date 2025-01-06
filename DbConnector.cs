using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace HotelRes1
{
    internal class DbConnector
    {
        private string connectionString;
        private MySqlConnection connection;
        public DbConnector()
        {
            connectionString = "Server=127.0.0.1;Database=hotel_management_system;Uid=root;Pwd=;";
            connection = new MySqlConnection(connectionString);
        }


        public bool IsValidNamePass(string username, string password)
        {
            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM user_table WHERE User_Name = @username AND User_Password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool AddUser(string username, string password)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO user_table (User_Name, User_Password) VALUES (@username, @password)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public void DisplayAndSearchUser(string query, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public bool UpdateUser(string id, string username, string password)
        {
            try
            {
                connection.Open();
                string query = "UPDATE user_table SET User_Name = @username, User_Password = @password WHERE User_ID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public bool DeleteUser(string id)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM user_table WHERE User_ID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool AddClient(string firstName, string lastName, string phone, string address)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO client_table (Client_FirstName, Client_LastName, Client_Phone, Client_Address) VALUES (@firstName, @lastName, @phone, @address)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public void DisplayAndSearchClient(string query, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        public bool UpdateClient(string id, string firstName, string lastName, string phone, string address)
        {
            try
            {
                connection.Open();
                string query = "UPDATE client_table SET Client_FirstName = @firstName, Client_LastName = @lastName, Client_Phone = @phone, Client_Address = @address WHERE Client_ID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public bool DeleteClient(string id)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM client_table WHERE Client_ID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool AddRoom(string RoomType, string RoomPhone, string RoomFree)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO room_table (Room_Type, Room_Phone, Room_Free) VALUES (@RoomType, @RoomPhone, @RoomFree)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    cmd.Parameters.AddWithValue("@RoomPhone", RoomPhone);
                    cmd.Parameters.AddWithValue("@RoomFree", RoomFree);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public void DisplayAndSearchRoom(string query, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public bool UpdateRoom(string RoomNo, string RoomType, string RoomPhone, string RoomFree)
        {
            try
            {
                connection.Open();
                string query = "UPDATE room_table SET Room_Type = @RoomType, Room_Phone = @RoomPhone, Room_Free = @RoomFree WHERE Room_Number = @RoomNo";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomNo", RoomNo);
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    cmd.Parameters.AddWithValue("@RoomPhone", RoomPhone);
                    cmd.Parameters.AddWithValue("@RoomFree", RoomFree);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public bool DeleteRoom(string RoomNo)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM room_table WHERE Room_Number = @RoomNo";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomNo", RoomNo);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool UpdateReservation(string reservationId, string roomType, string roomNo, string clientId, string dateIn, string dateOut)
        {
            try
            {
                connection.Open();
                string query = "UPDATE reservation_table SET Room_Type = @RoomType, Room_No = @RoomNo, Client_ID = @ClientId, Date_In = @DateIn, Date_Out = @DateOut WHERE Reservation_ID = @ReservationId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ReservationId", reservationId);
                    cmd.Parameters.AddWithValue("@RoomType", roomType);
                    cmd.Parameters.AddWithValue("@RoomNo", roomNo);
                    cmd.Parameters.AddWithValue("@ClientId", clientId);
                    cmd.Parameters.AddWithValue("@DateIn", dateIn);
                    cmd.Parameters.AddWithValue("@DateOut", dateOut);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool DeleteReservation(string reservationId)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM reservation_table WHERE Reservation_ID = @reservationId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@reservationId", reservationId);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool AddReservation(string roomType, string roomNo, string clientId, string dateIn, string dateOut)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            try
            {
                connection.Open();
                // Convert roomNo and clientId to integer since they're int(11)
                if (!int.TryParse(roomNo, out int roomNumber))
                {
                    throw new Exception("Invalid room number format");
                }

                if (!int.TryParse(clientId, out int clientIdNumber))
                {
                    throw new Exception("Invalid client ID format");
                }

                string query = @"INSERT INTO Reservation_table 
                        (Reservation_Room_Type, Reservation_Room_Number, Reservation_Client_ID, 
                         Reservation_In, Reservation_Out) 
                        VALUES (@roomType, @roomNumber, @clientId, @dateIn, @dateOut)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@roomType", roomType);
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                    cmd.Parameters.AddWithValue("@clientId", clientIdNumber);
                    cmd.Parameters.AddWithValue("@dateIn", dateIn);
                    cmd.Parameters.AddWithValue("@dateOut", dateOut);

                    int result = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Insert result: {result} rows affected");
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding reservation: {ex.Message}");
                MessageBox.Show($"Failed to add reservation: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool UpdateReservationRoom(string roomNo, string roomFree)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            try
            {
                connection.Open();
                // Convert roomNo to integer since Room_Number is int(11)
                if (!int.TryParse(roomNo, out int roomNumber))
                {
                    throw new Exception("Invalid room number format");
                }

                string query = "UPDATE Room_table SET Room_Free = @roomFree WHERE Room_Number = @roomNumber";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                    cmd.Parameters.AddWithValue("@roomFree", roomFree);

                    int result = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Update result: {result} rows affected");
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating room: {ex.Message}");
                MessageBox.Show($"Failed to update room status: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public void RoomTypeAndNo(string roomType, ComboBox comboBox)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT Room_Number FROM Room_table WHERE Room_Type = @roomType AND Room_Free = 'Yes' ORDER BY Room_Number";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@roomType", roomType);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox.Items.Clear(); // Clear old items

                        // Check if we have any results
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No available rooms found for this room type.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader["Room_Number"].ToString());
                        }
                    }
                }

                // Set default selection if items are available
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load room numbers. Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
        public void DisplayAndSearchReservation(string query, string searchTerm, DataGridView dataGridView)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Convert searchTerm to int if it's a valid number, otherwise use 0
                    int searchId;
                    if (int.TryParse(searchTerm, out searchId))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", searchId);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", 0);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Configure DataGridView settings
                        dataGridView.AutoGenerateColumns = true;
                        dataGridView.DataSource = dataTable;

                        // Optionally format column headers for better display
                        if (dataGridView.Columns.Count > 0)
                        {
                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                // Remove underscores and format column headers
                                column.HeaderText = column.HeaderText.Replace("_", " ");
                            }
                        }

                        // If no results found, show message
                        if (dataTable.Rows.Count == 0)
                        {
                            Console.WriteLine("No reservations found for this client ID");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching reservations: {ex.Message}");
                MessageBox.Show($"Error searching reservations: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        // Add this method to load all reservations initially
        public void LoadAllReservations(DataGridView dataGridView)
        {
            string query = @"SELECT 
                        r.Reservation_ID,
                        r.Reservation_Room_Type,
                        r.Reservation_Room_Number,
                        r.Reservation_Client_ID,
                        r.Reservation_In,
                        r.Reservation_Out,
                        rm.Room_Phone
                    FROM Reservation_table r
                    LEFT JOIN Room_table rm ON r.Reservation_Room_Number = rm.Room_Number
                    ORDER BY r.Reservation_ID DESC";

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;

                    // Format column headers
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        column.HeaderText = column.HeaderText.Replace("_", " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading reservations: {ex.Message}");
                MessageBox.Show($"Error loading reservations: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DisplayAndSearchReservation(string query, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public int Count(string query)
        {
            int count = 0;
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

        public bool AddReservation(string roomId, string roomType, string clientId, string reservationIn, string reservationOut)
        {
            try
            {
                connection.Open();
                string query = @"
            INSERT INTO reservation_table 
            (Reservation_Room_Number, Reservation_Room_Type, Reservation_Client_ID, Reservation_In, Reservation_Out) 
            VALUES (@roomId, @roomType, @clientId, @reservationIn, @reservationOut)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@roomId", roomId);
                    cmd.Parameters.AddWithValue("@roomType", roomType);
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@reservationIn", reservationIn);
                    cmd.Parameters.AddWithValue("@reservationOut", reservationOut);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool UpdateRoomFree(string roomNumber)
        {
            try
            {
                connection.Open();
                string query = "UPDATE room_table SET Room_Free = 'No' WHERE Room_Number = @roomNumber AND Room_Free = 'Yes'";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool UpdateRoomFreeToYes(string roomNumber)
        {
            try
            {
                connection.Open();
                string query = "UPDATE room_table SET Room_Free = 'Yes' WHERE Room_Number = @roomNumber AND Room_Free = 'No'";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // True if a row was updated
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }



        public void DisplayAndSearchReservation(string query, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public bool UpdateReservation(string reservationId, string roomType, string roomNumber, string clientId, string reservationIn, string reservationOut)
        {
            try
            {
                connection.Open();
                string query = "UPDATE reservation_table SET Reservation_Room_Type = @roomType, Reservation_Room_Number = @roomNumber, Reservation_Client_ID = @clientId, Reservation_In = @reservationIn, Reservation_Out = @reservationOut WHERE Reservation_ID = @reservationId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@reservationId", reservationId);
                    cmd.Parameters.AddWithValue("@roomType", roomType);
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@reservationIn", reservationIn);
                    cmd.Parameters.AddWithValue("@reservationOut", reservationOut);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public bool DeleteReservation(string reservationId)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM reservation_table WHERE Reservation_ID = @reservationId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@reservationId", reservationId);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public void RoomTypeAndNo(string query, ComboBox comboBox)
        {
            try
            {
                connection.Open(); 
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    object firstItem = null;
                    if (comboBox.Items.Count > 0)
                    {
                        firstItem = comboBox.Items[0];
                    }

                    comboBox.Items.Clear();
                    if (firstItem != null)
                    {
                        comboBox.Items.Add(firstItem);
                    }
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["Room_Number"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close(); 
            }
        }






    }
}