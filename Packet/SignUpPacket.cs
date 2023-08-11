using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmokPacket;

namespace OmokPacket
{
    public enum SignUpErrorType
    {
        ALLOK = 0,
        IDERR,
        NAMEERR
        
    }

    public class SignUpPacket:Packet
    {
        public string signUpName { get; set; }
        public string signUpID { get; set; }
        public string signUpPW { get; set; }

        public int signUpCheck { get; set; }

        public SignUpPacket()
        {
            this.signUpID = null;
            this.signUpPW = null;
            int signUpCheck = 0;
            type = PacketType.SIGNUP;
            length = 4096;

        }
    }
}
