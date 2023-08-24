
namespace OmokClient
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Messagebox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SendMessageBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.FriendAddButton = new System.Windows.Forms.Button();
            this.SendFriendBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.FriendListBox = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PlayerHistory = new System.Windows.Forms.Label();
            this.PlayerID = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.playerPicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MakeRoomButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindRoomLabel = new System.Windows.Forms.Label();
            this.FindRoom = new System.Windows.Forms.TextBox();
            this.RefreshRoomList = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Messagebox);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(977, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 677);
            this.panel1.TabIndex = 0;
            // 
            // Messagebox
            // 
            this.Messagebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Messagebox.Location = new System.Drawing.Point(0, 0);
            this.Messagebox.Multiline = true;
            this.Messagebox.Name = "Messagebox";
            this.Messagebox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Messagebox.Size = new System.Drawing.Size(387, 591);
            this.Messagebox.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.SendMessageBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 591);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(387, 86);
            this.panel8.TabIndex = 3;
            // 
            // SendMessageBox
            // 
            this.SendMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendMessageBox.Location = new System.Drawing.Point(0, 0);
            this.SendMessageBox.Multiline = true;
            this.SendMessageBox.Name = "SendMessageBox";
            this.SendMessageBox.Size = new System.Drawing.Size(387, 86);
            this.SendMessageBox.TabIndex = 0;
            this.SendMessageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageSendEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(636, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 677);
            this.panel2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 237);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(341, 440);
            this.panel9.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.FriendAddButton);
            this.panel11.Controls.Add(this.SendFriendBox);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 412);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(341, 28);
            this.panel11.TabIndex = 5;
            // 
            // FriendAddButton
            // 
            this.FriendAddButton.Location = new System.Drawing.Point(265, 3);
            this.FriendAddButton.Name = "FriendAddButton";
            this.FriendAddButton.Size = new System.Drawing.Size(75, 23);
            this.FriendAddButton.TabIndex = 4;
            this.FriendAddButton.Text = "추가";
            this.FriendAddButton.UseVisualStyleBackColor = true;
            this.FriendAddButton.Click += new System.EventHandler(this.FriendAddButton_Click);
            // 
            // SendFriendBox
            // 
            this.SendFriendBox.Location = new System.Drawing.Point(0, 3);
            this.SendFriendBox.Name = "SendFriendBox";
            this.SendFriendBox.Size = new System.Drawing.Size(259, 25);
            this.SendFriendBox.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.FriendListBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(341, 440);
            this.panel10.TabIndex = 4;
            // 
            // FriendListBox
            // 
            this.FriendListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendListBox.FormattingEnabled = true;
            this.FriendListBox.ItemHeight = 15;
            this.FriendListBox.Location = new System.Drawing.Point(0, 0);
            this.FriendListBox.Name = "FriendListBox";
            this.FriendListBox.Size = new System.Drawing.Size(341, 440);
            this.FriendListBox.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PlayerHistory);
            this.panel6.Controls.Add(this.PlayerID);
            this.panel6.Controls.Add(this.PlayerName);
            this.panel6.Controls.Add(this.playerPicture);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 237);
            this.panel6.TabIndex = 0;
            // 
            // PlayerHistory
            // 
            this.PlayerHistory.AutoSize = true;
            this.PlayerHistory.Font = new System.Drawing.Font("굴림", 10F);
            this.PlayerHistory.Location = new System.Drawing.Point(168, 205);
            this.PlayerHistory.Name = "PlayerHistory";
            this.PlayerHistory.Size = new System.Drawing.Size(49, 17);
            this.PlayerHistory.TabIndex = 7;
            this.PlayerHistory.Text = "label2";
            // 
            // PlayerID
            // 
            this.PlayerID.AutoSize = true;
            this.PlayerID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayerID.Font = new System.Drawing.Font("굴림", 10F);
            this.PlayerID.Location = new System.Drawing.Point(77, 220);
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.Size = new System.Drawing.Size(49, 17);
            this.PlayerID.TabIndex = 6;
            this.PlayerID.Text = "label2";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlayerName.Font = new System.Drawing.Font("굴림", 15F);
            this.PlayerName.Location = new System.Drawing.Point(0, 199);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(77, 25);
            this.PlayerName.TabIndex = 5;
            this.PlayerName.Text = "label1";
            // 
            // playerPicture
            // 
            this.playerPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerPicture.Location = new System.Drawing.Point(0, 0);
            this.playerPicture.Name = "playerPicture";
            this.playerPicture.Size = new System.Drawing.Size(341, 199);
            this.playerPicture.TabIndex = 4;
            this.playerPicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 677);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.RoomListBox);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(636, 623);
            this.panel5.TabIndex = 0;
            // 
            // RoomListBox
            // 
            this.RoomListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 15;
            this.RoomListBox.Location = new System.Drawing.Point(0, 0);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(636, 623);
            this.RoomListBox.TabIndex = 3;
            this.RoomListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RoomListBox_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.MakeRoomButton);
            this.panel4.Controls.Add(this.FindButton);
            this.panel4.Controls.Add(this.FindRoomLabel);
            this.panel4.Controls.Add(this.FindRoom);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 54);
            this.panel4.TabIndex = 0;
            // 
            // MakeRoomButton
            // 
            this.MakeRoomButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MakeRoomButton.Location = new System.Drawing.Point(0, 0);
            this.MakeRoomButton.Name = "MakeRoomButton";
            this.MakeRoomButton.Size = new System.Drawing.Size(104, 54);
            this.MakeRoomButton.TabIndex = 7;
            this.MakeRoomButton.Text = "방만들기";
            this.MakeRoomButton.UseVisualStyleBackColor = true;
            this.MakeRoomButton.Click += new System.EventHandler(this.FindRoomButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FindButton.Location = new System.Drawing.Point(524, 0);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(112, 54);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "찾기";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindRoomButton_Click);
            // 
            // FindRoomLabel
            // 
            this.FindRoomLabel.AutoSize = true;
            this.FindRoomLabel.Font = new System.Drawing.Font("굴림", 16F);
            this.FindRoomLabel.Location = new System.Drawing.Point(3, 21);
            this.FindRoomLabel.Name = "FindRoomLabel";
            this.FindRoomLabel.Size = new System.Drawing.Size(102, 27);
            this.FindRoomLabel.TabIndex = 1;
            this.FindRoomLabel.Text = "방 이름";
            // 
            // FindRoom
            // 
            this.FindRoom.Font = new System.Drawing.Font("굴림", 14F);
            this.FindRoom.Location = new System.Drawing.Point(105, 14);
            this.FindRoom.Name = "FindRoom";
            this.FindRoom.Size = new System.Drawing.Size(420, 34);
            this.FindRoom.TabIndex = 0;
            // 
            // RefreshRoomList
            // 
            this.RefreshRoomList.Tick += new System.EventHandler(this.RefreshRoomList_Tick);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 677);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Lobby";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FindRoomLabel;
        private System.Windows.Forms.TextBox FindRoom;
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Messagebox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox SendMessageBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button FriendAddButton;
        private System.Windows.Forms.TextBox SendFriendBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListBox FriendListBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label PlayerID;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.PictureBox playerPicture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button MakeRoomButton;
        private System.Windows.Forms.Label PlayerHistory;
        private System.Windows.Forms.Timer RefreshRoomList;
    }
}