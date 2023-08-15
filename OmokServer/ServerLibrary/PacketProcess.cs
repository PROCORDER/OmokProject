using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using OmokPacket;
using ServerLibrary;
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

                case PacketType.LOBBY:
                    {
                        return LobbyPacketType(sender,  e, receivePacket);

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
                case PacketType.LOBBYLOAD:
                    {
                        LobbyloadPacket packet = (LobbyloadPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LobbyLoadProcess( packet);
                        
                    }

                default:
                    {
                        return null;
                        
                    }

            }
        }
        public static byte[] LobbyPacketType(object sender, SocketAsyncEventArgs e, Packet receivePacket)
        {
            LobbyPacket packet=(LobbyPacket)Packet.Desserialize(e.Buffer);
            switch (packet.lobbyAction)
            {
                case ELobbyaction.LOBBYLOAD:
                    {
                        LobbyloadPacket lobbyloadpacket = (LobbyloadPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LobbyLoadProcess( lobbyloadpacket);
                    }
                case ELobbyaction.ENTERROOM:
                    {
                        EnterRoomPacket enterpacket = (EnterRoomPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.EnterRoomProcess( enterpacket);
                    }
                case ELobbyaction.REFRESHROOMLIST:
                    {
                        RefreshRoomlistPacket refreshPacket = (RefreshRoomlistPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.RefreshLobbyLoadProcess( refreshPacket);
                    }
                case ELobbyaction.MAKEROOM:
                    {
                        MakeRoomPacket makeRoomPacket = (MakeRoomPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.MakeRoomProcess( makeRoomPacket);
                    }
                default:
                    return null;

            }
        }
    }
}
