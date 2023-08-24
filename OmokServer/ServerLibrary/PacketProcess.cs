using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using OmokPacket;
 using System.Collections.Concurrent;
namespace ServerLibrary
{
    public class PacketProcess : Packet
    {
        public static byte[] HandlePacketType(object sender, SocketAsyncEventArgs e,Packet receivePacket)
        {
            switch (receivePacket.type)
            {
                case PacketType.LOGIN:
                    {
                        LoginPacket packet=(LoginPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LoginProcess(packet);
                        
                    }
                 

                case PacketType.SIGNUP:
                    {
                        SignUpPacket packet = (SignUpPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.SIgnupProcess(packet);
                        
                    }

                case PacketType.PLAYGAME:
                    {
                        LoginPacket packet = (LoginPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LoginProcess( packet);
                        
                    }

                case PacketType.SENDMESSAGE:
                    {
                        LoginPacket packet = (LoginPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LoginProcess( packet);
                        
                    }


                case PacketType.MAKEFRIEND:
                    {
                        MakeFriendPacket packet = (MakeFriendPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.MakeFriendProcess(packet);
                    }
                default:
                    {
                        Packet packet = (Packet)Packet.Desserialize(e.Buffer);
                        packet.type = PacketType.ERR;
                        byte[] sendERRBuffer = new byte[1024 * 4];
                        Packet.Serialize(packet).CopyTo(sendERRBuffer, 0);
                        return sendERRBuffer;
                    }


            }
        }
        public static void HandleLobbyPacketType(byte[] buffer, ConcurrentDictionary<Guid, ClientStateInfo> clients,Guid client)
        {
            LobbyPacket receivePacket = (LobbyPacket)Packet.Desserialize(buffer);
            receivePacket.user.clientId = client;
            LobbyMethod.SQLIOClientId(receivePacket.user);
            switch (receivePacket.lobbyAction)
            {
                case ELobbyaction.LOBBYLOAD:
                    {
                        LobbyloadPacket lobbyloadpacket = (LobbyloadPacket)Packet.Desserialize(buffer);
                         IOCompletionPortServerLibrary.LobbyLoadProcess( clients,client,lobbyloadpacket);
                        break;
                    }
                case ELobbyaction.ENTERROOM:
                    {
                        EnterRoomPacket enterpacket = (EnterRoomPacket)Packet.Desserialize(buffer);
                        IOCompletionPortServerLibrary.EnterRoomProcess(clients, client, enterpacket);
                        break;
                    }
                case ELobbyaction.REFRESHROOMLIST:
                    {
                        RefreshRoomlistPacket refreshPacket = (RefreshRoomlistPacket)Packet.Desserialize(buffer);
                        IOCompletionPortServerLibrary.RefreshLobbyLoadProcess(clients, client, refreshPacket);
                        break;
                    }
                case ELobbyaction.MAKEROOM:
                    {
                        MakeRoomPacket makeRoomPacket = (MakeRoomPacket)Packet.Desserialize(buffer);
                         IOCompletionPortServerLibrary.MakeRoomProcess(clients, client, makeRoomPacket);
                        break;
                    }
                case ELobbyaction.WAITINGROOM:
                    {
                         PacketProcess.WaitingRoomPacketType(clients,ref client, buffer,  clients);
                        break;
                    }
                default:
                    {
                        Packet packet = (Packet)Packet.Desserialize(buffer);
                        packet.type = PacketType.ERR;
                        byte[] sendERRBuffer = new byte[1024 * 4];
                        Packet.Serialize(packet).CopyTo(sendERRBuffer, 0);
                        break;

                    }
            }
        }
        public static byte[] WaitingRoomPacketType(byte[] buffer)
        {
            WaitingRoomPacket packet = (WaitingRoomPacket)Packet.Desserialize(buffer);
            if (MySQLLobbyIO.IsHOST(packet) == true)
            {
              //호스트 액션에 따른 패킷 처리 함수
            }
            else
            {
                //게스트 액션에 따른 패킷 처리 함수
            }
        }
    }
}
