using System.Windows.Forms;

namespace ScreenCameraServer
{
    public partial class LoginForm : Form
    {
        private NetworkManager network;
        private int Toggle, MalX, MalY;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void startServer_Click(object sender, System.EventArgs e)
        {
            network = new NetworkManager();
            if (network.CheckAndSetIpv4AndPort(ipv4_tb.Text, port_tb.Text))
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Xem lại định dạng nhập vào \n Xem IPV4 trong cmd \n Port là số nguyên dương < 10000");
            }
        }

        #region Move Form

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Toggle = 1;
            MalX = e.X;
            MalY = e.Y;
        }
        #endregion
    }
}
