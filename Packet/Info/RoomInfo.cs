using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokPacket
{
    public class RoomInfo
    {
        public bool EmptyPlayer { get; set; }
        public bool EmptyObserver1 { get; set; }
        public bool EmptyObserver2 { get; set; }
        public bool EmptyObserver3 { get; set; }

        public string roomName { get; set; }
        public Guid roomCode { get; set; }
        public UserInfo host { get; set; }
        public UserInfo player { get; set; }
        public UserInfo Observer1 { get; set; }
        public UserInfo Observer2 { get; set; }
        public UserInfo Observer3 { get; set; }



    }
}
