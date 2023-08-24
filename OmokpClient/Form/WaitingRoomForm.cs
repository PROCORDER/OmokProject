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
    public partial class WaitingRoomForm : Form
    {
        private string selectedName = "";
        UserInfo user;
        public string myID { get; set; }
        public string myName { get; set; }

        private byte[] ChatsendBuffer = new byte[1024 * 8];
        private byte[] ChatreadBuffer = new byte[1024 * 8];
        private byte[] LobbysendBuffer = new byte[1024 * 4];
        private byte[] LobbyreadBuffer = new byte[1024 * 4];


        private TcpClient chatClient;
        private TcpClient guestClient;
        private NetworkStream chatStream;
        private NetworkStream waitingRoomstream;
        private NetworkStream GuestStream;
        private bool Chatconnected = false;
        private bool waitingconnected = false;
        private bool guestConnected = false;
        WaitingRoomPacket waitingpacket = new WaitingRoomPacket();

        private readonly object WaitingRoomlock = new object();
        private readonly object ChatingRoomlock = new object();

        //비동기로 입력받는 것을 구현할 것


        public WaitingRoomForm(RoomInfo room, UserInfo user,NetworkStream stream)
        {
            waitingRoomstream = stream;
            InitializeComponent();
            waitingpacket.room = room;
            this.user = user;
        }
        private void InitializeContextMenu()
        {
            ToolStripMenuItem invitePlayerItem = new ToolStripMenuItem("플레이어로 초대하기");
            ToolStripMenuItem inviteObserverItem = new ToolStripMenuItem("관전자로 초대하기");

            invitePlayerItem.Click += InvitePlayerItem_Click;
            inviteObserverItem.Click += InviteObserverItem_Click;

            contextMenuStrip1.Items.Add(invitePlayerItem);
            contextMenuStrip1.Items.Add(inviteObserverItem);

        }
        async private void InvitePlayerItem_Click(object sender, EventArgs e)
        {
            if (waitingpacket.room.EmptyPlayer == false)
            {
                PlayerInvitePacket readPacket;

                await Task.Run(() =>
                {
                    lock (WaitingRoomlock)
                    {
                        PlayerInvitePacket sendPacket = new PlayerInvitePacket(waitingpacket, GetPlayer());
                        Packet.Serialize(sendPacket).CopyTo(LobbysendBuffer, 0);

                        ClientIOMethod.Send(LobbysendBuffer, waitingRoomstream);

                        int read = waitingRoomstream.Read(LobbyreadBuffer, 0, 1024 * 4);
                        readPacket = (PlayerInvitePacket)Packet.Desserialize(LobbyreadBuffer);
                    }
                    if (readPacket.Success == true)
                    {
                        waitingpacket.room.player = readPacket.invitedUser;
                        waitingpacket.room.EmptyPlayer = true;

                    }
                });
                ChangeUserLabel(waitingpacket.room);
            }

        }
        public UserInfo GetPlayer()
        {
            UserInfo user = new UserInfo();
            lock (WaitingRoomlock)
            {
                user.MyName = selectedName;
            }
            return user;
        }

        async private void InviteObserverItem_Click(object sender, EventArgs e)
        {
            int EmptyObserver;
            EmptyObserver = WhoIsEmptyObserver(waitingpacket);
            if (EmptyObserver == 4)
            {
                MessageBox.Show("관전자 자리가 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                ObserverInvitePacket readPacket;

                await Task.Run(() =>
                {
                    lock (WaitingRoomlock)
                    {
                        ObserverInvitePacket sendPacket = new ObserverInvitePacket(waitingpacket, GetPlayer());
                        Packet.Serialize(sendPacket).CopyTo(LobbysendBuffer, 0);

                        ClientIOMethod.Send(LobbysendBuffer, waitingRoomstream);

                        int read = waitingRoomstream.Read(LobbyreadBuffer, 0, 1024 * 4);
                        readPacket = (ObserverInvitePacket)Packet.Desserialize(LobbyreadBuffer);
                    }
                    if (readPacket.Success == true)
                    {
                        waitingpacket.room = readPacket.room;

                    }
                });
                ChangeUserLabel(waitingpacket.room);
            }

        }

        private int WhoIsEmptyObserver(WaitingRoomPacket waiting)
        {
            if (waiting.room.EmptyObserver1 == false)
                return 1;
            else if (waiting.room.EmptyObserver2 == false)
                return 2;
            else if (waiting.room.EmptyObserver3 == false)
                return 3;
            else
                return 4;
        }
        private void FriendListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = FriendListBox.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    FriendListBox.SelectedIndex = index;
                    selectedName = FriendListBox.SelectedItem.ToString();
                }
            }
        }
        private async void WaitingRoomForm_Load(object sender, EventArgs e)
        {
            ChangeUserLabel(waitingpacket.room);
            ConnectToServer(PortIP.CHATPORT, ref chatStream, ref chatClient, ref Chatconnected);
            ConnectToServer(PortIP.LOBBYPORT, ref GuestStream, ref guestClient,ref guestConnected);
            FriendListBox.Items.Clear();
            foreach (string list in user.friendList)
            {
                FriendListBox.Items.Add(list);
            }
            await StartReceivingPacketsAsync();

        }
        public void ConnectToServer(int Port, ref NetworkStream stream, ref TcpClient client, ref bool connected)
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


        private void FriendAdd_Click(object sender, EventArgs e)
        {
            MakeFriendPacket makeFriendPacket = new MakeFriendPacket(user);
            Packet.Serialize(makeFriendPacket).CopyTo(LobbysendBuffer, 0);

            ClientIOMethod.Send(LobbysendBuffer, waitingRoomstream);

            int read = waitingRoomstream.Read(LobbyreadBuffer, 0, 1024 * 4);
            MakeFriendPacket readMakeFriendPacket = (MakeFriendPacket)Packet.Desserialize(LobbyreadBuffer);

            if (readMakeFriendPacket.bFriendAddSuccess == true)
            {
                FriendListBox.Items.Clear();
                foreach (string list in readMakeFriendPacket.user.friendList)
                {
                    FriendListBox.Items.Add(list);
                }
                MessageBox.Show("친구 추가에 성공하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("친구 추가에 실패하였습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Invoke((MethodInvoker)delegate
            {
                sendFriendBox.Text = "";
            });
        }

        private void ChangeUserLabel(RoomInfo WaitingRoomInfo)
        {
            Invoke((MethodInvoker)delegate
            {
                HostName.Text = WaitingRoomInfo.host.MyName;
            HostHistory.Text = WaitingRoomInfo.host.History[0] + "승" + WaitingRoomInfo.host.History[1] + "패";
            HostId.Text = WaitingRoomInfo.host.MyId;

            PlayerName.Text = WaitingRoomInfo.player.MyName;
            PlayerId.Text = WaitingRoomInfo.player.MyId;
            PlayerHistory.Text = WaitingRoomInfo.player.History[0] + "승" + WaitingRoomInfo.player.History[1] + "패";
            if (WaitingRoomInfo.Observer1.MyId != null)
                Observer1.Text = WaitingRoomInfo.Observer1.MyName + "(" + WaitingRoomInfo.Observer1.MyId + ")";
            if (WaitingRoomInfo.Observer2.MyId != null)
                Observer2.Text = WaitingRoomInfo.Observer2.MyName + "(" + WaitingRoomInfo.Observer2.MyId + ")";
            if (WaitingRoomInfo.Observer3.MyId != null)
                Observer3.Text = WaitingRoomInfo.Observer3.MyName + "(" + WaitingRoomInfo.Observer3.MyId + ")";
            });
        }

        private async void Messagebutton_Click(object sender, EventArgs e)
        {
            SendMessagePacket sendMessagePacket = new SendMessagePacket(user);
            sendMessagePacket.message = SendMessageBox.Text;
            SendMessagePacket readmessagePacket;
            Invoke((MethodInvoker)delegate
            {
                Messagebox.Text += Environment.NewLine + user.MyName + ":" + SendMessageBox.Text;
            });
            await Task.Run(() =>
            {
                lock (ChatingRoomlock)
                {
                    Packet.Serialize(sendMessagePacket).CopyTo(ChatsendBuffer, 0);

                    ClientIOMethod.Send(ChatsendBuffer, chatStream);

                    int read = chatStream.Read(ChatreadBuffer, 0, 1024 * 8);
                    readmessagePacket = (SendMessagePacket)Packet.Desserialize(ChatreadBuffer);
                }
            });
            Invoke((MethodInvoker)delegate
            {
                SendMessageBox.Text = "";
            });
        }

        private async Task StartReceivingPacketsAsync()
        {
            while (true)
            {
                EnterRoomPacket receivedPacket = await ReceivePacketAsync();
                if (receivedPacket.bEnterRoom == true)
                {
                    lock (WaitingRoomlock)
                    {
                        waitingpacket.room = receivedPacket.room;
                    }
                    
                    ChangeUserLabel(waitingpacket.room);
                }

            }
        }
        private async Task<EnterRoomPacket> ReceivePacketAsync()
        {
            try
            {
                byte[] readPlayerBuffer = new byte[1024 * 8];
                lock (WaitingRoomlock) {
                    EnterRoomPacket sendCheckClient = new EnterRoomPacket(user);
                    sendCheckClient.room = waitingpacket.room;
                }
                await Task.Run(()=>{
                    ClientIOMethod.Send(readPlayerBuffer, GuestStream);
                });
                    
               
                int bytesRead = await GuestStream.ReadAsync(readPlayerBuffer, 0, readPlayerBuffer.Length);
               

                if (bytesRead > 0)
                {
                    EnterRoomPacket readMessagePacket = (EnterRoomPacket)Packet.Desserialize(readPlayerBuffer);
                    return readMessagePacket;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 발생: " + ex.Message);
                return null;
            }

        }





}  

}
