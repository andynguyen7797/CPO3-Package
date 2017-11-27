using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CPO3_Remaker
{
    public class NetWork_Manager
    {
        #region Const
        protected const int PORT_TRANSFER = 9000;
        #endregion

        #region Properties

        private static IPAddress ip_giaotiep;
        protected static IPAddress Ip_giaotiep
        {
            get
            {
                return ip_giaotiep;
            }

            set
            {
                ip_giaotiep = value;
            }
        }

        #endregion

        #region NetWork Methods
        public void Create_Server(List<Player_Control> list_player)
        {
            Thread serverThr = new Thread(() => {
                try
                {
                    IPEndPoint ip_endpoint_server = new IPEndPoint(Ip_giaotiep, PORT_TRANSFER);
                    TcpListener server = new TcpListener(ip_endpoint_server);
                    server.Start();
                    MessageBox.Show("Đang chờ client ...");
                    // mỗi client được accept thì lần lượt giao tiếp với player_control


                    while (true)
                    {
                        // chap nhan ket noi 
                        TcpClient client = server.AcceptTcpClient();
                        MessageBox.Show("Đã có 1 kết nối");
                        ClientActivity(client, list_player);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi trong việc kết nối, kiểm tra lại địa chỉ IP trong cmd : " + ex.Message);
                }
            });
            serverThr.Start();
        }

        public bool Save_IPV4(string ipV4)
        {
            try
            {
                Ip_giaotiep = IPAddress.Parse(ipV4);
                return true;

            } catch (Exception ex)
            {
                MessageBox.Show("IP không đúng định dạng ! : " + ex.Message);
                return false;
            }
        }

        private void ClientActivity(TcpClient client,List<Player_Control> list_player)
        {
            Thread clientThr = new Thread(() => {
                //tìm 1 vị trí trống cho client
                StreamReader readData = new StreamReader(client.GetStream());
                string indexOfUser = "";
                while (true)
                {
                    indexOfUser = readData.ReadLine();
                    if (indexOfUser.Contains("INDEX"))
                    {
                        indexOfUser = indexOfUser.Remove(0, 6);
                        break;
                    }
                }

                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    if (list_player[i].Tag == (object)"NULL" && indexOfUser == list_player[i].IndexOfUser)
                    {
                        // tạo luồng riêng cho client hiện hành
                        new Client_Thread(client, readData, list_player[i]);
                        list_player[i].Tag = "NO_NULL";
                        list_player[i].Enabled = true;
                        break;
                    }
                }
            });
            clientThr.Start();
        }
        #endregion

    }
}
