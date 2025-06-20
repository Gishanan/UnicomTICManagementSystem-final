using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentContoller
    {
        public string AddStudent(Student student)
        {
            using (var Dbconn = Dbcon.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Students(Name, Age, Address, PhoneNumber, CourseID,ClassName) VALUES(@name, @age, @address, @phonenumber, @courseId,@ClassName)";
                using (SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, Dbconn))
                {
                    insertStudentCommand.Parameters.AddWithValue("@name", student.St_Name);
                    insertStudentCommand.Parameters.AddWithValue("@age", student.St_Age);
                    insertStudentCommand.Parameters.AddWithValue("@address", student.St_Address);
                    insertStudentCommand.Parameters.AddWithValue("@phonenumber", student.St_PhoneNumber);
                    insertStudentCommand.Parameters.AddWithValue("@courseId", student.CourseId);
                    insertStudentCommand.Parameters.AddWithValue("@ClassName", student.ClassName);
                    insertStudentCommand.ExecuteNonQuery();
                }
            }

            return "Student added";
        }


        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var getDbconn = Dbcon.GetConnection())
            {
                var cmd = getDbconn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Students";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            St_Id = reader.GetInt32(reader.GetOrdinal("StudentID")),
                            St_Name = reader.GetString(reader.GetOrdinal("Name")),
                            St_Age = reader.GetInt32(reader.GetOrdinal("Age")),
                            St_Address = reader.GetString(reader.GetOrdinal("Address")),
                            St_PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                            CourseId = reader.IsDBNull(reader.GetOrdinal("CourseID")) ? 0 : reader.GetInt32(reader.GetOrdinal("CourseID")),
                            ClassName = reader.GetString(reader.GetOrdinal("ClassName"))
                        });
                    }
                }
            }
            return students;
        }


        public string UpdateStudent(Student student)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string updateQuery = @"UPDATE Students 
                               SET Name = @name, Age = @age, Address = @address, PhoneNumber = @phonenumber, CourseID = @courseId ,ClassName = @ClassName
                               WHERE StudentID = @id";

                using (var cmd = new SQLiteCommand(updateQuery, dbConn))
                {
                    cmd.Parameters.AddWithValue("@name", student.St_Name);
                    cmd.Parameters.AddWithValue("@age", student.St_Age);
                    cmd.Parameters.AddWithValue("@address", student.St_Address);
                    cmd.Parameters.AddWithValue("@phonenumber", student.St_PhoneNumber);
                    cmd.Parameters.AddWithValue("@courseId", student.CourseId);
                    cmd.Parameters.AddWithValue("@id", student.St_Id);
                    cmd.Parameters.AddWithValue("@ClassName", student.ClassName);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Student updated successfully." : "No student was updated.";
                }
            }
        }



        public string DeleteStudent(int studentId)
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "DELETE FROM Students WHERE StudentID = @id";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0 ? "Student deleted successfully." : "No student was deleted.";
                }
            }
        }


    }
}
