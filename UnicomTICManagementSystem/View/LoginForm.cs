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
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class LoginForm : Form
    { 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark();
            Student student = new Student();
            Room room = new Room();
            Course course = new Course();
            Subjet subjet = new Subjet();
            Timetable timetable = new Timetable();
            string username = Name.Text.Trim();
            string password = Paas.Text;
            Paas.UseSystemPasswordChar = true;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            { 
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=Unicomtic.db"))
            {
                conn.Open();

                string query = "SELECT Role, ReferenseId FROM Users WHERE Username = @username AND Password = @password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["Role"].ToString();
                            int referenceId = Convert.ToInt32(reader["ReferenseId"]);

                            
                            LoginSession.LoggedInRole = role;
                            LoginSession.ReferenceId = referenceId;

                            MessageBox.Show("Login Successful!");

                           
                            OpenDashboard(role, referenceId);

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }

        private void OpenDashboard(string role, int refId)
        {
            Form dashboard = null;

            switch (role.ToLower())
            {
                case "admin":
                    dashboard = new MainForm(role);
                    break;
                case "staff":
                    dashboard = new StaffMainform(role);
                    break;
                case "lecturer":
                    dashboard = new LecturerMainForm(role);
                    break;
                case "student":
                    dashboard = new StudentMainForm();
                    break;
                default:
                    MessageBox.Show("Unknown role!");
                    return;
            }

            dashboard.Show();
        }

        private void sign_add_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
       

