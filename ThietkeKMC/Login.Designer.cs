namespace ThietkeKMC
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Btnexit = new Button();
            BtLogin = new Button();
            panel3 = new Panel();
            txboxPass = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbUsername = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Btnexit);
            panel1.Controls.Add(BtLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 151);
            panel1.TabIndex = 0;
            // 
            // Btnexit
            // 
            Btnexit.Location = new Point(322, 90);
            Btnexit.Name = "Btnexit";
            Btnexit.Size = new Size(75, 23);
            Btnexit.TabIndex = 5;
            Btnexit.Text = "Đăng Xuất";
            Btnexit.UseVisualStyleBackColor = true;
            Btnexit.Click += Btnexit_Click;
            // 
            // BtLogin
            // 
            BtLogin.Location = new Point(230, 90);
            BtLogin.Name = "BtLogin";
            BtLogin.Size = new Size(75, 23);
            BtLogin.TabIndex = 4;
            BtLogin.Text = "Đăng Nhập";
            BtLogin.UseVisualStyleBackColor = true;
            BtLogin.Click += BtLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txboxPass);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(2, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 35);
            panel3.TabIndex = 3;
            // 
            // txboxPass
            // 
            txboxPass.Location = new Point(137, 7);
            txboxPass.Name = "txboxPass";
            txboxPass.Size = new Size(250, 23);
            txboxPass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 35);
            panel2.TabIndex = 0;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(137, 7);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(250, 23);
            txbUsername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 1;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // Login
            // 
            AcceptButton = BtLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Btnexit;
            ClientSize = new Size(409, 151);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox txboxPass;
        private Label label2;
        private TextBox txbUsername;
        private Button button2;
        private Button button1;
        private Button btexit;
        private Button BtLogin;
        private Button Btnexit;
    }
}
