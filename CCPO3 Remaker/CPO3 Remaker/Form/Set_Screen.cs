using System;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public partial class Set_Screen : Form
    {
        private Set_Screen_Properties screen_class;
        private int MalX, MalY, Toggle;

        public Set_Screen()
        {
            InitializeComponent();
            screen_class = new Set_Screen_Properties(this);
        }

        #region Events
        private void set_font_player_btt_Click(object sender, EventArgs e)
        {            
            screen_class.Set_Font_Player_Properties();
        }

        private void set_font_score_btt_Click(object sender, EventArgs e)
        {
            screen_class.Set_Font_Score_Properties();
        }

        private void cancel_btt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Apply_btt_Click(object sender, EventArgs e)
        {           
          screen_class.Apply_Settings();         
        }

        private void Set_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Set_Screen_Properties.Data_arr = new byte[0];
            Set_Screen_Properties.Clear_Data_Review();
        }

        private void Set_Screen_Shown(object sender, EventArgs e)
        {
            ScreenSettingsLog.ReShow_Log_Data(log_tb);
        }

        private void color_top_screen_ColorChanged(object sender, EventArgs e)
        {
            topPanelColor.BackColor = color_top_screen.Color;
        }

        private void color_bottom_screen_ColorChanged(object sender, EventArgs e)
        {
            bottomPanelcolor.BackColor = color_bottom_screen.Color;
        }
        #endregion

        #region Move Form

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Toggle = 1;
            MalX = e.X;
            MalY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }

        #endregion

    }
}
