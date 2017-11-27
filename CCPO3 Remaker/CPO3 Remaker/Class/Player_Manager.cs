using System;
using System.Collections.Generic;
using System.Threading;

namespace CPO3_Remaker
{
    [Serializable]
    public class Player_Manager
    {
        // Quản lý điểm của 4 thí sinh và trạng thái hiện tại của họ (đang bị khóa hay đang mở)
        #region Properties

        public struct PLAYER_INFO
        {
            public string player_name;
            public int current_score;
            public string isLock;
        }
        public static PLAYER_INFO[] list_player_info;
        public static List<Player_Control> list_player;

        #endregion

        #region Init
        public Player_Manager(List<Player_Control> player)
        {
            if (player != null)
            {
                list_player = player;
                list_player_info = new PLAYER_INFO[Cons.PLAYER_COUNT];
            }
        }
        #endregion

        #region Methods
        public void Start_Save_Info_Thread()
        {
            Thread save_thread = new Thread(Save_Info);
            save_thread.Start();
        }

        private void Save_Info()
        {
            while (true)
            {
                    Save_Player_Info();
            }
        }

        private void Save_Player_Info()
        {
            //lưu thông tin của player 

            for(int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                if (list_player[i] == null)
                {
                    list_player[i].Player_name = "NULL";
                    list_player[i].Player_score = 0;
                    list_player[i].IsLock = 0;
                }

                if (list_player[i].Player_name != null) {
                    //tạo bản sao của list_player_info[change_index] vì bản thân nó không phải là 1 giá trị
                    PLAYER_INFO copy = list_player_info[i];

                    //save into copy variable
                    copy.player_name = list_player[i].Player_name;
                    copy.current_score = list_player[i].Player_score;
                    copy.isLock = list_player[i].IsLock.ToString();

                    //save into change_index
                    list_player_info[i] = copy;
                }               
            }
          
                             
        }
              
        private void Save_Info_To_File()
        {
            for (int i = 0;i < list_player_info.Length; i++)
            {
                System.IO.File.WriteAllText(@"P:\\Data\\Data.txt", list_player_info[i].player_name);
            }
        }

        public string Get_Main_Info()
        {
            //// lấy thông tin từ 3 đối thủ 
            string info_packet = "";
            // vị trí 1 là tên, 2 là điểm
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                //mỗi thông tin của 1 người sẽ được nén theo mẫu : $<Điểm>@<Tên>
                info_packet += "$" + list_player_info[i].current_score + "@" + list_player_info[i].player_name;
            }
            return info_packet;
           
        }
        #endregion
    }
}
