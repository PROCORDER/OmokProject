using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Collections.Concurrent;
using OmokPacket;


namespace ServerLibrary
{
    public class LobbyandWaitingSendMethod
    {
        public static void LobbyActionSend(ConcurrentDictionary<Guid, ClientStateInfo> clients,byte[] buffer,Guid client){
            if (clients.TryGetValue(client, out ClientStateInfo clientState))
            {
                clientState.Socket.Send(buffer);
            }
        }

        public static void EnterRoomSend(ConcurrentDictionary<Guid, ClientStateInfo> clients, List<Guid> clientList, byte[] buffer)
        {
            foreach (Guid clientId in clientList)
            {
                if (clients.TryGetValue(clientId, out ClientStateInfo clientState))
                {
                    clientState.Socket.Send(buffer);
                }
            }

        }
        public static void WaitingRoomSend(ConcurrentDictionary<Guid, ClientStateInfo> clients){

        }
    }
}
