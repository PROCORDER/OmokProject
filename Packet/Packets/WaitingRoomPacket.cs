using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace OmokPacket
{
    public enum EWaitingRoomHostAction
    {
        PLAY = 0,
        KICK=1,
        PLAYERINVITE=2,
        OBSERVERINVITE=3,
        MESSAGE=4,
        BOOM=5


    }
    public enum EWaitingRoomGuestAction
    {
        MESSAGE = 0,
        EXIT=1
    }
        [ProtoContract]
    public class WaitingRoomPacket:LobbyPacket
    {

            [ProtoMember(5)]
            public EWaitingRoomHostAction hostAction { get; set; }
            [ProtoMember(6)]
            public EWaitingRoomGuestAction guestAction { get; set; }
            public WaitingRoomPacket()
            {
                type = PacketType.WAITINGROOM;
        }

    }
    public class PlayerInvitePacket:WaitingRoomPacket {
        public UserInfo invitedUser;
        public bool Success;

    public PlayerInvitePacket(WaitingRoomPacket waitingRoom ,UserInfo user)
        {
            room = waitingRoom.room;
            invitedUser = user;
            hostAction = EWaitingRoomHostAction.PLAYERINVITE;
        }


    }
    public class ObserverInvitePacket:WaitingRoomPacket
    {
        public UserInfo invitedUser;
        public bool Success;
        public ObserverInvitePacket(WaitingRoomPacket waitingRoom, UserInfo user)
        {
            room = waitingRoom.room;
            invitedUser = user;
            hostAction = EWaitingRoomHostAction.OBSERVERINVITE;
        }
    }

}
