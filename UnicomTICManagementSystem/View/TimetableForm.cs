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

    public partial class TimetableForm : Form
    {
        private readonly LecturerController lecturerController = new LecturerController();
        private readonly SubjectController subjectController = new SubjectController();
        private readonly RoomControllers roomController = new RoomControllers();
        private readonly TimetableControllers timetableController;
        private int _selectedTimetableId = -1;

        public TimetableForm()
        {
            InitializeComponent();
            timetableController = new TimetableControllers();

            comboBox44.Items.AddRange(new object[] { "A","B" });
            comboBox44.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView99.CellClick += DataGridView99_CellClick;
            Add_Timetable.Click += Add_Timetable_Click;
            Update_Timetabe.Click += Update_Timetable_Click;
            Delete_Timetable.Click += Delete_Timetable_Click;

            this.Load += TimetableForm_Load;

        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            LoadLecturers();
            LoadSubjects();
            LoadRooms();
            LoadTimetables();
        }

        private void LoadLecturers()
        {
            try
            {
                comboBox11.DataSource = lecturerController.GetAllLecturers();
                comboBox11.DisplayMember = "LecturerName";
                comboBox11.ValueMember = "LecturerID";
                comboBox11.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading lecturers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                comboBox22.DataSource = subjectController.GetAllSubjects();
                comboBox22.DisplayMember = "Su_Name";
                comboBox22.ValueMember = "Su_Id";
                comboBox22.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRooms()
        {
            try
            {
                comboBox33.DataSource = roomController.GetAllRooms();
                comboBox33.DisplayMember = "RoomName";
                comboBox33.ValueMember = "RoomID";
                comboBox33.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTimetables()
        {
            try
            {
                dataGridView99.DataSource = timetableController.GetAllTimetables();
                dataGridView99.ClearSelection();
                ClearInputs();
                _selectedTimetableId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading timetables: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            comboBox11.SelectedIndex = -1;
            comboBox22.SelectedIndex = -1;
            comboBox33.SelectedIndex = -1;
            comboBox44.SelectedIndex = -1;
            comboBox44.SelectedIndex = -1;
            dateTimePicker66.Value = DateTime.Now;
            dateTimePicker21.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
        }

        private bool ValidateInputs()
        {
            if (comboBox11.SelectedValue == null || comboBox22.SelectedValue == null ||
                comboBox33.SelectedValue == null || comboBox44.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all timetable fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dateTimePicker66.Value >= dateTimePicker21.Value)
            {
                MessageBox.Show("Start time must be before end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Add_Timetable_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var newTimetable = new Timetable
            {
                SubjectId = (int)comboBox22.SelectedValue,
                LecturerId = (int)comboBox11.SelectedValue,
                RoomId = (int)comboBox33.SelectedValue,
                ClassName = comboBox44.SelectedItem.ToString(),
                StartTime = dateTimePicker66.Value,
                EndTime = dateTimePicker21.Value,
                Date = dateTimePicker3.Value.Date
            };


            string message = timetableController.AddTimetable(newTimetable);
            MessageBox.Show(message, "Add Timetable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTimetables();
        }


        private void Update_Timetable_Click(object sender, EventArgs e)
        {
            if (_selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            var updatedTimetable = new Timetable
            {
                TimetableId = _selectedTimetableId,
                SubjectId = (int)comboBox22.SelectedValue,
                LecturerId = (int)comboBox11.SelectedValue,
                RoomId = (int)comboBox33.SelectedValue,
                ClassName = comboBox44.SelectedItem.ToString(),
                StartTime = dateTimePicker66.Value,
                EndTime = dateTimePicker21.Value,
                Date = dateTimePicker3.Value.Date
            };

            string message = timetableController.UpdateTimetable(updatedTimetable);
            MessageBox.Show(message, "Update Timetable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTimetables();
        }

        private void Delete_Timetable_Click(object sender, EventArgs e)
        {
            if (_selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            string message = timetableController.DeleteTimetable(_selectedTimetableId);
            MessageBox.Show(message, "Delete Timetable", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTimetables();
        }

        private void DataGridView99_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView99.Rows[e.RowIndex];

                _selectedTimetableId = Convert.ToInt32(row.Cells["TimetableId"].Value);
                comboBox44.Text = row.Cells["ClassName"].Value?.ToString();

                comboBox11.SelectedValue = Convert.ToInt32(row.Cells["LecturerId"].Value);
                comboBox22.SelectedValue = Convert.ToInt32(row.Cells["SubjectId"].Value);
                comboBox33.SelectedValue = Convert.ToInt32(row.Cells["RoomId"].Value);

                dateTimePicker66.Value = Convert.ToDateTime(row.Cells["StartTime"].Value);
                dateTimePicker21.Value = Convert.ToDateTime(row.Cells["EndTime"].Value);
                dateTimePicker3.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Back_Time_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomFrom());
        }

        private void Next_time_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamForm());
        }

        private void TimetableForm_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
