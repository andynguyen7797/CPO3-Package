using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public partial class Form1 : Form
    {
     
        #region Properties
        private int MalX, MalY, Toggle;

        public string ipV4;
        private NetWork_Manager net_work;       
        private Player_Manager player;
        private SystemLog systemLog;

        private Quan_ly_man_hinh_diem man_hinh_diem_manager;
        private Quan_ly_man_hinh_tra_loi man_hinh_tra_loi_manager;

        private Man_Hinh_Cau_Tra_Loi mhtl_form;
        private Man_Hinh_Diem mhd_form;
        
        #endregion

        #region Init
        
        /*FORM EDGE*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse
         );

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        public Form1()
        {
            InitializeComponent();
          
            Create_Player_manager();

            SystemLog.DeleteAllLogFile();
            systemLog = new SystemLog(this);
        }

        private void Create_Player_manager()
        {
            //tạo 1 list để dễ quản lí các play_control , giúp cho việc sắp xếp và nhận dữ liệu dễ hơn
            List<Player_Control> list_player = new List<Player_Control>();
            list_player.Add(player_Control1);
            list_player.Add(player_Control2);
            list_player.Add(player_Control3);
            list_player.Add(player_Control4);

            player = new Player_Manager(list_player);
            player.Start_Save_Info_Thread();
        }

        #endregion

        #region Move Form
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Toggle = 1;
            MalX = e.X;
            MalY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }

        #endregion

        #region Event

        /*FORM EVENTS*/
        private void close_btt_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //killing all threads is running
                Environment.Exit(0);

                // exit application
                Application.Exit();
            }
        }

        private void minisize_btt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //phân luồng Server          
            Create_Server();
        }

        private void about_author_btt_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Cons.ABOUT_AUTHOR_PAGE_PATH);
            } catch
            {
                MessageBox.Show("Không tìm thấy file html, mở file lưu trữ ...");
                MessageBox.Show("Bùi Quang Đính /n Sdt : 01282773234 /n Email : 2s.1417.0710.1999@gmail.com /n Facebook : https://www.facebook.com/BiQaDi");
            }
        }

        private void ViewLog_btt_Click(object sender, EventArgs e)
        {
            LogForm log = new LogForm();
            log.GetName(player_Control1.name_lb.Text, player_Control2.name_lb.Text, player_Control3.name_lb.Text, player_Control4.name_lb.Text);
            log.ViewLog();
            log.Show();
        }

        /*TOOL TIP*/
        private void Form1_Load(object sender, EventArgs e)
        {
            // time down tool tip
            toolTip.SetToolTip(play_timecount_btt, "Chạy thời gian");
            toolTip.SetToolTip(stop_timecount_btt, "Tạm dừng thời gian");
            toolTip.SetToolTip(set_timeCount_btt, "Thiết lập thời gian");

            // man hinh diem tool tip
            toolTip.SetToolTip(mo_man_hinh_diem, "Mở màn hình hiển thị điểm và tên của từng thí sinh");
            toolTip.SetToolTip(dong_man_hinh_diem, "Đóng màn hình hiển thị điểm và tên thí sinh. Cho phép lưu lại các thuộc tính nếu người điều khiển muốn");
            toolTip.SetToolTip(thiet_lap_thong_so_man_hinh_diem, "Mở cửa sổ thiết lập các thông số như vị trí, kích thước, link ảnh cho màn hình điểm hoặc màn hình trả lời");
            toolTip.SetToolTip(update_name_and_score_btt, "Cập nhật điểm và tên của từng thí sinh, hiển thị nó lên màn hình câu trả lời theo thứ tự");           

            // man hinh tra loi tool tip
            toolTip.SetToolTip(mo_man_hinh_tra_loi, "Mở màn hình hiển thị câu trả lời và thời gian tương ứng của từng thí sinh");
            toolTip.SetToolTip(dong_man_hinh_tra_loi, "Đóng màn hình hiển thị câu trả lời và thời gian. Cho phép lưu lại các thuộc tính nếu người điều khiển muốn");
            toolTip.SetToolTip(thiet_lap_thong_so_man_hinh_cau_tra_loi, "Mở cửa sổ thiết lập các thông số như vị trí, kích thước, link ảnh của màn hình điểm hoặc trả lời");
            toolTip.SetToolTip(update_name_and_score_btt, "Cập nhật câu trả lời và thời gian, hiển thị lên màn hình theo thứ tự");
        }
        /*-------------*/

        /*TIME DOWN EVENTS*/
        private void play_timecount_btt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hãy chắc chắn bạn đã thiết lập thời gian đếm ngược ở textBox bên phải !!! \n Nhấn Yes để tiếp tục \n Nhấn No để quay lại thiết lập thời gian", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                player_Control1.Start_TimeCount();
                player_Control2.Start_TimeCount();
                player_Control3.Start_TimeCount();
                player_Control4.Start_TimeCount();
            }          
        }
 
        private void stop_timecount_btt_Click(object sender, EventArgs e)
        {
            player_Control1.Stop_TimeCount(false);
            player_Control2.Stop_TimeCount(false);
            player_Control3.Stop_TimeCount(false);
            player_Control4.Stop_TimeCount(false);
        }

        private void set_timeCount_btt_Click(object sender, EventArgs e)
        {
            try
            {
                player_Control1.Set_TimeCount((Convert.ToInt32(deadline_tb.Text)));
                player_Control2.Set_TimeCount((Convert.ToInt32(deadline_tb.Text)));
                player_Control3.Set_TimeCount((Convert.ToInt32(deadline_tb.Text)));
                player_Control4.Set_TimeCount((Convert.ToInt32(deadline_tb.Text)));
            }
            catch
            {
                MessageBox.Show("Định dạng không đúng, vui lòng nhập lại", "Thông báo");
            }
        }
        /*---------------*/

        /*PERFORM COUNTER*/

        private void timecount_Tick(object sender, EventArgs e)
        {
            double cpuUsage = Math.Round(performanceCounter.NextValue());

            cpuUsage_lb.Text = "CPU Usage : " + cpuUsage + " %";
            if (cpuUsage < 30)
            {
                cpuUsageColor.BackColor = Cons.CPU_USAGE_NORMAL;
            }
            if (cpuUsage >= 30 && cpuUsage <= 80)
            {
                cpuUsageColor.BackColor = Cons.CPU_USAGE_MEDIUM;
            }
            if (cpuUsage > 80)
            {
                cpuUsageColor.BackColor = Cons.CPU_USAGE_MAXIUM;
            }
        }

        /*----------------*/
        /*MÀN HÌNH ĐIỂM EVENTS*/
        private void mo_man_hinh_diem_Click(object sender, EventArgs e)
        {
            mhd_form = new Man_Hinh_Diem();
            if (man_hinh_diem_manager == null)
            {
                man_hinh_diem_manager = new Quan_ly_man_hinh_diem(mhd_form);
            }
            else
            {
                man_hinh_diem_manager = new Quan_ly_man_hinh_diem(mhd_form, true);
            }
            man_hinh_diem_manager.Mo_Man_Hinh_Diem();

        }

        private void dong_man_hinh_diem_Click(object sender, EventArgs e)
        {
            if (mhd_form == null)
            {
                MessageBox.Show("Bạn chưa mở màn hình điểm lên lần nào", "Thông báo");
                return;
            }
            if (mhd_form.IsDisposed)
            {
                MessageBox.Show("Bạn đã đóng màn hình điểm lại rồi", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có muốn lưu lại các thuộc tính để sử dụng ở lần mở tiếp theo ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                man_hinh_diem_manager.Dong_Man_Hinh_Diem(true);
            }
            else
            {
                man_hinh_diem_manager.Dong_Man_Hinh_Diem(false);
            }
        }

        private void thiet_lap_thong_so_man_hinh_diem_Click(object sender, EventArgs e)
        {
            Man_Hinh_Diem_Va_Tra_Loi_Editter mh_editter = new Man_Hinh_Diem_Va_Tra_Loi_Editter();

            // thiết lập các kết nối tới các control trong màn hình điểm và trả lời
            if(mhd_form == null)
            {
                MessageBox.Show("Màn hình điểm vẫn chưa được mở, vui lòng mở màn hình điểm để tiến hành chỉnh sửa", "Thông báo");
            } else
            {
                mh_editter.Get_Man_Hinh(mhd_form);
                mh_editter.Load_Component_Array();
                mh_editter.Get_Component();
                mh_editter.Show();
            }           
        }

        private void update_name_and_score_btt_Click(object sender, EventArgs e)
        {
            Thread UpdateThread = new Thread(UpdateNameScoreThread);
            UpdateThread.Start();
            update_name_and_score_btt.Enabled = false;
        }

        private void UpdateNameScoreThread()
        {
            while (true)
            {
                try
                {
                    string[] name = new string[] { player_Control1.name_lb.Text,player_Control2.name_lb.Text,
            player_Control3.name_lb.Text,player_Control4.name_lb.Text};

                    string[] score = new string[] { player_Control1.Player_score.ToString(), player_Control2.Player_score.ToString(), player_Control3.Player_score.ToString(), player_Control4.Player_score.ToString() };

                    byte[] tag_avatar = new byte[] { 0, 1, 2, 3 };

                  //  SapXep.Sapxep_Max_To_Min(ref name, ref score, ref tag_avatar);

                    man_hinh_diem_manager.Cap_nhat_ten_va_diem(name, score, tag_avatar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật, có thể câu trả lời hoặc thời gian đang để trống nội dung - chi tiết : " + ex.Message,"Thông báo");
                    MessageBox.Show("Vui lòng nhấn nút cập nhật điểm lần nữa để quá trình tiếp tục", "Thông báo");
                    update_name_and_score_btt.Enabled = true;
                    break;
                }
            }
        }
        /*---------------------*/

        /*MÀN HÌNH TRẢ LỜI EVENTS*/

        private void mo_man_hinh_tra_loi_Click(object sender, EventArgs e)
        {
            mhtl_form = new Man_Hinh_Cau_Tra_Loi();
            if (man_hinh_tra_loi_manager == null)
            {
                man_hinh_tra_loi_manager = new Quan_ly_man_hinh_tra_loi(mhtl_form);
            }
            else
            {
                man_hinh_tra_loi_manager = new Quan_ly_man_hinh_tra_loi(mhtl_form, true);
            }
            man_hinh_tra_loi_manager.Mo_Man_Hinh_Tra_Loi();
        }

        private void dong_man_hinh_tra_loi_Click(object sender, EventArgs e)
        {
            if (mhtl_form == null)
            {
                MessageBox.Show("Bạn chưa mở nó lên lần nào", "Thông báo");
                return;
            }
            if (mhtl_form.IsDisposed)
            {
                MessageBox.Show("Bạn đã đóng lại rồi", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có muốn lưu lại các thuộc tính để sử dụng ở lần mở tiếp theo ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                man_hinh_tra_loi_manager.Dong_Man_Hinh_Tra_Loi(true);
            }
            else
            {
                man_hinh_tra_loi_manager.Dong_Man_Hinh_Tra_Loi(false);
            }
        }

        private void update_answer_and_time_btt_Click(object sender, EventArgs e)
        {
            try
            {
                string[] answer_content = new string[] {player_Control1.name_lb.Text.ToUpper() + "\n" + player_Control1.answer_content.Text,player_Control2.name_lb.Text.ToUpper() + "\n" + player_Control2.answer_content.Text,
            player_Control3.name_lb.Text.ToUpper() + "\n" + player_Control3.answer_content.Text,player_Control4.name_lb.Text.ToUpper() + "\n" + player_Control4.answer_content.Text};

                string[] time = new string[] { player_Control1.time_lb.Text, player_Control2.time_lb.Text, player_Control3.time_lb.Text, player_Control4.time_lb.Text };

                byte[] tag_avatar = new byte[] { 0, 1, 2, 3 };
              //  SapXep.Sapxep_Min_To_Max(ref answer_content,ref time,ref tag_avatar);

                man_hinh_tra_loi_manager.Cap_nhat_diem_va_thoi_gian(answer_content, time, tag_avatar);
                Thread.Sleep(500);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật, có thể câu trả lời hoặc thời gian đang để trống nội dung - chi tiết : " + ex.Message);
            }
        }
        
        private void thiet_lap_thong_so_man_hinh_cau_tra_loi_Click(object sender, EventArgs e)
        {
            Man_Hinh_Diem_Va_Tra_Loi_Editter mh_editter = new Man_Hinh_Diem_Va_Tra_Loi_Editter();

            // thiết lập các kết nối tới các control trong màn hình điểm và trả lời
            if (mhtl_form == null)
            {
                MessageBox.Show("Màn hình trả lời vẫn chưa được mở, vui lòng mở màn hình trả lời để tiến hành chỉnh sửa", "Thông báo");
            }
            else
            {
                mh_editter.Get_Man_Hinh(mhtl_form);
                mh_editter.Load_Component_Array();
                mh_editter.Get_Component();
                mh_editter.Show();
            }
        }
        /*---------------------*/

        /*THÔNG TIN KHỞI TẠO SERVER*/
        private void Create_Server()
        {
            //tạo 1 list để dễ quản lí các play_control , giúp cho việc sắp xếp và nhận dữ liệu dễ hơn
            List<Player_Control> list_player = new List<Player_Control>();
            list_player.Add(player_Control1);
            list_player.Add(player_Control2);
            list_player.Add(player_Control3);
            list_player.Add(player_Control4);

            net_work = new NetWork_Manager();
            //create server
            net_work.Create_Server(list_player);

        }
        /*-------------------------*/

        #endregion
    }
}
