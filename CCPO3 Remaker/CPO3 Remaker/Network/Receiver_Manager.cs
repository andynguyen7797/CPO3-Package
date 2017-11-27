using System.Net.Sockets;
using System.IO;

namespace CPO3_Remaker
{
    public class Receiver_Manager 
    {
        #region Const
        private const char ANSWER_SIGN = '#';
        private const char ALARM_SIGN = '@';
        private const char NAME_PlAYER_SIGN = '*';
        private const string DESTROY_CLIENT = "Y2K";
        #endregion

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

        private Player_Control player_control;
        public Player_Control Player_control
        {
            get
            {
                return player_control;
            }

            set
            {
                player_control = value;
            }
        }

        private StreamReader readData;
        public StreamReader ReadData
        {
            get
            {
                return readData;
            }

            set
            {
                readData = value;
            }
        }


        #endregion

        #region Init
        public Receiver_Manager(TcpClient client,StreamReader readData,Player_Control player)
        {
            Player_control = player;
            Client = client;
            ReadData = readData;
        }
        #endregion

        #region Receive
        public void Receive()
        {
            try
            {
                string data = "";
                while (true)
                {
                    data = ReadData.ReadLine();
                    if(data != "") Direct_From_Sign(data);
                }
            } catch 
            {
                this.Client.Close();
                Player_control.SetDefault();
            }

        }

        private void Direct_From_Sign(string data)
        {
            // điều hướng các chức năng dựa vào dấu hiệu của clien gửi tới

            if (data.LastIndexOf(ANSWER_SIGN) == data.Length - 1) // nhận câu trả lời
            {
                Receiver_Answer(data.Remove(data.Length - 1, 1));
            }

            if (data.LastIndexOf(ALARM_SIGN) == data.Length - 1) // nhận chuông
            {
                Receiver_Alarm();
            }

            if (data.LastIndexOf(NAME_PlAYER_SIGN) == data.Length - 1) // nhận tên thí sinh
            {
                Receiver_Update_Name_Of_Player(data);
            }

        }

        private void Receiver_Answer(string answer_data)
        {
            Player_control.SetAnswerContent(answer_data);
            Player_control.Stop_TimeCount(true);
        }

        private void Receiver_Alarm()
        {
            Player_control.Stop_TimeCount(true);
            Player_control.Alarm_Activity();        
        }

        private void Receiver_Update_Name_Of_Player(string name)
        {
            name = name.Remove(name.Length - 1, 1);
            this.Player_control.SetName(name);
        }
        #endregion
    }
}
