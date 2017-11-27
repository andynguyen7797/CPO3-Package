namespace CPO3_Remaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deadline_tb = new System.Windows.Forms.TextBox();
            this.timecount = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mo_man_hinh_diem = new System.Windows.Forms.Button();
            this.update_name_and_score_btt = new System.Windows.Forms.Button();
            this.dong_man_hinh_diem = new System.Windows.Forms.Button();
            this.thiet_lap_thong_so_man_hinh_diem = new System.Windows.Forms.Button();
            this.stop_timecount_btt = new System.Windows.Forms.Button();
            this.play_timecount_btt = new System.Windows.Forms.Button();
            this.set_timeCount_btt = new System.Windows.Forms.Button();
            this.mo_man_hinh_tra_loi = new System.Windows.Forms.Button();
            this.update_answer_and_time__btt = new System.Windows.Forms.Button();
            this.dong_man_hinh_tra_loi = new System.Windows.Forms.Button();
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi = new System.Windows.Forms.Button();
            this.about_author_btt = new System.Windows.Forms.Button();
            this.ViewLog_btt = new System.Windows.Forms.Button();
            this.minisize_btt = new System.Windows.Forms.Button();
            this.close_btt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.performanceCounter = new System.Diagnostics.PerformanceCounter();
            this.cpuUsage_lb = new System.Windows.Forms.Label();
            this.cpuUsageColor = new System.Windows.Forms.Button();
            this.horizontalLine9 = new CPO3_Remaker.horizontalLine();
            this.horizontalLine5 = new CPO3_Remaker.horizontalLine();
            this.horizontalLine4 = new CPO3_Remaker.horizontalLine();
            this.horizontalLine3 = new CPO3_Remaker.horizontalLine();
            this.horizontalLine2 = new CPO3_Remaker.horizontalLine();
            this.horizontalLine1 = new CPO3_Remaker.horizontalLine();
            this.player_Control4 = new CPO3_Remaker.Player_Control();
            this.player_Control3 = new CPO3_Remaker.Player_Control();
            this.player_Control2 = new CPO3_Remaker.Player_Control();
            this.player_Control1 = new CPO3_Remaker.Player_Control();
            this.horizontalLine8 = new CPO3_Remaker.horizontalLine();
            this.horizontalLine7 = new CPO3_Remaker.horizontalLine();
            this.horizontalLine6 = new CPO3_Remaker.horizontalLine();
            this.line1 = new CPO3_Remaker.Line();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.player_Control4);
            this.panel1.Controls.Add(this.player_Control3);
            this.panel1.Controls.Add(this.player_Control2);
            this.panel1.Controls.Add(this.player_Control1);
            this.panel1.Controls.Add(this.horizontalLine8);
            this.panel1.Controls.Add(this.horizontalLine7);
            this.panel1.Controls.Add(this.horizontalLine6);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 585);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(62, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPO CONTROLLER";
            // 
            // deadline_tb
            // 
            this.deadline_tb.Location = new System.Drawing.Point(595, 13);
            this.deadline_tb.Name = "deadline_tb";
            this.deadline_tb.Size = new System.Drawing.Size(60, 20);
            this.deadline_tb.TabIndex = 5;
            // 
            // timecount
            // 
            this.timecount.Enabled = true;
            this.timecount.Interval = 1000;
            this.timecount.Tick += new System.EventHandler(this.timecount_Tick);
            // 
            // mo_man_hinh_diem
            // 
            this.mo_man_hinh_diem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mo_man_hinh_diem.BackgroundImage")));
            this.mo_man_hinh_diem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mo_man_hinh_diem.FlatAppearance.BorderSize = 0;
            this.mo_man_hinh_diem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mo_man_hinh_diem.Location = new System.Drawing.Point(376, 10);
            this.mo_man_hinh_diem.Name = "mo_man_hinh_diem";
            this.mo_man_hinh_diem.Size = new System.Drawing.Size(23, 23);
            this.mo_man_hinh_diem.TabIndex = 10;
            this.mo_man_hinh_diem.UseVisualStyleBackColor = true;
            this.mo_man_hinh_diem.Click += new System.EventHandler(this.mo_man_hinh_diem_Click);
            // 
            // update_name_and_score_btt
            // 
            this.update_name_and_score_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_name_and_score_btt.BackgroundImage")));
            this.update_name_and_score_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.update_name_and_score_btt.FlatAppearance.BorderSize = 0;
            this.update_name_and_score_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_name_and_score_btt.Location = new System.Drawing.Point(463, 10);
            this.update_name_and_score_btt.Name = "update_name_and_score_btt";
            this.update_name_and_score_btt.Size = new System.Drawing.Size(23, 23);
            this.update_name_and_score_btt.TabIndex = 13;
            this.update_name_and_score_btt.UseVisualStyleBackColor = true;
            this.update_name_and_score_btt.Click += new System.EventHandler(this.update_name_and_score_btt_Click);
            // 
            // dong_man_hinh_diem
            // 
            this.dong_man_hinh_diem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dong_man_hinh_diem.BackgroundImage")));
            this.dong_man_hinh_diem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dong_man_hinh_diem.FlatAppearance.BorderSize = 0;
            this.dong_man_hinh_diem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dong_man_hinh_diem.Location = new System.Drawing.Point(405, 10);
            this.dong_man_hinh_diem.Name = "dong_man_hinh_diem";
            this.dong_man_hinh_diem.Size = new System.Drawing.Size(23, 23);
            this.dong_man_hinh_diem.TabIndex = 11;
            this.dong_man_hinh_diem.UseVisualStyleBackColor = true;
            this.dong_man_hinh_diem.Click += new System.EventHandler(this.dong_man_hinh_diem_Click);
            // 
            // thiet_lap_thong_so_man_hinh_diem
            // 
            this.thiet_lap_thong_so_man_hinh_diem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thiet_lap_thong_so_man_hinh_diem.BackgroundImage")));
            this.thiet_lap_thong_so_man_hinh_diem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thiet_lap_thong_so_man_hinh_diem.FlatAppearance.BorderSize = 0;
            this.thiet_lap_thong_so_man_hinh_diem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thiet_lap_thong_so_man_hinh_diem.Location = new System.Drawing.Point(434, 11);
            this.thiet_lap_thong_so_man_hinh_diem.Name = "thiet_lap_thong_so_man_hinh_diem";
            this.thiet_lap_thong_so_man_hinh_diem.Size = new System.Drawing.Size(23, 23);
            this.thiet_lap_thong_so_man_hinh_diem.TabIndex = 12;
            this.thiet_lap_thong_so_man_hinh_diem.UseVisualStyleBackColor = true;
            this.thiet_lap_thong_so_man_hinh_diem.Click += new System.EventHandler(this.thiet_lap_thong_so_man_hinh_diem_Click);
            // 
            // stop_timecount_btt
            // 
            this.stop_timecount_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop_timecount_btt.BackgroundImage")));
            this.stop_timecount_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop_timecount_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.stop_timecount_btt.FlatAppearance.BorderSize = 0;
            this.stop_timecount_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_timecount_btt.Location = new System.Drawing.Point(537, 10);
            this.stop_timecount_btt.Name = "stop_timecount_btt";
            this.stop_timecount_btt.Size = new System.Drawing.Size(23, 23);
            this.stop_timecount_btt.TabIndex = 7;
            this.stop_timecount_btt.UseVisualStyleBackColor = true;
            this.stop_timecount_btt.Click += new System.EventHandler(this.stop_timecount_btt_Click);
            // 
            // play_timecount_btt
            // 
            this.play_timecount_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play_timecount_btt.BackgroundImage")));
            this.play_timecount_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play_timecount_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.play_timecount_btt.FlatAppearance.BorderSize = 0;
            this.play_timecount_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_timecount_btt.Location = new System.Drawing.Point(508, 10);
            this.play_timecount_btt.Name = "play_timecount_btt";
            this.play_timecount_btt.Size = new System.Drawing.Size(23, 23);
            this.play_timecount_btt.TabIndex = 6;
            this.play_timecount_btt.UseVisualStyleBackColor = true;
            this.play_timecount_btt.Click += new System.EventHandler(this.play_timecount_btt_Click);
            // 
            // set_timeCount_btt
            // 
            this.set_timeCount_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_timeCount_btt.BackgroundImage")));
            this.set_timeCount_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.set_timeCount_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.set_timeCount_btt.FlatAppearance.BorderSize = 0;
            this.set_timeCount_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_timeCount_btt.Location = new System.Drawing.Point(566, 10);
            this.set_timeCount_btt.Name = "set_timeCount_btt";
            this.set_timeCount_btt.Size = new System.Drawing.Size(23, 23);
            this.set_timeCount_btt.TabIndex = 8;
            this.set_timeCount_btt.UseVisualStyleBackColor = true;
            this.set_timeCount_btt.Click += new System.EventHandler(this.set_timeCount_btt_Click);
            // 
            // mo_man_hinh_tra_loi
            // 
            this.mo_man_hinh_tra_loi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mo_man_hinh_tra_loi.BackgroundImage")));
            this.mo_man_hinh_tra_loi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mo_man_hinh_tra_loi.FlatAppearance.BorderSize = 0;
            this.mo_man_hinh_tra_loi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mo_man_hinh_tra_loi.Location = new System.Drawing.Point(677, 9);
            this.mo_man_hinh_tra_loi.Name = "mo_man_hinh_tra_loi";
            this.mo_man_hinh_tra_loi.Size = new System.Drawing.Size(23, 23);
            this.mo_man_hinh_tra_loi.TabIndex = 10;
            this.mo_man_hinh_tra_loi.UseVisualStyleBackColor = true;
            this.mo_man_hinh_tra_loi.Click += new System.EventHandler(this.mo_man_hinh_tra_loi_Click);
            // 
            // update_answer_and_time__btt
            // 
            this.update_answer_and_time__btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_answer_and_time__btt.BackgroundImage")));
            this.update_answer_and_time__btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.update_answer_and_time__btt.FlatAppearance.BorderSize = 0;
            this.update_answer_and_time__btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_answer_and_time__btt.Location = new System.Drawing.Point(764, 9);
            this.update_answer_and_time__btt.Name = "update_answer_and_time__btt";
            this.update_answer_and_time__btt.Size = new System.Drawing.Size(23, 23);
            this.update_answer_and_time__btt.TabIndex = 13;
            this.update_answer_and_time__btt.UseVisualStyleBackColor = true;
            this.update_answer_and_time__btt.Click += new System.EventHandler(this.update_answer_and_time_btt_Click);
            // 
            // dong_man_hinh_tra_loi
            // 
            this.dong_man_hinh_tra_loi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dong_man_hinh_tra_loi.BackgroundImage")));
            this.dong_man_hinh_tra_loi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dong_man_hinh_tra_loi.FlatAppearance.BorderSize = 0;
            this.dong_man_hinh_tra_loi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dong_man_hinh_tra_loi.Location = new System.Drawing.Point(706, 9);
            this.dong_man_hinh_tra_loi.Name = "dong_man_hinh_tra_loi";
            this.dong_man_hinh_tra_loi.Size = new System.Drawing.Size(23, 23);
            this.dong_man_hinh_tra_loi.TabIndex = 11;
            this.dong_man_hinh_tra_loi.UseVisualStyleBackColor = true;
            this.dong_man_hinh_tra_loi.Click += new System.EventHandler(this.dong_man_hinh_tra_loi_Click);
            // 
            // thiet_lap_thong_so_man_hinh_cau_tra_loi
            // 
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thiet_lap_thong_so_man_hinh_cau_tra_loi.BackgroundImage")));
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.FlatAppearance.BorderSize = 0;
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.Location = new System.Drawing.Point(735, 10);
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.Name = "thiet_lap_thong_so_man_hinh_cau_tra_loi";
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.Size = new System.Drawing.Size(23, 23);
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.TabIndex = 12;
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.UseVisualStyleBackColor = true;
            this.thiet_lap_thong_so_man_hinh_cau_tra_loi.Click += new System.EventHandler(this.thiet_lap_thong_so_man_hinh_cau_tra_loi_Click);
            // 
            // about_author_btt
            // 
            this.about_author_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about_author_btt.BackgroundImage")));
            this.about_author_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.about_author_btt.FlatAppearance.BorderSize = 0;
            this.about_author_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_author_btt.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_author_btt.ForeColor = System.Drawing.Color.Transparent;
            this.about_author_btt.Location = new System.Drawing.Point(1277, 4);
            this.about_author_btt.Name = "about_author_btt";
            this.about_author_btt.Size = new System.Drawing.Size(30, 30);
            this.about_author_btt.TabIndex = 16;
            this.about_author_btt.UseVisualStyleBackColor = true;
            this.about_author_btt.Click += new System.EventHandler(this.about_author_btt_Click);
            // 
            // ViewLog_btt
            // 
            this.ViewLog_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ViewLog_btt.FlatAppearance.BorderSize = 0;
            this.ViewLog_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewLog_btt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLog_btt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ViewLog_btt.Location = new System.Drawing.Point(270, 6);
            this.ViewLog_btt.Name = "ViewLog_btt";
            this.ViewLog_btt.Size = new System.Drawing.Size(86, 30);
            this.ViewLog_btt.TabIndex = 17;
            this.ViewLog_btt.Text = "View Log";
            this.ViewLog_btt.UseVisualStyleBackColor = false;
            this.ViewLog_btt.Click += new System.EventHandler(this.ViewLog_btt_Click);
            // 
            // minisize_btt
            // 
            this.minisize_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.minisize_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minisize_btt.BackgroundImage")));
            this.minisize_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minisize_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.minisize_btt.FlatAppearance.BorderSize = 0;
            this.minisize_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minisize_btt.Location = new System.Drawing.Point(1313, 4);
            this.minisize_btt.Name = "minisize_btt";
            this.minisize_btt.Size = new System.Drawing.Size(30, 30);
            this.minisize_btt.TabIndex = 4;
            this.minisize_btt.UseVisualStyleBackColor = false;
            this.minisize_btt.Click += new System.EventHandler(this.minisize_btt_Click);
            // 
            // close_btt
            // 
            this.close_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.close_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btt.BackgroundImage")));
            this.close_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.close_btt.FlatAppearance.BorderSize = 0;
            this.close_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btt.Location = new System.Drawing.Point(1349, 4);
            this.close_btt.Name = "close_btt";
            this.close_btt.Size = new System.Drawing.Size(30, 30);
            this.close_btt.TabIndex = 3;
            this.close_btt.UseVisualStyleBackColor = false;
            this.close_btt.Click += new System.EventHandler(this.close_btt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // performanceCounter
            // 
            this.performanceCounter.CategoryName = "Processor";
            this.performanceCounter.CounterName = "% Processor Time";
            this.performanceCounter.InstanceName = "_Total";
            // 
            // cpuUsage_lb
            // 
            this.cpuUsage_lb.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuUsage_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.cpuUsage_lb.Location = new System.Drawing.Point(809, 12);
            this.cpuUsage_lb.Name = "cpuUsage_lb";
            this.cpuUsage_lb.Size = new System.Drawing.Size(159, 19);
            this.cpuUsage_lb.TabIndex = 23;
            this.cpuUsage_lb.Text = "CPU Usage :";
            // 
            // cpuUsageColor
            // 
            this.cpuUsageColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.cpuUsageColor.FlatAppearance.BorderSize = 0;
            this.cpuUsageColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpuUsageColor.Location = new System.Drawing.Point(974, 10);
            this.cpuUsageColor.Name = "cpuUsageColor";
            this.cpuUsageColor.Size = new System.Drawing.Size(23, 23);
            this.cpuUsageColor.TabIndex = 25;
            this.cpuUsageColor.UseVisualStyleBackColor = false;
            // 
            // horizontalLine9
            // 
            this.horizontalLine9.Location = new System.Drawing.Point(1003, -1);
            this.horizontalLine9.Name = "horizontalLine9";
            this.horizontalLine9.Size = new System.Drawing.Size(10, 43);
            this.horizontalLine9.TabIndex = 24;
            // 
            // horizontalLine5
            // 
            this.horizontalLine5.Location = new System.Drawing.Point(356, -1);
            this.horizontalLine5.Name = "horizontalLine5";
            this.horizontalLine5.Size = new System.Drawing.Size(10, 43);
            this.horizontalLine5.TabIndex = 22;
            // 
            // horizontalLine4
            // 
            this.horizontalLine4.Location = new System.Drawing.Point(492, -1);
            this.horizontalLine4.Name = "horizontalLine4";
            this.horizontalLine4.Size = new System.Drawing.Size(10, 43);
            this.horizontalLine4.TabIndex = 21;
            // 
            // horizontalLine3
            // 
            this.horizontalLine3.Location = new System.Drawing.Point(661, -1);
            this.horizontalLine3.Name = "horizontalLine3";
            this.horizontalLine3.Size = new System.Drawing.Size(10, 43);
            this.horizontalLine3.TabIndex = 20;
            // 
            // horizontalLine2
            // 
            this.horizontalLine2.Location = new System.Drawing.Point(258, -1);
            this.horizontalLine2.Name = "horizontalLine2";
            this.horizontalLine2.Size = new System.Drawing.Size(10, 43);
            this.horizontalLine2.TabIndex = 19;
            // 
            // horizontalLine1
            // 
            this.horizontalLine1.Location = new System.Drawing.Point(793, -1);
            this.horizontalLine1.Name = "horizontalLine1";
            this.horizontalLine1.Size = new System.Drawing.Size(10, 43);
            this.horizontalLine1.TabIndex = 18;
            // 
            // player_Control4
            // 
            this.player_Control4.AccessibleDescription = "3";
            this.player_Control4.Add_score = 0;
            this.player_Control4.Answer_cnt = null;
            this.player_Control4.AvatarPath = null;
            this.player_Control4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player_Control4.Enabled = false;
            this.player_Control4.IndexOfUser = "4";
            this.player_Control4.IsLock = 0;
            this.player_Control4.IsLockEdit = 0;
            this.player_Control4.Location = new System.Drawing.Point(1026, 3);
            this.player_Control4.Name = "player_Control4";
            this.player_Control4.Player_name = null;
            this.player_Control4.Player_score = 0;
            this.player_Control4.Size = new System.Drawing.Size(335, 572);
            this.player_Control4.TabIndex = 3;
            this.player_Control4.Tag = "NULL";
            // 
            // player_Control3
            // 
            this.player_Control3.AccessibleDescription = "2";
            this.player_Control3.Add_score = 0;
            this.player_Control3.Answer_cnt = null;
            this.player_Control3.AvatarPath = null;
            this.player_Control3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player_Control3.Enabled = false;
            this.player_Control3.IndexOfUser = "3";
            this.player_Control3.IsLock = 0;
            this.player_Control3.IsLockEdit = 0;
            this.player_Control3.Location = new System.Drawing.Point(685, 3);
            this.player_Control3.Name = "player_Control3";
            this.player_Control3.Player_name = null;
            this.player_Control3.Player_score = 0;
            this.player_Control3.Size = new System.Drawing.Size(335, 572);
            this.player_Control3.TabIndex = 2;
            this.player_Control3.Tag = "NULL";
            // 
            // player_Control2
            // 
            this.player_Control2.AccessibleDescription = "1";
            this.player_Control2.Add_score = 0;
            this.player_Control2.Answer_cnt = null;
            this.player_Control2.AvatarPath = null;
            this.player_Control2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player_Control2.Enabled = false;
            this.player_Control2.IndexOfUser = "2";
            this.player_Control2.IsLock = 0;
            this.player_Control2.IsLockEdit = 0;
            this.player_Control2.Location = new System.Drawing.Point(344, 3);
            this.player_Control2.Name = "player_Control2";
            this.player_Control2.Player_name = null;
            this.player_Control2.Player_score = 0;
            this.player_Control2.Size = new System.Drawing.Size(335, 572);
            this.player_Control2.TabIndex = 1;
            this.player_Control2.Tag = "NULL";
            // 
            // player_Control1
            // 
            this.player_Control1.AccessibleDescription = "0";
            this.player_Control1.Add_score = 0;
            this.player_Control1.Answer_cnt = null;
            this.player_Control1.AvatarPath = null;
            this.player_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player_Control1.Enabled = false;
            this.player_Control1.IndexOfUser = "1";
            this.player_Control1.IsLock = 0;
            this.player_Control1.IsLockEdit = 0;
            this.player_Control1.Location = new System.Drawing.Point(3, 3);
            this.player_Control1.Name = "player_Control1";
            this.player_Control1.Player_name = null;
            this.player_Control1.Player_score = 0;
            this.player_Control1.Size = new System.Drawing.Size(335, 572);
            this.player_Control1.TabIndex = 0;
            this.player_Control1.Tag = "NULL";
            // 
            // horizontalLine8
            // 
            this.horizontalLine8.Location = new System.Drawing.Point(1017, -2);
            this.horizontalLine8.Name = "horizontalLine8";
            this.horizontalLine8.Size = new System.Drawing.Size(10, 598);
            this.horizontalLine8.TabIndex = 6;
            // 
            // horizontalLine7
            // 
            this.horizontalLine7.Location = new System.Drawing.Point(676, -1);
            this.horizontalLine7.Name = "horizontalLine7";
            this.horizontalLine7.Size = new System.Drawing.Size(10, 598);
            this.horizontalLine7.TabIndex = 5;
            // 
            // horizontalLine6
            // 
            this.horizontalLine6.Location = new System.Drawing.Point(335, -1);
            this.horizontalLine6.Name = "horizontalLine6";
            this.horizontalLine6.Size = new System.Drawing.Size(10, 598);
            this.horizontalLine6.TabIndex = 4;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(-2, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1396, 10);
            this.line1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1391, 640);
            this.Controls.Add(this.cpuUsageColor);
            this.Controls.Add(this.horizontalLine9);
            this.Controls.Add(this.cpuUsage_lb);
            this.Controls.Add(this.horizontalLine5);
            this.Controls.Add(this.horizontalLine4);
            this.Controls.Add(this.mo_man_hinh_diem);
            this.Controls.Add(this.horizontalLine3);
            this.Controls.Add(this.update_name_and_score_btt);
            this.Controls.Add(this.deadline_tb);
            this.Controls.Add(this.dong_man_hinh_diem);
            this.Controls.Add(this.thiet_lap_thong_so_man_hinh_diem);
            this.Controls.Add(this.stop_timecount_btt);
            this.Controls.Add(this.mo_man_hinh_tra_loi);
            this.Controls.Add(this.play_timecount_btt);
            this.Controls.Add(this.horizontalLine2);
            this.Controls.Add(this.set_timeCount_btt);
            this.Controls.Add(this.update_answer_and_time__btt);
            this.Controls.Add(this.dong_man_hinh_tra_loi);
            this.Controls.Add(this.horizontalLine1);
            this.Controls.Add(this.thiet_lap_thong_so_man_hinh_cau_tra_loi);
            this.Controls.Add(this.ViewLog_btt);
            this.Controls.Add(this.about_author_btt);
            this.Controls.Add(this.minisize_btt);
            this.Controls.Add(this.close_btt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.line1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Player_Control player_Control1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close_btt;
        private System.Windows.Forms.Button minisize_btt;
        private System.Windows.Forms.TextBox deadline_tb;
        private System.Windows.Forms.Button play_timecount_btt;
        private System.Windows.Forms.Timer timecount;
        private System.Windows.Forms.Button stop_timecount_btt;
        private System.Windows.Forms.Button set_timeCount_btt;
        private System.Windows.Forms.Button mo_man_hinh_diem;
        private System.Windows.Forms.Button dong_man_hinh_diem;
        private System.Windows.Forms.Button thiet_lap_thong_so_man_hinh_diem;
        private System.Windows.Forms.Button update_name_and_score_btt;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button mo_man_hinh_tra_loi;
        private System.Windows.Forms.Button update_answer_and_time__btt;
        private System.Windows.Forms.Button dong_man_hinh_tra_loi;
        private System.Windows.Forms.Button thiet_lap_thong_so_man_hinh_cau_tra_loi;
        private System.Windows.Forms.Button about_author_btt;
        public Player_Control player_Control4;
        public Player_Control player_Control3;
        public Player_Control player_Control2;
        private System.Windows.Forms.Button ViewLog_btt;
        private Line line1;
        private horizontalLine horizontalLine1;
        private horizontalLine horizontalLine2;
        private horizontalLine horizontalLine3;
        private horizontalLine horizontalLine4;
        private horizontalLine horizontalLine5;
        private horizontalLine horizontalLine8;
        private horizontalLine horizontalLine7;
        private horizontalLine horizontalLine6;
        private System.Diagnostics.PerformanceCounter performanceCounter;
        private System.Windows.Forms.Label cpuUsage_lb;
        private horizontalLine horizontalLine9;
        private System.Windows.Forms.Button cpuUsageColor;
    }
}

