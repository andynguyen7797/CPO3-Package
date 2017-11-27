using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace CPO3_Remaker
{
    public partial class Player_Control : UserControl
    {

        #region Properties
        private string avatarPath; // ảnh thí sinh
        public string AvatarPath
        {
            get
            {
                return avatarPath;
            }

            set
            {
                avatarPath = value;
            }
        }

        private string player_name; // tên thí sinh
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

        private int player_score; // điểm hiện tại của thí sinh
        public int Player_score
        {
            get
            {
                return player_score;
            }

            set
            {
                player_score = value;
            }
        }

        private string answer_cnt; // câu trả lời dạng text của thí sinh
        public string Answer_cnt
        {
            get
            {
                return answer_cnt;
            }

            set
            {
                answer_cnt = value;
            }
        }

        private int add_score; // số lượng điểm cộng thêm 
        public int Add_score
        {
            get
            {
                return add_score;
            }

            set
            {
                add_score = value;
            }
        }

        private int isLock; // kiểm tra có khóa màn hình thí sinh không ?
        public int IsLock
        {
            get
            {
                return isLock;
            }

            set
            {
                isLock = value;
            }
        }
      
        private int isLockEdit; // kiểm tra có khóa chỉnh sửa tên trên màn hình thí sinh không ?
        public int IsLockEdit
        {
            get
            {
                return isLockEdit;
            }

            set
            {
                isLockEdit = value;
            }
        }

        private string indexOfUser;
        public string IndexOfUser
        {
            get
            {
                return indexOfUser;
            }

            set
            {
                indexOfUser = value;
            }
        }

       
        private ASCIIEncoding encoding = new ASCIIEncoding();
        private Player_Manager player_manager;
        private double time;
        private double deadline;
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


        public Player_Control()
        {
            InitializeComponent();
            SetBorderOfControl();
            SetDefaultOfProperty();
            player_manager = new Player_Manager(null);
            
        }
           
        private void SetBorderOfControl()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 25, 25));
            this.panelControl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.panelControl.Width, this.panelControl.Height, 25, 25));
        }  
        
        private void SetDefaultOfProperty()
        {
            Player_score = 0;
            Player_name = "NAME";
        }
        #endregion

        #region Methods

        #region Event

        private void plus_btt_Click(object sender, EventArgs e)
        {
            this.Player_score += 10;
            if(Player_score >= 0 && Player_score < 10)
            {
                score_lb.Text = "00" + Player_score;
                return;
            }
            if(Player_score >= 10 && Player_score < 100)
            {
                score_lb.Text = "0" + Player_score;
                return;
            }
            score_lb.Text = Player_score.ToString();
            
       
        }

        private void dec_btt_Click(object sender, EventArgs e)
        {
            this.Player_score -= 10;
            if (Player_score >= 0 && Player_score < 10)
            {
                score_lb.Text = "00" + Player_score;
                return;
            }
            if (Player_score >= 10 && Player_score < 100)
            {
                score_lb.Text = "0" + Player_score;
                return;
            }
            score_lb.Text = Player_score.ToString();
       
          
        }

        private void add_custom_btt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Add_score = Convert.ToInt32(addScore_tb.Text);
                Player_score = Add_score;
                if (Player_score >= 0 && Player_score < 10)
                {
                    score_lb.Text = "00" + Player_score;
                    return;
                }
                if (Player_score >= 10 && Player_score < 100)
                {
                    score_lb.Text = "0" + Player_score;
                    return;
                }
                score_lb.Text = Player_score.ToString();
               
            } catch (Exception ex)
            {
                MessageBox.Show("Không nhập đúng định dạng !!! : " + ex.Message);
                return;
            }
        }

        private void settings_btt_Click(object sender, EventArgs e)
        {
            Set_Screen set_screen_form = new Set_Screen();
            set_screen_form.Show();
        }

        private void addScore_tb_Click(object sender, EventArgs e)
        {
            addScore_tb.Text = "";
        }

        private void player_ava_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    player_ava.BackgroundImage = Image.FromFile(file.InitialDirectory + file.FileName);
                    AvatarPath = file.InitialDirectory + file.FileName;
                }
                catch
                {
                    MessageBox.Show("File ảnh không đúng định dạng", "Thông báo");
                }
            }
        }

        #endregion

        #region Methods
    
        /*EFFECT METHODS*/
        /// <summary>
        /// Hoạt động của chuông khi được nhận
        /// </summary>
        public void Alarm_Activity()
        {
            BackGround_flicker();
            Play_Alarm_Sound();
        }

        private void BackGround_flicker()
        {
            /* nếu nhận được chuông, nền đổi màu */

                this.BackColor = Color.FromArgb(231,76,60);
                System.Threading.Thread.Sleep(500);
                this.BackColor = Color.FromArgb(236, 240, 241);
                Application.DoEvents();
        }

        private void Play_Alarm_Sound()
        { 
            try
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                sound.SoundLocation = Cons.ALARM_SOUND_PATH;
                sound.Play();
            } catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong việc chạy âm thanh chuông !!! : " + ex.Message);
            }
        }

        /*SET DEFAULT IF CLIENT EXIT*/
        /// <summary>
        /// Thiết lập các mặc định khi client out ra
        /// </summary>
        public void SetDefault()
        {
            this.Tag = "NULL";
            name_lb.Text = "NAME";
            score_lb.Text = "000";
            this.Player_score = 0;
            this.Player_name = "NAME";
            this.time_lb.Text = "0.0";
            player_ava.BackgroundImage = Image.FromFile(Cons.DEFAULT_USER_LOGO_PATH);
            AvatarPath = Cons.DEFAULT_USER_LOGO_PATH;
            this.Enabled = false;
        }

        /*SET DATA*/
        public void SetAnswerContent(string answerContent)
        {
            if(answerContent != "")
            {
                answer_content.Text = answerContent;
            } else
            {
                answer_content.Text = "UNKNOWN ANWER";
            }
            
        }

        public void SetName(string name)
        {
            if(name != "")
            {
                name_lb.Text = name;
                Player_name = name;
            } else
            {
                name_lb.Text = "NAME";
                Player_name = "NAME";
            }
            
        }

        public void SetBackClrToChecked(Color color,string lockName)
        {
            if(lockName == "LockButton")
            {
                lock_btt.BackColor = color;
            }
            if(lockName == "LockEditButton")
            {
                lock_user_edit_btt.BackColor = color;
            }
        }

        /*TIME EVENTS*/
        public void Set_TimeCount(int deadline)
        {
            time = 0;
            time_lb.Text = "000";
            answer_content.Text = "";
            timecount_player.Stop();
            time_count_progressbar.Value = 0;
            this.deadline = deadline*100;
            time_count_progressbar.Maximum = 100;           
            
        }

        public void Start_TimeCount()
        {
            timecount_player.Start();
        }

        public void Stop_TimeCount(bool stop_From_player)
        {
            if (stop_From_player) {
                time_lb.Text = (time / 100.0).ToString();
            } else
            {
                time_count_progressbar.Step = 0;
                timecount_player.Stop();
            } 
        }

        private void timecount_player_Tick(object sender, EventArgs e)
        {
            if (time >= deadline)
            {            
                timecount_player.Stop();
                return;
            }
            time += 10;
            time_count_progressbar.Value = Convert.ToInt32((((time)/deadline)*100));
            time_count_progressbar.PerformStep();           
        }
                
        /*SET EVENTS TO BUTTON*/
        public void SetEventToPlusBtt(EventHandler events,bool add)
        {
            if(add)
            {
                plus_btt.Click += events;
            } else
            {
                plus_btt.Click -= events;
            }       
        }

        public void SetEventToDecBtt(EventHandler events,bool add)
        {
            if (add)
            {
                dec_btt.Click += events;
            } else
            {
                dec_btt.Click -= events;
            }
        
        }

        public void SetEventToAddCustomBtt(EventHandler events,bool add)
        {
            if (add)
            {
                add_custom_btt.Click += events;
            } else
            {
                add_custom_btt.Click -= events;
            }
            
        }

        public void SetEventToLockControlBtt(EventHandler events,bool add)
        {
            if (add)
            {
                lock_btt.Click += events;
            } else
            {
                lock_btt.Click -= events;
            }
           
        }

        public void SetEventToLockEditBtt(EventHandler events,bool add)
        {
            if (add)
            {
                lock_user_edit_btt.Click += events;
            } else
            {
                lock_user_edit_btt.Click -= events;
            }
            
        }
        #endregion

        #endregion

    }
}
