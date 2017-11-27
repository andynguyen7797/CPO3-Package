using System;
using System.Windows.Forms;

namespace CPO3_Editter
{
    public partial class Score_Screen : Form
    {
        public Score_Screen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;           
        }

        private void Score_Screen_Resize(object sender, EventArgs e)
        {
            name.Height = this.Height / 4;
            score.Height = (this.Height * 3) / 4;            
        }
    }
}
