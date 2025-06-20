using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.View;

namespace UnicomTICManagementSystem.View
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
           

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

       
        private void Main_Course_Click(object sender, EventArgs e)
        {
            LoadForm(new CourseForm());
        }

        private void Main_Student_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentForm());
        }

        private void Main_Subject_Click(object sender, EventArgs e)
        {
            LoadForm(new SubjectForm());
        }

        private void Main_Lecturer_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerForm());
        }

        private void Main_Room_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomFrom());
        }

        private void Main_Ls_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerStudentControllersForm());
        }

        private void Main_Aimin_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminForm());
        }

        private void Main_Staff_Click(object sender, EventArgs e)
        {
            LoadForm(new StaffForm());
        }

        private void Main_Time_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm());
        }

        private void Main_Exam_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamForm());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Mark_Click(object sender, EventArgs e)
        {
            LoadForm(new MarkForm());
        }

        private void Main_logout_Click(object sender, EventArgs e)
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
}
