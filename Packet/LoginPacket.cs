using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokPacket
{
    public class LoginPacket:Packet
    {
       public string loginID
        {
            get { return loginID; }
            set { loginID = value; }
        }


        public string loginPW
        {
            get { return loginPW; }
            set { loginPW = value; }
        }

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

