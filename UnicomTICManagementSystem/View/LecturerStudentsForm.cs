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

namespace UnicomTICManagementSystem.View
{
    public partial class LecturerStudentControllersForm : Form
    {
        private readonly LecturerStudentControllers _controller = new LecturerStudentControllers();

        public LecturerStudentControllersForm()
        {
            InitializeComponent();
            LoadLecturerStudentData();
        }

        private void LoadLecturerStudentData()
        {
            DataTable dt = _controller.GetLecturerStudentView();
            dataGridView100.DataSource = dt;
            dataGridView100.ClearSelection();
        }
    

        private void dataGridView100_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
