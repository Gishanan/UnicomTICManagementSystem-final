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
    internal class AdminControllers
    {
        public string AddAdmin(Admin admin)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"INSERT INTO Admins (AdminName, AdminAge, AdminPhoneNumber)
                                     VALUES (@name, @age, @phone)";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@name", admin.AdminName);
                        cmd.Parameters.AddWithValue("@age", admin.AdminAge);
                        cmd.Parameters.AddWithValue("@phone", admin.AdminPhoneNumber);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Admin added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding admin: {ex.Message}";
            }
        }

        public List<Admin> GetAllAdmins()
        {
            var adminList = new List<Admin>();

            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Admins";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adminList.Add(new Admin
                            {
                                AdminId = reader.GetInt32(reader.GetOrdinal("AdminID")),
                                AdminName = reader.GetString(reader.GetOrdinal("AdminName")),
                                AdminAge = reader.GetInt32(reader.GetOrdinal("AdminAge")),
                                AdminPhoneNumber = reader.GetString(reader.GetOrdinal("AdminPhoneNumber"))
                            });
                        }
                    }
                }
            }

            return adminList;
        }

        public string UpdateAdmin(Admin admin)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"UPDATE Admins 
                                     SET AdminName = @name, AdminAge = @age, AdminPhoneNumber = @phone 
                                     WHERE AdminID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@name", admin.AdminName);
                        cmd.Parameters.AddWithValue("@age", admin.AdminAge);
                        cmd.Parameters.AddWithValue("@phone", admin.AdminPhoneNumber);
                        cmd.Parameters.AddWithValue("@id", admin.AdminId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Admin updated successfully." : "No admin was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating admin: {ex.Message}";
            }
        }

        public string DeleteAdmin(int adminId)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "DELETE FROM Admins WHERE AdminID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@id", adminId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Admin deleted successfully." : "No admin was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting admin: {ex.Message}";
            }
        }
    }
}
