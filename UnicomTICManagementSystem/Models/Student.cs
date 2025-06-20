using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    public class Student
    {
        public int St_Id { get; set; }
        public string St_Name { get; set; }
        public int St_Age { get; set; }
        public String St_Address { get; set; }
        public string St_PhoneNumber { get; set; }
        public int CourseId { get; set; }
        public string ClassName { get; set; } // Assuming ClassName is a property of Student
    }
}
