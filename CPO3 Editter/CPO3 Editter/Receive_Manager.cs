using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace CPO3_Editter
{
    public class Receive_Manager : Network_Manager
    {

        #region Const
        private const char TURNON_CONTROl = '1';
        private const char TURNOFF_CONTROL = '0';
        private const char TURNON_EDIT = '4';
        private const char TURNOFF_EDIT = '3';
        private const char RECEIVE_IMAGE = '#';
        private const char ENEMY_NAME = '@';
        private const char ENEMY_SCORE = '$';
        private const string STOP_LISTEN = "Y2K";
        private const char UPDATE_SCREEN = '*';
        private const int ENEMY_COUNT = 4;
        private const char SET_SCREEN_PROPERTIES_SIGN = '/';   
        #endregion

        #region Properties
        private Player_Status my_player;
        public Player_Status My_player
        {
            get
            {
                return my_player;
            }

            set
            {
                my_player = value;
            }
        }

        private List<enemy> enemy_list_control;
        public List<enemy> Enemy_list_control
        {
            get
            {
                return enemy_list_control;
            }

            set
            {
                enemy_list_control = value;
            }
        }
      
        public struct ENEMY_INFO
        {
            public string player_name;
            public int current_score;          
            public string isLock;
        }

        private ScoreScreen_Manager score_screen_class;
        #endregion

        #region Init

        public Receive_Manager(Player_Status player,List<enemy> enemy_list)
        {
            this.My_player = player;
            this.Enemy_list_control = enemy_list;
            score_screen_class = new ScoreScreen_Manager(enemy_list[0].enemy_name_lb.Text); ;
        }

        #endregion
        
        #region Receive Activity

        public void Receiver()
        {

            if (Client == null)
            {
                MessageBox.Show("Client is null");
                return;
            }
            try
            {
                StreamReader read_data = new StreamReader(Client.GetStream());
                string data = "";
                while (true)
                {
                    data = read_data.ReadLine();
                    if (data.Equals(STOP_LISTEN)) break;
                    Direct(data);
                }
            } catch
            {
                // try connect again
                Thread beginConnectThr = new Thread(() => {
                    BeginConnect(My_player);
                    Receiver();
                });
                beginConnectThr.Start();                           
            }
        }
        
        private void Direct(string data)
        {
            // điều hướng dựa vào kí hiệu trên data
            if (data.Equals(TURNOFF_CONTROL.ToString())) OnOffControl(false);
            if (data.Equals(TURNON_CONTROl.ToString())) OnOffControl(true);
            if (data.Equals(TURNOFF_EDIT.ToString())) OnOff_Edit(false);
            if (data.Equals(TURNON_EDIT.ToString())) OnOff_Edit(true);
            if (data.IndexOf(ENEMY_SCORE) == 0) Show_Name_And_Score_Of_Enemy(data);
            if (data.IndexOf(UPDATE_SCREEN.ToString()) == 0) Call_Update_Screen(data);
            if (data.LastIndexOf(SET_SCREEN_PROPERTIES_SIGN.ToString()) == data.Length - 1) Set_Screen_Properties(data);
        }

        private void OnOffControl(bool turnOn)
        {
            // tắt mở control , khóa máy thí sinh khi trả lời sai hình ảnh chính vòng vượt chướng ngại vật
            if (turnOn)
            {
                My_player.alarm_btt.Enabled = true;
                My_player.send_btt.Enabled = true;
            }
            else
            {
                My_player.alarm_btt.Enabled = false;
                My_player.send_btt.Enabled = false;
            }
        }

        private void OnOff_Edit(bool turnOn)
        {
            if (turnOn)
            {
                My_player.send_name_btt.Enabled = true;
                My_player.name_tb.ReadOnly = false;
            } else
            {
                My_player.send_name_btt.Enabled = false;
                My_player.name_tb.ReadOnly = true;
            }
        }

        private ENEMY_INFO[] GetAvatar_Name(string data)
        {
            ENEMY_INFO[] enemy_list = new ENEMY_INFO[ENEMY_COUNT];

            /*Unit test : 

            $50@Huy$110@Nhan$100@Duy 

             */
            for (int i = 0; i < ENEMY_COUNT; i++)
            {
                // get score
                string score = data.Remove(data.IndexOf(ENEMY_NAME), data.Length - data.IndexOf(ENEMY_NAME)); // score : $50
                score = score.Trim(ENEMY_SCORE); // score : 50
                enemy_list[i].current_score = Convert.ToInt32(score); // enemy_list[i].score = 50

                // remove score in data
                data = data.Remove(0, data.IndexOf(ENEMY_NAME)); // data : @Huy$110@Nhan$100@Duy 

                // get name
                if (data.IndexOf(ENEMY_SCORE) >= 0)
                {
                    string name = data.Remove(data.IndexOf(ENEMY_SCORE), data.Length - data.IndexOf(ENEMY_SCORE)); // name : @Huy
                    name = name.Trim(ENEMY_NAME); // name : Huy
                    enemy_list[i].player_name = name; // enemy_list[i].name = Huy

                    // remove name in data
                    data = data.Remove(0, data.IndexOf(ENEMY_SCORE)); // data : $110@Nhan$100@Duy 
                }
                else
                {
                    enemy_list[i].player_name = data.Trim(ENEMY_NAME); // TH : data : @Duy 
                }
            }

            return enemy_list;
        }
      
        private void Save_Enemy_Info(ENEMY_INFO[] enemy_info_list)
        {          
            for (int i = 0;i < ENEMY_COUNT; i++)
            {
                //get score , bring into label score
                Enemy_list_control[i].enemy_current_score.Text = enemy_info_list[i].current_score.ToString();

                //get name, bring into label name
                Enemy_list_control[i].enemy_name_lb.Text = enemy_info_list[i].player_name;
            }
        }

        private void Show_Name_And_Score_Of_Enemy(string data)
        {
            ENEMY_INFO[] enemy_list_data = GetAvatar_Name(data);           
            Save_Enemy_Info(enemy_list_data);
        }

        public void Call_Update_Screen(string data)
        {
            // vì data có dạng * + <điểm số> + * + <tên> nên phải cắt dấu * đi
            data = data.Remove(0, 1);

            // get score
            string score = data.Substring(0, data.IndexOf(UPDATE_SCREEN));
            //get name
            string name = data.Substring(data.IndexOf(UPDATE_SCREEN) + 1, data.Length - (data.IndexOf(UPDATE_SCREEN) + 1));

            //update
            score_screen_class.Update_Screen(score,name);       
        }

        private void Set_Screen_Properties(string data)
        {
            data = data.Remove(data.Length - 1, 1);
            score_screen_class.Set_Screen_Properties(data);   
        }
        #endregion
    }
}
