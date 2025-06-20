using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class StudentMainForm : Form
    {
        private readonly StudentForm _studentForm;
        public StudentMainForm()
        {
           
         
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadForm(Form form)
        {
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();
        }

        public DataTable ConvertToDataTable(List<Student> students)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Address");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("CourseID");
            dt.Columns.Add("ClassName");

            foreach (var student in students)
            {
                dt.Rows.Add(student.St_Id, student.St_Name, student.St_Age, student.St_Address, student.St_PhoneNumber, student.CourseId, student.ClassName);
            }

            return dt;
        }

        
        private void Studet_Main_Click(object sender, EventArgs e, StudentContoller studentContoller)
        {
            
        }



        public void RefreshGrid()
        {
            
        }

        private void Studet_Main_Click(object sender, EventArgs e)
        {
            StudentContoller studentContoller = new StudentContoller();
           dataGridView1.DataSource = studentContoller.GetAllStudents();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void Main_Exam_Click(object sender, EventArgs e)
        {
            ExamControllers examControllers = new ExamControllers();
            dataGridView1.DataSource = examControllers.GetAllExams();

        }

        private void Main_Mark_Click(object sender, EventArgs e)
        {
            MarkControllers markControllers = new MarkControllers();
            dataGridView1.DataSource = markControllers.GetAllMarks();

        }

        private void Main_Course_Click(object sender, EventArgs e)
        {
            CourseController courseController = new CourseController();
            dataGridView1.DataSource = courseController.GetAllCourses();
        }

        private void Main_Subject_Click(object sender, EventArgs e)
        {
            SubjectController subjectController = new SubjectController();
            dataGridView1.DataSource = subjectController.GetAllSubjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }

    internal class ConvertToDataTable
    {
    }
}
