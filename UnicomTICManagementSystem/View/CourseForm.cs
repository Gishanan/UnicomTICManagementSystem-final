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
    public partial class CourseForm : Form
    {
        string _currentUserRole;
        private readonly CourseController _courseController;
        
         private int _selectedCourseId = -1;


        public CourseForm()
        {
            InitializeComponent();
            _courseController = new CourseController();

            dataGridView1.CellClick += dataGridView1_CellContentClick;

            LoadCourses();
        }


        public CourseForm(string currentUserRole = "")
        {
            _currentUserRole = currentUserRole;
            InitializeComponent();

            if (currentUserRole.ToLower() == "admin")
            {
                Add_Course.Visible = true;
                Update_Course.Visible = true;
                Delete_Course.Visible = true;
            }
            else if (currentUserRole.ToLower() == "staff")
            {
                Add_Course.Visible = false;
                Update_Course.Visible = false;
                Delete_Course.Visible = false;
                Back_Course.Visible = false;
                Next_Course.Visible = false;
            }
            else if (currentUserRole.ToLower() == "lecturer")
            {
                Add_Course.Visible = false;
                Update_Course.Visible = false;
                Delete_Course.Visible = false;
                Back_Course.Visible = false;
                Next_Course.Visible = false;
            }

            _courseController = new CourseController();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            LoadCourses();


        }


        private void LoadCourses()
        {
            try
            {
                var courses = _courseController.GetAllCourses();
                dataGridView1.DataSource = courses;
                dataGridView1.ClearSelection();
                ClearInputs();
                _selectedCourseId = -1;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            CourseName.Text = string.Empty;
        }


        private void Add_Course_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CourseName.Text))
            {
                MessageBox.Show("Please enter course name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var course = new Course
            {
                Cu_Name = CourseName.Text.Trim()
            };

            string message = _courseController.AddCourse(course);
            MessageBox.Show(message, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCourses();
        }

        private void Update_Course_Click(object sender, EventArgs e)
        {
            if (_selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(CourseName.Text))
            {
                MessageBox.Show("Please enter course name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var course = new Course
            {
                Cu_Id = _selectedCourseId,
                Cu_Name = CourseName.Text.Trim()
            };

            
            string message = _courseController.UpdateCourse(course); 
            MessageBox.Show(message, "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCourses();


        }

        private void Delete_Course_Click(object sender, EventArgs e)
        {
            if (_selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            string message = _courseController.DeleteCourse(_selectedCourseId);
            MessageBox.Show(message, "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCourses();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                _selectedCourseId = Convert.ToInt32(row.Cells["Cu_Id"].Value);
                CourseName.Text = row.Cells["Cu_Name"].Value?.ToString();
            }
        }

        private void CourseName_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }

        private void Next_Course_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentForm());
        }

        private void Back_Course_Click(object sender, EventArgs e)
        {
            LoadForm(new StaffForm());
        }
    }
}
