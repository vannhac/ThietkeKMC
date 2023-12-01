namespace ThietkeKMC
{
    partial class Thongtin
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
            panel2 = new Panel();
            txbUsername = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            textBox4 = new TextBox();
            label5 = new Label();
            btnCapnhat = new Button();
            btnout = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 35);
            panel2.TabIndex = 1;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(137, 7);
            txbUsername.Name = "txbUsername";
            txbUsername.ReadOnly = true;
            txbUsername.Size = new Size(305, 23);
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
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 35);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu:";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 35);
            panel3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 7);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 1;
            label3.Text = "Tên Hiển Thị:";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(475, 35);
            panel4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 23);
            textBox3.TabIndex = 2;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(120, 19);
            label4.TabIndex = 1;
            label4.Text = "Mật Khẩu mới:";
            label4.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 187);
            panel5.Name = "panel5";
            panel5.Size = new Size(475, 35);
            panel5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 7);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(305, 23);
            textBox4.TabIndex = 2;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 7);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 1;
            label5.Text = "Nhập Lại:";
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(269, 237);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(89, 27);
            btnCapnhat.TabIndex = 3;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += button1_Click;
            // 
            // btnout
            // 
            btnout.Location = new Point(364, 237);
            btnout.Name = "btnout";
            btnout.Size = new Size(89, 27);
            btnout.TabIndex = 5;
            btnout.Text = "Thoát";
            btnout.UseVisualStyleBackColor = true;
            btnout.Click += btnout_Click;
            // 
            // Thongtin
            // 
            AcceptButton = btnCapnhat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnout;
            ClientSize = new Size(466, 279);
            Controls.Add(btnout);
            Controls.Add(btnCapnhat);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Thongtin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            Load += Thongtincnhan_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUsername;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel3;
        private TextBox textBox2;
        private Label label3;
        private Panel panel4;
        private TextBox textBox3;
        private Label label4;
        private Panel panel5;
        private TextBox textBox4;
        private Label label5;
        private Button btnCapnhat;
        private Button btnout;
    }
}