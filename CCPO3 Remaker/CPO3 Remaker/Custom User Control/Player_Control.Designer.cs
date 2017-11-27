namespace CPO3_Remaker
{
    partial class Player_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Control));
            this.status_bar = new System.Windows.Forms.Panel();
            this.time_count_progressbar = new System.Windows.Forms.ProgressBar();
            this.alarm = new System.Windows.Forms.PictureBox();
            this.name_lb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.answer_content = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.score_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_custom_btt = new System.Windows.Forms.Button();
            this.dec_btt = new System.Windows.Forms.Button();
            this.plus_btt = new System.Windows.Forms.Button();
            this.addScore_tb = new System.Windows.Forms.TextBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.settings_btt = new System.Windows.Forms.Button();
            this.horizontalLine1 = new CPO3_Remaker.horizontalLine();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lock_user_edit_btt = new System.Windows.Forms.Button();
            this.horizontalLine2 = new CPO3_Remaker.horizontalLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lock_btt = new System.Windows.Forms.Button();
            this.timecount_player = new System.Windows.Forms.Timer(this.components);
            this.time_lb = new System.Windows.Forms.Label();
            this.player_ava = new CPO3_Remaker.Circle_Image();
            this.status_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_bar
            // 
            this.status_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.status_bar.Controls.Add(this.time_count_progressbar);
            this.status_bar.Controls.Add(this.alarm);
            this.status_bar.Location = new System.Drawing.Point(0, 0);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(335, 29);
            this.status_bar.TabIndex = 0;
            // 
            // time_count_progressbar
            // 
            this.time_count_progressbar.Location = new System.Drawing.Point(3, 9);
            this.time_count_progressbar.Name = "time_count_progressbar";
            this.time_count_progressbar.Size = new System.Drawing.Size(299, 10);
            this.time_count_progressbar.TabIndex = 5;
            // 
            // alarm
            // 
            this.alarm.Image = ((System.Drawing.Image)(resources.GetObject("alarm.Image")));
            this.alarm.Location = new System.Drawing.Point(307, 1);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(25, 25);
            this.alarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarm.TabIndex = 4;
            this.alarm.TabStop = false;
            // 
            // name_lb
            // 
            this.name_lb.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(102, 110);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(139, 29);
            this.name_lb.TabIndex = 3;
            this.name_lb.Text = "Name";
            this.name_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answer_content);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.score_lb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("TimeBurner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera";
            // 
            // answer_content
            // 
            this.answer_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.answer_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answer_content.Font = new System.Drawing.Font("TimeBurner", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_content.Location = new System.Drawing.Point(11, 163);
            this.answer_content.Name = "answer_content";
            this.answer_content.ReadOnly = true;
            this.answer_content.Size = new System.Drawing.Size(300, 58);
            this.answer_content.TabIndex = 3;
            this.answer_content.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TimeBurner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Answer";
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Font = new System.Drawing.Font("TimeBurner", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lb.Location = new System.Drawing.Point(85, 55);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(152, 82);
            this.score_lb.TabIndex = 1;
            this.score_lb.Text = "000";
            this.score_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TimeBurner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Score";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.add_custom_btt);
            this.groupBox2.Controls.Add(this.dec_btt);
            this.groupBox2.Controls.Add(this.plus_btt);
            this.groupBox2.Controls.Add(this.addScore_tb);
            this.groupBox2.Controls.Add(this.panelControl);
            this.groupBox2.Font = new System.Drawing.Font("TimeBurner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 186);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller";
            // 
            // add_custom_btt
            // 
            this.add_custom_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.add_custom_btt.Font = new System.Drawing.Font("TimeBurner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_custom_btt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.add_custom_btt.Location = new System.Drawing.Point(174, 63);
            this.add_custom_btt.Name = "add_custom_btt";
            this.add_custom_btt.Size = new System.Drawing.Size(137, 49);
            this.add_custom_btt.TabIndex = 5;
            this.add_custom_btt.Text = "Enter";
            this.add_custom_btt.UseVisualStyleBackColor = false;
            this.add_custom_btt.Click += new System.EventHandler(this.add_custom_btt_Click);
            // 
            // dec_btt
            // 
            this.dec_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dec_btt.Font = new System.Drawing.Font("TimeBurner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_btt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dec_btt.Location = new System.Drawing.Point(93, 63);
            this.dec_btt.Name = "dec_btt";
            this.dec_btt.Size = new System.Drawing.Size(75, 49);
            this.dec_btt.TabIndex = 2;
            this.dec_btt.Text = "-10";
            this.dec_btt.UseVisualStyleBackColor = false;
            this.dec_btt.Click += new System.EventHandler(this.dec_btt_Click);
            // 
            // plus_btt
            // 
            this.plus_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.plus_btt.Font = new System.Drawing.Font("TimeBurner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_btt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.plus_btt.Location = new System.Drawing.Point(12, 63);
            this.plus_btt.Name = "plus_btt";
            this.plus_btt.Size = new System.Drawing.Size(75, 49);
            this.plus_btt.TabIndex = 1;
            this.plus_btt.Text = "+10";
            this.plus_btt.UseVisualStyleBackColor = false;
            this.plus_btt.Click += new System.EventHandler(this.plus_btt_Click);
            // 
            // addScore_tb
            // 
            this.addScore_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.addScore_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addScore_tb.Location = new System.Drawing.Point(11, 28);
            this.addScore_tb.Name = "addScore_tb";
            this.addScore_tb.Size = new System.Drawing.Size(300, 22);
            this.addScore_tb.TabIndex = 0;
            this.addScore_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addScore_tb.Click += new System.EventHandler(this.addScore_tb_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelControl.Controls.Add(this.panel3);
            this.panelControl.Controls.Add(this.horizontalLine1);
            this.panelControl.Controls.Add(this.panel2);
            this.panelControl.Controls.Add(this.horizontalLine2);
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(3, 118);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(311, 65);
            this.panelControl.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.settings_btt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 65);
            this.panel3.TabIndex = 12;
            // 
            // settings_btt
            // 
            this.settings_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.settings_btt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.settings_btt.FlatAppearance.BorderSize = 0;
            this.settings_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_btt.Image = ((System.Drawing.Image)(resources.GetObject("settings_btt.Image")));
            this.settings_btt.Location = new System.Drawing.Point(0, 0);
            this.settings_btt.Name = "settings_btt";
            this.settings_btt.Size = new System.Drawing.Size(117, 65);
            this.settings_btt.TabIndex = 4;
            this.settings_btt.UseVisualStyleBackColor = false;
            this.settings_btt.Click += new System.EventHandler(this.settings_btt_Click);
            // 
            // horizontalLine1
            // 
            this.horizontalLine1.Dock = System.Windows.Forms.DockStyle.Left;
            this.horizontalLine1.Location = new System.Drawing.Point(184, 0);
            this.horizontalLine1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.horizontalLine1.Name = "horizontalLine1";
            this.horizontalLine1.Size = new System.Drawing.Size(10, 65);
            this.horizontalLine1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lock_user_edit_btt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(100, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 65);
            this.panel2.TabIndex = 10;
            // 
            // lock_user_edit_btt
            // 
            this.lock_user_edit_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lock_user_edit_btt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lock_user_edit_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lock_user_edit_btt.FlatAppearance.BorderSize = 0;
            this.lock_user_edit_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lock_user_edit_btt.Image = ((System.Drawing.Image)(resources.GetObject("lock_user_edit_btt.Image")));
            this.lock_user_edit_btt.Location = new System.Drawing.Point(0, 0);
            this.lock_user_edit_btt.Name = "lock_user_edit_btt";
            this.lock_user_edit_btt.Size = new System.Drawing.Size(84, 65);
            this.lock_user_edit_btt.TabIndex = 6;
            this.lock_user_edit_btt.UseVisualStyleBackColor = false;
            // 
            // horizontalLine2
            // 
            this.horizontalLine2.Dock = System.Windows.Forms.DockStyle.Left;
            this.horizontalLine2.Location = new System.Drawing.Point(84, 0);
            this.horizontalLine2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.horizontalLine2.Name = "horizontalLine2";
            this.horizontalLine2.Size = new System.Drawing.Size(16, 65);
            this.horizontalLine2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lock_btt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 65);
            this.panel1.TabIndex = 9;
            // 
            // lock_btt
            // 
            this.lock_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lock_btt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lock_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lock_btt.FlatAppearance.BorderSize = 0;
            this.lock_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lock_btt.Image = ((System.Drawing.Image)(resources.GetObject("lock_btt.Image")));
            this.lock_btt.Location = new System.Drawing.Point(0, 0);
            this.lock_btt.Name = "lock_btt";
            this.lock_btt.Size = new System.Drawing.Size(84, 65);
            this.lock_btt.TabIndex = 3;
            this.lock_btt.UseVisualStyleBackColor = false;
            // 
            // timecount_player
            // 
            this.timecount_player.Tick += new System.EventHandler(this.timecount_player_Tick);
            // 
            // time_lb
            // 
            this.time_lb.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lb.Location = new System.Drawing.Point(210, 76);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(92, 29);
            this.time_lb.TabIndex = 6;
            this.time_lb.Text = "0.0";
            this.time_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_ava
            // 
            this.player_ava.BackgroundImage = global::CPO3_Remaker.Properties.Resources.user;
            this.player_ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player_ava.Location = new System.Drawing.Point(134, 35);
            this.player_ava.Name = "player_ava";
            this.player_ava.Size = new System.Drawing.Size(70, 70);
            this.player_ava.TabIndex = 7;
            this.player_ava.Click += new System.EventHandler(this.player_ava_Click);
            // 
            // Player_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.player_ava);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.status_bar);
            this.Name = "Player_Control";
            this.Size = new System.Drawing.Size(335, 572);
            this.status_bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alarm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel status_bar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox alarm;
        public System.Windows.Forms.RichTextBox answer_content;
        public System.Windows.Forms.Button lock_btt;
        public System.Windows.Forms.Label name_lb;
        public System.Windows.Forms.Button dec_btt;
        public System.Windows.Forms.Button plus_btt;
        public System.Windows.Forms.Button add_custom_btt;
        public System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.ProgressBar time_count_progressbar;
        private System.Windows.Forms.Timer timecount_player;
        public System.Windows.Forms.Label time_lb;
        public System.Windows.Forms.Button lock_user_edit_btt;
        public System.Windows.Forms.Button settings_btt;
        public System.Windows.Forms.TextBox addScore_tb;
        public Circle_Image player_ava;
        private System.Windows.Forms.Panel panelControl;
        private horizontalLine horizontalLine2;
        private System.Windows.Forms.Panel panel3;
        private horizontalLine horizontalLine1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
