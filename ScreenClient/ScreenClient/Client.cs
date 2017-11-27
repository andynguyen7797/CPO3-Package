using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ScreenClient
{
    public class Client
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
 
        private static TcpClient screeClient;
        public static TcpClient ScreeClient
        {
            get
            {
                return screeClient;
            }

            set
            {
                screeClient = value;
            }
        }
      
        private static int indexOfscreen; //  phần mềm dựa trên indexOfscreen để quay màn hình nào
        protected static int IndexOfscreen
        {
            get
            {
                return indexOfscreen;
            }

            set
            {
                indexOfscreen = value;
            }
        }
        
        private static int delayTimetoCapture; // việc delay sẽ khiến chương trình ổn hơn chút
        protected static int DelayTimetoCapture
        {
            get
            {
                return delayTimetoCapture;
            }

            set
            {
                delayTimetoCapture = value;
            }
        }

        private static string mode; // máy mà chương trình cần quay là máy thí sinh hay MC hay màn hình led
        private static string infomation; // một số thông tin cần thiết để người giám sát biết đang xem màn hình của ai
        private static string index; // số thứ tự của màn hình, số thứ tự quyết định vị trí hiển thị trên máy server
        private int TIMEOUT = 30000; // là khoảng thời gian cao nhất để chương trình cố gắng kết nối lại, nếu vượt khỏi thì sẽ out ra

       // private ASCIIEncoding encoding = new ASCIIEncoding();
        private ReiceveManager receive;
        private SendManager send;
        #endregion

        #region Init
        public bool SetClientProperty(string ipv4, string port,int indexOfScreen, string modeOfuser,string indexOfuser, string someInfomation)
        {
            try
            {
                IpV4 = IPAddress.Parse(ipv4);
            }
            catch
            {
                return false;
            }

            try
            {
                Port = Convert.ToInt32(port);
                if (Port >= 10000) throw new Exception();
            } catch
            {
                return false;
            }

            if(mode == "")
            {
                return false;
            } else
            {
                mode = modeOfuser;
            }

            if(infomation == "")
            {
                return false;
            } else
            {
                infomation = someInfomation;
            }

            IndexOfscreen = indexOfScreen;
            if(indexOfuser == "")
            {
                return false;
            } else
            {
                index = indexOfuser;
            }    
            return true;
        }

        public Client()
        {
            DelayTimetoCapture = 0;
        }
        
        public void CreateClient()
        {
            try
            {
                //create client
                IPEndPoint ipEndpoint = new IPEndPoint(IpV4, Port);
                ScreeClient = new TcpClient();

                // connect server
                ScreeClient.Connect(ipEndpoint);
                MessageBox.Show("Kết nối thành công, để tắt vui lòng tắt trong show Hidden Tab");
                SendSomeInfoOfClient();
                             
            } catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại : " + ex.Message);
            }
        }

        #endregion

        #region Methods
        public void SetDelayTime(string delayData) {

            delayData = delayData.Remove(0, 6);
            int delayTime;
            if(int.TryParse(delayData,out delayTime))
            {
                DelayTimetoCapture = delayTime;
            } else
            {
                MessageBox.Show("Set Delay Time failed");
            }

        }

        public void BeginConnect()
        {
            ScreeClient.Close();
            ScreeClient = new TcpClient();
            IPEndPoint ipEndpoint = new IPEndPoint(IpV4, port);

            int timeOut = TIMEOUT;
            bool tryConnect;

            while (true)
            {
                if(timeOut <= 0)
                {
                    tryConnect = false;
                    break;
                }

                try
                {
                    ScreeClient.Connect(ipEndpoint);
                    tryConnect = true;
                    break;
                } catch
                {
                    timeOut -= 1000;
                }

                System.Threading.Thread.Sleep(1000);
            }

            if(tryConnect == true)
            {
                
                SendSomeInfoOfClient(); // send again
                receive = new ReiceveManager();
                send = new SendManager();
                receive.Receive();
                send.StartSendImageCapture();
                NotifyMessage.showMessage("Screen Client is connect again success", 1, 3000);
            } else
            {
                //Exit
                NotifyMessage.showMessage("Screen Client is exitting ...", 2, 3000);
                Environment.Exit(0);
                Application.Exit();
            }
        }

        private void SendSomeInfoOfClient()
        {
            string clientInfo = "HEADER " + index + "/" + mode + "/" + infomation;
            //send data
            Stream stream = ScreeClient.GetStream();
            byte[] data = Encoding.Unicode.GetBytes(clientInfo);
            stream.Write(data, 0, data.Length);
        }
        #endregion
    }
}
