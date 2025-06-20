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
    public partial class RoomFrom : Form
    {
        private readonly RoomControllers _roomController;
        private int _selectedRoomId = -1;

        public RoomFrom()
        {
            InitializeComponent();

            _roomController = new RoomControllers();

            
            RoomcomboBox1.Items.AddRange(new[] { "Hall", "Lab", "Classroom", "Conference Room" });
            RoomcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            
            Add_Room.Click += Add_Room_Click;
            Update_Room.Click += Update_Room_Click;
            Delete_Room.Click += Delete_Room_Click;
            RoomdataGridView1.CellClick += DataGridViewRooms_CellClick;

            
            RoomdataGridView1.AutoGenerateColumns = true;
            RoomdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RoomdataGridView1.MultiSelect = false;
            RoomdataGridView1.ReadOnly = true;
            RoomdataGridView1.AllowUserToAddRows = false;

            
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                var rooms = _roomController.GetAllRooms();
                RoomdataGridView1.DataSource = rooms;

                if (RoomdataGridView1.Columns.Contains("RoomId"))
                    RoomdataGridView1.Columns["RoomId"].HeaderText = "Room ID";
                if (RoomdataGridView1.Columns.Contains("RoomName"))
                    RoomdataGridView1.Columns["RoomName"].HeaderText = "Room Name";
                if (RoomdataGridView1.Columns.Contains("RoomType"))
                    RoomdataGridView1.Columns["RoomType"].HeaderText = "Room Type";

                RoomdataGridView1.ClearSelection();
                ClearInputs();
                _selectedRoomId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            RoomName.Text = string.Empty;
            RoomcomboBox1.SelectedIndex = -1;
        }

        private void Add_Room_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RoomName.Text) || RoomcomboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var room = new Room
            {
                RoomName = RoomName.Text.Trim(),
                RoomType = RoomcomboBox1.SelectedItem.ToString()
            };

            string message = _roomController.AddRoom(room);
            MessageBox.Show(message, "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadRooms();
        }

        private void Update_Room_Click(object sender, EventArgs e)
        {
            if (_selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(RoomName.Text) || RoomcomboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var room = new Room
            {
                RoomId = _selectedRoomId,
                RoomName = RoomName.Text.Trim(),
                RoomType = RoomcomboBox1.SelectedItem.ToString()
            };

            string message = _roomController.UpdateRoom(room);
            MessageBox.Show(message, "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadRooms();
        }

        private void Delete_Room_Click(object sender, EventArgs e)
        {
            if (_selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            string message = _roomController.DeleteRoom(_selectedRoomId);
            MessageBox.Show(message, "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadRooms();
        }

        private void DataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = RoomdataGridView1.Rows[e.RowIndex];
                _selectedRoomId = Convert.ToInt32(row.Cells["RoomId"].Value);
                RoomName.Text = row.Cells["RoomName"].Value?.ToString();
                RoomcomboBox1.SelectedItem = row.Cells["RoomType"].Value?.ToString();
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

        private void Back_Room_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerForm());
        }

        private void Next_Room_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm());
        }
    }
}
