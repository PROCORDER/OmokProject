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
    public partial class Lobby : Form
    {
        UserInfo user;

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
        private RoomInfo room;
        


        private readonly object Lobbylock = new object();
        private readonly object Chatlock = new object();
        public Lobby(UserInfo user)
        {
            room.roomName = "Lobby";
            this.user = user;
            InitializeComponent();
        }

        private async void Lobby_Load(object sender, EventArgs e)
        {
            ConnectToServer(PortIP.LOBBYPORT, ref Lobbystream, ref Lobbyclient, ref Lobbyconnected);
            ConnectToServer(PortIP.CHECKPORT, ref chatStream, ref chatClient, ref Chatconnected);

            LobbyloadPacket lobbyLoadPacket = new LobbyloadPacket();
            lobbyLoadPacket.user = user;
            Packet.Serialize(lobbyLoadPacket).CopyTo(LobbysendBuffer, 0);

            ClientIOMethod.Send(LobbysendBuffer, Lobbystream);

            int read = Lobbystream.Read(LobbyreadBuffer, 0, 1024 * 4);
            LobbyloadPacket readLobbyloadPacket = (LobbyloadPacket)Packet.Desserialize(LobbyreadBuffer);


            PlayerName.Text = user.MyName;
            PlayerID.Text = user.MyId;
            PlayerHistory.Text = "(" + readLobbyloadPacket.user.History[0] + "승" + readLobbyloadPacket.user.History[1] + "패" + ")";

            Invoke((MethodInvoker)delegate
            {
                RoomListBox.Items.Clear();
                foreach (string list in readLobbyloadPacket.roomList)
                {
                    RoomListBox.Invoke(new Action(() =>
                    {
                        RoomListBox.Items.Add(list);
                    }));
                }
                FriendListBox.Items.Clear();
                foreach (string list in readLobbyloadPacket.user.friendList)
                {
                    FriendListBox.Invoke(new Action(() =>
                    {
                        FriendListBox.Items.Add(list);
                    }));
                }

            });
           
            await ReadChat(chatStream);
        }
        private void ConnectToServer(int Port, ref NetworkStream stream, ref TcpClient client, ref bool connected)
        {
            try
            {

                client = new TcpClient();

                client.Connect(PortIP.SERVERIP, Port);
                stream = client.GetStream();


                connected = true;
                Console.WriteLine("서버에 연결되었습니다.");
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("서버와 연결되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        async private void FriendAddButton_Click(object sender, EventArgs e)
        {
            MakeFriendPacket makeFriendPacket = new MakeFriendPacket(user);
            MakeFriendPacket readMakeFriendPacket;
            await Task.Run(()=>{
                lock (Lobbylock)
                {
                    makeFriendPacket.addFriend.MyName = SendFriendBox.Text;
                    Packet.Serialize(makeFriendPacket).CopyTo(LobbysendBuffer, 0);

                    ClientIOMethod.Send(LobbysendBuffer, Lobbystream);

                    int read = Lobbystream.Read(LobbyreadBuffer, 0, 1024 * 4);
                    readMakeFriendPacket = (MakeFriendPacket)Packet.Desserialize(LobbyreadBuffer);
                }
                if (readMakeFriendPacket.bFriendAddSuccess == true)
                {

                    Invoke((MethodInvoker)delegate
                    {
                        FriendListBox.Items.Clear();
                        foreach (string list in readMakeFriendPacket.user.friendList)
                        {
                            FriendListBox.Items.Add(list);
                        }
                    });

                    System.Windows.Forms.MessageBox.Show("친구 추가에 성공하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("친구 추가에 실패하였습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            });

        }

        private async void RefreshRoomList_Tick(object sender, EventArgs e)
        {
            RefreshRoomlistPacket readRefreshPacket;


            readRefreshPacket = await Task.Run(() =>
              {
                  RefreshRoomlistPacket refresh = new RefreshRoomlistPacket();
                  Packet.Serialize(refresh).CopyTo(LobbysendBuffer, 0);

                  ClientIOMethod.Send(LobbysendBuffer, Lobbystream);


                  int read = Lobbystream.Read(LobbyreadBuffer, 0, 1024 * 4);
                  return (RefreshRoomlistPacket)Packet.Desserialize(LobbyreadBuffer);
              });
            Invoke((MethodInvoker)delegate
            {
                RoomListBox.Items.Clear();
                foreach (string list in readRefreshPacket.roomList)
                {
                    RoomListBox.Invoke(new Action(() =>
                    {
                        RoomListBox.Items.Add(list);
                    }));
                }
            });
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
                    RoomListBox.TopIndex = i;
                }
            }
        }
        private void MakeRoomButton_Click(object sender, EventArgs e)
        {
            MakeRoomForm makeRoomForm = new MakeRoomForm(Lobbystream, user);
            makeRoomForm.MakeRoomRequested += HandleEnterRoomRequest;

            makeRoomForm.ShowDialog();

        }
        private void HandleEnterRoomRequest(MakeRoomPacket packet)
        {
            if (packet.bmakeRoomSuccess == true)
            {
                
                WaitingRoomForm waitingRoomForm = new WaitingRoomForm(packet.room, packet.user,Lobbystream);
                this.Hide();
                waitingRoomForm.ShowDialog();
            }
            else
            {
                return;
            }
        }

        async private void RoomListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EnterRoomPacket enterRoom = new EnterRoomPacket(user);
            string selectedItemText = RoomListBox.SelectedItem.ToString();
            enterRoom.room.roomName = selectedItemText;
            await Task.Run(() =>
            {
                lock (Lobbylock)
                {
                    Packet.Serialize(enterRoom).CopyTo(LobbysendBuffer, 0);

                    ClientIOMethod.Send(LobbysendBuffer, Lobbystream);

                    int read = Lobbystream.Read(LobbyreadBuffer, 0, 1024 * 4);
                    enterRoom = (EnterRoomPacket)Packet.Desserialize(LobbyreadBuffer);
                }
                if (enterRoom.bEnterRoom == true)
                {
                    chatClient.Close();

                    chatStream.Close();
                    this.Hide();
                    this.Enabled = false;
                    WaitingRoomForm inRoomForm = new WaitingRoomForm(enterRoom.room, user, Lobbystream);
                    inRoomForm.ShowDialog();
                    this.Show();
                    this.Enabled = true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("방 입장에 실패하였습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });
        }
        private async void MessageSendEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendMessagePacket sendMessagePacket = new SendMessagePacket(user);
                sendMessagePacket.message = SendMessageBox.Text;
                SendMessagePacket readmessagePacket;
                await Task.Run(() =>
                {
                    lock (Chatlock)
                    {
                        Packet.Serialize(sendMessagePacket).CopyTo(ChatsendBuffer, 0);

                        ClientIOMethod.Send(ChatsendBuffer, chatStream);

                        int read = chatStream.Read(ChatreadBuffer, 0, 1024 * 4);
                        readmessagePacket = (SendMessagePacket)Packet.Desserialize(ChatreadBuffer);
                    }
                });
                Invoke((MethodInvoker)delegate
                {
                    SendMessageBox.Text = "";
                });
                e.Handled = true; 
            }
            
        }
        private async Task ReadChat(NetworkStream chatStream)
        {
            byte[] buffer = new byte[1024 * 4];
            int bytesRead;
            try
            {
                while ((bytesRead = await chatStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    SendMessagePacket readMessagePacket = (SendMessagePacket)Packet.Desserialize(buffer);
                    Invoke((MethodInvoker)delegate
                    {
                        Messagebox.Text += Environment.NewLine + readMessagePacket.user.MyName + ":" + readMessagePacket.message;
                    });

                }

            }
            catch(InvalidOperationException ex)
            {
                Messagebox.Text += Environment.NewLine +ex+"ERR";
            }
        }

    }
}
