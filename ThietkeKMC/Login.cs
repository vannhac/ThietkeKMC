using ThietkeKMC.Dungtruoc;

namespace ThietkeKMC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            string tk = txbUsername.Text;
            string mk = txboxPass.Text;
            if (Login1(tk,mk))
            {
                Fmoivo f = new Fmoivo();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản mật khẩu");
            }
        }
        bool Login1(string tk,string mk)
        {
            return ACcount.Instance.Login(tk,mk);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
