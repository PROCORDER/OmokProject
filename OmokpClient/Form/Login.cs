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
namespace OmokClient
{
    public partial class Login : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private bool connected = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

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
                
                Console.WriteLine("서버 연결 오류: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm SignUpForm = new SignUpForm();
            SignUpForm.ShowDialog();
            this.Show();

        }
    }
}
