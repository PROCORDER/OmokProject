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
            public int roomCode { get; set; }

        }
}
