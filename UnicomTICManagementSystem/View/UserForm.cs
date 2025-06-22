using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Data;

namespace UnicomTICManagementSystem.View
{

    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();




            comboBox009.Items.AddRange(new object[] { "Admin", "Staff", "Lecturer", "Student" });
            comboBox009.DropDownStyle = ComboBoxStyle.DropDownList;


            CreateUsersTableIfNotExists();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = Name.Text.Trim();
            string password = Pass.Text;
            string confirmPassword = Cpass.Text;
            string role = comboBox009.SelectedIndex == -1 ? null : comboBox009.SelectedItem.ToString();
            string referenceIdText = Ree.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(role) ||
                string.IsNullOrEmpty(referenceIdText))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!int.TryParse(referenceIdText, out int referenceId))
            {
                MessageBox.Show("Reference ID must be a number.");
                return;
            }

            if (!ReferenceExists(role, referenceId))
            {
                MessageBox.Show($"Reference ID does not exist in the {role} table.");
                return;
            }

            if (UsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }
        }

        private void InsertUser(string username, string password, string role, int referenceId)
        {
            using (var conn = new SQLiteConnection("Data Source=Unicomtic.db"))
            {
                conn.Open();

                string insertQuery = "INSERT INTO Users (Username, Password, Role, ReferenseId) VALUES (@username, @password, @role, @refId)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@refId", referenceId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User registered successfully.");


                    this.Hide();

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();


                }
            }
        }




        private bool UsernameExists(string username)
        {
            using (var conn = new SQLiteConnection("Data Source=Unicomtic.db"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool ReferenceExists(string role, int referenceId)
        {
            string tableName = null;
            string idColumn = null;

            switch (role)
            {
                case "Admin":
                    tableName = "Admins";
                    idColumn = "AdminID";
                    break;
                case "Staff":
                    tableName = "SFatts";
                    idColumn = "StaffID";
                    break;
                case "Lecturer":
                    tableName = "Lecturers";
                    idColumn = "LecturerID";
                    break;
                case "Student":
                    tableName = "Students";
                    idColumn = "StudentID";
                    break;
                default:
                    return false;
            }

            using (var conn = new SQLiteConnection("Data Source=Unicomtic.db"))
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {idColumn} = @refId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@refId", referenceId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void CreateUsersTableIfNotExists()
        {
            using (var conn = new SQLiteConnection("Data Source=Unicomtic.db"))
            {
                conn.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                         ReferenseId INTEGER NOT NULL,
                        Role TEXT NOT NULL
                    );";

                using (var cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ClearForm()
        {
            Name.Clear();
            Pass.Clear();
            Cpass.Clear();
            comboBox009.SelectedIndex = -1;
            Ree.Clear();
        }


        private void Add_User_Click(object sender, EventArgs e) { }
        private void Update_User_Click(object sender, EventArgs e) { }
        private void Delete_User_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = Name.Text.Trim();
            string password = Pass.Text;
            string confirmPassword = Cpass.Text;
            string role = comboBox009.SelectedIndex == -1 ? null : comboBox009.SelectedItem.ToString();
            string referenceIdText = Ree.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || 
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(role) ||
                string.IsNullOrEmpty(referenceIdText))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
 
            

            



            if (!int.TryParse(referenceIdText, out int referenceId))
            {
                MessageBox.Show("Reference ID must be a number.");
                return;
            }

            if (!ReferenceExists(role, referenceId))
            {
                MessageBox.Show($"Reference ID does not exist in the {role} table.");
                return;
            }

            if (UsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }


            InsertUser(username, password, role, referenceId);
        }
      

        }
    }

   

