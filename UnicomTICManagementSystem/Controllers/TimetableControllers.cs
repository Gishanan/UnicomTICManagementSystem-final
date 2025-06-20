using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class TimetableControllers
    {

        public string AddTimetable(Timetable timetable)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                   

                    string conflictCheck = @"
                SELECT COUNT(*) FROM Timetables
                WHERE (@LecturerID = LecturerID OR @RoomID = RoomID)
                  AND (@StartTime < EndTime AND @EndTime > StartTime)";

                    using (var cmd = new SQLiteCommand(conflictCheck, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@LecturerID", timetable.LecturerId);
                        cmd.Parameters.AddWithValue("@RoomID", timetable.RoomId);
                        cmd.Parameters.AddWithValue("@StartTime", timetable.StartTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@EndTime", timetable.EndTime.ToString("HH:mm"));

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                            return "Either the lecturer or the room is already booked at this time.";
                    }


                    string insertQuery = @"
                INSERT INTO Timetables 
                (LecturerID, SubjectID, RoomID, ClassName, Date, StartTime, EndTime)
                VALUES 
                (@LecturerID, @SubjectID, @RoomID, @ClassName, @Date, @StartTime, @EndTime)";

                    using (var insertCmd = new SQLiteCommand(insertQuery, dbConn))
                    {
                        insertCmd.Parameters.AddWithValue("@LecturerID", timetable.LecturerId);
                        insertCmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectId);
                        insertCmd.Parameters.AddWithValue("@RoomID", timetable.RoomId);
                        insertCmd.Parameters.AddWithValue("@ClassName", timetable.ClassName);
                        insertCmd.Parameters.AddWithValue("@Date", timetable.Date.ToString("yyyy-MM-dd"));
                        insertCmd.Parameters.AddWithValue("@StartTime", timetable.StartTime.ToString("HH:mm"));
                        insertCmd.Parameters.AddWithValue("@EndTime", timetable.EndTime.ToString("HH:mm"));

                        int result = insertCmd.ExecuteNonQuery();
                        return result > 0 ? "Timetable added successfully." : "Failed to add timetable.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error adding timetable: {ex.Message}";
            }
        }


        public List<Timetable> GetAllTimetables()
        {
            List<Timetable> timetables = new List<Timetable>();

            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Timetables";
                using (var cmd = new SQLiteCommand(query, dbConn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timetables.Add(new Timetable
                        {
                            TimetableId = reader.GetInt32(reader.GetOrdinal("TimetableID")),
                            SubjectId = reader.GetInt32(reader.GetOrdinal("SubjectID")),
                            LecturerId = reader.GetInt32(reader.GetOrdinal("LecturerID")),
                            RoomId = reader.GetInt32(reader.GetOrdinal("RoomID")),
                            ClassName = reader.GetString(reader.GetOrdinal("ClassName")),
                            StartTime = DateTime.Parse(reader.GetString(reader.GetOrdinal("StartTime"))),
                            EndTime = DateTime.Parse(reader.GetString(reader.GetOrdinal("EndTime"))),
                            Date = DateTime.Parse(reader.GetString(reader.GetOrdinal("Date")))
                        });
                    }
                }
            }
            return timetables;
        }

        public string UpdateTimetable(Timetable timetable)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = @"UPDATE Timetables 
                        SET SubjectID = @subjectId, 
                            LecturerID = @lecturerId, 
                            RoomID = @roomId, 
                            ClassName = @className,
                            StartTime = @startTime, 
                            EndTime = @endTime, 
                            Date = @date 
                        WHERE TimetableID = @id";

                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@subjectId", timetable.SubjectId);
                        cmd.Parameters.AddWithValue("@lecturerId", timetable.LecturerId);
                        cmd.Parameters.AddWithValue("@roomId", timetable.RoomId);
                        cmd.Parameters.AddWithValue("@className", timetable.ClassName);
                        cmd.Parameters.AddWithValue("@startTime", timetable.StartTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@endTime", timetable.EndTime.ToString("HH:mm"));
                        cmd.Parameters.AddWithValue("@date", timetable.Date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@id", timetable.TimetableId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Timetable updated successfully." : "No timetable was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating timetable: {ex.Message}";
            }
        }

        public string DeleteTimetable(int timetableId)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "DELETE FROM Timetables WHERE TimetableID = @id";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@id", timetableId);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0 ? "Timetable deleted successfully." : "No timetable found to delete.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting timetable: {ex.Message}";
            }
        }
    }
}
