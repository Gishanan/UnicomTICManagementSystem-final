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
    internal class MarkControllers
    {
        public string AddMark(Mark mark)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", mark.StudentId);
                        cmd.Parameters.AddWithValue("@ExamID", mark.ExamId);
                        cmd.Parameters.AddWithValue("@Score", mark.score);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Mark added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding mark: {ex.Message}";
            }
        }

        public List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Marks";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marks.Add(new Mark
                            {
                                MarkId = reader.GetInt32(reader.GetOrdinal("MarkID")),
                                StudentId = reader.GetInt32(reader.GetOrdinal("StudentID")),
                                ExamId = reader.GetInt32(reader.GetOrdinal("ExamID")),
                                score = reader.GetInt32(reader.GetOrdinal("Score"))
                            });
                        }
                    }
                }
            }
            return marks;
        }

        public string UpdateMark(Mark mark)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @MarkID";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", mark.StudentId);
                        cmd.Parameters.AddWithValue("@ExamID", mark.ExamId);
                        cmd.Parameters.AddWithValue("@Score", mark.score);
                        cmd.Parameters.AddWithValue("@MarkID", mark.MarkId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Mark updated successfully." : "No mark was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating mark: {ex.Message}";
            }
        }

        public string DeleteMark(int markId)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "DELETE FROM Marks WHERE MarkID = @MarkID";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@MarkID", markId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Mark deleted successfully." : "No mark was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting mark: {ex.Message}";
            }
        }
    }
}
