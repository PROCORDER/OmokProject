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
    public partial class Login : Form
    {
        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];
        private TcpClient client;
        private NetworkStream stream;
        private bool connected = false;
        UserInfo user;
        
        


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ConnectToServer(PortIP.CHECKPORT,ref stream,ref client,ref connected);

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


        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm SignUpForm = new SignUpForm(stream);
            SignUpForm.ShowDialog();
            this.Show();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(LoginIDTextBox.Text)&& string.IsNullOrWhiteSpace(LoginPWBox.Text))
            {
                MessageBox.Show("아이디와 비밀번호 모두 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoginPacket loginPacket = new LoginPacket();
            loginPacket.user.MyId = LoginIDTextBox.Text;
            loginPacket.user.MyPw = LoginPWBox.Text;
            user = loginPacket.user;
            Packet.Serialize(loginPacket).CopyTo(sendBuffer, 0);

            ClientIOMethod.Send(sendBuffer,stream);
            
            int read = stream.Read(readBuffer, 0, 1024 * 4);
            LoginPacket readLoginPacket=(LoginPacket)Packet.Desserialize(readBuffer);
            if (readLoginPacket.loginCheck == true)
            {
                this.Hide();
                Lobby LobbyForm = new Lobby(user);
                LobbyForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 틀렸습니다. 다시 입력해주세요","로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginIDTextBox.Text = "";
                LoginPWBox.Text = "";
            }

        }



        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           if(connected==true)
            {
                client.Close();
            }
        }
    }
}
