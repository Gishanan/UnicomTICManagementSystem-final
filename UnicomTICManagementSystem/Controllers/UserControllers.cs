using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class UserControllers
    {
        
        public string AddUser(User user, string username)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"INSERT INTO Users (Username, Password, ReferenseId, Role) 
                                     VALUES (@Username, @Password, @ReferenseId, @Role)";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", user.PassWord);
                        cmd.Parameters.AddWithValue("@ReferenseId", user.ReferenseId);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "User added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding user: {ex.Message}";
            }
        }

    
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Users";
                using (var cmd = new SQLiteCommand(query, dbConn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                            PassWord = reader.GetString(reader.GetOrdinal("Password")),
                            ReferenseId = Convert.ToInt32(reader["ReferenseId"]),
                            Role = reader.GetString(reader.GetOrdinal("Role"))
                        });
                    }
                }
            }

            return users;
        }

       
        public string UpdateUser(User user, string username)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"UPDATE Users 
                                     SET Username = @Username, Password = @Password, 
                                         ReferenseId = @ReferenseId, Role = @Role 
                                     WHERE UserID = @UserID";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", user.PassWord);
                        cmd.Parameters.AddWithValue("@ReferenseId", user.ReferenseId);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@UserID", user.UserID);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0 ? "User updated successfully." : "No user was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating user: {ex.Message}";
            }
        }

        //
        public string DeleteUser(int userId)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0 ? "User deleted successfully." : "No user was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting user: {ex.Message}";
            }
        }

        
        public User GetUserByCredentials(string username, string password)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                PassWord = reader["Password"].ToString(),
                                ReferenseId = Convert.ToInt32(reader["ReferenseId"]),
                                Role = reader["Role"].ToString()
                            };
                        }
                    }
                }
            }

            return null; 
        }
    }
}
