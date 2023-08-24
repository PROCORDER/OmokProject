using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Net.Sockets;

namespace ServerLibrary
{
    public class ClientStateInfo
    {
        public Socket Socket { get; set; }
        public byte[] Buffer { get; } = new byte[1024 * 4];
    }
}
