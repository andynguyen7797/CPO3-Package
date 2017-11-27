using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using WindowsDisplayAPI;
using System.Collections.Generic;

namespace CPO3_Remaker
{
    public class Quan_ly_man_hinh_tra_loi
    {
        #region Properties

        #region Struct

        struct AVATAR_PROPERTIES
        {          
            public int x_axis;
            public int y_axis;
            public int width;
            public int height;
            public string avatarPath;
        }

        struct ANSWER_PROPERTIES
        {
            public int x_axis;
            public int y_axis;
            public int width;
            public int height;
            public Font font;
            public Color foreColor;
        }

        struct TIME_PROPERTIES
        {
            public int x_axis;
            public int y_axis;
            public int width;
            public int height;
            public Font font;
            public Color foreColor;
        }

        #endregion

        private Man_Hinh_Cau_Tra_Loi man_hinh_cau_tra_loi;
        public Man_Hinh_Cau_Tra_Loi Man_hinh_cau_tra_loi
        {
            get
            {
                return man_hinh_cau_tra_loi;
            }

            set
            {
                man_hinh_cau_tra_loi = value;
            }
        }

        private static AVATAR_PROPERTIES[] avatar_properties;
        private static ANSWER_PROPERTIES[] answer_content_properties;
        private static TIME_PROPERTIES[] time_properties;

        private Circle_Image[] circle_img_array = new Circle_Image[Cons.PLAYER_COUNT];
        private TextBox[] answer_content_array = new TextBox[Cons.PLAYER_COUNT];
        private Label[] time_array = new Label[Cons.PLAYER_COUNT];

        private int screenPosition;
        #endregion

        #region Init
        public Quan_ly_man_hinh_tra_loi(Man_Hinh_Cau_Tra_Loi man_hinh_cau_tra_loi)
        {
            Man_hinh_cau_tra_loi = man_hinh_cau_tra_loi;
            properties_Init();
            Add_Components_To_Array();
        }

        public Quan_ly_man_hinh_tra_loi(Man_Hinh_Cau_Tra_Loi man_hinh_diem,bool isInit)
        {
            Man_hinh_cau_tra_loi = man_hinh_diem;
            Add_Components_To_Array();
        }

        private void properties_Init()
        {
            avatar_properties = new AVATAR_PROPERTIES[Cons.PLAYER_COUNT];
            answer_content_properties = new ANSWER_PROPERTIES[Cons.PLAYER_COUNT];
            time_properties = new TIME_PROPERTIES[Cons.PLAYER_COUNT];
        }

        private void Add_Components_To_Array()
        {
            // add circle image
            circle_img_array[0] = Man_hinh_cau_tra_loi.ava_1;
            circle_img_array[1] = Man_hinh_cau_tra_loi.ava_2;
            circle_img_array[2] = Man_hinh_cau_tra_loi.ava_3;
            circle_img_array[3] = Man_hinh_cau_tra_loi.ava_4;

            // add answer content
            answer_content_array[0] = Man_hinh_cau_tra_loi.content_tb_1;
            answer_content_array[1] = Man_hinh_cau_tra_loi.content_tb_2;
            answer_content_array[2] = Man_hinh_cau_tra_loi.content_tb_3;
            answer_content_array[3] = Man_hinh_cau_tra_loi.content_tb_4;

            // add time label
            time_array[0] = Man_hinh_cau_tra_loi.content_phu_1;
            time_array[1] = Man_hinh_cau_tra_loi.content_phu_2;
            time_array[2] = Man_hinh_cau_tra_loi.content_phu_3;
            time_array[3] = Man_hinh_cau_tra_loi.content_phu_4;
        }
        #endregion

        #region Methods

        /*OPEN*/
        public void Mo_Man_Hinh_Tra_Loi()
        {
            if(CheckIfDataExist())
            {
                Mo_man_hinh_da_luu();
            } else
            {
                Mo_man_hinh_mac_dinh();
            }
        }
       
        private void Mo_man_hinh_da_luu()
        {
            /*load avatar properties*/

            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                circle_img_array[i].Location = new Point(avatar_properties[i].x_axis, avatar_properties[i].y_axis);

                circle_img_array[i].Width = avatar_properties[i].width;
                circle_img_array[i].Height = avatar_properties[i].height;

                circle_img_array[i].BackgroundImage = Image.FromFile(avatar_properties[i].avatarPath);

                //save image path to Tag Component
                circle_img_array[i].Tag = avatar_properties[i].avatarPath;
            }

            /*load answer properties*/
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                answer_content_array[i].Location = new Point(answer_content_properties[i].x_axis, answer_content_properties[i].y_axis);

                answer_content_array[i].Width = answer_content_properties[i].width;
                answer_content_array[i].Height = answer_content_properties[i].height;

                answer_content_array[i].Font = answer_content_properties[i].font;
                answer_content_array[i].ForeColor = answer_content_properties[i].foreColor;
            }

            /*load time properties*/
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                time_array[i].Location = new Point(time_properties[i].x_axis, time_properties[i].y_axis);

                time_array[i].Width = time_properties[i].width;
                time_array[i].Height = time_properties[i].height;

                time_array[i].Font = time_properties[i].font;
                time_array[i].ForeColor = time_properties[i].foreColor;
            }

            Detect_Screen();
            Man_hinh_cau_tra_loi.Show();
        }
        
        private void Mo_man_hinh_mac_dinh()
        {
            Detect_Screen();
            Man_hinh_cau_tra_loi.Show();
        }

        /*FILE EVENTS*/
        private bool LoadDataFromFile()
        {
            CreateFileIfNotExist(Cons.DATA_OF_MANHINHTRALOI);

            // get data from text file
            string[] jsonData = System.IO.File.ReadAllLines(Cons.DATA_OF_MANHINHTRALOI);
            if(jsonData.Length == 0)
            {
                //dữ liệu không tồn tại trong file
                return false;
            }
            
            // load data into object

                dynamic dataOfAvatar = SerializerOfJson.DeserializeFromJsonFile(jsonData[0], Type.GetType("avatar_properties"));
                dynamic dataOfAnswer = SerializerOfJson.DeserializeFromJsonFile(jsonData[1], Type.GetType("answer_content_properties"));
                dynamic dataOfTime = SerializerOfJson.DeserializeFromJsonFile(jsonData[2], Type.GetType("time_properties"));
                
                /*Lớp Converter cần cho những sự chuyển đổi những kiểu dữ liệu đặc biệt*/
                FontConverter converter = new FontConverter();
                ColorConverter converter1 = new ColorConverter();

                /*Tránh tạo những biến này trong vòng lặp, nó khiến thời gian xử lí lâu hơn vì phải tạo đi tạo lại những biến như thế*/
                string colorStr;
                string fontStr;
                string[] fontProperty;

                int index = 0;
                foreach (var data in dataOfAvatar)
                {
                    avatar_properties[index].x_axis = data["x_axis"];
                    avatar_properties[index].y_axis = data["y_axis"];

                    avatar_properties[index].width = data["width"];
                    avatar_properties[index].height = data["height"];

                    avatar_properties[index].avatarPath = data["avatarPath"];

                    index++;
                }

                //reset index
                index = 0;

                foreach (var data in dataOfAnswer)
                {
                    answer_content_properties[index].x_axis = data["x_axis"];
                    answer_content_properties[index].y_axis = data["y_axis"];

                    answer_content_properties[index].width = data["width"];
                    answer_content_properties[index].height = data["height"];

                    colorStr = data["foreColor"];
                    var color = (Color)converter1.ConvertFromString(colorStr);
                    answer_content_properties[index].foreColor = color;

                    /*Font data có dạng <Tên font>, <Kích thước>pt ==> cần tách thành mảng với 2 phần tử là tên và kích thước*/
                    fontStr = data["font"];
                    fontProperty = fontStr.Split(',');
                    fontProperty[1] = fontProperty[1].Substring(0,fontProperty[1].IndexOf('p'));
                    answer_content_properties[index].font = new Font(fontProperty[0], (float)Convert.ToDouble(fontProperty[1]));

                index++;
                }

                index = 0;

                foreach (var data in dataOfTime)
                {
                    time_properties[index].x_axis = data["x_axis"];
                    time_properties[index].y_axis = data["y_axis"];

                    time_properties[index].width = data["width"];
                    time_properties[index].height = data["height"];

                    /*Font data có dạng <Tên font>, <Kích thước>pt ==> cần tách thành mảng với 2 phần tử là tên và kích thước*/
                    fontStr = data["font"];
                    fontProperty = fontStr.Split(',');
                    fontProperty[1] = fontProperty[1].Substring(0, fontProperty[1].IndexOf('p'));
                    time_properties[index].font = new Font(fontProperty[0], (float)Convert.ToDouble(fontProperty[1]));

                    colorStr = data["foreColor"];
                    var color = (Color)converter1.ConvertFromString(colorStr);
                    time_properties[index].foreColor = color;

                index++;
                }         
            return true;
        }

        /*CHECK*/
        private void CreateFileIfNotExist(string path) {
            if (!File.Exists(path))
            {
                FileStream fs =  File.Create(path);
                fs.Close();
            }

        }

        private bool CheckIfDataExist()
        {
            /*KIỂM TRA DỮ LIỆU ĐÃ TỒN TẠI CHƯA*/
            if(avatar_properties[0].avatarPath != null && answer_content_properties[0].font != null && time_properties[0].font != null)
            {
                return true;
            }

            if (LoadDataFromFile())
            {
                return true;
            }
            return false;                          
        }

        /*DETECT SCREEN MONITOR*/
        private void Detect_Screen()
        {
            List<Screen> screenList = new List<Screen>();
            string Message = "";
            int indexOfscreen = 0;

            foreach(var dislay in Display.GetDisplays())
            {
                screenList.Add(dislay.GetScreen());
                Message += " " + indexOfscreen + " - [" + dislay.DeviceName + "] ; ";
                indexOfscreen++; 
            }

            int select_screen_key;
            if (!int.TryParse(Interaction.InputBox("Hệ thống tìm được " + screenList.Count + " màn hình." + Message, "Màn hình", "1", -1, -1), out select_screen_key))
            {
                MessageBox.Show("Không đúng định dạng, vui lòng nhập lại ở lần mở kế tiếp", "Thông báo");
            }
            else
            {
                screenPosition = select_screen_key;
            }
            try
            {
                Rectangle rec = screenList[select_screen_key].Bounds;
                Man_hinh_cau_tra_loi.SetBounds(rec.X, rec.Y, rec.Width, rec.Height);
                Man_hinh_cau_tra_loi.StartPosition = FormStartPosition.Manual;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy đảm bảo bạn đã kết nối màn hình thứ 2 \n Chi tiết : " + ex.Message, "Thông báo");
                Man_hinh_cau_tra_loi.Location = screenList[0].WorkingArea.Location;
            }
        }

        /*CLOSE*/
        public void Dong_Man_Hinh_Tra_Loi(bool saveProperties)
        {
            if (saveProperties)
            { 
                Save_Properties();
                Save_To_File();
                Man_hinh_cau_tra_loi.Close();
            } else
            {
                Man_hinh_cau_tra_loi.Close();
            }
        }

        /*UPDATE*/
        public void Cap_nhat_diem_va_thoi_gian(string[] answer_content,string[] time, byte[] tag_ava)
        {
            int i;
            for(i = 0;i < Cons.PLAYER_COUNT; i++)
            {
                answer_content_array[i].Text = answer_content[i];

                // change avatar
                circle_img_array[i].BackgroundImage = circle_img_array[tag_ava[i]].BackgroundImage;
            }

            for(i = 0;i < Cons.PLAYER_COUNT; i++)
            {
                time_array[i].Text = time[i];
            }
        }
        #endregion

        #region Save
        public void Save_To_File()
        {
            //clean all text in text file
            File.WriteAllText(Cons.DATA_OF_MANHINHTRALOI, String.Empty);

            SerializerOfJson.SerializeToJson(Cons.DATA_OF_MANHINHTRALOI, avatar_properties);
            SerializerOfJson.SerializeToJson(Cons.DATA_OF_MANHINHTRALOI, answer_content_properties);
            SerializerOfJson.SerializeToJson(Cons.DATA_OF_MANHINHTRALOI, time_properties);
            SerializerOfJson.SerializeToJson(Cons.DATA_OF_MANHINHTRALOI, screenPosition);
        }

        private void Save_Properties()
        {
            /*save avatar properties*/

            for(int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                avatar_properties[i].x_axis = circle_img_array[i].Location.X;
                avatar_properties[i].y_axis = circle_img_array[i].Location.Y;

                avatar_properties[i].width = circle_img_array[i].Width;
                avatar_properties[i].height = circle_img_array[i].Height;

                avatar_properties[i].avatarPath = circle_img_array[i].Tag.ToString();
            }

            /*save answer properties*/
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                answer_content_properties[i].x_axis = answer_content_array[i].Location.X;
                answer_content_properties[i].y_axis = answer_content_array[i].Location.Y;

                answer_content_properties[i].width = answer_content_array[i].Width;
                answer_content_properties[i].height = answer_content_array[i].Height;

                answer_content_properties[i].font = answer_content_array[i].Font;
                answer_content_properties[i].foreColor = answer_content_array[i].ForeColor;
            }

            /*save time properties*/
            for(int i = 0;i < Cons.PLAYER_COUNT; i++)
            {
                time_properties[i].x_axis = time_array[i].Location.X;
                time_properties[i].y_axis = time_array[i].Location.Y;


                time_properties[i].width = time_array[i].Width;
                time_properties[i].height = time_array[i].Height;

                time_properties[i].font = time_array[i].Font;
                time_properties[i].foreColor = time_array[i].ForeColor;
            }
        }
        #endregion
    }
}
