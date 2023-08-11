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
    public class IOCompletionPortServerLibrary
    {
        public static byte[] LoginProcess(object sender, SocketAsyncEventArgs e,LoginPacket sendLoginPacket)
        {
            byte[] sendBuffer = new byte[1024 * 4];
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            string idToCheck = sendLoginPacket.loginID; // 입력한 ID
            string passwordToCheck = sendLoginPacket.loginPW; // 입력한 비밀번호

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
                            sendLoginPacket.loginName = reader["Name"].ToString();
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

        public static byte[] SIgnupProcess(object sender, SocketAsyncEventArgs e,SignUpPacket sendSIgnupPacket)
        {
            byte[] sendBuffer = new byte[1024 * 4];
            string connectionString = "Server=localhost;Database=accounts;User Id=root;Password=1234;";
            string idToCheck = sendSIgnupPacket.signUpID; // 입력한 ID
            string passwordToCheck = sendSIgnupPacket.signUpPW; // 입력한 비밀번호
            string nameToCheck = sendSIgnupPacket.signUpName;

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
    }
}
