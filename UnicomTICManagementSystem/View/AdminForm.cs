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
    public partial class AdminForm : Form
    {
        private readonly AdminControllers _adminController;
        private int _selectedAdminId = -1;

        public AdminForm()
        {
            InitializeComponent();
            _adminController = new AdminControllers();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadAdmins();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadAdmins();
        }

        private void LoadAdmins()
        {
            try
            {
                var adminList = _adminController.GetAllAdmins();
                dataGridView1.DataSource = adminList;
                dataGridView1.ClearSelection();
                ClearInputs();
                _selectedAdminId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading admins: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            AdminName.Text = string.Empty;
            AdminAge.Text = string.Empty;
            AdminPhone.Text = string.Empty;
        }

        private void Add_Admin_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var admin = new Admin
                {
                    AdminName = AdminName.Text.Trim(),
                    AdminAge = int.Parse(AdminAge.Text.Trim()),
                    AdminPhoneNumber = AdminPhone.Text.Trim()
                };

                string message = _adminController.AddAdmin(admin);
                MessageBox.Show(message, "Add Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdmins();
            }
        }

        private void Update_Admin_Click(object sender, EventArgs e)
        {
            if (_selectedAdminId == -1)
            {
                MessageBox.Show("Please select an admin to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateInputs())
            {
                var admin = new Admin
                {
                    AdminId = _selectedAdminId,
                    AdminName = AdminName.Text.Trim(),
                    AdminAge = int.Parse(AdminAge.Text.Trim()),
                    AdminPhoneNumber = AdminPhone.Text.Trim()
                };

                string message = _adminController.UpdateAdmin(admin);
                MessageBox.Show(message, "Update Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdmins();
            }
        }

        private void Delete_Admin_Click(object sender, EventArgs e)
        {
            if (_selectedAdminId == -1)
            {
                MessageBox.Show("Please select an admin to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string message = _adminController.DeleteAdmin(_selectedAdminId);
                MessageBox.Show(message, "Delete Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdmins();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                _selectedAdminId = Convert.ToInt32(row.Cells["AdminId"].Value);
                AdminName.Text = row.Cells["AdminName"].Value?.ToString();
                AdminAge.Text = row.Cells["AdminAge"].Value?.ToString();
                AdminPhone.Text = row.Cells["AdminPhoneNumber"].Value?.ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(AdminName.Text) ||
                string.IsNullOrWhiteSpace(AdminAge.Text) ||
                string.IsNullOrWhiteSpace(AdminPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(AdminAge.Text.Trim(), out _))
            {
                MessageBox.Show("Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(AdminPhone.Text.Trim(), out _))
            {
                MessageBox.Show("Phone number must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

        private void Next_Admin_Click(object sender, EventArgs e)
        {
            LoadForm(new StaffForm());
        }
    }
}
