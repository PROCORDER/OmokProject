using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
namespace OmokPacket
{
    public enum ELobbyaction
    {
        MAKEROOM = 0,
        LOBBYLOAD=1,
        REFRESHROOMLIST=2,
        ENTERROOM= 3,
        WAITINGROOM,
        LOBBYOUT,
           ERR
    }
    public enum EWaitingRoomState 
    {
        PLAYERIN=0,
        PLAYEROUT=1,
        OBSERVER1IN=2,
        OBSERVER1OUT,
        OBSERVER2IN ,
        OBSERVER2OUT,
        OBSERVER3IN,
        OBSERVER3OUT,
            ERR

    }



    [ProtoContract]
    public class LobbyPacket : Packet
    {
        [ProtoMember(5)]
        public ELobbyaction lobbyAction { get; set; }
        public RoomInfo room { get; set; }
    }

    [ProtoContract]
    public class LobbyloadPacket : LobbyPacket {

        [ProtoMember(6)]
        public List<string> roomList;

        public LobbyloadPacket()
        {
         
            type = PacketType.LOBBY;
            lobbyAction = ELobbyaction.LOBBYLOAD;
        }
    }

    [ProtoContract]
    public class RefreshRoomlistPacket : LobbyPacket {
        [ProtoMember(6)]
        public List<string> roomList;
        public RefreshRoomlistPacket()
        {
            type = PacketType.LOBBY;
            lobbyAction = ELobbyaction.REFRESHROOMLIST;
        }
    }


    
    [ProtoContract]
    public class MakeRoomPacket : LobbyPacket
    {
        [ProtoMember(6)]
        public bool bmakeRoomSuccess { get; set; }

        public MakeRoomPacket(UserInfo user)
        {
            this.user = user;
            type = PacketType.LOBBY;
            lobbyAction = ELobbyaction.MAKEROOM;
        }

    }
    

    [ProtoContract]
    public class EnterRoomPacket : LobbyPacket
    {

        [ProtoMember(6)]
        public bool bEnterRoom { get; set; }

        public EnterRoomPacket(UserInfo user)
        {
            this.user = user;
            type = PacketType.LOBBY;
            lobbyAction = ELobbyaction.ENTERROOM;
        }

    }
}
