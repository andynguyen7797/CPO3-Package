using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public partial class AnswerContent_Editter : UserControl
    {
        #region Const
        private const byte CONTENT = 0;
        private const byte CONTENT_PHU = 1;
        #endregion

        #region Properties
        private Form form;

        private TextBox content;
        private Label content_phu;

        private byte key;
        private int Toggle, malX, malY;
        #endregion

        #region Init

        public AnswerContent_Editter()
        {       
            InitializeComponent();
        }

        public void Get_Component(Form man_hinh, string control_name, byte key)
        {
            this.key = key;
            form = man_hinh;
                       
            if (key == CONTENT)
            {
                content = this.form.Controls.Find(control_name, true).FirstOrDefault() as TextBox;
                
            }
            if (key == CONTENT_PHU)
            {
                content_phu = this.form.Controls.Find(control_name, true).FirstOrDefault() as Label;
            }
        }
        
        #endregion

        #region Events

        /*OTHER EVENTS*/
        private void width_tb_TextChanged(object sender, EventArgs e)
        {
            int width;

            if (int.TryParse(width_tb.Text, out width))
            {
                width = int.Parse(width_tb.Text);
            }
            else
            {
                MessageBox.Show("Định dạng kích thước không đúng, vui lòng nhập lại !!!", "Thông báo");
                return;
            }

            if (key == CONTENT)
            {
                // content
                content.Width = width;
            }
            if (key == CONTENT_PHU)
            {
                //content_phu
                content_phu.Width = width;
            }
        }

        private void heigth_tb_TextChanged(object sender, EventArgs e)
        {
            int height;

            if (int.TryParse(heigth_tb.Text, out height))
            {
                height = int.Parse(heigth_tb.Text);
            }
            else
            {
                MessageBox.Show("Định dạng kích thước không đúng, vui lòng nhập lại !!!", "Thông báo");
                return;
            }

            if (key == CONTENT)
            {
                // content
                content.Height = height;
            }
            if (key == CONTENT_PHU)
            {
                //content_phu
                content_phu.Height = height;
            }
        }

        private void openFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;

            if (font.ShowDialog() == DialogResult.OK)
            {
                if (key == CONTENT)
                {
                    content.Font = font.Font;
                    content.ForeColor = font.Color;
                }
                if (key == CONTENT_PHU)
                {
                    content_phu.Font = font.Font;
                    content_phu.ForeColor = font.Color;
                }
            }
        }

        private void change_background_color_EditValueChanged(object sender, EventArgs e)
        {
            if (key == CONTENT)
            {
                content.BackColor = change_background_color.Color;
            }
            if (key == CONTENT_PHU)
            {
                content_phu.BackColor = change_background_color.Color;
            }
        }

        private void onoffLabel_Toggled(object sender, EventArgs e)
        {
            if (key == CONTENT)
            {
                content.Visible = onoffLabel.IsOn;
            }

            if (key == CONTENT_PHU)
            {
                content_phu.Visible = onoffLabel.IsOn;
            }
           
        }
        
       
        /*MOVE CONTROL BY HAND EVENTS*/

        private void up_btt_Click(object sender, EventArgs e)
        {
            int step;
            if (int.TryParse(step_tb.Text, out step))
            {
                step = int.Parse(step_tb.Text);
                Control_Location(1, step);
            }
            else
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
            if (key == CONTENT)
            {
                #region Answer Content Move
                switch (location_key)
                {
                    case 1:
                        {
                            // UP
                            if (content.Location.Y - step < 0)
                            {
                                MessageBox.Show("Đã đến rìa của form", "Thông báo");
                            }
                            else
                            {
                                content.Location = new Point(content.Location.X, content.Location.Y - step);
                            }
                            break;
                        }

                    case 2:
                        {
                            //DOWN
                            if (content.Location.Y + step > form.Height)
                            {
                                MessageBox.Show("Đã đến rìa của form", "Thông báo");
                            }
                            else
                            {
                                content.Location = new Point(content.Location.X, content.Location.Y + step);
                            }
                            break;
                        }
                    case 3:
                        {
                            //LEFT
                            if (content.Location.X - step < 0)
                            {
                                MessageBox.Show("Đã đến rìa của form", "Thông báo");
                            }
                            else
                            {
                                content.Location = new Point(content.Location.X - step, content.Location.Y);
                            }
                            break;
                        }
                    case 4:
                        {
                            //RIGHT
                            if (content.Location.X + step > form.Width)
                            {
                                MessageBox.Show("Đã đến rìa của form", "Thông báo");
                            }
                            else
                            {
                                content.Location = new Point(content.Location.X + step, content.Location.Y);
                            }
                            break;
                        }
                }
                #endregion
            }
            if (key == CONTENT_PHU)
            {
                #region content_phu Move
                switch (location_key)
                {
                    case 1:
                        {
                            // UP
                            if (content_phu.Location.Y - step < 0)
                            {
                                MessageBox.Show("Đã đến rìa của form", "Thông báo");
                            }
                            else
                            {
                                content_phu.Location = new Point(content_phu.Location.X, content_phu.Location.Y - step);
                            }
                            break;
                        }

                    case 2:
                        {
                            //DOWN
                            if (content_phu.Location.Y + step > form.Height)
                            {
                                MessageBox.Show("Đã đến rìa của form", "Thông báo");
                            }
                            else
                            {
                                content_phu.Location = new Point(content_phu.Location.X, content_phu.Location.Y + step);
                            }
                            break;
                        }
                    case 3:
                        {
                            //LEFT
                            if (content_phu.Location.X - step < 0)
                            {
                                MessageBox.Show("Đã đến rìa của form", "Thông báo");
                            }
                            else
                            {
                                content_phu.Location = new Point(content_phu.Location.X - step, content_phu.Location.Y);
                            }
                            break;
                        }
                    case 4:
                        {
                            //RIGHT
                            if (content_phu.Location.X + step > form.Width)
                            {
                                MessageBox.Show("Đã đến rìa của form", "Thông báo");
                            }
                            else
                            {
                                content_phu.Location = new Point(content_phu.Location.X + step, content_phu.Location.Y);
                            }
                            break;
                        }
                }
                #endregion
            }

        }

        private void Control_By_Hand()
        {
            if (key == CONTENT)
            {
                content.MouseDown -= Mouse_Down;
                content.MouseUp -= Mouse_Up;
                content.MouseMove -= Mouse_Move;
            }
            if (key == CONTENT_PHU)
            {
                content_phu.MouseDown -= Mouse_Down;
                content_phu.MouseUp -= Mouse_Up;
                content_phu.MouseMove -= Mouse_Move;
            }
        }

        /*MOVE CONTROL BY CURSOR*/

        private void Control_Location_By_Cursor()
        {
            if (key == CONTENT)
            {
                content.MouseDown += Mouse_Down;
                content.MouseUp += Mouse_Up;
                content.MouseMove += Mouse_Move;
            }
            if (key == CONTENT_PHU)
            {
                content_phu.MouseDown += Mouse_Down;
                content_phu.MouseUp += Mouse_Up;
                content_phu.MouseMove += Mouse_Move;
            }
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
            if (key == CONTENT)
            {
                if (Toggle == 1)
                {
                    content.Left = e.X + content.Left - malX;
                    content.Top = e.Y + content.Top - malY;
                }
            }
            if (key == CONTENT_PHU)
            {
                if (Toggle == 1)
                {
                    content_phu.Left = e.X + content_phu.Left - malX;
                    content_phu.Top = e.Y + content_phu.Top - malY;
                }
            }


        }

        /*EDIT OPTIOPS*/

        private void edit_by_cursor_option_Click(object sender, EventArgs e)
        {
            edit_by_cursor();
        }

        private void edit_by_hand_option_Click(object sender, EventArgs e)
        {
            edit_by_hand();
        }

        public void edit_by_cursor()
        {
            edit_by_cursor_option.Checked = true;
            edit_by_hand_option.Checked = false;
            controllerPositionPanel.Enabled = false;

            Control_Location_By_Cursor();
        }

        public void edit_by_hand()
        {
            edit_by_hand_option.Checked = true;
            edit_by_cursor_option.Checked = false;
            controllerPositionPanel.Enabled = true;

            Control_By_Hand();
        }

        #endregion

        #region Methods
        /*MAIN EVENTS*/
        public void width_in_Main(string value)
        {
            int width;

            if (value == null) return;
            if (int.TryParse(value, out width))
            {
                width = int.Parse(value);
            }
            else
            {
                return;
            }

            if (key == CONTENT)
            {
                // content
                content.Width = width;
            }
            if (key == CONTENT_PHU)
            {
                //content_phu
                content_phu.Width = width;
            }
        }

        public void height_in_Main(string value)
        {
            int height;

            if (value == null) return;
            if (int.TryParse(value, out height))
            {
                height = int.Parse(value);
            }
            else
            {
                return;
            }

            if (key == CONTENT)
            {
                // content
                content.Height = height;
            }
            if (key == CONTENT_PHU)
            {
                //content_phu
                content_phu.Height = height;
            }
        }

        public void SetVisible(bool isVisible)
        {
            if (key == CONTENT)
            {
                content.Visible = isVisible;
            }
            if (key == CONTENT_PHU)
            {
                content_phu.Visible = isVisible;
            }
        }

        public void SetFont(Font font,Color fontColor)
        {
                if (key == CONTENT)
                {
                    content.Font = font;
                    content.ForeColor = fontColor;
                }
                if (key == CONTENT_PHU)
                {
                    content_phu.Font = font;
                    content_phu.ForeColor = fontColor;
                }          
        }

        public void SetBackColor(Color backcolor)
        {
            if (key == CONTENT)
            {
                content.BackColor = backcolor;
            }
            if (key == CONTENT_PHU)
            {
                content_phu.BackColor = backcolor;
            }
        }
        #endregion
    }
}
