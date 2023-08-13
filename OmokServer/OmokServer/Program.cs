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
using ManageServer;
namespace OmokServer
{

    class OmokCheckserver { 
        public static void Main(string[] args)
        {
            ManageServer.IOCompletionPortServer iocpServer = new IOCompletionPortServer();
            iocpServer.StartServer(12345);
        }
    }

}
