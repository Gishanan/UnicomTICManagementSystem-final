using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PassWord { get; set; }
        public int ReferenseId { get; set; }
        public string Role { get; set; }
    }
}
