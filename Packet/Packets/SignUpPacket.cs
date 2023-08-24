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
        IDERR=1,
        NAMEERR=2
        
    }

    public class SignUpPacket:Packet
    {
     
        public int signUpCheck { get; set; }

        public SignUpPacket()
        {
            type = PacketType.SIGNUP;
            length = 4096;

        }
    }
}
