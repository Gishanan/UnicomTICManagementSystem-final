using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class LecturerForm : Form
    {
        private readonly LecturerController _lecturerController = new LecturerController();
        private readonly SubjectController _subjectController = new SubjectController();

        private int _selectedLecturerId = -1;

        public LecturerForm()
        {
            InitializeComponent();

            
            dataGridView777.CellClick += DataGridViewLecturers_CellClick;

           
            LoadSubjects();   
            LoadLecturers(); 
        }

        private void LoadLecturers()
        {
            dataGridView777.DataSource = _lecturerController.GetAllLecturers();
            dataGridView777.ClearSelection();
            ClearInputs();
            _selectedLecturerId = -1;
        }

        private void LoadSubjects()
        {
            comboBox44.DataSource = _subjectController.GetAllSubjects();
            comboBox44.DisplayMember = "Su_Name";
            comboBox44.ValueMember = "Su_Id";
            comboBox44.SelectedIndex = -1;
        }

        private void ClearInputs()
        {
            L_Name.Clear();
            comboBox44.SelectedIndex = -1;
            User.Clear();
        }

        private void Add_Lecturer_Click(object sender, EventArgs e)
        {
            if (IsLecturerFormInvalid()) return;

            var lecturer = new Lecturer
            {
                LecturerName = L_Name.Text,
                SubjectID = (int)comboBox44.SelectedValue,
                UserID = int.Parse(User.Text)
            };

            MessageBox.Show(_lecturerController.AddLecturer(lecturer), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLecturers();
        }

        //private void Update_Lecturer_Click(object sender, EventArgs e)
        //{
        //    if (_selectedLecturerId == -1)
        //    {
        //        MessageBox.Show("Please select a lecturer to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (IsLecturerFormInvalid()) return;

        //    var lecturer = new Lecturer
        //    {
        //        LecturerID = _selectedLecturerId,
        //        LecturerName = L_Name.Text,
        //        SubjectID = (int)comboBox44.SelectedValue,
        //        UserID = int.Parse(User.Text)
        //    };

        //    MessageBox.Show(_lecturerController.UpdateLecturer(lecturer), "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    LoadLecturers();
        //}

        //private void Delete_Lecturer_Click(object sender, EventArgs e)
        //{
        //    if (_selectedLecturerId == -1)
        //    {
        //        MessageBox.Show("Please select a lecturer to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    var confirm = MessageBox.Show("Are you sure you want to delete this lecturer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (confirm == DialogResult.Yes)
        //    {
        //        MessageBox.Show(_lecturerController.DeleteLecturer(_selectedLecturerId), "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadLecturers();
        //    }
        //}

        private void DataGridViewLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView777.Rows[e.RowIndex];
                _selectedLecturerId = Convert.ToInt32(row.Cells["LecturerID"].Value);
                L_Name.Text = row.Cells["LecturerName"].Value?.ToString();

                if (row.Cells["SubjectID"].Value != DBNull.Value)
                {
                    comboBox44.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
                }

                User.Text = row.Cells["UserID"].Value?.ToString();
            }
        }

        private bool IsLecturerFormInvalid()
        {
            if (string.IsNullOrWhiteSpace(L_Name.Text) ||
                comboBox44.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(User.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (!int.TryParse(User.Text, out _))
            {
                MessageBox.Show("User ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void Delete_Lecturer_Click(object sender, EventArgs e)
        {
            if (_selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this lecturer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show(_lecturerController.DeleteLecturer(_selectedLecturerId), "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLecturers();
            }
        }

        private void Update_Lecturer_Click(object sender, EventArgs e)
        {
            if (_selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsLecturerFormInvalid()) return;

            var lecturer = new Lecturer
            {
                LecturerID = _selectedLecturerId,
                LecturerName = L_Name.Text,
                SubjectID = (int)comboBox44.SelectedValue,
                UserID = int.Parse(User.Text)
            };

            MessageBox.Show(_lecturerController.UpdateLecturer(lecturer), "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLecturers();
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

        private void Back_Lecturer_Click(object sender, EventArgs e)
        {
            LoadForm(new SubjectForm());
        }

        private void Next_Lecturer_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomFrom());
        }
    }
}
