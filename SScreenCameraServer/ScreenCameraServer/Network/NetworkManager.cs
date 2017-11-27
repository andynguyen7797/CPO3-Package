using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScreenCameraServer
{
    public class NetworkManager
    {
        #region Properties
        private static IPAddress ipV4;
        protected static IPAddress IpV4
        {
            get
            {
                return ipV4;
            }

            set
            {
                ipV4 = value;
            }
        }
   
        private static int port;
        protected static int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

      //  private ASCIIEncoding encoding = new ASCIIEncoding();
        #endregion

        public void CreateServer(List<Camera> CameraList)
        {
            Thread ServerListening = new Thread(() => {
                try
                {
                    IPEndPoint ipEndPointServer = new IPEndPoint(IpV4, Port);
                    TcpListener server = new TcpListener(ipEndPointServer);
                    server.Start();

                    while (true)
                    {
                        //chap nhan ket noi
                        Socket client = server.AcceptSocket();
                        MessageBox.Show("Da co 1 ket noi");
                        Thread ClientListening = new Thread(() =>
                        {
                            // tìm 1 vị trí còn trống phù hợp
                            // headdata chứa <số thứ tự>/<Loại camera>/<Một số thông tin cơ bản>
                            string[] resultOfInfo = new string[3];
                            string data = "";
                            while (true)
                            {                            
                                byte[] head_data = new byte[Cons.BUFFER_SIZE];
                                client.Receive(head_data);
                                data = Encoding.Unicode.GetString(head_data);

                                if (data.Contains("HEADER"))
                                {
                                    resultOfInfo = NetworkMethod.UnserialzeHEADER(data);
                                    break;
                                    
                                }
                            }

                            for (int i = 0; i < Cons.CAMERA_COUNT; i++)
                            {
                                if (CameraList[i].Tag == (object)"NULL" && CameraList[i].IndexOfUser == resultOfInfo[0]
                                    && CameraList[i].Mode.ToString().ToUpper() == resultOfInfo[1])
                                {

                                    CameraList[i].SomeInfo = resultOfInfo[2];
                                    CameraList[i].Tag = "NO_NULL";
                                    CameraList[i].Enabled = true;
                                    // tạo luồng riêng cho client hiện hành
                                    new ClientThread(client, CameraList[i]);
                                    break;
                                }
                            }                       
                        });
                        ClientListening.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi trong việc kết nối, kiểm tra lại địa chỉ IP trong cmd : " + ex.Message);
                }
            });
            ServerListening.Start();        
        }

        public bool CheckAndSetIpv4AndPort(string ipV4,string PORT)
        {
            try
            {
                IpV4 = IPAddress.Parse(ipV4);
            }
            catch
            {
                return false;
            }

            try
            {
                Port = Convert.ToInt32(PORT);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
