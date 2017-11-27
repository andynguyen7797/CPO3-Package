using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public partial class Ava_Editter : UserControl
    {
        #region Properties
        private Form form;
        private Circle_Image control;
        private int Toggle, malX, malY;
        #endregion

        #region Init
        public Ava_Editter()
        {
            InitializeComponent();
        }

        public void Get_Component(Form man_hinh,string control_name)
        {
            this.form = man_hinh;

            control = this.form.Controls.Find(control_name, true).FirstOrDefault() as Circle_Image;

            if(control == null)
            {
                MessageBox.Show("Lỗi trong việc tìm tên biến, vui lòng mở source code để kiểm tra !", "Thông báo");
            }

        }
    
        #endregion

        #region Events

        /*OTHER EVENTS*/
        private void browse_btt_Click(object sender, EventArgs e)
        {

                OpenFileDialog file = new OpenFileDialog();

                if (file.ShowDialog() == DialogResult.OK)
                {
                    // show image on avatar
                    control.BackgroundImage = Image.FromFile(file.InitialDirectory + file.FileName);
                    control.BackgroundImageLayout = ImageLayout.Stretch;
                    control.Tag = file.InitialDirectory + file.FileName;
                    
                    //show image on avatar review
                    avatar_review.BackgroundImage = Image.FromFile(file.InitialDirectory + file.FileName);
                    avatar_review.BackgroundImageLayout = ImageLayout.Stretch;
                }         
        }

        private void radius_TextChanged(object sender, EventArgs e)
        {
            int radius_value;
            if (radius.Text == null)
            {
                return;
            }

            if (int.TryParse(radius.Text, out radius_value))
            {
                control.Width = radius_value;
                control.Height = radius_value;
            }
        }

        /*MAIN EVENTS*/
        public void set_radius_in_main(string value)
        {
            int radius_value;
            if (value == null)
            {          
                return;
            }

            if (int.TryParse(value, out radius_value))
            {
                control.Width = radius_value;
                control.Height = radius_value;
            }
        }

        public void SetVisible(bool isVisible)
        {
            control.Visible = isVisible;
        }

        /*----------------*/

        /*MOVE CONTROL BY HAND EVENTS BUTTON*/

        private void up_btt_Click(object sender, EventArgs e)
        {
            int step;
            if(int.TryParse(step_tb.Text,out step))
            {
                step = int.Parse(step_tb.Text);
                Control_Location(1, step);
            } else
            {
                step = 1;
                Control_Location(1, step);
            }
            
        }

        private void down_btt_Click(object sender, EventArgs e)
        {
            int step;
            if (int.TryParse(step_tb.Text, out step))
            {
                step = int.Parse(step_tb.Text);
                Control_Location(2, step);
            }
            else
            {
                step = 1;
                Control_Location(2, step);
            }

        }

        private void left_btt_Click(object sender, EventArgs e)
        {
            int step;
            if (int.TryParse(step_tb.Text, out step))
            {
                step = int.Parse(step_tb.Text);
                Control_Location(3, step);
            }
            else
            {
                step = 1;
                Control_Location(3, step);
            }

        }

        private void right_btt_Click(object sender, EventArgs e)
        {
            int step;
            if (int.TryParse(step_tb.Text, out step))
            {
                step = int.Parse(step_tb.Text);
                Control_Location(4, step);
            }
            else
            {
                step = 1;
                Control_Location(4, step);
            }
        }
  
        private void Control_Location(int location_key, int step)
        {
            switch (location_key)
            {
                case 1:
                    {
                        // UP
                        if (control.Location.Y - step < 0)
                        {
                            MessageBox.Show("Đã đến rìa của form", "Thông báo");
                        }
                        else
                        {
                            control.Location = new Point(control.Location.X, control.Location.Y - step);
                        }
                        break;
                    }

                case 2:
                    {
                        //DOWN
                        if (control.Location.Y + step > form.Height)
                        {
                            MessageBox.Show("Đã đến rìa của form", "Thông báo");
                        }
                        else
                        {
                            control.Location = new Point(control.Location.X, control.Location.Y + step);
                        }
                        break;
                    }
                case 3:
                    {
                        //LEFT
                        if (control.Location.X - step < 0)
                        {
                            MessageBox.Show("Đã đến rìa của form", "Thông báo");
                        }
                        else
                        {
                            control.Location = new Point(control.Location.X - step, control.Location.Y);
                        }
                        break;
                    }
                case 4:
                    {
                        //RIGHT
                        if (control.Location.X + step > form.Width)
                        {
                            MessageBox.Show("Đã đến rìa của form", "Thông báo");
                        }
                        else
                        {
                            control.Location = new Point(control.Location.X + step, control.Location.Y);
                        }
                        break;
                    }
            }
        }

        private void Control_By_Hand()
        {
            control.MouseDown -= Mouse_Down;
            control.MouseUp -= Mouse_Up;
            control.MouseMove -= Mouse_Move;
        }

        /*------------------------------------*/

        /*MOVE CONTROL BY CURSOR*/

        private void Control_Location_By_Cursor()
        {
            control.MouseDown += Mouse_Down;
            control.MouseUp += Mouse_Up;
            control.MouseMove += Mouse_Move;
        }

        private void Mouse_Down(object sendew, MouseEventArgs e)
        {
            Toggle = 1;
            malX = e.X;
            malY = e.Y;
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (Toggle == 1)
            {
                control.Left = e.X + control.Left - malX;
                control.Top = e.Y + control.Top - malY;
            }
        }

        /*------------------*/

        /*EDIT OPTIONS*/
        private void edit_by_hand_option_Click(object sender, EventArgs e)
        {
            edit_by_hand();
        }

        private void edit_by_cursor_option_Click(object sender, EventArgs e)
        {
            edit_by_cursor();
        }

        private void switchPicture_Toggled(object sender, EventArgs e)
        {
            control.Visible = switchPicture.IsOn;
        }

        public void edit_by_hand()
        {
            edit_by_hand_option.Checked = true;
            edit_by_cursor_option.Checked = false;
            controllerPositionPanel.Enabled = true;

            Control_By_Hand();
        }

        public void edit_by_cursor()
        {
            
            edit_by_cursor_option.Checked = true;
            edit_by_hand_option.Checked = false;
            controllerPositionPanel.Enabled = false;

            Control_Location_By_Cursor();
        }

        /*---------------*/
        #endregion

    }
}

