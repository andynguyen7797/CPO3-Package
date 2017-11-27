using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace CPO3_Editter
{
    public class Current_Player
    {
        #region Const
        private const int PORT_NUMBER1 = 9999;
        private const int PORT_NUMBER2 = 9998;
        private const int PORT_NUMBER3 = 9997;
        private const int BUFFER_SIZE = 1024;
        private const int ALARM_WAITER_TIME = 1000;
        private const int SEND_WAITER_TIME = 300;

        #endregion

        #region Properties
        private TcpClient client_answer; // máy khách client gửi câu trả lời
        public TcpClient Client_answer
        {
            get
            {
                return client_answer;
            }

            set
            {
                client_answer = value;
            }
        }

        private TcpClient client_alarm;
        public TcpClient Client_alarm
        {
            get
            {
                return client_alarm;
            }

            set
            {
                client_alarm = value;
            }
        }

        static private string ip_receiver;
        public string Ip_receiver
        {
            get
            {
                return ip_receiver;
            }

            set
            {
                ip_receiver = value;
            }
        }
    
        private string answer_content;
        public string Answer_content
        {
            get
            {
                return answer_content;
            }

            set
            {
                answer_content = value;
            }
        }

        private string check_alarm;
        public string Check_alarm
        {
            get
            {
                return check_alarm;
            }

            set
            {
                check_alarm = value;
            }
        }

        private Player_Status player_panel;
        public Player_Status Player_panel
        {
            get
            {
                return player_panel;
            }

            set
            {
                player_panel = value;
            }
        }
        ASCIIEncoding encoding;
        private Send_Manager send_manager;
        #endregion

        #region Init
        public Current_Player(Player_Status current_player)
        {
            encoding = new ASCIIEncoding();
            this.Player_panel = current_player;
            send_manager = new Send_Manager();
        }
        #endregion

        #region Methods

        /*LOCK ALARM BUTTON AND ANSWER BUTTON*/
        public void Unenable_alarm()
        {
            Player_panel.sendAlarmMessage.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Player_panel.alarm_btt.Enabled = false;
            Thread.Sleep(ALARM_WAITER_TIME);
            Application.DoEvents();
            this.player_panel.alarm_btt.Enabled = true;
        }
        public void Unenable_answer()
        {
            Player_panel.sendAnswerMessage.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Player_panel.send_btt.Enabled = false;
            Thread.Sleep(SEND_WAITER_TIME);
            Application.DoEvents();
            this.player_panel.send_btt.Enabled = true;
        }

        /*CHANGE COLOR IF USER WAS SEND*/
        /*Một thanh panel chuyển màu xanh báo cho thí sinh biết đã gửi*/
        private void AlarmColorSend()
        {        
            Player_panel.sendAlarmMessage.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            Thread.Sleep(500);
            Application.DoEvents();
        }

        private void AnswerColorSend()
        {
            Player_panel.sendAnswerMessage.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            Thread.Sleep(500);
            Application.DoEvents();
        }

        #region Send

        public void Send_Alarm()
        {
            //  Wait_MiliSecond_Al();
            // gửi tín hiệu chuông tới máy chủ
            send_manager.Send_Alarm();
            AlarmColorSend();                
        }

        public void Send_Answer_Content(string content)
        {
            send_manager.Send_Answer_Content(content);
            AnswerColorSend();
        }

        public void Send_Name_Of_Player(string name)
        {
            send_manager.Send_Name_Of_Player(name);
        }

        #endregion   
        #endregion
    }
}
