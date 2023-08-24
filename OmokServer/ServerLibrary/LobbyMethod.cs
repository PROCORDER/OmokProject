using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OmokPacket;

namespace ServerLibrary
{
    public class LobbyMethod
    {
        public static void UpdatePlayerInRoom(ref EnterRoomPacket sendEnterRoomPacket, string connectionString)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE roomlist SET Player = @playerId WHERE RoomName = @roomName";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@playerId", sendEnterRoomPacket.user.MyId);
                    command.Parameters.AddWithValue("@roomName", sendEnterRoomPacket.room.roomName);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static bool bIsEmptyPlayer(string connectionString, string roomName)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select Player from roomlist where RoomName=@roomName";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomName", roomName);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        object result = command.ExecuteScalar(); // Executes query and retrieves the first column of the first row

                        return result == null || string.IsNullOrEmpty(result.ToString());
                    }
                }
            }
        }


        public static void GetUserInfo( UserInfo user,MySqlConnection connection)
        {
                string query = "SELECT Id,Name,Win,defeat FROM accounts_table where Id=@Id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", user.MyId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        user.MyName = reader["Name"].ToString();
                        user.History[0] = reader["Win"].ToString();
                        user.History[1] = reader["defeat"].ToString();
                        user.clientId = Guid.Parse(reader["clientId"].ToString());
                    }
                }
            
        }




        public static bool bMakeRoom(string roomName, string MyId)
        {
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select RoomName from roomlist where RoomName=@roomName";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomName", roomName);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {

                            query = "INSERT INTO RoomList (RoomName, Host) VALUES (@RoomName, @Host)";
                            reader.Close();

                            using (MySqlCommand insertCommand = new MySqlCommand(query, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@RoomName", roomName);
                                insertCommand.Parameters.AddWithValue("@Host", MyId);

                                insertCommand.ExecuteNonQuery();
                                return true;
                            }
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }

        }
        public static bool bMakeFriend(string myId, string addFriendId)
        {
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Friend From friendlist where HostId=@HostId ";

                using (MySqlCommand command1 = new MySqlCommand(query, connection))
                {
                    command1.Parameters.AddWithValue("@HostId", myId);
                    using (MySqlDataReader reader = command1.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            string insertQuery = "INSERT INTO friendlist (HostId, Friend) VALUES (@MyId, @AddFriend)";
                            reader.Close();
                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@MyId", myId);
                                insertCommand.Parameters.AddWithValue("@AddFriend", addFriendId);

                                insertCommand.ExecuteNonQuery();
                                return true;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
            }

        }

        public static void SQLIOClientId(UserInfo user)
        {
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE accounts_table SET clientId=@userclientId where clientId='@userId'  ";

                using (MySqlCommand command1 = new MySqlCommand(query, connection))
                {
                    command1.Parameters.AddWithValue("@userclientId", user.clientId);
                    command1.Parameters.AddWithValue("@userId", user.MyId);
                }
            }

        }

        public static void SQLFormClosed(Guid guid)
        {
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE accounts_table SET clientId = NULL WHERE clientId = @clientId";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@clientId", guid); // userId 변수에 실제 사용자 ID를 할당합니다.

                    int rowsAffected = command.ExecuteNonQuery();
                }

            }
        }
        public static EnterRoomPacket NullValueCheckAndInsert(MySqlDataReader reader,ref EnterRoomPacket sendEnterRoomPacket,MySqlConnection connection,ref List<Guid> clientlist)
        {                                    
            if (reader["Observer1"] != DBNull.Value)
            {
                sendEnterRoomPacket.room.Observer1.MyId = reader["Observer1"].ToString();
                LobbyMethod.GetUserInfo( sendEnterRoomPacket.room.Observer1, connection);
                clientlist.Add(sendEnterRoomPacket.room.Observer1.clientId);
            }

            if (reader["Observer2"] != DBNull.Value)
            {
                sendEnterRoomPacket.room.Observer2.MyId = reader["Observer2"].ToString();
                LobbyMethod.GetUserInfo( sendEnterRoomPacket.room.Observer2, connection);
                clientlist.Add(sendEnterRoomPacket.room.Observer2.clientId);
            }

            if (reader["Observer3"] != DBNull.Value)
            {
                sendEnterRoomPacket.room.Observer3.MyId = reader["Observer3"].ToString();
                LobbyMethod.GetUserInfo( sendEnterRoomPacket.room.Observer3, connection);
                clientlist.Add(sendEnterRoomPacket.room.Observer3.clientId);
            }

            if (reader["Host"] != DBNull.Value)
            {
                sendEnterRoomPacket.room.host.MyId = reader["Host"].ToString();
                LobbyMethod.GetUserInfo( sendEnterRoomPacket.room.host, connection);
                clientlist.Add(sendEnterRoomPacket.room.host.clientId);
            }
            return sendEnterRoomPacket;
        }

    }
}

