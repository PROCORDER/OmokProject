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
        [ProtoMember(4)]
        public string loginID
        {
            get { return loginID; }
            set { loginID = value; }
        }

        [ProtoMember(5)]
        public string loginPW
        {
            get { return loginPW; }
            set { loginPW = value; }
        }
        [ProtoMember(6)]
        public string loginName { get; set; }
        [ProtoMember(7)]
        public bool loginCheck
        {
            get { return loginCheck; }
            set { loginCheck = value; }
        }

        public LoginPacket()
        {
            this.loginID = null;
            this.loginPW = null;
            this.loginCheck = false;
            length = 4096;
            type = (int)PacketType.LOGIN;
        }
    }
}

