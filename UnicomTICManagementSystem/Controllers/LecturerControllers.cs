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
    public class LecturerController
    {
        public string AddLecturer(Lecturer lecturer)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = @"INSERT INTO Lecturers (LecturerName, SubjectID, UserID)
                                 VALUES (@name, @subjectId, @userId)";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    cmd.Parameters.AddWithValue("@name", lecturer.LecturerName);
                    cmd.Parameters.AddWithValue("@subjectId", lecturer.SubjectID);
                    cmd.Parameters.AddWithValue("@userId", lecturer.UserID);

                    cmd.ExecuteNonQuery();
                }
            }

            return "Lecturer added successfully.";
        }

        public List<Lecturer> GetAllLecturers()
        {
            var lecturers = new List<Lecturer>();

            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Lecturers";
                using (var cmd = new SQLiteCommand(query, dbConn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturers.Add(new Lecturer
                        {
                            LecturerID = reader.GetInt32(reader.GetOrdinal("LecturerID")),
                            LecturerName = reader.GetString(reader.GetOrdinal("LecturerName")),
                            SubjectID = reader.IsDBNull(reader.GetOrdinal("SubjectID")) ? 0 : reader.GetInt32(reader.GetOrdinal("SubjectID")),
                            UserID = reader.IsDBNull(reader.GetOrdinal("UserID")) ? 0 : reader.GetInt32(reader.GetOrdinal("UserID"))
                        });
                    }
                }
            }

            return lecturers;
        }

        public string UpdateLecturer(Lecturer lecturer)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = @"UPDATE Lecturers
                                 SET LecturerName = @name, SubjectID = @subjectId, UserID = @userId
                                 WHERE LecturerID = @id";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    cmd.Parameters.AddWithValue("@name", lecturer.LecturerName);
                    cmd.Parameters.AddWithValue("@subjectId", lecturer.SubjectID);
                    cmd.Parameters.AddWithValue("@userId", lecturer.UserID);
                    cmd.Parameters.AddWithValue("@id", lecturer.LecturerID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Lecturer updated successfully." : "No lecturer was updated.";
                }
            }
        }

        public string DeleteLecturer(int lecturerId)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "DELETE FROM Lecturers WHERE LecturerID = @id";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    cmd.Parameters.AddWithValue("@id", lecturerId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0 ? "Lecturer deleted successfully." : "No lecturer was deleted.";
                }
            }
        }
    }
}
