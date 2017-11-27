using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Collections.Generic;
using WindowsDisplayAPI;

namespace CPO3_Remaker
{
     class Quan_ly_man_hinh_diem
    {
        #region Properties

        struct AVATAR_PROPERTIES
        {
          public int x_axis;
          public int y_axis;
          public int width;
          public int height;
          public string avatarPath;
        }

        struct NAME_PROPERTIES
        {
            public int x_axis;
            public int y_axis;
            public int width;
            public int height;
            public Font font;
            public Color foreColor;
        }

        struct SCORE_PROPERTIES
        {
            public int x_axis;
            public int y_axis;
            public int width;
            public int height;
            public Font font;
            public Color foreColor;
        }

        private static AVATAR_PROPERTIES[] avatar_properties;
        private static NAME_PROPERTIES[] name_properties;
        private static SCORE_PROPERTIES[] score_properties;

        private Circle_Image[] circle_img_array = new Circle_Image[Cons.PLAYER_COUNT];
        private TextBox[] name_array = new TextBox[Cons.PLAYER_COUNT];
        private Label[] score_array = new Label[Cons.PLAYER_COUNT];

        private Man_Hinh_Diem man_hinh_diem;
        private Man_Hinh_Diem Man_hinh_diem
        {
            get
            {
                return man_hinh_diem;
            }

            set
            {
                man_hinh_diem = value;
            }
        }

        #endregion

        #region Init

         public Quan_ly_man_hinh_diem(Man_Hinh_Diem man_hinh_diem)
        {
            Man_hinh_diem = man_hinh_diem;
            properties_Init();
            Add_Component_To_Array();
        }

         public Quan_ly_man_hinh_diem(Man_Hinh_Diem man_hinh_diem,bool isInit)
        {
            Man_hinh_diem = man_hinh_diem;           
            Add_Component_To_Array();
        }

         private void properties_Init()
        {
            avatar_properties = new AVATAR_PROPERTIES[Cons.PLAYER_COUNT];
            name_properties = new NAME_PROPERTIES[Cons.PLAYER_COUNT];
            score_properties = new SCORE_PROPERTIES[Cons.PLAYER_COUNT];
        }

         private void Add_Component_To_Array()
        {
            // add circle image
            circle_img_array[0] = Man_hinh_diem.ava_1;
            circle_img_array[1] = Man_hinh_diem.ava_2;
            circle_img_array[2] = Man_hinh_diem.ava_3;
            circle_img_array[3] = Man_hinh_diem.ava_4;

            // add name content
            name_array[0] = Man_hinh_diem.content_tb_1;
            name_array[1] = Man_hinh_diem.content_tb_2;
            name_array[2] = Man_hinh_diem.content_tb_3;
            name_array[3] = Man_hinh_diem.content_tb_4;

            // add score label
            score_array[0] = Man_hinh_diem.content_phu_1;
            score_array[1] = Man_hinh_diem.content_phu_2;
            score_array[2] = Man_hinh_diem.content_phu_3;
            score_array[3] = Man_hinh_diem.content_phu_4;
        }

        #endregion

        #region Methods

        /*OPEN*/
       public void Mo_Man_Hinh_Diem()
        {
            if (CheckDataIfExist())
            {
                Mo_man_hinh_da_luu();
            }
            else
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
                circle_img_array[i].Tag = avatar_properties[i].avatarPath;
            }

            /*load answer properties*/
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                name_array[i].Location = new Point(name_properties[i].x_axis, name_properties[i].y_axis);

                name_array[i].Width = name_properties[i].width;
                name_array[i].Height = name_properties[i].height;

                name_array[i].Font = name_properties[i].font;
                name_array[i].ForeColor = name_properties[i].foreColor;
            }

            /*load time properties*/
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                score_array[i].Location = new Point(score_properties[i].x_axis, score_properties[i].y_axis);

                score_array[i].Width = score_properties[i].width;
                score_array[i].Height = score_properties[i].height;

                score_array[i].Font = score_properties[i].font;
                score_array[i].ForeColor = score_properties[i].foreColor;
            }

            Detect_Screen();
            Man_hinh_diem.Show();
        }
       
       private  void Mo_man_hinh_mac_dinh()
        {
           
            Detect_Screen();
            Man_hinh_diem.Show();
        }

       private  void Detect_Screen()
        {
            List<Screen> screenList = new List<Screen>();
            string Message = "";
            int indexOfscreen = 0;

            foreach (var dislay in Display.GetDisplays())
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
            try
            {
                Rectangle rec = screenList[select_screen_key].Bounds;
                Man_hinh_diem.SetBounds(rec.X, rec.Y, rec.Width, rec.Height);
                Man_hinh_diem.StartPosition = FormStartPosition.Manual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy đảm bảo bạn đã kết nối màn hình thứ 2 \n Chi tiết : " + ex.Message, "Thông báo");
                Man_hinh_diem.Location = screenList[0].WorkingArea.Location;
            }
        }

        /*CLOSE*/
       public void Dong_Man_Hinh_Diem(bool saveProperties)
        {
            if (saveProperties)
            {
                Save_Properties();
                Save_To_File();
                Man_hinh_diem.Dispose();
            }
            else
            {
                Man_hinh_diem.Dispose();
            }
        }

        /*UPDATE*/
       public void Cap_nhat_ten_va_diem(string[] answer_content, string[] time, byte[] ava_tag)
        {
            int i;
            for (i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                name_array[i].Text = answer_content[i];

                circle_img_array[i].BackgroundImage = circle_img_array[ava_tag[i]].BackgroundImage;
            }

            for (i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                score_array[i].Text = time[i];
            }
        }

        /*FILE EVENTS*/
        private bool LoadDataFromFile()
        {
            CreateFileIfNotExist(Cons.DATA_OF_MANHINHDIEM);

            // get data from text file
            string[] jsonData = System.IO.File.ReadAllLines(Cons.DATA_OF_MANHINHDIEM);

            if (jsonData.Length == 0)
            {
                //dữ liệu không tồn tại trong file
                return false;
            }

            // load data into object

            dynamic dataOfAvatar = SerializerOfJson.DeserializeFromJsonFile(jsonData[0], Type.GetType("avatar_properties"));
            dynamic dataOfName = SerializerOfJson.DeserializeFromJsonFile(jsonData[1], Type.GetType("name_properties"));
            dynamic dataOfScore = SerializerOfJson.DeserializeFromJsonFile(jsonData[2], Type.GetType("score_properties"));

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

            foreach (var data in dataOfName)
            {
                name_properties[index].x_axis = data["x_axis"];
                name_properties[index].y_axis = data["y_axis"];

                name_properties[index].width = data["width"];
                name_properties[index].height = data["height"];

                colorStr = data["foreColor"];
                var color = (Color)converter1.ConvertFromString(colorStr);
                name_properties[index].foreColor = color;

                /*Font data có dạng <Tên font>, <Kích thước>pt ==> cần tách thành mảng với 2 phần tử là tên và kích thước*/
                fontStr = data["font"];
                fontProperty = fontStr.Split(',');
                fontProperty[1] = fontProperty[1].Substring(0, fontProperty[1].IndexOf('p'));
                name_properties[index].font = new Font(fontProperty[0], (float)Convert.ToDouble(fontProperty[1]));

                index++;
            }

            index = 0;

            foreach (var data in dataOfScore)
            {
                score_properties[index].x_axis = data["x_axis"];
                score_properties[index].y_axis = data["y_axis"];

                score_properties[index].width = data["width"];
                score_properties[index].height = data["height"];

                /*Font data có dạng <Tên font>, <Kích thước>pt ==> cần tách thành mảng với 2 phần tử là tên và kích thước*/
                fontStr = data["font"];
                fontProperty = fontStr.Split(',');
                fontProperty[1] = fontProperty[1].Substring(0, fontProperty[1].IndexOf('p'));
                score_properties[index].font = new Font(fontProperty[0], (float)Convert.ToDouble(fontProperty[1]));

                colorStr = data["foreColor"];
                var color = (Color)converter1.ConvertFromString(colorStr);
                score_properties[index].foreColor = color;

                index++;
            }
            return true;
        }

        /*CHECK EVENTS*/
        private void CreateFileIfNotExist(string path)
        {
            if (!File.Exists(path))
            {
              FileStream fs = File.Create(path);
                fs.Close();
            }
        }

        private bool CheckDataIfExist()
        {
            if (avatar_properties[0].avatarPath != null && name_properties[0].font != null && score_properties[0].font != null)
            {
                return true;
            }

            if (LoadDataFromFile())
            {
                return true;
            }
            return false;

        }
        #endregion

        #region Save
        private void Save_To_File()
        {
            //clean all text in text file
            File.WriteAllText(Cons.DATA_OF_MANHINHDIEM, String.Empty);

            SerializerOfJson.SerializeToJson(Cons.DATA_OF_MANHINHDIEM, avatar_properties);
            SerializerOfJson.SerializeToJson(Cons.DATA_OF_MANHINHDIEM, name_properties);
            SerializerOfJson.SerializeToJson(Cons.DATA_OF_MANHINHDIEM, score_properties);
        }

        private  void Save_Properties()
        {
            /*save avatar properties*/

            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                avatar_properties[i].x_axis = circle_img_array[i].Location.X;
                avatar_properties[i].y_axis = circle_img_array[i].Location.Y;

                avatar_properties[i].width = circle_img_array[i].Width;
                avatar_properties[i].height = circle_img_array[i].Height;

                avatar_properties[i].avatarPath = circle_img_array[i].Tag.ToString();
            }

            /*save name properties*/
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                name_properties[i].x_axis = name_array[i].Location.X;
                name_properties[i].y_axis = name_array[i].Location.Y;

                name_properties[i].width = name_array[i].Width;
                name_properties[i].height = name_array[i].Height;

                name_properties[i].font = name_array[i].Font;
                name_properties[i].foreColor = name_array[i].ForeColor;
            }

            /*save score properties*/
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                score_properties[i].x_axis = score_array[i].Location.X;
                score_properties[i].y_axis = score_array[i].Location.Y;


                score_properties[i].width = score_array[i].Width;
                score_properties[i].height = score_array[i].Height;

                score_properties[i].font = score_array[i].Font;
                score_properties[i].foreColor = score_array[i].ForeColor;
            }
        }
        #endregion
    }
}
