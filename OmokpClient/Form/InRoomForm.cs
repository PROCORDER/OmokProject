using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmokClient
{
    public partial class InRoomForm : Form
    {
        string myName;
        string roomName;
        public InRoomForm(string myName,string roomName)
        {
            InitializeComponent();
            this.myName = myName;
            this.roomName = roomName;
        }

        private void InRoomForm_Load(object sender, EventArgs e)
        {
            this.Text = roomName;
        }
    }
}
