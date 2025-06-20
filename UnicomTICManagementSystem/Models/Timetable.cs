using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    public class Timetable
    {
        public int TimetableId { get; set; } 
        public int LecturerId { get; set; } 
        public int SubjectId { get; set; }
        public int RoomId { get; set; } 
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; } 
        public DateTime Date { get; set; } 
        public string ClassName { get; set; } 
    }
}
