using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using WindowsDisplayAPI;

namespace CPO3_Editter
{
    public class ScoreScreen_Manager
   {

        #region Properties
        private Score_Screen screen;
        public Score_Screen Screen
        {
            get
            {
                return screen;
            }

            set
            {
                screen = value;
            }
        }
    
        private string player_name;
        public string Player_name
        {
            get
            {
                return player_name;
            }

            set
            {
                player_name = value;
            }
        }

        private string score;
        public string Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        private Send_Manager send_class;
        #endregion

        #region Init
        public ScoreScreen_Manager(string player_name)
        {
            send_class = new Send_Manager();

            this.Player_name = player_name;
            this.Score = "000";

            Screen = new Score_Screen();
            Show_Screen();
        }
        #endregion

        #region Methods

        public void Show_Screen()
        {           
            Screen.name.Text = this.Player_name;
            Screen.score.Text = this.Score;
            Detect_Screen();
            Screen.Show();
        }

        public void Update_Screen(string score,string name)
        {
            /*CẬP NHẬT ĐIỂM*/

            // Cập nhật định dạng của điểm
            int convert_score = Convert.ToInt32(score);
            if (convert_score >= 0 && convert_score <= 9)
            {
                score = "00" + score;
            }

            if (convert_score >= 10 && convert_score <= 99)
            {
                score = "0" + score;
            }

            // In ra màn hình
            Screen.score.Text = score;

            /*CẬP NHẬT TÊN*/
            Screen.name.Text = name;
        }

        private void Detect_Screen()
        {
            /*Tìm màn hình thứ 2 nếu tìm thấy thì chuyển form sang màn hình đó*/
            List<Screen> screenList = new List<System.Windows.Forms.Screen>();
            string Message = "";
            int indexOfscreen = 0;
            foreach(var screen in Display.GetDisplays())
            {
                screenList.Add(screen.GetScreen());
                Message += " " + indexOfscreen + " - [" + screen.DeviceName + "] ; ";
            }
            int select_screen_key;
            if (!int.TryParse(Interaction.InputBox("Hệ thống tìm được " + screenList.Count + " màn hình." + Message, "Màn hình", "1", -1, -1), out select_screen_key))
            {
                MessageBox.Show("Không đúng định dạng, vui lòng nhập lại ở lần mở kế tiếp", "Thông báo");
            }
            try {
                Rectangle red = screenList[select_screen_key].Bounds;
                Screen.SetBounds(red.X, red.Y, red.Width, red.Height);
                Screen.StartPosition = FormStartPosition.Manual;
            } catch (Exception ex)
            {
                Screen.Location = screenList[0].WorkingArea.Location;            
                MessageBox.Show(ex.Message);
            }
            
        }

        /* SET SCREEN PROPERTIES */
        public void Set_Screen_Properties(string data_packet)
        {
            /*Thiết lập các thuộc tính về font và màu sắc từ data gửi tới*/

            byte[] data_zip = Extra_data_packet(data_packet);
            List<string> data_Deserialize = Deserialize_Data_ZIP(data_zip);
            Set_Properties(data_Deserialize);         
        }

        private byte[] Extra_data_packet(string data_packet)
        {           
            byte[] data_receive_arr = Convert.FromBase64String(data_packet);
            return data_receive_arr;             
        }

        private void Set_Properties(List<string> data_zip)
        {
            if (data_zip == null) return;
                  
            /* set font */
            if(data_zip[0] != null && data_zip[1] != null)
            {
                Screen.name.Font = new Font(data_zip[0], (float)Convert.ToDouble(data_zip[1]));
            }
           
            if(data_zip[2] != null)
            {
                Screen.name.ForeColor = Color.FromName(data_zip[2]);
            }
            
            if(data_zip[3] != null && data_zip[4] != null)
            {
                Screen.score.Font = new Font(data_zip[3], (float)Convert.ToDouble(data_zip[4]));
            }
            
            if(data_zip[5] != null)
            {
                Screen.score.ForeColor = Color.FromName(data_zip[5]);
            }
           

            //set top color
            if(data_zip[6] != null)
            {
                Screen.name.BackColor = System.Drawing.ColorTranslator.FromHtml(data_zip[6]);
            }
            

            //set bottom color
            if(data_zip[7] != null)
            {
                Screen.score.BackColor = System.Drawing.ColorTranslator.FromHtml(data_zip[7]);
            }
            
        }

        private List<string> Deserialize_Data_ZIP(byte[] data)
        {
            /*giải nén mảng byte thành dạng list*/

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(data);
            return bf.Deserialize(ms) as List<string>;
        }
        #endregion

    }
}
