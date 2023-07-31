
namespace OmokClient
{
    partial class PlayGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGameForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Omok = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.GuestHistory = new System.Windows.Forms.Label();
            this.GuestName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.HostHistroy = new System.Windows.Forms.Label();
            this.HostName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.MessagesendButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Omok)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Omok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 803);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Omok
            // 
            this.Omok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Omok.Image = ((System.Drawing.Image)(resources.GetObject("Omok.Image")));
            this.Omok.Location = new System.Drawing.Point(0, 0);
            this.Omok.Name = "Omok";
            this.Omok.Size = new System.Drawing.Size(803, 803);
            this.Omok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Omok.TabIndex = 0;
            this.Omok.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(803, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 803);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.MessagesendButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 762);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 41);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 762);
            this.panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.GuestHistory);
            this.panel8.Controls.Add(this.GuestName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 100);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(325, 100);
            this.panel8.TabIndex = 1;
            // 
            // GuestHistory
            // 
            this.GuestHistory.AutoSize = true;
            this.GuestHistory.Location = new System.Drawing.Point(209, 82);
            this.GuestHistory.Name = "GuestHistory";
            this.GuestHistory.Size = new System.Drawing.Size(45, 15);
            this.GuestHistory.TabIndex = 3;
            this.GuestHistory.Text = "label2";
            // 
            // GuestName
            // 
            this.GuestName.AutoSize = true;
            this.GuestName.Font = new System.Drawing.Font("굴림", 20F);
            this.GuestName.Location = new System.Drawing.Point(6, 20);
            this.GuestName.Name = "GuestName";
            this.GuestName.Size = new System.Drawing.Size(110, 34);
            this.GuestName.TabIndex = 1;
            this.GuestName.Text = "label2";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.HostHistroy);
            this.panel7.Controls.Add(this.HostName);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 100);
            this.panel7.TabIndex = 0;
            // 
            // HostHistroy
            // 
            this.HostHistroy.AutoSize = true;
            this.HostHistroy.Location = new System.Drawing.Point(209, 82);
            this.HostHistroy.Name = "HostHistroy";
            this.HostHistroy.Size = new System.Drawing.Size(45, 15);
            this.HostHistroy.TabIndex = 2;
            this.HostHistroy.Text = "label1";
            // 
            // HostName
            // 
            this.HostName.AutoSize = true;
            this.HostName.Font = new System.Drawing.Font("굴림", 20F);
            this.HostName.Location = new System.Drawing.Point(6, 24);
            this.HostName.Name = "HostName";
            this.HostName.Size = new System.Drawing.Size(110, 34);
            this.HostName.TabIndex = 0;
            this.HostName.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(325, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(129, 279);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(325, 279);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 227);
            this.panel6.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(325, 506);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(129, 256);
            this.panel9.TabIndex = 4;
            // 
            // MessagesendButton
            // 
            this.MessagesendButton.Location = new System.Drawing.Point(379, 9);
            this.MessagesendButton.Name = "MessagesendButton";
            this.MessagesendButton.Size = new System.Drawing.Size(75, 23);
            this.MessagesendButton.TabIndex = 2;
            this.MessagesendButton.Text = "보내기";
            this.MessagesendButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 562);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 16F);
            this.textBox2.Location = new System.Drawing.Point(0, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(373, 38);
            this.textBox2.TabIndex = 3;
            // 
            // PlayGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlayGameForm";
            this.Text = "PlayGameForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Omok)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Omok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label GuestHistory;
        private System.Windows.Forms.Label GuestName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label HostHistroy;
        private System.Windows.Forms.Label HostName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button MessagesendButton;
    }
}