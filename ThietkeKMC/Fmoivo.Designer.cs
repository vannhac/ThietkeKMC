namespace ThietkeKMC
{
    partial class Fmoivo
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
            panel3 = new Panel();
            ListBill = new ListView();
            panel5 = new Panel();
            btnChangetable = new Button();
            comboBox3 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnGiam = new Button();
            btnthtoan = new Button();
            panel6 = new Panel();
            Foodcount = new NumericUpDown();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            thôngTinNhânViênToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem1 = new ToolStripMenuItem();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Foodcount).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(ListBill);
            panel3.Location = new Point(540, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 212);
            panel3.TabIndex = 1;
            // 
            // ListBill
            // 
            ListBill.Location = new Point(4, 3);
            ListBill.Name = "ListBill";
            ListBill.Size = new Size(320, 209);
            ListBill.TabIndex = 0;
            ListBill.UseCompatibleStateImageBehavior = false;
            ListBill.SelectedIndexChanged += ListBill_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnChangetable);
            panel5.Controls.Add(comboBox3);
            panel5.Controls.Add(numericUpDown1);
            panel5.Controls.Add(btnGiam);
            panel5.Controls.Add(btnthtoan);
            panel5.Location = new Point(540, 326);
            panel5.Name = "panel5";
            panel5.Size = new Size(332, 63);
            panel5.TabIndex = 2;
            // 
            // btnChangetable
            // 
            btnChangetable.Location = new Point(4, 5);
            btnChangetable.Name = "btnChangetable";
            btnChangetable.Size = new Size(89, 27);
            btnChangetable.TabIndex = 7;
            btnChangetable.Text = "Chuyển bàn";
            btnChangetable.UseVisualStyleBackColor = true;
            btnChangetable.Click += btnChangetable_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(4, 38);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(89, 23);
            comboBox3.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(154, 37);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(94, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGiam
            // 
            btnGiam.Location = new Point(154, 5);
            btnGiam.Name = "btnGiam";
            btnGiam.Size = new Size(94, 27);
            btnGiam.TabIndex = 4;
            btnGiam.Text = "Giảm giá";
            btnGiam.UseVisualStyleBackColor = true;
            // 
            // btnthtoan
            // 
            btnthtoan.Location = new Point(254, 5);
            btnthtoan.Name = "btnthtoan";
            btnthtoan.Size = new Size(75, 55);
            btnthtoan.TabIndex = 3;
            btnthtoan.Text = "Thanh toán";
            btnthtoan.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(Foodcount);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(comboBox2);
            panel6.Controls.Add(comboBox1);
            panel6.Location = new Point(540, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(332, 101);
            panel6.TabIndex = 3;
            // 
            // Foodcount
            // 
            Foodcount.Location = new Point(235, 29);
            Foodcount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            Foodcount.Name = "Foodcount";
            Foodcount.Size = new Size(31, 23);
            Foodcount.TabIndex = 3;
            Foodcount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Foodcount.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(154, 15);
            button1.Name = "button1";
            button1.Size = new Size(75, 55);
            button1.TabIndex = 2;
            button1.Text = "Thêm món";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(4, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(144, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 23);
            comboBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(876, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinNhânViênToolStripMenuItem, đăngXuấtToolStripMenuItem, thôngTinToolStripMenuItem1 });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(70, 20);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            thôngTinNhânViênToolStripMenuItem.Size = new Size(180, 22);
            thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            thôngTinNhânViênToolStripMenuItem.Click += thôngTinNhânViênToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(180, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem1
            // 
            thôngTinToolStripMenuItem1.Name = "thôngTinToolStripMenuItem1";
            thôngTinToolStripMenuItem1.Size = new Size(180, 22);
            thôngTinToolStripMenuItem1.Text = "Thông tin";
            // 
            // Fmoivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 392);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Fmoivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý bán hàng";
            Load += Fmoivo_Load;
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Foodcount).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private ListView ListBill;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private NumericUpDown Foodcount;
        private Button btnGiam;
        private Button btnthtoan;
        private Button btnChangetable;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem1;
    }
}