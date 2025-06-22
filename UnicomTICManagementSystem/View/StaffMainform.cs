using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.View
{
    public partial class StaffMainform : Form
    {
        string _currentUserRole;
        public StaffMainform(string currentUserRole)
        {
            InitializeComponent();
            _currentUserRole = currentUserRole;
        }

        public StaffMainform( )
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentForm(_currentUserRole));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new CourseForm(_currentUserRole));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new SubjectForm(_currentUserRole));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerForm(_currentUserRole));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomFrom(_currentUserRole));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm(_currentUserRole));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadForm(new MarkForm(_currentUserRole));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             LoadForm(new ExamForm(_currentUserRole));
        }
    }
}
