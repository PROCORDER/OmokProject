using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokClient
{
    public enum PacketType
    {
        Login,
        SignUp,
    }
    class Packet
    {
        public int Length { get; set; }

    }
}
