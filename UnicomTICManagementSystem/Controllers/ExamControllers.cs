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
    internal class ExamControllers
    {
        public string AddExam(Exam exam)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"INSERT INTO Exams 
                        (ExamName, SubjectID, StartTime, EndTime, Date)
                        VALUES 
                        (@examName, @subjectId, @startTime, @endTime, @date)";

                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@examName", exam.ExamName);
                        cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                        cmd.Parameters.AddWithValue("@startTime", exam.StartTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@endTime", exam.EndTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@date", exam.Date.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();

                        return "Exam added successfully.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error adding exam: {ex.Message}";
            }
        }

        public List<Exam> GetAllExams()
        {
            List<Exam> exams = new List<Exam>();

            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Exams";
                using (var cmd = new SQLiteCommand(query, dbConn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            ExamID = reader.GetInt32(reader.GetOrdinal("ExamID")),
                            ExamName = reader.GetString(reader.GetOrdinal("ExamName")),
                            SubjectID = reader.GetInt32(reader.GetOrdinal("SubjectID")),
                            StartTime = DateTime.Parse(reader.GetString(reader.GetOrdinal("StartTime"))),
                            EndTime = DateTime.Parse(reader.GetString(reader.GetOrdinal("EndTime"))),
                            Date = DateTime.Parse(reader.GetString(reader.GetOrdinal("Date")))
                        });
                    }
                }
            }

            return exams;
        }

        public string UpdateExam(Exam exam)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"UPDATE Exams 
                        SET ExamName = @examName,
                            SubjectID = @subjectId,
                            StartTime = @startTime,
                            EndTime = @endTime,
                            Date = @date
                        WHERE ExamID = @id";

                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@examName", exam.ExamName);
                        cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                        cmd.Parameters.AddWithValue("@startTime", exam.StartTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@endTime", exam.EndTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@date", exam.Date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@id", exam.ExamID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Exam updated successfully." : "No exam was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating exam: {ex.Message}";
            }
        }

        public string DeleteExam(int examId)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "DELETE FROM Exams WHERE ExamID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@id", examId);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0 ? "Exam deleted successfully." : "No exam found to delete.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting exam: {ex.Message}";
            }
        }
    }
}
