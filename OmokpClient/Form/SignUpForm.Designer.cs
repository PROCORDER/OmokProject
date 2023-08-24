
namespace OmokClient
{
    partial class SignUpForm
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
            this.SignUpNameBox = new System.Windows.Forms.TextBox();
            this.SignUpIDBox = new System.Windows.Forms.TextBox();
            this.SignUpPWBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MoveLogin = new System.Windows.Forms.Button();
            this.SingUpButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpNameBox
            // 
            this.SignUpNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpNameBox.Location = new System.Drawing.Point(136, 60);
            this.SignUpNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignUpNameBox.MaxLength = 15;
            this.SignUpNameBox.Name = "SignUpNameBox";
            this.SignUpNameBox.Size = new System.Drawing.Size(246, 25);
            this.SignUpNameBox.TabIndex = 0;
            this.SignUpNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateTextBoxInputKeyDown);
            this.SignUpNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTextBoxInputKeyPress);
            // 
            // SignUpIDBox
            // 
            this.SignUpIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpIDBox.Location = new System.Drawing.Point(136, 140);
            this.SignUpIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignUpIDBox.MaxLength = 15;
            this.SignUpIDBox.Name = "SignUpIDBox";
            this.SignUpIDBox.Size = new System.Drawing.Size(246, 25);
            this.SignUpIDBox.TabIndex = 2;
            this.SignUpIDBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateTextBoxInputKeyDown);
            this.SignUpIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTextBoxInputKeyPress);
            // 
            // SignUpPWBox
            // 
            this.SignUpPWBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpPWBox.Location = new System.Drawing.Point(136, 226);
            this.SignUpPWBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignUpPWBox.MaxLength = 15;
            this.SignUpPWBox.Name = "SignUpPWBox";
            this.SignUpPWBox.Size = new System.Drawing.Size(246, 25);
            this.SignUpPWBox.TabIndex = 3;
            this.SignUpPWBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidateTextBoxInputKeyDown);
            this.SignUpPWBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTextBoxInputKeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "PW";
            // 
            // MoveLogin
            // 
            this.MoveLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveLogin.Location = new System.Drawing.Point(14, 4);
            this.MoveLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoveLogin.Name = "MoveLogin";
            this.MoveLogin.Size = new System.Drawing.Size(86, 40);
            this.MoveLogin.TabIndex = 7;
            this.MoveLogin.Text = "<< Login";
            this.MoveLogin.UseVisualStyleBackColor = true;
            this.MoveLogin.Click += new System.EventHandler(this.MoveLogin_Click);
            // 
            // SingUpButton
            // 
            this.SingUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SingUpButton.Location = new System.Drawing.Point(174, 293);
            this.SingUpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SingUpButton.Name = "SingUpButton";
            this.SingUpButton.Size = new System.Drawing.Size(119, 30);
            this.SingUpButton.TabIndex = 8;
            this.SingUpButton.Text = "Sign Up";
            this.SingUpButton.UseVisualStyleBackColor = true;
            this.SingUpButton.Click += new System.EventHandler(this.SingUpButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 7F);
            this.label4.Location = new System.Drawing.Point(145, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "영어와 숫자만 입력이 가능합니다.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 7F);
            this.label5.Location = new System.Drawing.Point(145, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "영어와 숫자만 입력이 가능합니다.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 7F);
            this.label6.Location = new System.Drawing.Point(145, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "영어와 숫자만 입력이 가능합니다.";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 356);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SingUpButton);
            this.Controls.Add(this.MoveLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpPWBox);
            this.Controls.Add(this.SignUpIDBox);
            this.Controls.Add(this.SignUpNameBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignUpForm";
            this.Text = "SignUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUpFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SignUpNameBox;
        private System.Windows.Forms.TextBox SignUpIDBox;
        private System.Windows.Forms.TextBox SignUpPWBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MoveLogin;
        private System.Windows.Forms.Button SingUpButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}