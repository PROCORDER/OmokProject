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
using System.Collections.Concurrent;

namespace ServerLibrary
{
    public class IOCompletionPortServerLibrary
    {
        public static byte[] LoginProcess( LoginPacket sendLoginPacket)
        {
            byte[] sendBuffer = new byte[1024 * 4];
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            string idToCheck = sendLoginPacket.user.MyId; // 입력한 ID
            string passwordToCheck = sendLoginPacket.user.MyPw; // 입력한 비밀번호

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM accounts_table WHERE Id = @Id AND Pw = @Pw";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idToCheck);
                    command.Parameters.AddWithValue("@Pw", passwordToCheck);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sendLoginPacket.user.MyName = reader["Name"].ToString();
                            sendLoginPacket.loginCheck = true;
                            Packet.Serialize(sendLoginPacket).CopyTo(sendBuffer, 0);
                            return sendBuffer;

                        }
                        else
                        {
                            sendLoginPacket.loginCheck = false;
                            Packet.Serialize(sendLoginPacket).CopyTo(sendBuffer, 0);
                            return sendBuffer;
                        }
                    }
                }
            }
        }

        public static byte[] SIgnupProcess( SignUpPacket sendSIgnupPacket)
        {

            byte[] sendBuffer = new byte[1024 * 4];
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            string idToCheck = sendSIgnupPacket.user.MyId; // 입력한 ID
            string passwordToCheck = sendSIgnupPacket.user.MyPw; // 입력한 비밀번호
            string nameToCheck = sendSIgnupPacket.user.MyName;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM accounts_table WHERE Id = @Id OR Name = @Name";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idToCheck);
                    command.Parameters.AddWithValue("@Name", nameToCheck);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (idToCheck == reader["Id"].ToString())
                            {
                                sendSIgnupPacket.signUpCheck = 1;

                            }
                            else
                            {
                                sendSIgnupPacket.signUpCheck = 2;
                            }
                            Packet.Serialize(sendSIgnupPacket).CopyTo(sendBuffer, 0);
                            return sendBuffer;
                        }
                        else
                        {
                            query = "INSERT INTO accounts_table (Id, Password, Name) VALUES (@Id, @Password, @Name)";

                            command.Parameters.AddWithValue("@Id", idToCheck);
                            command.Parameters.AddWithValue("@Password", passwordToCheck);
                            command.Parameters.AddWithValue("@Name", nameToCheck);
                            command.ExecuteNonQuery(); // 새 레코드를 추가

                            sendSIgnupPacket.signUpCheck = 0;
                            Packet.Serialize(sendSIgnupPacket).CopyTo(sendBuffer, 0);
                            return sendBuffer;
                        }
                    }
                }
            }

        }
        public static void LobbyLoadProcess(ConcurrentDictionary<Guid, ClientStateInfo> clients, Guid client, LobbyloadPacket sendLobbyLoadPacket)
        {
            byte[] sendBuffer = new byte[1024 * 4];
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            string checkId = sendLobbyLoadPacket.user.MyId; // 입력한 ID

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Friend FROM FriendList WHERE HostId = @CheckId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CheckId", checkId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string friend = reader.GetString("Friend");
                            sendLobbyLoadPacket.user.friendList.Add(friend);
                        }
                    }
                }

                query = "SELECT Win,defeat FROM accounts_table WHERE Id = @CheckId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CheckId", checkId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        sendLobbyLoadPacket.user.History[0] = reader.GetString(0);
                        sendLobbyLoadPacket.user.History[1] = reader.GetString(1);

                    }
                }
                query = "SELECT RoomName FROM roomlist ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        string roomName = reader.GetString("");
                        sendLobbyLoadPacket.roomList.Add(roomName);
                    }
                }

            }
            Packet.Serialize(sendLobbyLoadPacket).CopyTo(sendBuffer, 0);
            LobbyandWaitingSendMethod.LobbyActionSend(clients, sendBuffer, client);
        }

        public static void RefreshLobbyLoadProcess(ConcurrentDictionary<Guid, ClientStateInfo> clients, Guid client, RefreshRoomlistPacket sendRoomListPacket)
        {
            byte[] sendBuffer = new byte[1024 * 4];
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            string checkId = sendRoomListPacket.user.MyId; // 입력한 ID

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT RoomName FROM roomlist ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        string roomName = reader.GetString("");
                        sendRoomListPacket.roomList.Add(roomName);
                    }
                }

            }
            Packet.Serialize(sendRoomListPacket).CopyTo(sendBuffer, 0);
            LobbyandWaitingSendMethod.LobbyActionSend(clients, sendBuffer, client);
        }

        public static void EnterRoomProcess(ConcurrentDictionary<Guid, ClientStateInfo> clients, Guid client,  EnterRoomPacket sendEnterRoomPacket)
        {
            byte[] sendBuffer = new byte[1024 * 4];
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            string checkId = sendEnterRoomPacket.user.MyId; // 입력한 ID
            string roomName = sendEnterRoomPacket.room.roomName;
            List<Guid> sendClientList = new List<Guid>();
            sendClientList.Add(client);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM roomlist where RoomName=@roomName";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomName", roomName);
 
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()&&LobbyMethod.bIsEmptyPlayer(connectionString,roomName))
                        {
                            LobbyMethod.NullValueCheckAndInsert(reader, ref sendEnterRoomPacket,connection,out sendClientList);

                            sendEnterRoomPacket.bEnterRoom = true;
                            LobbyMethod.UpdatePlayerInRoom( ref sendEnterRoomPacket, connectionString);
                        }
                        else
                        {
                            sendEnterRoomPacket.bEnterRoom = false;
                        }
                    }
                }         
                Packet.Serialize(sendEnterRoomPacket).CopyTo(sendBuffer, 0);

            }
            LobbyandWaitingSendMethod.EnterRoomSend(clients, sendClientList, sendBuffer);
        }
        public static void MakeRoomProcess(ConcurrentDictionary<Guid, ClientStateInfo> clients, Guid client, MakeRoomPacket sendMakeRoomPacket)
        {
            byte[] sendBuffer = new byte[1024 * 4];
           
            string checkId = sendMakeRoomPacket.user.MyId; // 입력한 ID
            string roomName = sendMakeRoomPacket.room.roomName;
 
            if(LobbyMethod.bMakeRoom(roomName,checkId))
            {
                sendMakeRoomPacket.bmakeRoomSuccess = true;
            }
            else
            {
                sendMakeRoomPacket.bmakeRoomSuccess = false;
            }
  
            Packet.Serialize(sendMakeRoomPacket).CopyTo(sendBuffer, 0);
            LobbyandWaitingSendMethod.LobbyActionSend(clients, sendBuffer, client);

        }

        public static void MakeFriendProcess(ConcurrentDictionary<Guid, ClientStateInfo> clients, Guid client, MakeFriendPacket sendMakeRoomPacket)
        {
            byte[] sendBuffer = new byte[1024 * 4];
            string myId = sendMakeRoomPacket.user.MyId; // 입력한 ID
            string addFriendId = sendMakeRoomPacket.addFriend.MyId;
            if (LobbyMethod.bMakeFriend(myId, addFriendId))
            {
                sendMakeRoomPacket.bFriendAddSuccess = true;
            }
            else
            {
                sendMakeRoomPacket.bFriendAddSuccess = false;
            }
            Packet.Serialize(sendMakeRoomPacket).CopyTo(sendBuffer, 0);
            LobbyandWaitingSendMethod.LobbyActionSend(clients, sendBuffer, client);
        }
        
    }
}
