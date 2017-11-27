using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    [Serializable]
    public class Set_Screen_Properties
    {
        #region Properties

        private Set_Screen screen_form;
        public Set_Screen Screen_form
        {
            get
            {
                return screen_form;
            }

            set
            {
                screen_form = value;
            }
        }
           
        private List<string> data_packet; // list này chứa các thông tin về font và màu của màn hình, sắp xếp theo từng phần tử
        public List<string> Data_packet
        {
            get
            {
                return data_packet;
            }

            set
            {
                data_packet = value;
            }
        }
       
        private static byte[] data_arr; // mảng byte có nhiệm vụ lưu trữ lại thông tin cả list để gửi đi
        public static byte[] Data_arr
        {
            get
            {
                return data_arr;
            }

            set
            {
                data_arr = value;
            }
        }
       
        private static byte[] data_review_arr;
        public static byte[] Data_review_arr
        {
            get
            {
                return data_review_arr;
            }

            set
            {
                data_review_arr = value;
            }
        }

        
        private static Image image_review;
        public static Image Image_review
        {
            get
            {
                return image_review;
            }

            set
            {
                image_review = value;
            }
        }

        private ScreenSettingsLog log_class;
        #endregion

        /*INIT*/
        public Set_Screen_Properties(Set_Screen screen_form)
        {
            this.Screen_form = screen_form;           
            Data_packet = new List<string>();
            log_class = new ScreenSettingsLog(this.Screen_form.log_tb);
        }

        /*BUTTON CLICK EVENTS AND REVIEW*/
        public void Set_Font_Player_Properties()
        {
            if(Screen_form.fontDialog.ShowDialog() == DialogResult.OK)
            {
                // review
                Screen_form.player_font_name_tb.Text = Screen_form.fontDialog.Font.Name;
                Screen_form.player_font_size_tb.Text = Screen_form.fontDialog.Font.Size.ToString();
                Screen_form.player_font_color_tb.Text = Screen_form.fontDialog.Color.Name;

                // write to log
                log_class.WriteLog_toTextBox("User has changed font of name screen properties - font name : " + Screen_form.fontDialog.Font.Name);
                log_class.WriteLog_toTextBox("User has changed font of name screen properties - font size : " + Screen_form.fontDialog.Font.Size.ToString());
                log_class.WriteLog_toTextBox("User has changed font of name screen properties - font color : " + Screen_form.fontDialog.Color.Name);
            }
        }

        public void Set_Font_Score_Properties()
        {
            if (Screen_form.fontDialog.ShowDialog() == DialogResult.OK)
            {
                // review
                Screen_form.score_font_name_tb.Text = Screen_form.fontDialog.Font.Name;
                Screen_form.score_font_size_tb.Text = Screen_form.fontDialog.Font.Size.ToString();
                Screen_form.score_font_color_tb.Text = Screen_form.fontDialog.Color.Name;

                //write to log
                log_class.WriteLog_toTextBox("User has changed font of score screen properties - font name : " + Screen_form.fontDialog.Font.Name);
                log_class.WriteLog_toTextBox("User has changed font of score screen properties - font size : " + Screen_form.fontDialog.Font.Size.ToString());
                log_class.WriteLog_toTextBox("User has changed font of score screen properties - font color : " + Screen_form.fontDialog.Color.Name);
            }
        }

        /*GET PROPERTIES AND ADD INTO LIST*/
        private void Get_Font()
        {

            // get player font
            if(Screen_form.player_font_name_tb.Text != "")
            {
                Data_packet.Add(Screen_form.player_font_name_tb.Text);
            } else
            {
                Data_packet.Add("Roboto Light");
            }
            
            if(Screen_form.player_font_size_tb.Text != "")
            {
                Data_packet.Add(Screen_form.player_font_size_tb.Text);
            } else
            {
                Data_packet.Add("72");
            }
            
            if(Screen_form.player_font_color_tb.Text != "")
            {
                Data_packet.Add(Screen_form.player_font_color_tb.Text);
            } else
            {
                Data_packet.Add("Black");
            }


            // get score font

            if (Screen_form.score_font_name_tb.Text != "")
            {
                Data_packet.Add(Screen_form.score_font_name_tb.Text);
            }
            else
            {
                Data_packet.Add("Roboto Light");
            }

            if (Screen_form.score_font_size_tb.Text != "")
            {
                Data_packet.Add(Screen_form.score_font_size_tb.Text);
            }
            else
            {
                Data_packet.Add("72");
            }

            if (Screen_form.score_font_color_tb.Text != "")
            {
                Data_packet.Add(Screen_form.score_font_color_tb.Text);
            }
            else
            {
                Data_packet.Add("Black");
            }

        }

        private void Get_Screen_Color()
        {         
            Data_packet.Add(ConvertHex_Color(Screen_form.color_top_screen));
            Data_packet.Add(ConvertHex_Color(Screen_form.color_bottom_screen));

            //write to log
            log_class.WriteLog_toTextBox("User has changed name screen color - hex color : " + ConvertHex_Color(Screen_form.color_top_screen));
            log_class.WriteLog_toTextBox("User has changed score screen color - hex color : " + ConvertHex_Color(Screen_form.color_bottom_screen));
        }

        private string ConvertHex_Color(DevExpress.XtraEditors.ColorPickEdit color)
        {
            /*Chuyển đổi màu sang dạng hex*/
            // xem cách chuyển đổi : https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
            return "#" + color.Color.R.ToString("X2") + color.Color.G.ToString("X2") + color.Color.B.ToString("X2");
        }

        /*SAVE PROPERTIES*/   
        public void Apply_Settings()
        {
            // Clear Packet if click again 
            Data_packet.Clear();

            // check screen
            Get_Font();
            Get_Screen_Color();
      
            //Phân tích thành mảng byte gửi đi
            Serialize_DataPacket_toByte(Data_packet);           
        }
 

        /*SERIALIZE INFOMATION TO BYTE ARRAY*/
        private void Serialize_DataPacket_toByte(object data_packet)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms,data_packet);
            Data_arr = ms.ToArray();
            ms.Dispose();
        }
        private Image Deserialze_DataPacket_toObject(byte[] data)
        {
            ImageConverter converter = new ImageConverter();
            Image img = (Image)converter.ConvertFrom(data);
            return img;

        }

        /*STATIC METHODS*/
        public static void Clear_Data_Review()
        {
            Data_review_arr = new byte[0];
        }
    }
}
