using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScreenCameraServer
{
    public partial class Form1 : Form
    {
        NetworkManager Server;
        private int Toggle, MalX, MalY;

        public Form1()
        {
            InitializeComponent();
        }

        #region Events
        private void Form1_Shown(object sender, EventArgs e)
        {
            List<Camera> CameraList = new List<Camera>();
            Server = new NetworkManager();
            //CameraList = this.Controls.OfType<Camera>().ToList();

            CameraList.Add(camera1);
            CameraList.Add(camera2);
            CameraList.Add(camera3);
            CameraList.Add(camera4);

            CameraList.Add(camera5);
            CameraList.Add(camera6);

            CameraList.Add(camera7);
            CameraList.Add(camera8);

            Server.CreateServer(CameraList);
        }

        private void close_btt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void minimine_btt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Move Form
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }
        #endregion
    }
}
