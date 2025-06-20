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
    internal class CourseController
    {
        public string AddCourse(Course course)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "INSERT INTO Courses (CourseName) VALUES (@CourseName)";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@CourseName", course.Cu_Name);
                        cmd.ExecuteNonQuery();
                    }

                  
                }
                return "Course added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding course: {ex.Message}";
            }
        }

        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();

            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Courses";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course
                            {
                                Cu_Id = reader.GetInt32(reader.GetOrdinal("CourseID")),
                                Cu_Name = reader.GetString(reader.GetOrdinal("CourseName"))
                            });
                        }
                    }
                }
            }

            return courses;
        }

        public string UpdateCourse(Course course)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "UPDATE Courses SET CourseName = @CourseName WHERE CourseID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@CourseName", course.Cu_Name);
                        cmd.Parameters.AddWithValue("@id", course.Cu_Id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Course updated successfully." : "No course was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating course: {ex.Message}";
            }
        }


        public string DeleteCourse(int courseId)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "DELETE FROM Courses WHERE CourseID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@id", courseId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Course deleted successfully." : "No course was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting course: {ex.Message}";
            }
        }

    }
}

