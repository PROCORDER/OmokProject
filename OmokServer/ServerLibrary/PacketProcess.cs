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
                        return IOCompletionPortServerLibrary.LoginProcess(sender, e,packet);
                        
                    }
                 

                case PacketType.SIGNUP:
                    {
                        SignUpPacket packet = (SignUpPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.SIgnupProcess(sender, e,packet);
                        
                    }

                case PacketType.LOBBY:
                    {
                        LoginPacket packet = (LoginPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LoginProcess(sender, e, packet);
                        
                    }

                case PacketType.PLAYGAME:
                    {
                        LoginPacket packet = (LoginPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LoginProcess(sender, e, packet);
                        
                    }

                case PacketType.INROOM:
                    {
                        LoginPacket packet = (LoginPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LoginProcess(sender, e, packet);
                        
                    }

                case PacketType.SENDMESSAGE:
                    {
                        LoginPacket packet = (LoginPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LoginProcess(sender, e, packet);
                        
                    }
                case PacketType.LOBBYLOAD:
                    {
                        LobbyloadPacket packet = (LobbyloadPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LobbyLoadProcess(sender, e, packet);
                        
                    }

                default:
                    {
                        LoginPacket packet = (LoginPacket)Packet.Desserialize(e.Buffer);
                        return IOCompletionPortServerLibrary.LoginProcess(sender, e, packet);
                        
                    }

            }
        }


        
    }
}
