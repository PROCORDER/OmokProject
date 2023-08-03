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
        
        


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ConnectToServer();

        }

        private void ConnectToServer()
        {
            try
            {
              
                string serverIP = "서버의 IP 주소"; 
                int serverPort = 7777; 

       
                client = new TcpClient();

                client.Connect(serverIP, serverPort);
                stream = client.GetStream();

                
                connected = true;
                Console.WriteLine("서버에 연결되었습니다.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("서버와 연결되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Send()
        {
            stream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            stream.Flush();
            Array.Clear(sendBuffer, 0, sendBuffer.Length);
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm SignUpForm = new SignUpForm();
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
            loginPacket.loginID = LoginIDTextBox.Text;
            loginPacket.loginPW = LoginPWBox.Text;
            Packet.Serialize(loginPacket).CopyTo(sendBuffer, 0);

            Send();
            
            int read = stream.Read(readBuffer, 0, 1024 * 4);
            LoginPacket readLoginPacket=(LoginPacket)Packet.Desserialize(readBuffer);
            if (readLoginPacket.loginCheck == true)
            {
                this.Hide();
                Robby RobbyForm = new Robby();
                RobbyForm.ShowDialog();
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
