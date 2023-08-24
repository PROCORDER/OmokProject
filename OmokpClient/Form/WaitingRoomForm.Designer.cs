
namespace OmokClient
{
    partial class WaitingRoomForm
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
            this.FriendListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.FriendAdd = new System.Windows.Forms.Button();
            this.sendFriendBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Messagebutton = new System.Windows.Forms.Button();
            this.SendMessageBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.Messagebox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Observer3 = new System.Windows.Forms.TextBox();
            this.Observer2 = new System.Windows.Forms.TextBox();
            this.Observer1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PlayerHistory = new System.Windows.Forms.Label();
            this.PlayerId = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.HostHistory = new System.Windows.Forms.Label();
            this.HostId = new System.Windows.Forms.Label();
            this.HostName = new System.Windows.Forms.Label();
            this.HostPictureBox = new System.Windows.Forms.PictureBox();
            this.playGuest = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FriendListBox);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(938, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 548);
            this.panel1.TabIndex = 0;
            // 
            // FriendListBox
            // 
            this.FriendListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.FriendListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FriendListBox.FormattingEnabled = true;
            this.FriendListBox.ItemHeight = 15;
            this.FriendListBox.Location = new System.Drawing.Point(0, 0);
            this.FriendListBox.Name = "FriendListBox";
            this.FriendListBox.Size = new System.Drawing.Size(262, 517);
            this.FriendListBox.TabIndex = 2;
            this.FriendListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FriendListBox_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.FriendAdd);
            this.panel9.Controls.Add(this.sendFriendBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 517);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(262, 31);
            this.panel9.TabIndex = 0;
            // 
            // FriendAdd
            // 
            this.FriendAdd.Location = new System.Drawing.Point(171, 0);
            this.FriendAdd.Name = "FriendAdd";
            this.FriendAdd.Size = new System.Drawing.Size(91, 31);
            this.FriendAdd.TabIndex = 1;
            this.FriendAdd.Text = "추가";
            this.FriendAdd.UseVisualStyleBackColor = true;
            this.FriendAdd.Click += new System.EventHandler(this.FriendAdd_Click);
            // 
            // sendFriendBox
            // 
            this.sendFriendBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.sendFriendBox.Location = new System.Drawing.Point(0, 0);
            this.sendFriendBox.Multiline = true;
            this.sendFriendBox.Name = "sendFriendBox";
            this.sendFriendBox.Size = new System.Drawing.Size(176, 31);
            this.sendFriendBox.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Messagebutton);
            this.panel7.Controls.Add(this.SendMessageBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 517);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(938, 100);
            this.panel7.TabIndex = 8;
            // 
            // Messagebutton
            // 
            this.Messagebutton.Location = new System.Drawing.Point(851, 0);
            this.Messagebutton.Name = "Messagebutton";
            this.Messagebutton.Size = new System.Drawing.Size(93, 31);
            this.Messagebutton.TabIndex = 1;
            this.Messagebutton.Text = "Message";
            this.Messagebutton.UseVisualStyleBackColor = true;
            this.Messagebutton.Click += new System.EventHandler(this.Messagebutton_Click);
            // 
            // SendMessageBox
            // 
            this.SendMessageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SendMessageBox.Font = new System.Drawing.Font("굴림", 12F);
            this.SendMessageBox.Location = new System.Drawing.Point(0, 0);
            this.SendMessageBox.Name = "SendMessageBox";
            this.SendMessageBox.Size = new System.Drawing.Size(852, 30);
            this.SendMessageBox.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StartButton);
            this.panel6.Controls.Add(this.Messagebox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 264);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(938, 253);
            this.panel6.TabIndex = 7;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("굴림", 20F);
            this.StartButton.Location = new System.Drawing.Point(831, 0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(107, 64);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "시작";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // Messagebox
            // 
            this.Messagebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Messagebox.Font = new System.Drawing.Font("굴림", 12F);
            this.Messagebox.Location = new System.Drawing.Point(0, 0);
            this.Messagebox.Multiline = true;
            this.Messagebox.Name = "Messagebox";
            this.Messagebox.Size = new System.Drawing.Size(938, 253);
            this.Messagebox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 264);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.playGuest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 264);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Observer3);
            this.panel5.Controls.Add(this.Observer2);
            this.panel5.Controls.Add(this.Observer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(584, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 264);
            this.panel5.TabIndex = 4;
            // 
            // Observer3
            // 
            this.Observer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Observer3.Location = new System.Drawing.Point(0, 176);
            this.Observer3.Multiline = true;
            this.Observer3.Name = "Observer3";
            this.Observer3.Size = new System.Drawing.Size(354, 88);
            this.Observer3.TabIndex = 2;
            // 
            // Observer2
            // 
            this.Observer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Observer2.Location = new System.Drawing.Point(0, 88);
            this.Observer2.Multiline = true;
            this.Observer2.Name = "Observer2";
            this.Observer2.Size = new System.Drawing.Size(354, 88);
            this.Observer2.TabIndex = 1;
            // 
            // Observer1
            // 
            this.Observer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Observer1.Location = new System.Drawing.Point(0, 0);
            this.Observer1.Multiline = true;
            this.Observer1.Name = "Observer1";
            this.Observer1.Size = new System.Drawing.Size(354, 88);
            this.Observer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PlayerHistory);
            this.panel4.Controls.Add(this.PlayerId);
            this.panel4.Controls.Add(this.PlayerName);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(292, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 264);
            this.panel4.TabIndex = 3;
            // 
            // PlayerHistory
            // 
            this.PlayerHistory.AutoSize = true;
            this.PlayerHistory.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHistory.Font = new System.Drawing.Font("굴림", 13F);
            this.PlayerHistory.Location = new System.Drawing.Point(224, 236);
            this.PlayerHistory.Name = "PlayerHistory";
            this.PlayerHistory.Size = new System.Drawing.Size(62, 22);
            this.PlayerHistory.TabIndex = 7;
            this.PlayerHistory.Text = "label4";
            // 
            // PlayerId
            // 
            this.PlayerId.AutoSize = true;
            this.PlayerId.BackColor = System.Drawing.Color.Transparent;
            this.PlayerId.Font = new System.Drawing.Font("굴림", 10F);
            this.PlayerId.Location = new System.Drawing.Point(162, 247);
            this.PlayerId.Name = "PlayerId";
            this.PlayerId.Size = new System.Drawing.Size(64, 17);
            this.PlayerId.TabIndex = 6;
            this.PlayerId.Text = "PlayerId";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.PlayerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.PlayerName.Location = new System.Drawing.Point(0, 230);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(156, 25);
            this.PlayerName.TabIndex = 5;
            this.PlayerName.Text = "PlayerName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 230);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.HostHistory);
            this.panel8.Controls.Add(this.HostId);
            this.panel8.Controls.Add(this.HostName);
            this.panel8.Controls.Add(this.HostPictureBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(292, 264);
            this.panel8.TabIndex = 2;
            // 
            // HostHistory
            // 
            this.HostHistory.AutoSize = true;
            this.HostHistory.BackColor = System.Drawing.Color.Transparent;
            this.HostHistory.Font = new System.Drawing.Font("굴림", 13F);
            this.HostHistory.Location = new System.Drawing.Point(181, 236);
            this.HostHistory.Name = "HostHistory";
            this.HostHistory.Size = new System.Drawing.Size(62, 22);
            this.HostHistory.TabIndex = 4;
            this.HostHistory.Text = "label2";
            // 
            // HostId
            // 
            this.HostId.AutoSize = true;
            this.HostId.BackColor = System.Drawing.Color.Transparent;
            this.HostId.Font = new System.Drawing.Font("굴림", 10F);
            this.HostId.Location = new System.Drawing.Point(89, 246);
            this.HostId.Name = "HostId";
            this.HostId.Size = new System.Drawing.Size(49, 17);
            this.HostId.TabIndex = 3;
            this.HostId.Text = "label2";
            // 
            // HostName
            // 
            this.HostName.AutoSize = true;
            this.HostName.BackColor = System.Drawing.Color.Transparent;
            this.HostName.Dock = System.Windows.Forms.DockStyle.Top;
            this.HostName.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.HostName.Location = new System.Drawing.Point(0, 230);
            this.HostName.Name = "HostName";
            this.HostName.Size = new System.Drawing.Size(83, 25);
            this.HostName.TabIndex = 2;
            this.HostName.Text = "label1";
            // 
            // HostPictureBox
            // 
            this.HostPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HostPictureBox.Location = new System.Drawing.Point(0, 0);
            this.HostPictureBox.Name = "HostPictureBox";
            this.HostPictureBox.Size = new System.Drawing.Size(292, 230);
            this.HostPictureBox.TabIndex = 0;
            this.HostPictureBox.TabStop = false;
            // 
            // playGuest
            // 
            this.playGuest.Dock = System.Windows.Forms.DockStyle.Left;
            this.playGuest.Location = new System.Drawing.Point(0, 0);
            this.playGuest.Name = "playGuest";
            this.playGuest.Size = new System.Drawing.Size(0, 264);
            this.playGuest.TabIndex = 1;
            this.playGuest.TabStop = false;
            // 
            // WaitingRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 548);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WaitingRoomForm";
            this.Text = "InRoomForm";
            this.Load += new System.EventHandler(this.WaitingRoomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Messagebutton;
        private System.Windows.Forms.TextBox SendMessageBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Messagebox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Observer3;
        private System.Windows.Forms.TextBox Observer2;
        private System.Windows.Forms.TextBox Observer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label PlayerHistory;
        private System.Windows.Forms.Label PlayerId;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label HostHistory;
        private System.Windows.Forms.Label HostId;
        private System.Windows.Forms.Label HostName;
        private System.Windows.Forms.PictureBox HostPictureBox;
        private System.Windows.Forms.PictureBox playGuest;
        private System.Windows.Forms.ListBox FriendListBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button FriendAdd;
        private System.Windows.Forms.TextBox sendFriendBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button StartButton;
    }
}