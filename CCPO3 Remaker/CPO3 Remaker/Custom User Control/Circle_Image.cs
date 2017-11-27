using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CPO3_Remaker
{
    public partial class Circle_Image : UserControl
    {
        #region Properties
        private GraphicsPath path = new GraphicsPath();
        #endregion

        public Circle_Image()
        {
            InitializeComponent();
            path.AddEllipse(0, 0, this.Width, this.Height);
            
            this.Region = new Region(path);
        }


        private void Circle_Image_Resize(object sender, EventArgs e)
        {
            path.Reset();
            
            if(this.Region != null)
            {
                this.Region.Dispose();
                this.Region = null;
            }

            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);
        }

        private void Circle_Image_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(Pens.White, 0, 0, this.Width, this.Height);

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        }
    }
}
