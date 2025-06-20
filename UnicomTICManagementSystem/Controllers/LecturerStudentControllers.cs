using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class LecturerStudentControllers
    {
        public DataTable GetLecturerStudentView()
        {
            using (var dbConn = Dbcon.GetConnection())
            {
                // Optional: Ensure table still exists at runtime
                string sql = @"
        CREATE TABLE IF NOT EXISTS LecturerStudents (
            LecturerID INTEGER NOT NULL,
            StudentID INTEGER NOT NULL,
            SubjectID INTEGER NOT NULL,
            PRIMARY KEY (LecturerID, StudentID, SubjectID),
            FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
            FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
            FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
        );";

                using (var cmd = new SQLiteCommand(sql, dbConn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Correct SELECT query using exact table and column names
                string query = @"
            SELECT 
                ls.LecturerID, 
                ls.StudentID, 
                ls.SubjectID
            FROM LecturerStudents ls";

                using (var adapter = new SQLiteDataAdapter(query, dbConn))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

    }
}
