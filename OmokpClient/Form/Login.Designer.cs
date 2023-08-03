
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
            this.SignupButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginIDTextBox = new System.Windows.Forms.TextBox();
            this.LoginPWBox = new System.Windows.Forms.TextBox();
            this.LoginIDLabel = new System.Windows.Forms.Label();
            this.LoginPWLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.Image = global::OmokClient.Properties.Resources.OmokLoginJpg;
            this.LoginPictureBox.Location = new System.Drawing.Point(14, 65);
            this.LoginPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(242, 211);
            this.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPictureBox.TabIndex = 0;
            this.LoginPictureBox.TabStop = false;
            // 
            // SignupButton
            // 
            this.SignupButton.Location = new System.Drawing.Point(293, 294);
            this.SignupButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(86, 29);
            this.SignupButton.TabIndex = 1;
            this.SignupButton.Text = "Sign up";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginButton.Location = new System.Drawing.Point(442, 294);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(86, 29);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginIDTextBox
            // 
            this.LoginIDTextBox.Location = new System.Drawing.Point(328, 101);
            this.LoginIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginIDTextBox.Name = "LoginIDTextBox";
            this.LoginIDTextBox.Size = new System.Drawing.Size(202, 25);
            this.LoginIDTextBox.TabIndex = 3;
            // 
            // LoginPWBox
            // 
            this.LoginPWBox.Location = new System.Drawing.Point(328, 214);
            this.LoginPWBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPWBox.Name = "LoginPWBox";
            this.LoginPWBox.Size = new System.Drawing.Size(202, 25);
            this.LoginPWBox.TabIndex = 4;
            // 
            // LoginIDLabel
            // 
            this.LoginIDLabel.AutoSize = true;
            this.LoginIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginIDLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoginIDLabel.Location = new System.Drawing.Point(290, 105);
            this.LoginIDLabel.Name = "LoginIDLabel";
            this.LoginIDLabel.Size = new System.Drawing.Size(31, 24);
            this.LoginIDLabel.TabIndex = 5;
            this.LoginIDLabel.Text = "ID";
            // 
            // LoginPWLabel
            // 
            this.LoginPWLabel.AutoSize = true;
            this.LoginPWLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPWLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginPWLabel.ForeColor = System.Drawing.Color.Coral;
            this.LoginPWLabel.Location = new System.Drawing.Point(282, 218);
            this.LoginPWLabel.Name = "LoginPWLabel";
            this.LoginPWLabel.Size = new System.Drawing.Size(47, 24);
            this.LoginPWLabel.TabIndex = 6;
            this.LoginPWLabel.Text = "PW";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(175)))), ((int)(((byte)(159)))));
            this.BackgroundImage = global::OmokClient.Properties.Resources.LoginBackgroundImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 345);
            this.Controls.Add(this.LoginPWLabel);
            this.Controls.Add(this.LoginIDLabel);
            this.Controls.Add(this.LoginPWBox);
            this.Controls.Add(this.LoginIDTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.LoginPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "OmokGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPictureBox;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox LoginIDTextBox;
        private System.Windows.Forms.TextBox LoginPWBox;
        private System.Windows.Forms.Label LoginIDLabel;
        private System.Windows.Forms.Label LoginPWLabel;
    }
}

