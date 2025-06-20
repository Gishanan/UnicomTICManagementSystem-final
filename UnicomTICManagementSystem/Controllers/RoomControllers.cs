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
    public class RoomControllers
    {
        
        public string AddRoom(Room room)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@RoomName, @RoomType)";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                        cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "Room added successfully.";
            }
            catch (Exception ex)
            {
                return $"Error adding room: {ex.Message}";
            }
        }

        
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();
            using (var dbConn = Dbcon.GetConnection())
            {
                string query = "SELECT * FROM Rooms";
                using (var cmd = new SQLiteCommand(query, dbConn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Room
                            {
                                RoomId = reader.GetInt32(reader.GetOrdinal("RoomID")),
                                RoomName = reader.GetString(reader.GetOrdinal("RoomName")),
                                RoomType = reader.GetString(reader.GetOrdinal("RoomType"))
                            });
                        }
                    }
                }
            }
            return rooms;
        }

        
        public string UpdateRoom(Room room)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "UPDATE Rooms SET RoomName = @RoomName, RoomType = @RoomType WHERE RoomID = @RoomID";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                        cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                        cmd.Parameters.AddWithValue("@RoomID", room.RoomId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Room updated successfully." : "No room was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error updating room: {ex.Message}";
            }
        }

        
        public string DeleteRoom(int roomId)
        {
            try
            {
                using (var dbConn = Dbcon.GetConnection())
                {
                    string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";
                    using (var cmd = new SQLiteCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Room deleted successfully." : "No room was deleted.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting room: {ex.Message}";
            }
        }
    }
}
