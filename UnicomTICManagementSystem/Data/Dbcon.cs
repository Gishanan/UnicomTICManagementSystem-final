using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Data
{
    internal class Dbcon
    {
        private static string connectionString = "Data Source=Unicomtic.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }
    }

    
}
