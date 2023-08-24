using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokPacket
{
    public class LobbyClosedPacket:LobbyPacket
    {
       LobbyClosedPacket(UserInfo user)
        {
            this.user = user;
        }
    }
}
