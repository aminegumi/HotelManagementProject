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
        private readonly EmailService _emailService;
        public DbConnector()
        {
            connectionString = "Server=127.0.0.1;Database=hotel_management_system;Uid=root;Pwd=;";
            connection = new MySqlConnection(connectionString);
            _emailService = new EmailService(
              "smtp.gmail.com",
              587,
              "zouhairtawjeeh@gmail.com",
              "alwe daxl onhx vqzd"
            );
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
        public bool AddClient(string firstName, string lastName, string phone, string address, string email)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO client_table (Client_FirstName, Client_LastName, Client_Phone, Client_Address, Client_Email) VALUES (@firstName, @lastName, @phone, @address, @email)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@email", email);

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
        public bool UpdateClient(string id, string firstName, string lastName, string phone, string address, string email)
        {
            try
            {
                connection.Open();
                string query = "UPDATE client_table SET Client_FirstName = @firstName, Client_LastName = @lastName, Client_Phone = @phone, Client_Address = @address, Client_Email = @email WHERE Client_ID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@email", email);
                        
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

        public bool AddRoom(string RoomType, string RoomPhone, string RoomFree, string RoomPrice)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO room_table (Room_Type, Room_Phone, Room_Free, Room_Price) VALUES (@RoomType, @RoomPhone, @RoomFree, @RoomPrice)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    cmd.Parameters.AddWithValue("@RoomPhone", RoomPhone);
                    cmd.Parameters.AddWithValue("@RoomFree", RoomFree);
                    cmd.Parameters.AddWithValue("@RoomPrice", RoomPrice);

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

        public bool UpdateRoom(string RoomNo, string RoomType, string RoomPhone, string RoomFree, string RoomPrice)
        {
            try
            {
                connection.Open();
                string query = "UPDATE room_table SET Room_Type = @RoomType, Room_Phone = @RoomPhone, Room_Free = @RoomFree, Room_Price = @RoomPrice WHERE Room_Number = @RoomNo";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomNo", RoomNo);
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    cmd.Parameters.AddWithValue("@RoomPhone", RoomPhone);
                    cmd.Parameters.AddWithValue("@RoomFree", RoomFree);
                    cmd.Parameters.AddWithValue("@RoomPrice", RoomPrice);

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
                   
                    if (result > 0)
                    {

                        string clientEmail = GetClientEmail(clientId);
                        if (!string.IsNullOrEmpty(clientEmail))
                        {
                            _emailService.SendReservationConfirmation(
                                clientEmail,
                                "Valued Guest",
                                roomType,
                                roomId,
                                reservationIn,
                                reservationOut
                            );
                        }
                    }
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
        private string GetClientEmail(string clientId)
        {
            string email = string.Empty;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = "SELECT Client_Email FROM Client_table WHERE Client_ID = @clientId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    object result = cmd.ExecuteScalar();
                    email = result?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting client email: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return email;
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

        public int Count(string query)
        {
            int result = 0;
            try
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    object count = cmd.ExecuteScalar();
                    if (count != null && int.TryParse(count.ToString(), out int countValue))
                    {
                        result = countValue;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Count function: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return result;
        }







    }
}
