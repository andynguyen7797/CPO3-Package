using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPO3_Editter
{
    public partial class LoginForm : Form
    {
        #region Properties
        private int MalX, MalY, Toggle;      
        private Network_Manager network;
        private Form1 mainForm;
        public static string Ip_receiver;
        #endregion

        #region Init
        public LoginForm()
        {
            InitializeComponent();          
            network = new Network_Manager();
            GetIpToList();
        }

        private void GetIpToList()
        {
            // find all ip address in LAN Network
            foreach(NetworkInterface net in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ipList = net.GetIPProperties();
                foreach(UnicastIPAddressInformation ipAddress in ipList.UnicastAddresses)
                {
                    ipCombobox.Items.Add(ipAddress.Address.ToString());
                }
            }
            
            Filter();
        }

        private void Filter()
        {
            for(int i = 0; i < ipCombobox.Items.Count; i++)
            {
                if (ipCombobox.Items[i].ToString().Contains("::"))
                {
                    ipCombobox.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        #endregion

        #region Events
        private void close_btt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connect_btt_Click(object sender, EventArgs e)
        {
            bool connected = network.Create_Client(ipCombobox.Text,userIndex.SelectedItem.ToString());
            
            if (connected == true)
            {
                mainForm = new Form1();
                //chuyển tới màn hình chính
                mainForm.Show();
                this.Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(connect_btt, "Khởi tạo Clien tới Server");
            toolTip.SetToolTip(ip_may_nhan_lb, "Là ip của server, server kết nối tới ip nào thì máy client phải kết nối tới ip đó");
        }
        #endregion

        #region Move Form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Toggle = 1;
            MalX = e.X;
            MalY = e.Y;
        }
        
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }
        #endregion
    }
}
