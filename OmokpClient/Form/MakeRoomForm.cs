using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using OmokPacket;

namespace OmokClient
{
    public partial class MakeRoomForm : Form
    {
        public event Action<MakeRoomPacket> MakeRoomRequested;

        private NetworkStream serverStream;
        private string RoomName;
        private UserInfo user;
        private byte[] sendMakeRoomBuffer = new byte[1024 * 4];
        MakeRoomPacket readMakeRoompacket;
        public MakeRoomForm(NetworkStream stream,UserInfo user)
        {
            InitializeComponent();
            serverStream = stream;
            this.user = user;
        }

        private void MakeRoomBTN_Click(object sender, EventArgs e)
        {
            RoomName=MakeRoomNameBox.Text;
            MakeRoomPacket sendMakeRoomPacket = new MakeRoomPacket(user);
            sendMakeRoomPacket.room.roomName = RoomName;

            Packet.Serialize(sendMakeRoomPacket).CopyTo(sendMakeRoomBuffer, 0);

            int read = serverStream.Read(sendMakeRoomBuffer, 0, 1024 * 4);
            readMakeRoompacket = (MakeRoomPacket)Packet.Desserialize(sendMakeRoomBuffer);

            if (readMakeRoompacket.bmakeRoomSuccess == true)
            {
                MakeRoomRequested?.Invoke(readMakeRoompacket);
                System.Windows.Forms.MessageBox.Show("방 만들기에 성공하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MakeRoomNameBox.Text = "";
                System.Windows.Forms.MessageBox.Show("방 만들기에 실패하였습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
