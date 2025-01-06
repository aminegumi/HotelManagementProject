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
        public DbConnector() {
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
