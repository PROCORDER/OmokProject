using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokPacket
{
        public class SendMessagePacket : Packet
        {
            public string message { get; set; }
            public  RoomInfo room { get; set; }
            public SendMessagePacket(UserInfo user)
            {
                this.user = user;
            }

        }
}
