using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokPacket
{
    public enum ELobbyaction
    {
        MakeRoom=0,
        Playwithfriend,
        Message,
        Exit

    }
    public enum EWaitingRoomHostAction
    {
        Play=0,
        Kick,
        Invite,
        Message,
        Boom


    }
    public enum EWaitingRoomGuestAction
    {
        Message=0,
        Exit
    }

    class LobbyPacket
    {
        string lobbyMyName;
        string message;
        int lobbyAction;
        int roomCode;

        bool inRoom;
        string roomName;
        
        bool imHost;
        int hostAction;

        int guestAction;     
    }
}
