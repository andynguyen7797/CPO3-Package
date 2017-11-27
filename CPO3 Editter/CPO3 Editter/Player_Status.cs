using System;
using System.Windows.Forms;

namespace CPO3_Editter
{
    public partial class Player_Status : UserControl
    {
        

        #region Properties
        private string ip_receiver;
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
        private Current_Player player_class;
        #endregion

        #region Init
        public Player_Status()
        {
            InitializeComponent();
            player_class = new Current_Player(this);

        }
        #endregion

        #region Event

        //Alarm Events
        private void alarm_btt_Click(object sender, EventArgs e)
        {
           SendAlarm();
        }

        //Answer Content Events
        private void send_btt_Click(object sender, EventArgs e)
        {
            SendAnswer();
        }

        //Name Event
        private void send_name_btt_Click(object sender, EventArgs e)
        {
            SendName();
        }

        private void exit_btt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "CPO3 Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Environment.Exit(0);
                Application.Exit();
            }
        }
        #endregion

        #region Methods
        public void SendAlarm()
        {
            player_class.Send_Alarm(); 
            player_class.Unenable_alarm();
        }

        public void SendAnswer()
        {
            if(answer_tb.Text == null)
            {
                answer_tb.Text = "Không có câu trả lời";
            }
            player_class.Send_Answer_Content(answer_tb.Text);
            player_class.Unenable_answer();
        }

        public void SendName()
        {
            if (name_tb.Text == null)
            {
                name_tb.Text = "Unknown";
            }
            player_class.Send_Name_Of_Player(name_tb.Text);
        }


        #endregion

    }
}
