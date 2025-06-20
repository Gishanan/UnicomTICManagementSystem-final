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
    internal class SubjectController
    {
        public string AddSubject(Subjet subject)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@name, @courseId)";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    cmd.Parameters.AddWithValue("@name", subject.Su_Name);
                    cmd.Parameters.AddWithValue("@courseId", subject.CourseId);
                    cmd.ExecuteNonQuery();
                }
            }
            return "Subject added successfully.";
        }

        public List<Subjet> GetAllSubjects()
        {
            List<Subjet> subjects = new List<Subjet>();
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Subjects";
                using (var cmd = new SQLiteCommand(query, dbConn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subjet
                        {
                            Su_Id = reader.GetInt32(reader.GetOrdinal("SubjectID")),
                            Su_Name = reader.GetString(reader.GetOrdinal("SubjectName")),
                            CourseId = reader.GetInt32(reader.GetOrdinal("CourseID"))
                        });
                    }
                }
            }
            return subjects;
        }

        public string UpdateSubject(Subjet subject)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "UPDATE Subjects SET SubjectName = @name, CourseID = @courseId WHERE SubjectID = @id";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    cmd.Parameters.AddWithValue("@name", subject.Su_Name);
                    cmd.Parameters.AddWithValue("@courseId", subject.CourseId);
                    cmd.Parameters.AddWithValue("@id", subject.Su_Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Subject updated successfully." : "No subject was updated.";
                }
            }
        }

        public string DeleteSubject(int subjectId)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "DELETE FROM Subjects WHERE SubjectID = @id";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    cmd.Parameters.AddWithValue("@id", subjectId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0 ? "Subject deleted successfully." : "No subject was deleted.";
                }
            }
        }
    }
}

