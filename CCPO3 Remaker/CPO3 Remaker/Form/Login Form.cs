using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace CPO3_Remaker
{
    public partial class Login_Form : Form
    {

        #region Properties
        private int MalX, MalY, Toggle;
        private Form1 f1;
        private NetWork_Manager net_work;
        #endregion

        #region Init
        public Login_Form()
        {
            InitializeComponent();
            net_work = new NetWork_Manager();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion

        #region Methods

        #region Events

        private void close_btt_Click(object sender, EventArgs e)
        {
            Application.Exit(); // đóng chương trình
        }

        private void minisize_btt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // thu nhỏ cửa sổ
        }

        private void local_ipV4_Click(object sender, EventArgs e)
        {
            //tự động xóa chữ trên textbox khi user nhấn
            local_ipV4.Text = "";
        }

        private void login_btt_Click(object sender, EventArgs e)
        {
                Show_MainForm_And_Save_ipV4();
        }

        private void Show_MainForm_And_Save_ipV4()
        {
            if (net_work.Save_IPV4(local_ipV4.Text))
            {
                f1 = new Form1();
                f1.Show();
                this.Hide();
            } else
            {
                return;
            }
            
            
        }

        private void Login_Form_Activated(object sender, EventArgs e)
        {
            //khi form đã được kích hoạt, gửi lời chào tới user          
        }
        #endregion

        #region Move Form
        private void Login_Form_MouseDown(object sender, MouseEventArgs e)
        {
            Toggle = 1;
            MalX = e.X;
            MalY = e.Y;
        }
  
        private void Login_Form_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }

        private void Login_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }
        #endregion

        #endregion
        
    }
}
