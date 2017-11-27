using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public partial class horizontalLine : UserControl
    {
        public horizontalLine()
        {
            InitializeComponent();
        }

        private void horizontalLine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Pen myPen = new Pen(new SolidBrush(Color.White));
            g.DrawLine(myPen, this.Width/2, 0, this.Width/2, this.Height);
        }
    }
}
