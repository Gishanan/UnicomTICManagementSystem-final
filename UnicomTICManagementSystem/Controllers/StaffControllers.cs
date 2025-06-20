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
    internal class StaffControllers
    {
        public string AddStaff(Staff staff)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"INSERT INTO SFatts (StaffName, StaffAge, StaffPhoneNumber)
                                     VALUES (@name, @age, @phone)";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@name", staff.StaffName);
                        cmd.Parameters.AddWithValue("@age", staff.StaffAge);
                        cmd.Parameters.AddWithValue("@phone", staff.StaffPhoneNumber);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "Staff added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding staff: {ex.Message}";
            }
        }

        public List<Staff> GetAllStaff()
        {
            var staffList = new List<Staff>();

            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM SFatts";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staffList.Add(new Staff
                            {
                                StaffId = reader.GetInt32(reader.GetOrdinal("StaffID")),
                                StaffName = reader.GetString(reader.GetOrdinal("StaffName")),
                                StaffAge = reader.GetInt32(reader.GetOrdinal("StaffAge")),
                                StaffPhoneNumber = reader.GetString(reader.GetOrdinal("StaffPhoneNumber"))
                            });
                        }
                    }
                }
            }

            return staffList;
        }

        public string UpdateStaff(Staff staff)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"UPDATE SFatts 
                                     SET StaffName = @name, StaffAge = @age, StaffPhoneNumber = @phone 
                                     WHERE StaffID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@name", staff.StaffName);
                        cmd.Parameters.AddWithValue("@age", staff.StaffAge);
                        cmd.Parameters.AddWithValue("@phone", staff.StaffPhoneNumber);
                        cmd.Parameters.AddWithValue("@id", staff.StaffId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Staff updated successfully." : "No staff was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating staff: {ex.Message}";
            }
        }

        public string DeleteStaff(int staffId)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string checkQuery = "SELECT COUNT(*) FROM SFatts WHERE StaffID = @id";
                    using (var checkCmd = new SQLiteCommand(checkQuery, dbConn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", staffId);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            return "Staff ID not found in the database.";
                        }
                    }

                    string query = "DELETE FROM SFatts WHERE StaffID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@id", staffId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Staff deleted successfully." : "No staff was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting staff: {ex.Message}";
            }
        }

    }
}
