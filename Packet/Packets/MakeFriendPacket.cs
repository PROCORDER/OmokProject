using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace OmokPacket
{
    [ProtoContract]
    public class MakeFriendPacket:Packet
    {
   
            [ProtoMember(6)]
            public UserInfo addFriend { get; set; }
            public bool bFriendAddSuccess { get; set; }

            public MakeFriendPacket(UserInfo user)
            {
                this.user = user; 
                type = PacketType.MAKEFRIEND;
            }

        }
    
}
