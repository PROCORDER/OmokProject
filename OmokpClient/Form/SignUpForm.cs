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
    public partial class SignUpForm : Form
    {
        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];
        private TcpClient client;
        private NetworkStream stream;
        private bool connected = false;

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
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void MoveLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ValidateTextBoxInputKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
            private void ValidateTextBoxInputKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            { 
                return;
            }

           
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Alt || e.KeyCode == Keys.Shift)
            {
                e.Handled = true;
            }
        }


        private void SingUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SignUpNameBox.Text) && string.IsNullOrWhiteSpace(SignUpIDBox.Text)&& string.IsNullOrWhiteSpace(SignUpPWBox.Text))
            {
                MessageBox.Show("모든 칸을 채워주세요", "회원가입 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SignUpPacket sendSignUpPacket = new SignUpPacket();
            sendSignUpPacket.signUpName = SignUpNameBox.Text;
            sendSignUpPacket.signUpID = SignUpIDBox.Text;
            sendSignUpPacket.signUpPW = SignUpPWBox.Text;
            Packet.Serialize(sendSignUpPacket).CopyTo(sendBuffer,0);
            Send();

            int read = stream.Read(readBuffer, 0, 1024 * 4);
            SignUpPacket readSignUpPacket = (SignUpPacket)Packet.Desserialize(readBuffer);
            if (readSignUpPacket.signUpCheck == 0)
            {
                MessageBox.Show("회원가입에 성공했습니다!", "회원가입 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                client.Close();
                this.Close();
            }
            else if (readSignUpPacket.signUpCheck == (int)SignUpErrorType.NAMEERR)
            {
                MessageBox.Show("중복된 Name입니다. 다시 입력해주세요", "회원가입 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(readSignUpPacket.signUpCheck == (int)SignUpErrorType.IDERR)
            {
                MessageBox.Show("중복된 ID입니다. 다시 입력해주세요", "회원가입 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SignUpFormClosed(object sender, FormClosedEventArgs e)
        {
            if (connected == true)
            {
                client.Close();
            }
        }
    }
}
