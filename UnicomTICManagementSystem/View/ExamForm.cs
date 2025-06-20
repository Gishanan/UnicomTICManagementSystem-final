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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.View
{
    public partial class ExamForm : Form
    {
        private readonly SubjectController subjectController = new SubjectController();
        private readonly ExamControllers examController = new ExamControllers(); // Instance of ExamControllers
        private int _selectedExamId = -1; // To store the ID of the selected exam for updates/deletes

        public ExamForm()
        {
            InitializeComponent();

            // Wire up event handlers
            this.Load += ExamForm_Load;
            Add_Exam.Click += Add_Exam_Click;
            Update_Exam.Click += Update_Exam_Click;
            Delete_Exam.Click += Delete_Exam_Click;
            dataGridView109.CellClick += dataGridView109_CellClick; // Assuming your DataGridView for exams is named dataGridView1
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadExams();
        }

        private void LoadSubjects()
        {
            try
            {
                comboBox88.DataSource = subjectController.GetAllSubjects();
                comboBox88.DisplayMember = "Su_Name"; // Assuming Subject model has Su_Name
                comboBox88.ValueMember = "Su_Id";     // Assuming Subject model has Su_Id
                comboBox88.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExams()
        {
            try
            {
                dataGridView109.DataSource = examController.GetAllExams(); // Assuming dataGridView1 is where exams are displayed
                dataGridView109.ClearSelection();
                ClearInputs();
                _selectedExamId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading exams: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            Names.Clear(); // Assuming you have a TextBox for ExamName
            comboBox88.SelectedIndex = -1;
            dateTimePicker88.Value = DateTime.Now; // Assuming dateTimePicker1 for StartTime
            dateTimePicker22.Value = DateTime.Now; // Assuming dateTimePicker2 for EndTime
            dateTimePicker33.Value = DateTime.Now; // Assuming dateTimePicker3 for Date
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(Names.Text) || comboBox88.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all exam fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dateTimePicker88.Value >= dateTimePicker22.Value)
            {
                MessageBox.Show("Start time must be before end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Add_Exam_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var newExam = new Exam
            {
                ExamName = Names.Text, // Assuming textBox1 is for ExamName
                SubjectID = (int)comboBox88.SelectedValue,
                StartTime = dateTimePicker88.Value,
                EndTime = dateTimePicker22.Value,
                Date = dateTimePicker33.Value.Date
            };

            string message = examController.AddExam(newExam);
            MessageBox.Show(message, "Add Exam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadExams();
        }

        private void Update_Exam_Click(object sender, EventArgs e)
        {
            if (_selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            var updatedExam = new Exam
            {
                ExamID = _selectedExamId,
                ExamName = Names.Text,
                SubjectID = (int)comboBox88.SelectedValue,
                StartTime = dateTimePicker88.Value,
                EndTime = dateTimePicker22.Value,
                Date = dateTimePicker33.Value.Date
            };

            string message = examController.UpdateExam(updatedExam);
            MessageBox.Show(message, "Update Exam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadExams();
        }

        private void Delete_Exam_Click(object sender, EventArgs e)
        {
            if (_selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            string message = examController.DeleteExam(_selectedExamId);
            MessageBox.Show(message, "Delete Exam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadExams();
        }

        private void dataGridView109_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView109.Rows[e.RowIndex];

                _selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                Names.Text = row.Cells["ExamName"].Value?.ToString();

                // Find the subject in the ComboBox by its ID
                if (row.Cells["SubjectID"].Value != DBNull.Value)
                {
                    comboBox88.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
                }
                else
                {
                    comboBox88.SelectedIndex = -1;
                }

                dateTimePicker88.Value = Convert.ToDateTime(row.Cells["StartTime"].Value);
                dateTimePicker22.Value = Convert.ToDateTime(row.Cells["EndTime"].Value);
                dateTimePicker33.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            }
        }

        // Keep the existing empty methods if they are required by the designer, otherwise you can remove them.
        private void comboBox88_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Next_Exam_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerStudentControllersForm());
        }

        private void Back_Exam_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm());
        }
    }
}
