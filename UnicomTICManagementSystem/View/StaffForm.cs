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
    public partial class StaffForm : Form
    {
        private readonly StaffControllers _staffController;
        private int _selectedStaffId = -1;

        public StaffForm()
        {
            InitializeComponent();
            _staffController = new StaffControllers();

            dataGridView1.CellClick += dataGridView1_CellClick;

            LoadStaff();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void LoadStaff()
        {
            try
            {
                var staffList = _staffController.GetAllStaff();
                dataGridView1.DataSource = staffList;
                dataGridView1.ClearSelection();
                ClearInputs();
                _selectedStaffId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            StaffName.Text = string.Empty;
            Staffage.Text = string.Empty;
            SfattPhonenumber.Text = string.Empty;
        }

        private void Add_Staff_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var staff = new Staff
                {
                    StaffName = StaffName.Text.Trim(),
                    StaffAge = int.Parse(Staffage.Text.Trim()),
                    StaffPhoneNumber = SfattPhonenumber.Text.Trim()
                };

                string message = _staffController.AddStaff(staff);
                MessageBox.Show(message, "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();
            }
        }

        private void Updata_Staff_Click(object sender, EventArgs e)
        {
            if (_selectedStaffId == -1)
            {
                MessageBox.Show("Please select a staff to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateInputs())
            {
                var staff = new Staff
                {
                    StaffId = _selectedStaffId,
                    StaffName = StaffName.Text.Trim(),
                    StaffAge = int.Parse(Staffage.Text.Trim()),
                    StaffPhoneNumber = SfattPhonenumber.Text.Trim()
                };

                string message = _staffController.UpdateStaff(staff);
                MessageBox.Show(message, "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();
            }
        }

        private void Delete_Staff_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                _selectedStaffId = Convert.ToInt32(row.Cells["StaffId"].Value);
                StaffName.Text = row.Cells["StaffName"].Value?.ToString();
                Staffage.Text = row.Cells["StaffAge"].Value?.ToString();
                SfattPhonenumber.Text = row.Cells["StaffPhoneNumber"].Value?.ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(StaffName.Text) ||
                string.IsNullOrWhiteSpace(Staffage.Text) ||
                string.IsNullOrWhiteSpace(SfattPhonenumber.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(Staffage.Text.Trim(), out _))
            {
                MessageBox.Show("Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Delete_Staff_Click_1(object sender, EventArgs e)
        {
            if (_selectedStaffId == -1)
            {
                MessageBox.Show("Please select a staff to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string message = _staffController.DeleteStaff(_selectedStaffId);
                MessageBox.Show(message, "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();
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

        private void Next_Staff_Click(object sender, EventArgs e)
        {
            LoadForm(new CourseForm());
        }

        private void Back_Staff_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminForm());
        }
    }
}
