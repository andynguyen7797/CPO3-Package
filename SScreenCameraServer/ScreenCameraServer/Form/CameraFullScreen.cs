using System.Drawing;
using System.Windows.Forms;

namespace ScreenCameraServer
{
    public partial class CameraFullScreen : Form
    {
        private int Toggle, MalX, MalY;
        private bool isMaxisize = true;

        public CameraFullScreen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public void GetScreenCapture(Image imageCapture)
        {
            cameraView.BackgroundImage = imageCapture;
        }

        private void minimine_btt_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btt_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }

        private void maxisize_Click(object sender, System.EventArgs e)
        {
            if(isMaxisize == true)
            {
                this.WindowState = FormWindowState.Normal;
                isMaxisize = false;
            } else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaxisize = true;
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Toggle = 1;
            MalX = e.X;
            MalY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }
    }
}
