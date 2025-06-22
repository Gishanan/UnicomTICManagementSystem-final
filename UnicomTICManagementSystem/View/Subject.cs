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
    public partial class SubjectForm : Form
    {
        string _currentUserRole;
        private readonly SubjectController _subjectController;
        private int _selectedSubjectId = -1;

        public SubjectForm()
        {
            InitializeComponent();
            _subjectController = new SubjectController();
            dataGridView24.CellClick += DataGridView1_CellClick;
            Load += SubjectForm_Load;

            LoadSubjects();
        }
        public SubjectForm(string currentUserRole = "")
        {
            _subjectController = new SubjectController();
            _currentUserRole = currentUserRole;
            InitializeComponent();
            dataGridView24.CellClick += DataGridView1_CellClick;
            Load += SubjectForm_Load;

            if (currentUserRole.ToLower() == "admin")
            {
                Add_Subject.Visible = true;
                Update_subject.Visible = true;
                Delete_Subject.Visible = true;
            }else if (currentUserRole.ToLower() =="staff")
            {
                Add_Subject.Visible = false;
                Update_subject.Visible = false;
                Delete_Subject.Visible = false;
                Back_Subject.Visible = false;
                Next_Subject.Visible = false;
            }else if (currentUserRole.ToLower() == "lecturer")
            {
                Add_Subject.Visible = false;
                Update_subject.Visible = false;
                Delete_Subject.Visible = false;
                Back_Subject.Visible = false;
                Next_Subject.Visible = false;

                
            }
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                List<Subjet> subjects = _subjectController.GetAllSubjects();
                dataGridView24.DataSource = subjects;
                dataGridView24.ClearSelection();
                ClearInputs();
                _selectedSubjectId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            SubjectName.Text = string.Empty;
            comboBox11.SelectedIndex = -1;
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            // Load courses into ComboBox for assigning subjects to courses
            CourseController courseController = new CourseController();
            comboBox11.DataSource = courseController.GetAllCourses();
            comboBox11.DisplayMember = "Cu_Name";
            comboBox11.ValueMember = "Cu_Id";
        }

        private void Add_Subject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SubjectName.Text) || comboBox11.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Subjet subjet = new Subjet
            {
                Su_Name = SubjectName.Text,
                CourseId = (int)comboBox11.SelectedValue
            };

            string message = _subjectController.AddSubject(subjet);
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSubjects();
        }

        private void Update_subject_Click(object sender, EventArgs e)
        {
            if (_selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(SubjectName.Text) || comboBox11.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Subjet subjet   = new Subjet
            {
                Su_Id = _selectedSubjectId,
                Su_Name = SubjectName.Text,
                CourseId = (int)comboBox11.SelectedValue
            };

            string message = _subjectController.UpdateSubject(subjet);

            MessageBox.Show(message, "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSubjects();
        }

        private void Delete_Subject_Click(object sender, EventArgs e)
        {
            if (_selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            string message = _subjectController.DeleteSubject(_selectedSubjectId);
            MessageBox.Show(message, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSubjects();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView24.Rows[e.RowIndex];

                _selectedSubjectId = Convert.ToInt32(row.Cells["Sub_Id"].Value);
                SubjectName.Text = row.Cells["Sub_Name"].Value?.ToString();

                if (row.Cells["CourseId"].Value != null)
                {
                    comboBox11.SelectedValue = Convert.ToInt32(row.Cells["CourseId"].Value);
                }
            }
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

        private void Next_Subject_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerForm());
        }

        private void Back_Subject_Click(object sender, EventArgs e)
        {
          LoadForm(new StudentForm());
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
