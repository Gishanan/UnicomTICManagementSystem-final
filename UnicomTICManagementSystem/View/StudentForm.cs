using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.View
{
    public partial class StudentForm : Form
    {
        private readonly StudentContoller _studentController;
        private readonly CourseController _courseController;
        private int _selectedStudentId = -1;

        public StudentForm()
        {
            InitializeComponent();
            _studentController = new StudentContoller();
            _courseController = new CourseController();

            comboBox277.Items.AddRange(new object[] { "A","B" });
            comboBox277.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView177.CellClick += DataGridViewStudents_CellClick;
            Load += StudentForm_Load;

            LoadStudents();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            ComboBox_Student.DataSource = _courseController.GetAllCourses();
            ComboBox_Student.DisplayMember = "Cu_Name";
            ComboBox_Student.ValueMember = "Cu_Id";
        }

        private void LoadStudents()
        {
            try
            {
                List<Student> students = _studentController.GetAllStudents();
                dataGridView177.DataSource = students;
                dataGridView177.ClearSelection();
                ClearInputs();
                _selectedStudentId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            name.Clear();
            ages.Clear();
            address.Clear();
            phonenumber.Clear();
            ComboBox_Student.SelectedIndex = -1;
            comboBox277.SelectedIndex = -1;
        }

        private void Add_Student_Click(object sender, EventArgs e)
        {
            if (IsFormInvalid()) return;

            Student student = new Student
            {
                St_Name = name.Text,
                St_Age = int.Parse(ages.Text),
                St_Address = address.Text,
                St_PhoneNumber = phonenumber.Text,
                CourseId = (int)ComboBox_Student.SelectedValue,
                ClassName = comboBox277.SelectedItem?.ToString()
            };

            string message = _studentController.AddStudent(student);
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadStudents();
        }

        private void Update_Student_Click(object sender, EventArgs e)
        {
            if (_selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsFormInvalid()) return;

            Student student = new Student
            {
                St_Id = _selectedStudentId,
                St_Name = name.Text,
                St_Age = int.Parse(ages.Text),
                St_Address = address.Text,
                St_PhoneNumber = phonenumber.Text,
                CourseId = (int)ComboBox_Student.SelectedValue,
                ClassName = comboBox277.SelectedItem?.ToString()
            };

            string message = _studentController.UpdateStudent(student);
            MessageBox.Show(message, "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadStudents();
        }

        private void Delete_Student_Click(object sender, EventArgs e)
        {
            if (_selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            string message = _studentController.DeleteStudent(_selectedStudentId);
            MessageBox.Show(message, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadStudents();
        }

        private void DataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView177.Rows[e.RowIndex];
                _selectedStudentId = Convert.ToInt32(row.Cells["St_Id"].Value);
                comboBox277.Text = row.Cells["ClassName"].Value?.ToString();


                name.Text = row.Cells["St_Name"].Value?.ToString();
                ages.Text = row.Cells["St_Age"].Value?.ToString();
                address.Text = row.Cells["St_Address"].Value?.ToString();
                phonenumber.Text = row.Cells["St_PhoneNumber"].Value?.ToString();
                ComboBox_Student.SelectedValue = Convert.ToInt32(row.Cells["CourseId"].Value);
            }
        }

        private bool IsFormInvalid()
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(ages.Text) ||
                string.IsNullOrWhiteSpace(address.Text) ||
                string.IsNullOrWhiteSpace(phonenumber.Text) ||
               ComboBox_Student.SelectedIndex == -1 || comboBox277.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (!int.TryParse(ages.Text, out _))
            {
                MessageBox.Show("Please enter a valid number for Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                St_Name = name.Text,
                St_Age = Convert.ToInt32(ages.Text),
                St_Address = address.Text,
                St_PhoneNumber = phonenumber.Text,
                CourseId = Convert.ToInt32(ComboBox_Student.SelectedValue),
                ClassName = comboBox277.Text
            };

            StudentContoller controller = new StudentContoller();
            string message = controller.AddStudent(student);  // or UpdateStudent

            MessageBox.Show(message);

            // Refresh Main Form table after add
            if (Application.OpenForms["StudentMainForm"] is StudentMainForm mainForm)
            {
                mainForm.RefreshGrid();
            }

            this.Close();  // Optional: close StudentForm
        }

        private void dataGridView177_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox_Student_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Next_Student_Click(object sender, EventArgs e)
        {
           LoadForm(new SubjectForm());
        }

        private void Back_Student_Click(object sender, EventArgs e)
        {
            LoadForm(new CourseForm());
        }
    }
}


