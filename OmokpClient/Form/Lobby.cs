using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OmokPacket;
using System.Net.Sockets;

namespace OmokClient
{
    public partial class Robby : Form
    {
        public string myID { get; set; }
        public string myName { get; set; }

        private byte[] ChatsendBuffer = new byte[1024 * 4];
        private byte[] ChatreadBuffer = new byte[1024 * 4];
        private byte[] LobbysendBuffer = new byte[1024 * 4];
        private byte[] LobbyreadBuffer = new byte[1024 * 4];

        private TcpClient chatClient;
        private TcpClient Lobbyclient;
        private NetworkStream chatStream;
        private NetworkStream Lobbystream;
        private bool Chatconnected = false;
        private bool Lobbyconnected = false;

        int LobbyPort = 7777;
        int ChatPort = 8888;

        private readonly object Lobbylock = new object();
        public Robby()
        {
            InitializeComponent();
        }

        private void Robby_Load(object sender, EventArgs e)
        {
            ConnectToServer(LobbyPort,Lobbystream,Lobbyclient,Lobbyconnected);
            ConnectToServer(ChatPort,chatStream,chatClient,Chatconnected);

            LobbyloadPacket robbyloadPacket = new LobbyloadPacket();
            robbyloadPacket.MyID = myID;
            Packet.Serialize(robbyloadPacket).CopyTo(LobbysendBuffer,0);

            Send(LobbysendBuffer,Lobbystream);

            int read = Lobbystream.Read(LobbyreadBuffer, 0, 1024 * 4);
            LobbyloadPacket readLobbyloadPacket = (LobbyloadPacket)Packet.Desserialize(LobbyreadBuffer);


            PlayerName.Text = myName;
            PlayerID.Text = myID;
            PlayerHistory.Text = "(" + readLobbyloadPacket.Histroy[0] + "승"  + readLobbyloadPacket.Histroy[1]+"패" + ")";


        }
        private void ConnectToServer(int Port,NetworkStream stream,TcpClient client,bool connected)
        {
            try
            {

                string serverIP = "서버의 IP 주소";
               
                client = new TcpClient();

                client.Connect(serverIP, Port);
                stream = client.GetStream();


                connected = true;
                Console.WriteLine("서버에 연결되었습니다.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("서버와 연결되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void Send(byte[]sendBuffer,NetworkStream stream)
        {
            stream.Write(sendBuffer, 0,sendBuffer.Length);
            stream.Flush();
            Array.Clear(sendBuffer, 0, sendBuffer.Length);
        }

        private void FriendAddButton_Click(object sender, EventArgs e)
        {
            MakeFriendPacket lobbyPacket = new MakeFriendPacket();
            lobbyPacket.lobbyAction = ELobbyaction.ADDFRIEND;
            Packet.Serialize(lobbyPacket).CopyTo(LobbysendBuffer, 0);
            
            Send(LobbysendBuffer, Lobbystream);

            int read = Lobbystream.Read(LobbyreadBuffer, 0, 1024 * 4);
            MakeFriendPacket readMakeFriendPacket = (MakeFriendPacket)Packet.Desserialize(LobbyreadBuffer);

            if (readMakeFriendPacket.bFriendAddSuccess == true)
            {
                FriendListBox.Items.Clear();
                foreach(string list in readMakeFriendPacket.Friendlist)
                {
                    FriendListBox.Items.Add(list);
                }
                MessageBox.Show("친구 추가에 성공하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("친구 추가에 실패하였습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void RefreshRoomList_Tick(object sender, EventArgs e)
        {
            RefreshRoomlistPacket readRefreshPacket;


            readRefreshPacket=await Task.Run(() =>
            {
                RefreshRoomlistPacket refresh = new RefreshRoomlistPacket();
                Packet.Serialize(refresh).CopyTo(LobbysendBuffer, 0);

                Send(LobbysendBuffer, Lobbystream);


                int read = Lobbystream.Read(LobbyreadBuffer, 0, 1024 * 4);
                 return (RefreshRoomlistPacket)Packet.Desserialize(LobbyreadBuffer);
            });
               
            foreach (string list in readRefreshPacket.roomList)
            {
                RoomListBox.Invoke(new Action(() => {
                    RoomListBox.Items.Add(list);
                }));
            }
        }

        private void FindRoomButton_Click(object sender, EventArgs e)
        {
            string searchText = FindRoom.Text;

            foreach (int index in RoomListBox.SelectedIndices)
            {
                RoomListBox.SetSelected(index, false);
            }

            for (int i = 0; i < RoomListBox.Items.Count; i++)
            {
                string listItem = RoomListBox.Items[i].ToString();
                if (listItem.Contains(searchText))
                {
                    RoomListBox.SetSelected(i, true);
                }
            }
        }

        async private void RoomListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EnterRoom enterRoom=new EnterRoom(myName);
            string selectedItemText = RoomListBox.SelectedItem.ToString();
            enterRoom.roomName = selectedItemText;
            await Task.Run(() =>
            {
                lock(Lobbylock)
                {
                    Packet.Serialize(enterRoom).CopyTo(LobbysendBuffer, 0);

                    Send(LobbysendBuffer, Lobbystream);

                    int read = Lobbystream.Read(LobbyreadBuffer, 0, 1024 * 4);
                    enterRoom = (EnterRoom)Packet.Desserialize(LobbyreadBuffer);
                }
                if (enterRoom.bEnterRoom == true)
                {
                    this.Hide();
                    this.Enabled = false;
                    InRoomForm inRoomForm = new InRoomForm(myName,enterRoom.roomName);
                    inRoomForm.ShowDialog();
                    this.Show();
                    this.Enabled = true;

                }
                else
                {
                    MessageBox.Show("방 입장에 실패하였습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });
            
        }
    }
}
