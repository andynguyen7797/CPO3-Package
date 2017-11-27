using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPO3_Editter
{
    public partial class line : UserControl
    {
        public line()
        {
            InitializeComponent();
        }

        private void line_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Pen myPen = new Pen(new SolidBrush(Color.White));
            g.DrawLine(myPen, 0, this.Height / 2, this.Width, this.Height / 2);
        }
    }
}
