using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace OmokPacket
{
    [ProtoContract]
    public class LoginPacket:Packet
    {

        [ProtoMember(5)]
        public bool loginCheck
        {
            get { return loginCheck; }
            set { loginCheck = value; }
        }

        public LoginPacket()
        {
            this.loginCheck = false;
            length = 4096;
            type = (int)PacketType.LOGIN;
        }
    }
}

