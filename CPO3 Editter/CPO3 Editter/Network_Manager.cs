using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPO3_Editter
{
    public class Network_Manager
    {
        #region Const
        protected const int PORT_TRANSFER = 9000;
        protected const int BUFFER_SIZE = 1024;
        protected const int TIMEOUT = 60000; // 60s
        #endregion

        #region Properties
        private static TcpClient client;
        protected static TcpClient Client
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

        private static string ipv4;
        protected static string Ipv4
        {
            get
            {
                return ipv4;
            }

            set
            {
                ipv4 = value;
            }
        }

        private static string index;
        protected static string Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        #endregion

        //Create Client
        public bool Create_Client(string ipV4,string indexOfUser)
        {
            try
            {
                //create client
                IPEndPoint ip_endpoint_client = new IPEndPoint(IPAddress.Parse(ipV4), PORT_TRANSFER);
                Client = new TcpClient();
                Ipv4 = ipV4;
                Index = indexOfUser;
                //connect to server
                Client.Connect(ip_endpoint_client);
                MessageBox.Show("Kết nối đến server [" + ipV4 + "] thành công !","Thông báo");

                SendIndexOfUser();
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại : " + ex.Message,"Thông báo");
                return false;
            }
        }

        public void SendIndexOfUser()
        {
            StreamWriter sendIndex = new StreamWriter(Client.GetStream());
            sendIndex.AutoFlush = true;
            sendIndex.WriteLine("INDEX " + Index);
        }

        #region Try to connect
        public void BeginConnect(Player_Status player)
        {
                //show UI
                player.tryConnectPanel.BringToFront();

                // close client to create a new client
                Client.Close();
                Client = new System.Net.Sockets.TcpClient();
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(Ipv4), PORT_TRANSFER);

                int timeout = TIMEOUT;
                bool tryToconnect;

                while (true)
                {
                    if (timeout <= 0)
                    {
                        tryToconnect = false;
                        break;
                    }

                    try
                    {
                        Client.Connect(ipEndPoint);
                        tryToconnect = true;
                        break;
                    }
                    catch
                    {
                        timeout -= 1000;
                    }

                    // show time of timeout
                    player.timeOutlb.Text = (timeout / 1000).ToString() + "s";
                    Thread.Sleep(1000);
                }

                if (tryToconnect == true)
                {
                    SendIndexOfUser();
                    player.tryConnectPanel.SendToBack();
                    player.timeOutlb.Text = (TIMEOUT / 1000).ToString() + "s";
                }
                else
                {
                    MessageBox.Show("Có lẽ server đã thoát, vui lòng khởi động lại phần mềm ");

                    //Exit
                    Environment.Exit(0);
                    Application.Exit();
                }    
        }
        #endregion
    }
}
