using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using ServerLibrary;

namespace LobbyandWaitingServer
{
    class LobbyandWaitingServer
    {
        
        private const int port = 12345;
        private static TcpListener listener;
        public static ConcurrentDictionary<Guid, ClientStateInfo> clients = new ConcurrentDictionary<Guid, ClientStateInfo>();

        static void Main(string[] args)
        {
            StartServer();
        }

        static void StartServer()
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            Console.WriteLine($"서버가 {IPAddress.Any}:{port} 에서 대기 중...");

            while (true)
            {
                try
                {
                    Socket clientSocket = listener.AcceptSocket();
                    ClientStateInfo clientState = new ClientStateInfo { Socket = clientSocket };
                    Guid clientId = Guid.NewGuid();
                    clients.TryAdd(clientId, clientState);

                    Console.WriteLine($"클라이언트 {clientId} 연결됨");

                    SocketAsyncEventArgs receiveEventArgs = new SocketAsyncEventArgs();
                    receiveEventArgs.SetBuffer(clientState.Buffer, 0, clientState.Buffer.Length);
                    receiveEventArgs.Completed += ReceiveCompleted;
                    receiveEventArgs.UserToken = clientId;


                    clientState.Socket.ReceiveAsync(receiveEventArgs);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"클라이언트 연결 오류: {e.Message}");
                }
            }
        }

        static void ReceiveCompleted(object sender, SocketAsyncEventArgs e)
        {
            if (e.SocketError == SocketError.Success && e.BytesTransferred > 0)
            {
                Guid clientId = (Guid)e.UserToken;
                byte[] receivedData = new byte[e.BytesTransferred];
                Array.Copy(e.Buffer, e.Offset, receivedData, 0, e.BytesTransferred);
                
                PacketProcess.HandleLobbyPacketType(receivedData, clients, clientId);; // 이것을 버퍼로 반환하는 것이 아닌 send까지 완료하는 형태로 가야한다. clientsState 

                if (clients.TryGetValue(clientId, out ClientStateInfo clientState))
                {
                    clientState.Socket.Send(receivedData);
                }

                e.SetBuffer(clientState.Buffer, 0, clientState.Buffer.Length);
                clientState.Socket.ReceiveAsync(e);
            }
            else
            {
                Guid clientId = (Guid)e.UserToken;
                LobbyMethod.SQLFormClosed(clientId);
                Console.WriteLine($"클라이언트 {clientId} 연결 해제");

                clients.TryRemove(clientId, out _);
            }
        }
    }
}




