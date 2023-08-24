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
        private NetworkStream stream;
        private bool connected = false;


        public SignUpForm(NetworkStream stream)
        {
            InitializeComponent();
            this.stream = stream;
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
            sendSignUpPacket.user.MyName = SignUpNameBox.Text;
            sendSignUpPacket.user.MyId = SignUpIDBox.Text;
            sendSignUpPacket.user.MyPw = SignUpPWBox.Text;
            Packet.Serialize(sendSignUpPacket).CopyTo(sendBuffer,0);
            ClientIOMethod.Send(sendBuffer,stream);

            int read = stream.Read(readBuffer, 0, 1024 * 4);
            SignUpPacket readSignUpPacket = (SignUpPacket)Packet.Desserialize(readBuffer);
            if (readSignUpPacket.signUpCheck == 0)
            {
                MessageBox.Show("회원가입에 성공했습니다!", "회원가입 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }
    }
}
