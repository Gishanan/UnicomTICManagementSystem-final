using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Data
{
    internal class Migrations
    {
        public static void RegisterMigrations()
        {
            using (var getDbconn = Dbcon.GetConnection())
            {
                string CreateTable = @"CREATE TABLE IF NOT EXISTS Users (
                            UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL,
                            Password TEXT NOT NULL,
                            ReferenseId TEXT NOT NULL,
                            Role TEXT NOT NULL
                         );";

                SQLiteCommand sQLiteCommand = new SQLiteCommand(CreateTable, getDbconn);
                sQLiteCommand.ExecuteNonQuery();
                MessageBox.Show("table created");


                string createCoursesTable = @"CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL
                );";
                SQLiteCommand coursesCommand = new SQLiteCommand(createCoursesTable, getDbconn);
                coursesCommand.ExecuteNonQuery();
                MessageBox.Show("Courses table created");


                string createRoomsTable = @"CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL,
                    RoomType TEXT NOT NULL
                );";
                SQLiteCommand roomsCommand = new SQLiteCommand(createRoomsTable, getDbconn);
                roomsCommand.ExecuteNonQuery();
                MessageBox.Show("Rooms table created");


                string createSubjectsTable = @"CREATE TABLE IF NOT EXISTS Subjects (
                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        CourseID INTEGER,
                        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                    );";
                SQLiteCommand subjectsCommand = new SQLiteCommand(createSubjectsTable, getDbconn);
                subjectsCommand.ExecuteNonQuery();
                MessageBox.Show("Subjects table created");


                string createStudentsTable = @"CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Age INTEGER NOT NULL,
                    PhoneNumber TEXT NOT NULL,
                    Address TEXT NOT NULL,
                   ClassName TEXT NOT NULL,
                    CourseID INTEGER,
                    UserID INTEGER,
                    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                );";
                SQLiteCommand studentsCommand = new SQLiteCommand(createStudentsTable, getDbconn);
                studentsCommand.ExecuteNonQuery();
                MessageBox.Show("Students table created");
                    

                string createExamsTable = @"CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        SubjectID INTEGER,
                        StartTime TEXT NOT NULL,
                        EndTime TEXT NOT NULL,
                        Date TEXT NOT NULL,
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                    );";
                SQLiteCommand examsCommand = new SQLiteCommand(createExamsTable, getDbconn);
                examsCommand.ExecuteNonQuery();
                MessageBox.Show("Exams table created");


                string createMarksTable = @"CREATE TABLE IF NOT EXISTS Marks (
                            MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentID INTEGER,
                            ExamID INTEGER,
                            Score INTEGER,
                            FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                            FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
                        );";
                SQLiteCommand marksCommand = new SQLiteCommand(createMarksTable, getDbconn);
                marksCommand.ExecuteNonQuery();
                MessageBox.Show("Marks table created");


                string createTimetablesTable = @"CREATE TABLE IF NOT EXISTS Timetables (
                        TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        LecturerID INTEGER,
                        SubjectID INTEGER,
                        RoomID INTEGER,
                        StartTime TEXT NOT NULL,
                        EndTime TEXT NOT NULL,
                        Date TEXT NOT NULL,
                        ClassName TEXT NOT NULL,
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                        FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
                    );";
                SQLiteCommand timetablesCommand = new SQLiteCommand(createTimetablesTable, getDbconn);
                timetablesCommand.ExecuteNonQuery();
                MessageBox.Show("Timetables table created");


               

                string createLecturersTable = @"CREATE TABLE IF NOT EXISTS Lecturers (
                    LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                    LecturerName TEXT NOT NULL,
                    SubjectID INTEGER,
                    UserID INTEGER,
                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                    FOREIGN KEY (UserID) REFERENCES Users(UserID)
                );";

                SQLiteCommand lecturersCommand = new SQLiteCommand(createLecturersTable, getDbconn);
                lecturersCommand.ExecuteNonQuery();
                MessageBox.Show("Lecturers table created");

                string createLecturerStudentsTable = @"
                                CREATE TABLE IF NOT EXISTS LecturerStudents (
                                    LecturerID INTEGER NOT NULL,
                                    StudentID INTEGER NOT NULL,
                                    SubjectID INTEGER NOT NULL,
                                    PRIMARY KEY (LecturerID, StudentID, SubjectID),
                                    FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                                );";

                SQLiteCommand lecturerStudentsCommand = new SQLiteCommand(createLecturerStudentsTable, getDbconn);
                lecturerStudentsCommand.ExecuteNonQuery();
                MessageBox.Show("LecturerStudents table created");

                string createAdminsTable = @"
                    CREATE TABLE IF NOT EXISTS Admins (
                        AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                        AdminName TEXT NOT NULL,
                        AdminAge INTEGER NOT NULL,
                        AdminPhoneNumber TEXT NOT NULL
                    );";

                SQLiteCommand adminsCommand = new SQLiteCommand(createAdminsTable, getDbconn);
                adminsCommand.ExecuteNonQuery();
                MessageBox.Show("Admins table created");

                 string createSFattsTable = @"
                    CREATE TABLE IF NOT EXISTS SFatts (
                        StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StaffName TEXT NOT NULL,
                        StaffAge INTEGER NOT NULL,
                        StaffPhoneNumber TEXT NOT NULL
                    );";

                SQLiteCommand sfattsCommand = new SQLiteCommand(createSFattsTable, getDbconn);
                sfattsCommand.ExecuteNonQuery();
                MessageBox.Show("SFatts table created");






            }

        }
    }
}
