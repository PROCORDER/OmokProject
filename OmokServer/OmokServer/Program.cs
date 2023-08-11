using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using OmokPacket;
using ServerLibrary;
namespace OmokServer
{
    class IOCompletionPortServer
    {
        private Socket listenSocket;
        private const int MaxConnections = 100;
        private Semaphore semaphore;
        private SocketAsyncEventArgsPool receiveEventArgsPool;

        

        public void StartServer(int port)
        {
            semaphore = new Semaphore(MaxConnections, MaxConnections);

            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenSocket.Bind(new IPEndPoint(IPAddress.Any, port));
            listenSocket.Listen(MaxConnections);

            Console.WriteLine("Server started. Listening on port " + port);

            receiveEventArgsPool = new SocketAsyncEventArgsPool(MaxConnections);

            //SocketAsyncEventArgs를 여러개 미리 만들어서 대응하는 방법
            for (int i = 0; i < MaxConnections; i++)
            {
                SocketAsyncEventArgs receiveEventArgs = new SocketAsyncEventArgs();
                receiveEventArgs.Completed += ProcessReceive;
                receiveEventArgs.SetBuffer(new byte[StateObject.BufferSize], 0, StateObject.BufferSize);
                receiveEventArgsPool.Push(receiveEventArgs);
            }

            StartAccept(null);
        }

        private void StartAccept(SocketAsyncEventArgs acceptEventArgs)
        {
            if (acceptEventArgs == null)
            {
                acceptEventArgs = new SocketAsyncEventArgs();
                acceptEventArgs.Completed += ProcessAccept;
            }
            else
            {
                acceptEventArgs.AcceptSocket = null; // AcceptSocket에는 연결된 클라이언트의 소켓이 저장된다.
            }

            semaphore.WaitOne();
            if (!listenSocket.AcceptAsync(acceptEventArgs))
            {
                ProcessAccept(listenSocket, acceptEventArgs);
            }
        }

        private void ProcessAccept(object sender, SocketAsyncEventArgs e)
        {
            StartReceive(e.AcceptSocket);
            StartAccept(e);
        }

        private void StartReceive(Socket clientSocket)
        {
            SocketAsyncEventArgs receiveEventArgs = receiveEventArgsPool.Pop();
            receiveEventArgs.AcceptSocket = clientSocket;

            if (!clientSocket.ReceiveAsync(receiveEventArgs))
            {
                ProcessReceive(clientSocket, receiveEventArgs);
            }
        }

        private void ProcessReceive(object sender, SocketAsyncEventArgs e)
        {
            Socket clientSocket = e.AcceptSocket;

            if (e.BytesTransferred > 0 && e.SocketError == SocketError.Success)
            {
                //string receivedData = Encoding.ASCII.GetString(e.Buffer, e.Offset, e.BytesTransferred);
                //Console.WriteLine("Received: " + receivedData);
                Packet handlereceivePacket = (Packet)Packet.Desserialize(e.Buffer);
                              
                byte[] receivedData= PacketProcess.HandlePacketType(sender, e, handlereceivePacket);
                StartSend(clientSocket, receivedData);
            }
            else
            {
                CloseClientSocket(clientSocket);
            }

            receiveEventArgsPool.Push(e);
        }

        public void StartSend(Socket clientSocket, byte[] buffer)
        {
            
            SocketAsyncEventArgs sendEventArgs = new SocketAsyncEventArgs();
            sendEventArgs.Completed += ProcessSend;
            sendEventArgs.SetBuffer(buffer, 0, buffer.Length);
            sendEventArgs.AcceptSocket = clientSocket;

            if (!clientSocket.SendAsync(sendEventArgs))
            {
                ProcessSend(clientSocket, sendEventArgs);
            }
        }

        private void ProcessSend(object sender, SocketAsyncEventArgs e)
        {
            Socket clientSocket = e.AcceptSocket;

            if (e.SocketError != SocketError.Success)
            {
                CloseClientSocket(clientSocket);
            }
        }

        private void CloseClientSocket(Socket clientSocket)
        {
            clientSocket.Close();
            semaphore.Release();
            Console.WriteLine("Client disconnected.");
        }

        public static void Main(string[] args)
        {
            IOCompletionPortServer iocpServer = new IOCompletionPortServer();
            iocpServer.StartServer(12345);
        }
    }

    class StateObject
    {
        public const int BufferSize = 1024;
    }

    class SocketAsyncEventArgsPool
    {
        private readonly Stack<SocketAsyncEventArgs> pool;

        public SocketAsyncEventArgsPool(int capacity)
        {
            pool = new Stack<SocketAsyncEventArgs>(capacity);
        }

        public void Push(SocketAsyncEventArgs item)
        {
            lock (pool)
            {
                pool.Push(item);
            }
        }

        public SocketAsyncEventArgs Pop()
        {
            lock (pool)
            {
                return pool.Pop();
            }
        }
    }
}
