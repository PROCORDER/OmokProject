
namespace OmokClient
{
    partial class InRoomForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Observer2Move = new System.Windows.Forms.Button();
            this.Observer1Move = new System.Windows.Forms.Button();
            this.Observer3 = new System.Windows.Forms.TextBox();
            this.Observer2 = new System.Windows.Forms.TextBox();
            this.Observer1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PlayGuestMove = new System.Windows.Forms.Button();
            this.GuestHistory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HostHistory = new System.Windows.Forms.Label();
            this.HostID = new System.Windows.Forms.Label();
            this.HostName = new System.Windows.Forms.Label();
            this.HostPictureBox = new System.Windows.Forms.PictureBox();
            this.playGuest = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Messagebox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Messagebutton = new System.Windows.Forms.Button();
            this.SendMessageBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGuest)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 264);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.playGuest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 264);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.Observer2Move);
            this.panel5.Controls.Add(this.Observer1Move);
            this.panel5.Controls.Add(this.Observer3);
            this.panel5.Controls.Add(this.Observer2);
            this.panel5.Controls.Add(this.Observer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(584, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 264);
            this.panel5.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "이동";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Observer2Move
            // 
            this.Observer2Move.Location = new System.Drawing.Point(266, 87);
            this.Observer2Move.Name = "Observer2Move";
            this.Observer2Move.Size = new System.Drawing.Size(75, 23);
            this.Observer2Move.TabIndex = 5;
            this.Observer2Move.Text = "이동";
            this.Observer2Move.UseVisualStyleBackColor = true;
            // 
            // Observer1Move
            // 
            this.Observer1Move.Location = new System.Drawing.Point(266, 0);
            this.Observer1Move.Name = "Observer1Move";
            this.Observer1Move.Size = new System.Drawing.Size(75, 23);
            this.Observer1Move.TabIndex = 4;
            this.Observer1Move.Text = "이동";
            this.Observer1Move.UseVisualStyleBackColor = true;
            // 
            // Observer3
            // 
            this.Observer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Observer3.Location = new System.Drawing.Point(0, 176);
            this.Observer3.Multiline = true;
            this.Observer3.Name = "Observer3";
            this.Observer3.Size = new System.Drawing.Size(341, 88);
            this.Observer3.TabIndex = 2;
            // 
            // Observer2
            // 
            this.Observer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Observer2.Location = new System.Drawing.Point(0, 88);
            this.Observer2.Multiline = true;
            this.Observer2.Name = "Observer2";
            this.Observer2.Size = new System.Drawing.Size(341, 88);
            this.Observer2.TabIndex = 1;
            // 
            // Observer1
            // 
            this.Observer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Observer1.Location = new System.Drawing.Point(0, 0);
            this.Observer1.Multiline = true;
            this.Observer1.Name = "Observer1";
            this.Observer1.Size = new System.Drawing.Size(341, 88);
            this.Observer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PlayGuestMove);
            this.panel4.Controls.Add(this.GuestHistory);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(292, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 264);
            this.panel4.TabIndex = 3;
            // 
            // PlayGuestMove
            // 
            this.PlayGuestMove.Location = new System.Drawing.Point(217, 3);
            this.PlayGuestMove.Name = "PlayGuestMove";
            this.PlayGuestMove.Size = new System.Drawing.Size(75, 23);
            this.PlayGuestMove.TabIndex = 3;
            this.PlayGuestMove.Text = "이동";
            this.PlayGuestMove.UseVisualStyleBackColor = true;
            // 
            // GuestHistory
            // 
            this.GuestHistory.AutoSize = true;
            this.GuestHistory.Font = new System.Drawing.Font("굴림", 13F);
            this.GuestHistory.Location = new System.Drawing.Point(189, 236);
            this.GuestHistory.Name = "GuestHistory";
            this.GuestHistory.Size = new System.Drawing.Size(62, 22);
            this.GuestHistory.TabIndex = 7;
            this.GuestHistory.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(89, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.HostHistory);
            this.panel3.Controls.Add(this.HostID);
            this.panel3.Controls.Add(this.HostName);
            this.panel3.Controls.Add(this.HostPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 264);
            this.panel3.TabIndex = 2;
            // 
            // HostHistory
            // 
            this.HostHistory.AutoSize = true;
            this.HostHistory.Font = new System.Drawing.Font("굴림", 13F);
            this.HostHistory.Location = new System.Drawing.Point(181, 236);
            this.HostHistory.Name = "HostHistory";
            this.HostHistory.Size = new System.Drawing.Size(62, 22);
            this.HostHistory.TabIndex = 4;
            this.HostHistory.Text = "label2";
            // 
            // HostID
            // 
            this.HostID.AutoSize = true;
            this.HostID.Font = new System.Drawing.Font("굴림", 10F);
            this.HostID.Location = new System.Drawing.Point(89, 246);
            this.HostID.Name = "HostID";
            this.HostID.Size = new System.Drawing.Size(49, 17);
            this.HostID.TabIndex = 3;
            this.HostID.Text = "label2";
            // 
            // HostName
            // 
            this.HostName.AutoSize = true;
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
            this.playGuest.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Messagebox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 264);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(925, 253);
            this.panel6.TabIndex = 4;
            // 
            // Messagebox
            // 
            this.Messagebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Messagebox.Font = new System.Drawing.Font("굴림", 12F);
            this.Messagebox.Location = new System.Drawing.Point(0, 0);
            this.Messagebox.Multiline = true;
            this.Messagebox.Name = "Messagebox";
            this.Messagebox.Size = new System.Drawing.Size(925, 253);
            this.Messagebox.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Messagebutton);
            this.panel7.Controls.Add(this.SendMessageBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 517);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(925, 100);
            this.panel7.TabIndex = 5;
            // 
            // Messagebutton
            // 
            this.Messagebutton.Location = new System.Drawing.Point(850, 3);
            this.Messagebutton.Name = "Messagebutton";
            this.Messagebutton.Size = new System.Drawing.Size(72, 23);
            this.Messagebutton.TabIndex = 1;
            this.Messagebutton.Text = "button1";
            this.Messagebutton.UseVisualStyleBackColor = true;
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
            // InRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 548);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "InRoomForm";
            this.Text = "InRoomForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGuest)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox playGuest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox HostPictureBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Observer2Move;
        private System.Windows.Forms.Button Observer1Move;
        private System.Windows.Forms.TextBox Observer3;
        private System.Windows.Forms.TextBox Observer2;
        private System.Windows.Forms.TextBox Observer1;
        private System.Windows.Forms.Button PlayGuestMove;
        private System.Windows.Forms.Label GuestHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HostHistory;
        private System.Windows.Forms.Label HostID;
        private System.Windows.Forms.Label HostName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Messagebox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Messagebutton;
        private System.Windows.Forms.TextBox SendMessageBox;
    }
}