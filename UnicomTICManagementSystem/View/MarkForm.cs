using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class MarkForm : Form
    {
        private readonly StudentContoller _studentController = new StudentContoller();
        private readonly ExamControllers _examController = new ExamControllers();
        private readonly MarkControllers _markController = new MarkControllers(); 

        private int _selectedMarkId = -1; 
        string _currentUserRole;
        public MarkForm( )
        {
            InitializeComponent();
            LoadStudents();
            LoadExams();
            LoadMarks();

            dataGridView123.CellClick += DataGridViewMarks_CellClick;

        }
        public MarkForm(string currentUserRole)
        {
            _currentUserRole = currentUserRole;
            InitializeComponent();
            LoadStudents();
            LoadExams();
            LoadMarks(); 


             
            if (currentUserRole.ToLower() == "admin")
            {
                Add_Mark.Visible = true;
                Update_Mark.Visible = true;
                Delete_Mark.Visible = true;
            }else if(currentUserRole.ToLower() == "staff")
            {
                Add_Mark.Visible = true;
                Update_Mark.Visible = true;
                Delete_Mark.Visible = true;
            }


                dataGridView123.CellClick += DataGridViewMarks_CellClick;
        }

  
        private void LoadStudents()
        {
            comboBox11.DataSource = _studentController.GetAllStudents();
            comboBox11.DisplayMember = "St_Name";
            comboBox11.ValueMember = "St_Id";
            comboBox11.SelectedIndex = -1; 
        }

        private void LoadExams()
        {
            comboBox55.DataSource = _examController.GetAllExams();
            comboBox55.DisplayMember = "Ex_Name";
            comboBox55.ValueMember = "ExamId";
            comboBox55.SelectedIndex = -1; 
        }

        private void LoadMarks()
        {
            dataGridView123.DataSource = _markController.GetAllMarks();
            dataGridView123.ClearSelection();
            ClearInputs();
            _selectedMarkId = -1;
        }

        private void ClearInputs()
        {
            comboBox11.SelectedIndex = -1;
            comboBox55.SelectedIndex = -1;
            Mark.Clear(); 
        }

        private void Add_Mark_Click(object sender, EventArgs e)
        {
            if (IsMarkFormInvalid()) return;

            var newMark = new Mark
            {
                StudentId = (int)comboBox11.SelectedValue,
                ExamId = (int)comboBox55.SelectedValue,
                score = int.Parse(Mark.Text) 
            };

            MessageBox.Show(_markController.AddMark(newMark), "Add Mark", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMarks();
        }

        private void Update_Mark_Click(object sender, EventArgs e)
        {
            if (_selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsMarkFormInvalid()) return;

            var updatedMark = new Mark
            {
                MarkId = _selectedMarkId,
                StudentId = (int)comboBox11.SelectedValue,
                ExamId = (int)comboBox55.SelectedValue,
                score = int.Parse(Mark.Text) 
            };

            MessageBox.Show(_markController.UpdateMark(updatedMark), "Update Mark", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMarks();
        }

        private void Delete_Mark_Click(object sender, EventArgs e)
        {
            if (_selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this mark?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show(_markController.DeleteMark(_selectedMarkId), "Delete Mark", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMarks();
            }
        }

        private void DataGridViewMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView123.Rows[e.RowIndex];
                _selectedMarkId = Convert.ToInt32(row.Cells["MarkId"].Value);

                if (row.Cells["StudentID"].Value != DBNull.Value)
                {
                    comboBox11.SelectedValue = Convert.ToInt32(row.Cells["StudentID"].Value);
                }

                if (row.Cells["ExamID"].Value != DBNull.Value)
                {
                    comboBox55.SelectedValue = Convert.ToInt32(row.Cells["ExamID"].Value);
                }

                Mark.Text = row.Cells["score"].Value?.ToString();
            }
        }

        private bool IsMarkFormInvalid()
        {
            if (comboBox11.SelectedIndex == -1 ||
                comboBox55.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(Mark.Text)) 
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (!int.TryParse(Mark.Text, out int scoreValue) || scoreValue < 0) 
            {
                MessageBox.Show("Score must be a valid non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

    }
}
