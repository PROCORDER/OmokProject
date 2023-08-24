using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using OmokPacket;
using ServerLibrary;

namespace ServerLibrary
{
    public class MySQLLobbyIO {
        public static bool IsHOST(WaitingRoomPacket user) {
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select Player from roomlist where RoomName=@roomName and host=@userId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomName", user.room.roomName);
                    command.Parameters.AddWithValue("@userId", user.user.MyId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        object result = command.ExecuteScalar(); 

                        return !(result == null || string.IsNullOrEmpty(result.ToString()));
                    }
                }
            }
        }

    }

}
