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

namespace UnicomTICManagementSystem.View
{
    public partial class LecturerMainForm : Form
    {
        public LecturerMainForm()
        {
            InitializeComponent();
            //panel2.Controls.Add(dataGridView1660);      // add to main form
            //panel2.Controls.Remove(dataGridView1660); // remove from panel2
           // dataGridView1660.BringToFront();
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



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Mark_Click(object sender, EventArgs e)
        {
            LoadForm(new MarkForm());
        }

        private void Main_Exam_Click(object sender, EventArgs e)
        {
            
            ExamControllers examControllers = new ExamControllers();
            dataGridView1660.DataSource = examControllers.GetAllExams();
        }

        private void Main_TimeTable_Click(object sender, EventArgs e)
        {
            
            TimetableControllers timetableControllers = new TimetableControllers();
            dataGridView1660.DataSource = timetableControllers.GetAllTimetables();  
        }

        private void Main_Course_Click(object sender, EventArgs e)
        {
           
            CourseController courseControllers = new CourseController();
            dataGridView1660.DataSource = courseControllers.GetAllCourses();
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
}
