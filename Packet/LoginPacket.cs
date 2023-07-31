using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokPacket
{
    class LoginPacket:Packet
    {
        string loginID;
        string loginPW;
        bool loginCheck;
        public LoginPacket()
        {
            this.loginID = null;
            this.loginPW = null;
            this.loginCheck = false;

        }
    }
}
