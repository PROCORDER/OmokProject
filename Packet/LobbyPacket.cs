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
        FINDROOM,
        PLAYWITH,
        ADDFRIEND,
        MESSAGE,
        LOBBYLOAD,
        REFRESHROOMLIST,
        ENTERROOM,
        EXIT

    }
    public enum EWaitingRoomHostAction
    {
        PLAY = 0,
        KICK,
        INVITE,
        MESSAGE,
        BOOM


    }
    public enum EWaitingRoomGuestAction
    {
        MESSAGE = 0,
        EXIT
    }

    [ProtoContract]
    public class LobbyPacket : Packet
    {
        [ProtoMember(4)]
        public string MyID { get; set; }
        [ProtoMember(5)]
        public int lobbyAction { get; set; }
    }

    [ProtoContract]
    public class LobbyloadPacket : LobbyPacket {
        [ProtoMember(6)]
        public string[] friendList;
        [ProtoMember(7)]
        public string[] roomList;
        [ProtoMember(8)]
        public string[] Histroy;

        public LobbyloadPacket()
        {
            type = PacketType.LOBBY;
            lobbyAction = (int)ELobbyaction.ADDFRIEND;
        }
    }

    [ProtoContract]
    public class RefreshRoomlistPacket : LobbyPacket {
        [ProtoMember(6)]
        public string[] roomList;
        public RefreshRoomlistPacket()
        {
            type = PacketType.LOBBY;
            lobbyAction = (int)ELobbyaction.REFRESHROOMLIST;
        }
    }

    [ProtoContract]
    public class MakeFriendPacket : LobbyPacket
    {
        [ProtoMember(6)]
        public bool bFriendAddSuccess { get; set; }
        [ProtoMember(7)]
        public string addfriendName { get; set; }
        [ProtoMember(8)]
        public string[] Friendlist { get; set; }

        public MakeFriendPacket(){
            type = PacketType.LOBBY;
            lobbyAction = (int)ELobbyaction.LOBBYLOAD;
            }
    }

    [ProtoContract]
    public class MakeRoom : LobbyPacket
    {
        [ProtoMember(6)]
        public bool makeRommSuccess { get; set; }
        [ProtoMember(7)]
        public string roomName { get; set; }
        [ProtoMember(8)]
        public int roomCode { get; set; }
        public MakeRoom()
        {
            type = PacketType.LOBBY;
            lobbyAction = (int)ELobbyaction.MAKEROOM;
        }

    }
    
    [ProtoContract]
    public class InRoom : LobbyPacket
    {
        [ProtoMember(6)]
        public bool imHost { get; set; }
        [ProtoMember(7)]
        public int hostAction { get; set; }
        [ProtoMember(8)]
        public int guestAction { get; set; }
        public InRoom()
        {
            type = PacketType.INROOM;
        }
    }

    [ProtoContract]
    public class EnterRoom : LobbyPacket
    {
        [ProtoMember(6)]
        public string roomName { get; set; }
        [ProtoMember(7)]
        public string myName { get; set; }
        [ProtoMember(8)]
        public bool bEnterRoom { get; set; }

        public EnterRoom(string name)
        {
            myName = name;
            type = PacketType.LOBBY;
            lobbyAction = (int)ELobbyaction.ENTERROOM;
        }
    }


}
