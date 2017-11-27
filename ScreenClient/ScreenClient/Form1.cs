using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ScreenClient
{
    public partial class Form1 : Form
    {
        #region Some Variable
        Client client;
        SendManager send;
        ReiceveManager receive;
        private int Toggle, MalX, MalY;
        #endregion

        public Form1()
        {
            InitializeComponent();
            GetScreenToList();
        }

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

        #region Events

        private void ok_btt_Click(object sender, EventArgs e)
        {
            client = new Client();
            send = new SendManager();
            receive = new ReiceveManager();
            bool result = client.SetClientProperty(ipv4_tb.Text, port_tb.Text,screenList.SelectedIndex, modeList.SelectedItem.ToString(),userIndexList.SelectedItem.ToString(), infomation_tb.Text);
            if(result == false)
            {
                MessageBox.Show("Xem lại định dạng ipv4 và port, port phải là số nguyên dương < 10000. Hãy chắc chắn bạn đã điền hết các ô trống");
            } else
            {
                client.CreateClient();
                send.StartSendImageCapture();
                receive.Receive();

                ShowAppinNotifyIcon();
            }
        }

        private void modeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear list
            userIndexList.Items.Clear();

            if(modeList.SelectedIndex == 0)
            {
                //USER
                userIndexList.Items.Add("1");
                userIndexList.Items.Add("2");
                userIndexList.Items.Add("3");
                userIndexList.Items.Add("4");
                userIndexList.SelectedIndex = 0;
                userIndexList.Enabled = true;
            }

            if(modeList.SelectedIndex == 1 || modeList.SelectedIndex == 2)
            {
                userIndexList.Items.Add("1");
                userIndexList.Items.Add("2");
                userIndexList.SelectedIndex = 0;
                userIndexList.Enabled = true;
            }
        }

        private void close_btt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
        #endregion

        #region Methods

        private void GetScreenToList()
        {
            List<string> screenListData = ScreenManager.DetectScreen();
            int count = screenListData.Count;

            for (int i = 0; i < count; i++)
            {
                screenList.Items.Add(screenListData[i]);
            }
        }

        private void ShowAppinNotifyIcon()
        {
            this.ShowInTaskbar = false;
            this.Hide();
            notifyIcon.ContextMenu = new ContextMenu();
            notifyIcon.ContextMenu.MenuItems.Add(0, new MenuItem("Exit",new EventHandler(close_btt_Click)));
            NotifyMessage notifyMess = new NotifyMessage(notifyIcon);
            NotifyMessage.showMessage("Screen Client is running", 0, 3000);
        }
        #endregion
    }
}
