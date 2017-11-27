using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public partial class LogForm : Form
    {
        private int MalX, MalY, Toggle;

        public LogForm()
        {
            InitializeComponent();
        }

        #region Methods
        public void ViewLog()
        {
            List<string> logData = new List<string>();
            // load log of User 1
            
            for(int i = 1; i <= Cons.PLAYER_COUNT; i++)
            {
                logData = SystemLog.ViewLog(Cons.LOG_FILE_PATH + i + ".txt");
                LoadDataToListBox(logData, "logOfuser" + i);
                logData.Clear();
            }
        }

        private void LoadDataToListBox(List<string> dataList,string listBoxname)
        {
            ListBox listBox = this.Controls.Find(listBoxname, true).FirstOrDefault() as ListBox;
            if(listBox == null)
            {
                MessageBox.Show("Có lỗi trong việc load dữ liệu vào list box tại LogForm.cs");
                return;
            }

            int count = dataList.Count;
            for(int i = 0; i < count; i++)
            {
                listBox.Items.Add(dataList[i]);
            }
        }

        public void GetName(string userName1,string userName2,string userName3,string userName4)
        {
            nameOfuser1.Text = userName1;
            nameOfuser2.Text = userName2;
            nameOfuser3.Text = userName3;
            nameOfuser4.Text = userName4;
        }

        #endregion

        #region Events
        private void cancel_btt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Move Form

        private void LogForm_MouseDown(object sender, MouseEventArgs e)
        {
            Toggle = 1;
            MalX = e.X;
            MalY = e.Y;
        }

        private void LogForm_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }

        private void LogForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }

        #endregion
    }
}
