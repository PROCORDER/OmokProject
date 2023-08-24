
namespace OmokClient
{
    partial class MakeRoomForm
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
            this.MakeRoomNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MakeRoomBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MakeRoomNameBox
            // 
            this.MakeRoomNameBox.Location = new System.Drawing.Point(114, 80);
            this.MakeRoomNameBox.Name = "MakeRoomNameBox";
            this.MakeRoomNameBox.Size = new System.Drawing.Size(278, 25);
            this.MakeRoomNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "방만들기";
            // 
            // MakeRoomBTN
            // 
            this.MakeRoomBTN.Location = new System.Drawing.Point(149, 138);
            this.MakeRoomBTN.Name = "MakeRoomBTN";
            this.MakeRoomBTN.Size = new System.Drawing.Size(123, 48);
            this.MakeRoomBTN.TabIndex = 2;
            this.MakeRoomBTN.Text = "방 만들기";
            this.MakeRoomBTN.UseVisualStyleBackColor = true;
            this.MakeRoomBTN.Click += new System.EventHandler(this.MakeRoomBTN_Click);
            // 
            // MakeRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 239);
            this.Controls.Add(this.MakeRoomBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MakeRoomNameBox);
            this.Name = "MakeRoomForm";
            this.Text = "MakeRoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MakeRoomNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MakeRoomBTN;
    }
}