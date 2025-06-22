using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Migrations.RegisterMigrations();
            Application.Run(new View.LoginForm());
            //Application.Run(new View.UserForm());
            //Application.Run(new View.MainForm());
           // Application.Run(new View.LecturerMainForm());
            //Application.Run(new View.StaffForm());
            //Application.Run(new View.AdminForm());
            //Application.Run(new View.StudentMainForm());
            //Application.Run(new View.CourseForm());
            //Application.Run(new View.StudentForm());
            //Application.Run(new View.SubjectForm());
            //Application.Run(new View.LecturerForm());
            //Application.Run(new View.LecturerStudentControllersForm());
            //Application.Run(new View.RoomFrom());
            //Application.Run(new View.ExamForm());
            //Application.Run(new View.MarkForm());
            //Application.Run(new View.TimetableForm());




        }
    }
}
