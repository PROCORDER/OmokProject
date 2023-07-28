
namespace OmokClient
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginPWBox = new System.Windows.Forms.TextBox();
            this.LoginIDLabel = new System.Windows.Forms.Label();
            this.LoginPWLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.Image = global::OmokClient.Properties.Resources.OmokLoginJpg;
            this.LoginPictureBox.Location = new System.Drawing.Point(12, 52);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(212, 169);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPictureBox.TabIndex = 0;
            this.LoginPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(287, 81);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(177, 21);
            this.LoginTextBox.TabIndex = 3;
            // 
            // LoginPWBox
            // 
            this.LoginPWBox.Location = new System.Drawing.Point(287, 171);
            this.LoginPWBox.Name = "LoginPWBox";
            this.LoginPWBox.Size = new System.Drawing.Size(177, 21);
            this.LoginPWBox.TabIndex = 4;
            // 
            // LoginIDLabel
            // 
            this.LoginIDLabel.AutoSize = true;
            this.LoginIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginIDLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoginIDLabel.Location = new System.Drawing.Point(254, 84);
            this.LoginIDLabel.Name = "LoginIDLabel";
            this.LoginIDLabel.Size = new System.Drawing.Size(25, 19);
            this.LoginIDLabel.TabIndex = 5;
            this.LoginIDLabel.Text = "ID";
            // 
            // LoginPWLabel
            // 
            this.LoginPWLabel.AutoSize = true;
            this.LoginPWLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPWLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginPWLabel.ForeColor = System.Drawing.Color.Coral;
            this.LoginPWLabel.Location = new System.Drawing.Point(247, 174);
            this.LoginPWLabel.Name = "LoginPWLabel";
            this.LoginPWLabel.Size = new System.Drawing.Size(37, 19);
            this.LoginPWLabel.TabIndex = 6;
            this.LoginPWLabel.Text = "PW";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(175)))), ((int)(((byte)(159)))));
            this.BackgroundImage = global::OmokClient.Properties.Resources.LoginBackgroundImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 276);
            this.Controls.Add(this.LoginPWLabel);
            this.Controls.Add(this.LoginIDLabel);
            this.Controls.Add(this.LoginPWBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "OmokGame";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox LoginPWBox;
        private System.Windows.Forms.Label LoginIDLabel;
        private System.Windows.Forms.Label LoginPWLabel;
    }
}

