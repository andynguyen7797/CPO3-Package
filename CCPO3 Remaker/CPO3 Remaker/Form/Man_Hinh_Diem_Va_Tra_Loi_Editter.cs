using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public partial class Man_Hinh_Diem_Va_Tra_Loi_Editter : Form
    {
        #region Properties
        private int MalX, MalY, Toggle;
        private Form form;

        // man hinh
        private Ava_Editter[] ava_array;
        private AnswerContent_Editter[] content_array;
        private AnswerContent_Editter[] content_phu_array;

        #endregion

        #region Init

        public Man_Hinh_Diem_Va_Tra_Loi_Editter()
        {
            InitializeComponent();
        }

        public void Get_Man_Hinh(Form man_hinh)
        {
            form = man_hinh;
            
            if(form.Name == "Man_Hinh_Cau_Tra_Loi")
            {
                
              slide1.Text = "A N S W E R";
              slide2.Text = "T I M E";

              TimeLabelMain_Panel.Text = "Time";
                AnswerLabelMain_Panel.Text = "Answer";
            }
            
            if(form.Name == "Man_Hinh_Diem")
            {
               slide1.Text = "N A M E";
               slide2.Text = "S C O R E";

               TimeLabelMain_Panel.Text = "Score";
               AnswerLabelMain_Panel.Text = "Name";
            }
        }

        #endregion

        #region Methods

        /*GET COMPONENT*/
 
        public void Get_Component()
        {
            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {              
                ava_array[i].Get_Component(form, "ava_" + (i + 1));
                content_array[i].Get_Component(form, "content_tb_" + (i + 1), 0);
                content_phu_array[i].Get_Component(form, "content_phu_" + (i + 1), 1);
            }
        }

        /*-------------*/

        /*LOAD COMPONENT*/

        public void Load_Component_Array()
        {
            /* Tải lên các thuộc tính cho màn hình - đưa các thành phần vào mảng để dễ quản lí*/

            // Init
            ava_array = new Ava_Editter[Cons.PLAYER_COUNT];
            content_array = new AnswerContent_Editter[Cons.PLAYER_COUNT];
            content_phu_array = new AnswerContent_Editter[Cons.PLAYER_COUNT];

            // Load
            ava_array[0] = ava_Editter1;
            ava_array[1] = ava_Editter2;
            ava_array[2] = ava_Editter3;
            ava_array[3] = ava_Editter4;

            content_array[0] = answerContent_Editter1;
            content_array[1] = answerContent_Editter2;
            content_array[2] = answerContent_Editter3;
            content_array[3] = answerContent_Editter4;

            content_phu_array[0] = time_editter_1;
            content_phu_array[1] = time_editter_2;
            content_phu_array[2] = time_editter_3;
            content_phu_array[3] = time_editter_4;
        }

        /*GET BACKGROUND*/
        public void Get_Background(Image image)
        {
            form.BackgroundImage = image;
        }
        /*----------------*/

        #endregion

        #region Events

        #region Form Events
        /*CLOSE FORM*/
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Move Form
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Toggle = 0;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Toggle = 1;
            MalX = e.X;
            MalY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Toggle == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MalX, MousePosition.Y - MalY);
            }
        }
        #endregion

        #endregion

        #region Change Silde
        private void slide1_Click(object sender, EventArgs e)
        {
            slide1Panel.BringToFront();

            slide2.BackColor = Color.FromArgb(27, 32, 40);
            slide1.BackColor = Color.FromArgb(44, 62, 80);
            slide3.BackColor = Color.FromArgb(27, 32, 40);
            slide4.BackColor = Color.FromArgb(27, 32, 40);
        }

        private void slide2_Click(object sender, EventArgs e)
        {
            slide2Panel.BringToFront();

            slide1.BackColor = Color.FromArgb(27, 32, 40);
            slide2.BackColor = Color.FromArgb(44, 62, 80);
            slide3.BackColor = Color.FromArgb(27, 32, 40);
            slide4.BackColor = Color.FromArgb(27, 32, 40);
        }

        private void slide3_Click(object sender, EventArgs e)
        {
            slide3Panel.BringToFront();

            slide1.BackColor = Color.FromArgb(27, 32, 40);
            slide2.BackColor = Color.FromArgb(27, 32, 40);
            slide3.BackColor = Color.FromArgb(44, 62, 80);
            slide4.BackColor = Color.FromArgb(27, 32, 40);
        }

        private void slide4_Click(object sender, EventArgs e)
        {
            slide4Panel.BringToFront();

            slide1.BackColor = Color.FromArgb(27, 32, 40);
            slide3.BackColor = Color.FromArgb(27, 32, 40);
            slide2.BackColor = Color.FromArgb(27, 32, 40);
            slide4.BackColor = Color.FromArgb(44, 62, 80);
        }
        #endregion

        #region Sự kiện điều chỉnh chung
        #region MAIN PANEL
        /*CURSOR MAIN*/
        private void cursor_main_Click(object sender, EventArgs e)
        {
            cursor_main.Checked = true;
            hand_main.Checked = false;

            for (int i = 0; i < Cons.PLAYER_COUNT; i++)
            {
                ava_array[i].edit_by_cursor();
                content_array[i].edit_by_cursor();
                content_phu_array[i].edit_by_cursor();
            }
        }
        /*-----------*/

        /*HAND MAIN*/
        private void hand_main_Click(object sender, EventArgs e)
        {
            cursor_main.Checked = false;
            hand_main.Checked = true;

            Thread SethandMainThr = new Thread(() => {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    ava_array[i].edit_by_hand();
                    content_array[i].edit_by_hand();
                    content_phu_array[i].edit_by_hand();
                }
            });
            SethandMainThr.Start();
          
        }   
        /*-----------*/

        /*STEP MAIN */
        private void step_main_TextChanged(object sender, EventArgs e)
        {
            Thread SetstepMainThr = new Thread(() =>
            {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    ava_array[i].edit_by_hand();
                    ava_array[i].step_tb.Text = step_main.Text;

                    content_array[i].edit_by_hand();
                    content_array[i].step_tb.Text = step_main.Text;

                    content_phu_array[i].edit_by_hand();
                    content_phu_array[i].step_tb.Text = step_main.Text;
                }
            });
            SetstepMainThr.Start();
        }
        /*-------------*/

        /*WIDTH MAIN */
        private void width_main_TextChanged(object sender, EventArgs e)
        {
            Thread SetWidthMainthr = new Thread(() =>
            {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_array[i].width_in_Main(width_main.Text);
                    content_array[i].width_tb.Text = width_main.Text;

                    content_phu_array[i].width_in_Main(width_main.Text);
                    content_phu_array[i].width_tb.Text = width_main.Text;
                }
            });
            SetWidthMainthr.Start();
        }
        /*-----------*/

        /*HEIGHT MAIN*/
        private void height_main_TextChanged(object sender, EventArgs e)
        {
            Thread SetHeightMainThr = new Thread(() => {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_array[i].height_in_Main(height_main.Text);
                    content_array[i].heigth_tb.Text = height_main.Text;

                    content_phu_array[i].height_in_Main(height_main.Text);
                    content_phu_array[i].heigth_tb.Text = height_main.Text;
                }
            });
            SetHeightMainThr.Start();
        }
        /*--------------*/

        /*RADIUS MAIN*/
        private void radius_main_TextChanged(object sender, EventArgs e)
        {
            Thread SetRadiusMain = new Thread(() =>
            {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    ava_array[i].set_radius_in_main(radius_main.Text);
                    ava_array[i].radius.Text = radius_main.Text;
                }
            });
            SetRadiusMain.Start();
        }
        /*---------*/
        #endregion

        #region COMPONENT PANEL

        /*On or Off Component*/
        private void visibleAvatarOfMain_Toggled(object sender, EventArgs e)
        {
            //on or off all avatar visible properties
            Thread OnOrOffThr = new Thread(() => {
                for(int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    ava_array[i].SetVisible(visibleAvatarOfMain.IsOn);
                }
            });
            OnOrOffThr.Start();
        }

        private void visibleContentChinhOfMain_Toggled(object sender, EventArgs e)
        {
            //on or off all "content chinh" visible properties
            Thread OnOrOffThr = new Thread(() => {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_array[i].SetVisible(visibleContentChinhOfMain.IsOn);
                }
            });
            OnOrOffThr.Start();
        }

        private void visibleContentPhuOfMain_Toggled(object sender, EventArgs e)
        {
            //on or off all "content phu" visible properties
            Thread OnOrOffThr = new Thread(() => {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_phu_array[i].SetVisible(visibleContentPhuOfMain.IsOn);
                }
            });
            OnOrOffThr.Start();
        }

        /*Size of Component*/
        private void widthContentChinhOfmain_TextChanged(object sender, EventArgs e)
        {
            Thread SetSizeOfComponentThr = new Thread(() => {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_array[i].width_in_Main(widthContentChinhOfmain.Text);
                    content_array[i].width_tb.Text = widthContentChinhOfmain.Text;
                }
            });
            SetSizeOfComponentThr.Start();          
        }

        private void heightContentChinhOfmain_TextChanged(object sender, EventArgs e)
        {
            Thread SetSizeOfComponentThr = new Thread(() => {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_array[i].height_in_Main(heightContentChinhOfmain.Text);
                    content_array[i].heigth_tb.Text = heightContentChinhOfmain.Text;
                }
            });
            SetSizeOfComponentThr.Start();
        }

        private void widthContentPhuOfmain_TextChanged(object sender, EventArgs e)
        {
            Thread SetSizeOfComponentThr = new Thread(() => {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_phu_array[i].width_in_Main(widthContentPhuOfmain.Text);
                    content_phu_array[i].width_tb.Text = widthContentPhuOfmain.Text;
                }
            });
            SetSizeOfComponentThr.Start();
        }

        private void heightContentPhuOfmain_TextChanged(object sender, EventArgs e)
        {
            Thread SetSizeOfComponentThr = new Thread(() => {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_phu_array[i].height_in_Main(heightContentPhuOfmain.Text);
                    content_phu_array[i].heigth_tb.Text = heightContentPhuOfmain.Text;
                }
            });
            SetSizeOfComponentThr.Start();
        }

        /*Font Settings Component*/
        private void fontSettingsOfContentChinh_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_array[i].SetFont(fontDialog.Font, fontDialog.Color);
                }
            }
        }

        private void fontSettingsOfContentPhu_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_phu_array[i].SetFont(fontDialog.Font, fontDialog.Color);
                }
            }
        }

        /*Background Color Setting Component*/
        private void BClrOfContentChinh_EditValueChanged(object sender, EventArgs e)
        {
            Thread SetBackColorThr = new Thread(() =>
            {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_array[i].SetBackColor(BClrOfContentChinh.Color);
                }
            });
            SetBackColorThr.Start();
        }

        private void BClrOfContentPhu_EditValueChanged(object sender, EventArgs e)
        {
            Thread SetBackColorThr = new Thread(() =>
            {
                for (int i = 0; i < Cons.PLAYER_COUNT; i++)
                {
                    content_phu_array[i].SetBackColor(BClrOfContentPhu.Color);
                }
            });
            SetBackColorThr.Start();
        }

        private void background_image_file_path_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region BackGround 
        private void browse_background_btt_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                background_image_file_path.Text = file.InitialDirectory + file.FileName;
                form.BackgroundImage = Image.FromFile(background_image_file_path.Text);
                reviewBackground.BackgroundImage = Image.FromFile(background_image_file_path.Text);
                reviewBackground.BringToFront();
            }
        }

        private void open_template_btt_Click(object sender, EventArgs e)
        {
            LoadTemplate();
        }

        private void LoadTemplate()
        {
            Thread loadTemplateFile = new Thread(() => {
                string[] directoryFiles = Directory.GetFiles(Cons.BACKGROUND_TEMPLATE_PATH);

                foreach(string filePath in directoryFiles)
                {
                    if(Path.GetExtension(filePath) == ".jpg" || Path.GetExtension(filePath) == ".png")
                    {
                        //create Picture Box to load image file
                        PictureBox image = new PictureBox()
                        {
                            Dock = DockStyle.Top,
                            Height = 150,
                            BackgroundImageLayout =  ImageLayout.Zoom,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        image.BackgroundImage = Image.FromFile(filePath);
                        image.DoubleClick += new EventHandler(delegate (object sender,EventArgs e) {
                            form.BackgroundImage = Image.FromFile(filePath);
                        });
                        if (templatePanel.InvokeRequired)
                        {
                            templatePanel.BeginInvoke((MethodInvoker)delegate ()
                            {
                                templatePanel.Controls.Add(image);
                            });
                        }                  
                    }
                }
                templatePanel.BringToFront();
            });
            loadTemplateFile.Start();
        }

        #endregion

        #endregion
    }
}
