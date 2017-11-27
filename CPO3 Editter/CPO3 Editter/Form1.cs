using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
namespace CPO3_Editter
{
    public partial class Form1 : Form
    {
        private int MalX, MalY, Toggle;
        private bool miniForm = false;
        private Receive_Manager receive;

        enum NORMAL
        {
            FORM_WIDTH = 465,
            CLOSE_X = 437,
            CLOSE_Y = 1,
            MINISIZE_X = 408,
            MINISIZE_Y = 1,
            MINIFORM_X = 379,
            MINIFORM_Y = 1
        }

        enum MINIFORM
        {
            FORM_WIDTH = 198,
            CLOSE_X = 171,
            CLOSE_Y = 1,
            MINISIZE_X = 142,
            MINISIZE_Y = 1,
            MINIFORM_X = 113,
            MINIFORM_Y = 1
        }
     
        #region Init
        public Form1()
        {        
            InitializeComponent();            
            Create_Receiver_Info();
            Create_Client_Thr();
            player_Status.tryConnectPanel.SendToBack();
        }

        private void Create_Client_Thr()
        {
            Thread receive_thr = new Thread(() =>
            {
                receive.Receiver();
            });

            receive_thr.Start();
        }

        private void Create_Receiver_Info()
        {
            List<enemy> enemy_list = new List<enemy>();

            //set into list
            enemy_list.Add(enemy1);
            enemy_list.Add(enemy2);
            enemy_list.Add(enemy3);
            enemy_list.Add(enemy4);

            receive = new Receive_Manager(player_Status,enemy_list);
        }
        #endregion

        #region Events
        private void close_btt_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát ?","CPO3 Exit",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Environment.Exit(0);
                Application.Exit();
            }
        }

        private void minimine_btt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Move Form
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

        private void miniForm_btt_Click(object sender, EventArgs e)
        {
            if(miniForm == true)
            {
                miniForm = false;

                // set new location
                this.Width = (int)NORMAL.FORM_WIDTH;
                close_btt.Location = new System.Drawing.Point((int)NORMAL.CLOSE_X, (int)NORMAL.CLOSE_Y);
                minimine_btt.Location = new System.Drawing.Point((int)NORMAL.MINISIZE_X, (int)NORMAL.MINISIZE_Y);
                miniForm_btt.Location = new System.Drawing.Point((int)NORMAL.MINIFORM_X, (int)NORMAL.MINIFORM_Y);

                // renew name of software
                nameOfSoftware.Text = "CPO3 Editter";
            } else
            {
                miniForm = true;

                // set new location
                this.Width = (int)MINIFORM.FORM_WIDTH;
                close_btt.Location = new System.Drawing.Point((int)MINIFORM.CLOSE_X, (int)MINIFORM.CLOSE_Y);
                minimine_btt.Location = new System.Drawing.Point((int)MINIFORM.MINISIZE_X, (int)MINIFORM.MINISIZE_Y);
                miniForm_btt.Location = new System.Drawing.Point((int)MINIFORM.MINIFORM_X, (int)MINIFORM.MINIFORM_Y);

                // renew name of software
                nameOfSoftware.Text = "Editter";
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }
        #endregion

        #region HotKey


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Home))
            {
                player_Status.SendAnswer();
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                player_Status.SendAlarm();
            }
        }


        #endregion
    }
}
