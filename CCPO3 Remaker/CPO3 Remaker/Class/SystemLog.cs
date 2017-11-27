using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public class SystemLog
    {
        private Form1 mainForm;
        public Form1 MainForm
        {
            get
            {
                return mainForm;
            }

            set
            {
                mainForm = value;
            }
        }
        private Player_Control[] listUser;  

        #region Init

        public SystemLog(Form1 mainForm)
        {
            this.MainForm = mainForm;
            InitSystemLog();
        }

        private void InitSystemLog()
        {
            AddUserToList();
            AddListenEvent();   
        }

        private void AddUserToList()
        {
            listUser = new Player_Control[Cons.PLAYER_COUNT];

            listUser[0] = MainForm.player_Control1;
            listUser[1] = MainForm.player_Control2;
            listUser[2] = MainForm.player_Control3;
            listUser[3] = MainForm.player_Control4;
        }

        private void AddListenEvent()
        {
            // USER
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                listUser[i].add_custom_btt.Click += CustomScoreEvent;
                listUser[i].dec_btt.Click += SubScoreEvent;
                listUser[i].plus_btt.Click += AddScoreEvent;

                listUser[i].name_lb.TextChanged += UserNameHasChange;
                listUser[i].BackColorChanged += ReceiveAlarm;
                listUser[i].answer_content.TextChanged += ReceiveAnswer;
                listUser[i].lock_user_edit_btt.Click += LockUserEdit;
            }

        }

        #endregion

        #region Events

        public void AddScoreEvent(object sender, EventArgs e)
        {
            Control Button = sender as Control;           
            //Get Parent
            Control Parent = Button.Parent;         
            //Get Parent Of Parent
            Control ParentOfParent = Parent.Parent;      
            Player_Control user = ParentOfParent as Player_Control;        
            WriteLog(user.name_lb.Text + " vừa được cộng 10 điểm " + WriteTimeNow(), user.IndexOfUser);
        }

        public void SubScoreEvent(object sender, EventArgs e)
        {
            Control Button = sender as Control;
            //Get Parent
            Control Parent = Button.Parent;
            //Get Parent Of Parent
            Control ParentOfParent = Parent.Parent;
            Player_Control user = ParentOfParent as Player_Control;
            WriteLog(user.name_lb.Text + " vừa bị trừ 10 điểm " + WriteTimeNow(), user.IndexOfUser);
        }

        public void CustomScoreEvent(object sender, EventArgs e)
        {
            Control Button = sender as Control;
            //Get Parent
            Control Parent = Button.Parent;
            //Get Parent Of Parent
            Control ParentOfParent = Parent.Parent;
            Player_Control user = ParentOfParent as Player_Control;
            int scoreHasChange;
            if (user.addScore_tb.Text == "" || int.TryParse(user.addScore_tb.Text, out scoreHasChange) == false)
            {
                return;
            }
            WriteLog(user.name_lb.Text + " vừa được thay đổi thành " + scoreHasChange + " điểm " + WriteTimeNow(), user.IndexOfUser);
        }

        public void UserNameHasChange(object sender, EventArgs e)
        {
            Control Button = sender as Control;
            //Get Parent
            Control Parent = Button.Parent;
            Player_Control user = Parent as Player_Control;
            WriteLog("Vừa được thay đổi thành : " + user.name_lb.Text + WriteTimeNow(), user.IndexOfUser);
        }

        public void SubmitMode(object sender, EventArgs e)
        {
            Control Button = sender as Control;
            //Get Parent
            Control Parent = Button.Parent;
            //Get Parent Of Parent
            Control ParentOfParent = Parent.Parent;
            //Get Parent Of Paren Of Parent
            Control ParentOfParentOfParent = ParentOfParent.Parent;
            //Get Parent Of Paren Of Parent Of Parent
            Control ParentOfParentOfParentOfParent = ParentOfParentOfParent.Parent;
            Player_Control user = ParentOfParentOfParentOfParent as Player_Control;
            if (user.IsLock == 1)
            {
                WriteLog(user.name_lb.Text + " đã bị khóa chế độ nộp " + WriteTimeNow(), user.IndexOfUser);
            } 
            if(user.IsLock == 0)
            {
                WriteLog(user.name_lb.Text + " đã được mở khóa chế độ nộp " + WriteTimeNow(), user.IndexOfUser);
            }
            
        }

        public void ReceiveAlarm(object sender, EventArgs e) {
            Player_Control user = sender as Player_Control;
            WriteLog(user.name_lb.Text + " vừa gửi chuông " + WriteTimeNow(), user.IndexOfUser);
        }

        public void ReceiveAnswer(object sender, EventArgs e)
        {
            Control Button = sender as Control;
            //Get Parent
            Control Parent = Button.Parent;
            //Get Parent Of Parent
            Control ParentOfParent = Parent.Parent;
            Player_Control user = ParentOfParent as Player_Control;
            WriteLog(user.name_lb.Text + " vừa trả lời : " + user.answer_content.Text + WriteTimeNow(), user.IndexOfUser);            
        }
        
        public void LockUserEdit(object sender, EventArgs e)
        {
            Control Button = sender as Control;
            //Get Parent
            Control Parent = Button.Parent;
            //Get Parent Of Parent
            Control ParentOfParent = Parent.Parent;
            //Get Parent Of Paren Of Parent
            Control ParentOfParentOfParent = ParentOfParent.Parent;
            //Get Parent Of Paren Of Parent Of Parent
            Control ParentOfParentOfParentOfParent = ParentOfParentOfParent.Parent;
            Player_Control user = ParentOfParentOfParentOfParent as Player_Control;
            if (user.IsLockEdit == 1)
            {
                WriteLog(user.name_lb.Text + " vừa bị khóa chỉnh sửa từ máy chủ " + WriteTimeNow(), user.IndexOfUser);
            }

            if(user.IsLockEdit == 0)
            {
                WriteLog(user.name_lb.Text + " vừa được mở khóa chỉnh sửa từ máy chủ " + WriteTimeNow(),user.IndexOfUser);
            }
           
        }
        #endregion

        #region Methods

        public static List<string> ViewLog(string filePath)
        {
            List<string> logList = new List<string>();
            if (!File.Exists(filePath))
            {
                logList.Add("Không load được file Log");
                logList.Add("Đường dẫn không tồn tại : " + filePath);
                return logList;
            }
            logList = File.ReadAllLines(filePath).ToList();
            return logList;
        }
        #endregion

        #region Log

        private void WriteLog(string logMessage,string index)
        {
            string filePath = Cons.LOG_FILE_PATH + index + ".txt";
            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(Cons.LOG_FILE_PATH + index + ".txt");
                fs.Close();
            }
            try
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine(logMessage);
                sw.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Có lỗi trong việc ghi file Log : " + ex.Message);
            }
            // Thread writeLog = new Thread(() => {
            //    var dataText = File.ReadAllLines(filePath).ToList();
            //    int curPos = 0;
            //    for(int i = 0; i < dataText.Count; i++)
            //     {
            //         curPos++;
            //         if (dataText[i] == userControlname) break;
            //     }             
            //     dataText.Insert(curPos, "*" + logMessage + "*");
            //     File.WriteAllLines(filePath, dataText.ToArray());       
            //});
            //writeLog.Start();
        }

        private string WriteTimeNow()
        {
            DateTime now = DateTime.Now;
            return "[" + now.Hour + "h:" + now.Minute + "p:" + now.Second + "s:" + now.Millisecond + "ms]";
        }

        public static void DeleteAllLogFile()
        {
            try
            {
                File.WriteAllText(Cons.LOG_FILE_PATH + "1.txt", String.Empty);
                File.WriteAllText(Cons.LOG_FILE_PATH + "2.txt", String.Empty);
                File.WriteAllText(Cons.LOG_FILE_PATH + "3.txt", String.Empty);
                File.WriteAllText(Cons.LOG_FILE_PATH + "4.txt", String.Empty);
            } catch(Exception ex)
            {
                MessageBox.Show("Có lỗi trong việc clear file log : " + ex.Message);
            }
        }
        #endregion

    }
}
