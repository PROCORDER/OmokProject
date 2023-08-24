using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace OmokClient
{
    public class ClientIOMethod
    {
        public static void Send(byte[] sendBuffer, NetworkStream stream)
        {
            stream.Write(sendBuffer, 0, sendBuffer.Length);
            stream.Flush();
            Array.Clear(sendBuffer, 0, sendBuffer.Length);
        }
       
    }
    
}
