using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public class Send_Manager : NetWork_Manager
    {
        #region Properties
        private TcpClient client;
        public TcpClient Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }
        private Player_Control player;
        public Player_Control Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }
        private Player_Manager player_manager;
        private byte isLock = 0;
        private byte isLock_Edit = 3;
        #endregion

        /*INIT*/

        public Send_Manager(TcpClient client, Player_Control player)
        {
            this.Client = client;
            this.Player = player;
          
            Create_Event_For_Send_Manager();

            Send_Player_InFo();
            Send_Screen_Properties();

            player_manager = new Player_Manager(null);
        }

        private void Create_Event_For_Send_Manager()
        {          
            Player.SetEventToPlusBtt(Send_Score_Click, true);
            Player.SetEventToDecBtt(Send_Score_Click, true);
            Player.SetEventToAddCustomBtt(Send_Score_Click, true);
            Player.SetEventToLockEditBtt(Send_Lock_Edit_to_Client, true);
            Player.SetEventToLockControlBtt(Send_Lock_to_Client, true);
        }

        /*SEND LOCK SIGN*/

        public void Send_Lock_to_Client(object sender, EventArgs e)
        {
            if (Client == null)
            {
                MessageBox.Show("Lỗi khóa máy thí sinh, vui lòng restart lại chương trình");
                return;
            } // kiểm tra xem đã có client chưa, nếu chưa thì out ra

            // 0 là mở khóa, 1 là khóa
            var writer = new StreamWriter(Client.GetStream());
            writer.AutoFlush = true;
            writer.WriteLine(isLock.ToString());

            // đổi lock để lần nhấn tiếp theo sẽ mở khóa
            ChangeLock();
        }

        private void ChangeLock()
        {
            if (isLock == 0)
            {
                isLock = 1;
                Player.IsLock = 1;
                Player.SetBackClrToChecked(Cons.LOCKED, "LockButton");
            } else
            {
                isLock = 0;
                Player.IsLock = 0;
                Player.SetBackClrToChecked(Cons.UNLOCKED, "LockButton");
            }
        }

        /*SEND LOCK EDIT SIGN*/

        public void Send_Lock_Edit_to_Client(object sender, EventArgs e)
        {
            if (Client == null)
            {
                MessageBox.Show("Lỗi khóa máy thí sinh, vui lòng restart lại chương trình");
                return;
            } // kiểm tra xem đã có client chưa, nếu chưa thì out ra

            // 0 là mở khóa, 1 là khóa
            var writer = new StreamWriter(Client.GetStream());
            writer.AutoFlush = true;
            writer.WriteLine(isLock_Edit.ToString());

            // đổi lock để lần nhấn tiếp theo sẽ mở khóa
            Change_Lock_Edit();
        }

        private void Change_Lock_Edit()
        {
            if (isLock_Edit == 3)
            {
                isLock_Edit = 4;
                Player.IsLockEdit = 1;
                Player.SetBackClrToChecked(Cons.LOCKED, "LockEditButton");
            }
            else
            {
                isLock_Edit = 3;
                Player.IsLockEdit = 0;
                Player.SetBackClrToChecked(Cons.UNLOCKED, "LockEditButton");
            }
        }

        /* SEND SCORE */

        public void Send_Score_Click(object sender, EventArgs e)
        {
            if (!Client.Connected)
            {
                MessageBox.Show("Lỗi cập nhật điểm thí sinh, vui lòng restart lại chương trình");
                return;
            } // kiểm tra xem đã có client chưa, nếu chưa thì out ra

            var writer = new StreamWriter(Client.GetStream());
            writer.AutoFlush = true;
            writer.WriteLine("*" + Player.score_lb.Text + "*" + Player.name_lb.Text);
        }
    
        /*SEND PLAYER INFOMATION : name,score*/

        private void Send_Player_InFo() {
            Thread SendPlayerInfoThr = new Thread(() => {

                var writer = new StreamWriter(Client.GetStream());
                writer.AutoFlush = true;
                string data_packet;
                while (true)
                {
                    try
                    {
                        data_packet = player_manager.Get_Main_Info();
                        writer.WriteLine(data_packet);
                    }
                    catch
                    {
                        continue;
                    }
                    Thread.Sleep(500);
                }

            });
            SendPlayerInfoThr.Start();
        }

        /*SEND SCREEN PROPERTIES : font,screen color*/

        private void Send_Screen_Properties()
        {
            Thread sendScreenProperty = new Thread(() => {
                var writer = new StreamWriter(Client.GetStream());
                writer.AutoFlush = true;
                string data_packet;
                while (true)
                {
                    try
                    {
                        data_packet = Convert.ToBase64String(Set_Screen_Properties.Data_arr);
                        if (data_packet.Length != 0)
                        {
                            data_packet += "/";
                            writer.WriteLine(data_packet);
                        }
                    }
                    catch
                    {
                        continue;
                    }
                    Thread.Sleep(500);
                }
            });
            sendScreenProperty.Start();
        }

        /// <summary>
        /// Khi client out ra, sự kiện của client cũ vẫn bị giữ lại theo toán tử += nên cần phải trừ nó đi cho lần sau
        /// </summary>
        public void Delete_Event_Of_Old_Client()
        {
            //Player.plus_btt.Click += Send_Score_Click;
            Player.SetEventToPlusBtt(Send_Score_Click, false);
            // Player.dec_btt.Click += Send_Score_Click;
            Player.SetEventToDecBtt(Send_Score_Click, false);
            // Player.add_custom_btt.Click += Send_Score_Click;
            Player.SetEventToAddCustomBtt(Send_Score_Click, false);
            Player.SetEventToLockEditBtt(Send_Lock_Edit_to_Client, false);
            Player.SetEventToLockControlBtt(Send_Lock_to_Client, false);
        }
     }
}
