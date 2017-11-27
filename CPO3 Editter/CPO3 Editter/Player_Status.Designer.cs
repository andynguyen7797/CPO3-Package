namespace CPO3_Editter
{
    partial class Player_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Status));
            this.answer_tb = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alarm_btt = new System.Windows.Forms.Button();
            this.send_btt = new System.Windows.Forms.Button();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.send_name_btt = new System.Windows.Forms.Button();
            this.sendAlarmMessage = new System.Windows.Forms.Panel();
            this.sendAnswerMessage = new System.Windows.Forms.Panel();
            this.tryConnectPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_btt = new System.Windows.Forms.Button();
            this.timeOutlb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.line1 = new CPO3_Editter.line();
            this.tryConnectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // answer_tb
            // 
            this.answer_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.answer_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answer_tb.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_tb.Location = new System.Drawing.Point(5, 81);
            this.answer_tb.Name = "answer_tb";
            this.answer_tb.Size = new System.Drawing.Size(191, 117);
            this.answer_tb.TabIndex = 2;
            this.answer_tb.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Câu trả lời của bạn";
            // 
            // alarm_btt
            // 
            this.alarm_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.alarm_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alarm_btt.BackgroundImage")));
            this.alarm_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alarm_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.alarm_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarm_btt.Location = new System.Drawing.Point(16, 206);
            this.alarm_btt.Name = "alarm_btt";
            this.alarm_btt.Size = new System.Drawing.Size(74, 66);
            this.alarm_btt.TabIndex = 6;
            this.alarm_btt.UseVisualStyleBackColor = false;
            this.alarm_btt.Click += new System.EventHandler(this.alarm_btt_Click);
            // 
            // send_btt
            // 
            this.send_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.send_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("send_btt.BackgroundImage")));
            this.send_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.send_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.send_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_btt.Font = new System.Drawing.Font("Roboto Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.send_btt.Location = new System.Drawing.Point(118, 206);
            this.send_btt.Name = "send_btt";
            this.send_btt.Size = new System.Drawing.Size(74, 66);
            this.send_btt.TabIndex = 7;
            this.send_btt.UseVisualStyleBackColor = false;
            this.send_btt.Click += new System.EventHandler(this.send_btt_Click);
            // 
            // name_tb
            // 
            this.name_tb.BackColor = System.Drawing.SystemColors.Control;
            this.name_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tb.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tb.Location = new System.Drawing.Point(47, 10);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 23);
            this.name_tb.TabIndex = 9;
            this.name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // send_name_btt
            // 
            this.send_name_btt.FlatAppearance.BorderSize = 0;
            this.send_name_btt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send_name_btt.Location = new System.Drawing.Point(159, 10);
            this.send_name_btt.Name = "send_name_btt";
            this.send_name_btt.Size = new System.Drawing.Size(23, 23);
            this.send_name_btt.TabIndex = 10;
            this.send_name_btt.Text = ">";
            this.send_name_btt.UseVisualStyleBackColor = true;
            this.send_name_btt.Click += new System.EventHandler(this.send_name_btt_Click);
            // 
            // sendAlarmMessage
            // 
            this.sendAlarmMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sendAlarmMessage.Location = new System.Drawing.Point(5, 206);
            this.sendAlarmMessage.Name = "sendAlarmMessage";
            this.sendAlarmMessage.Size = new System.Drawing.Size(11, 66);
            this.sendAlarmMessage.TabIndex = 11;
            // 
            // sendAnswerMessage
            // 
            this.sendAnswerMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sendAnswerMessage.Location = new System.Drawing.Point(107, 206);
            this.sendAnswerMessage.Name = "sendAnswerMessage";
            this.sendAnswerMessage.Size = new System.Drawing.Size(11, 66);
            this.sendAnswerMessage.TabIndex = 12;
            // 
            // tryConnectPanel
            // 
            this.tryConnectPanel.Controls.Add(this.pictureBox1);
            this.tryConnectPanel.Controls.Add(this.exit_btt);
            this.tryConnectPanel.Controls.Add(this.timeOutlb);
            this.tryConnectPanel.Controls.Add(this.label3);
            this.tryConnectPanel.Controls.Add(this.label1);
            this.tryConnectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tryConnectPanel.Location = new System.Drawing.Point(0, 0);
            this.tryConnectPanel.Name = "tryConnectPanel";
            this.tryConnectPanel.Size = new System.Drawing.Size(201, 280);
            this.tryConnectPanel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 110);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exit_btt
            // 
            this.exit_btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.exit_btt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_btt.FlatAppearance.BorderSize = 0;
            this.exit_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btt.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exit_btt.Location = new System.Drawing.Point(0, 240);
            this.exit_btt.Name = "exit_btt";
            this.exit_btt.Size = new System.Drawing.Size(201, 40);
            this.exit_btt.TabIndex = 3;
            this.exit_btt.Text = "Exit";
            this.exit_btt.UseVisualStyleBackColor = false;
            this.exit_btt.Click += new System.EventHandler(this.exit_btt_Click);
            // 
            // timeOutlb
            // 
            this.timeOutlb.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutlb.Location = new System.Drawing.Point(146, 101);
            this.timeOutlb.Name = "timeOutlb";
            this.timeOutlb.Size = new System.Drawing.Size(36, 23);
            this.timeOutlb.TabIndex = 2;
            this.timeOutlb.Text = "10s";
            this.timeOutlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đang thử \r\nkết nối lại trong ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vấn đề đường truyền\r\n               :((";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.answer_tb);
            this.controlPanel.Controls.Add(this.sendAnswerMessage);
            this.controlPanel.Controls.Add(this.alarm_btt);
            this.controlPanel.Controls.Add(this.sendAlarmMessage);
            this.controlPanel.Controls.Add(this.send_btt);
            this.controlPanel.Controls.Add(this.send_name_btt);
            this.controlPanel.Controls.Add(this.line1);
            this.controlPanel.Controls.Add(this.name_tb);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(201, 280);
            this.controlPanel.TabIndex = 14;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(5, 39);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(190, 13);
            this.line1.TabIndex = 8;
            // 
            // Player_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.tryConnectPanel);
            this.Name = "Player_Status";
            this.Size = new System.Drawing.Size(201, 280);
            this.tryConnectPanel.ResumeLayout(false);
            this.tryConnectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox answer_tb;
        public System.Windows.Forms.Button alarm_btt;
        public System.Windows.Forms.Button send_btt;
        private line line1;
        public System.Windows.Forms.Button send_name_btt;
        public System.Windows.Forms.TextBox name_tb;
        public System.Windows.Forms.Panel sendAlarmMessage;
        public System.Windows.Forms.Panel sendAnswerMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button exit_btt;
        public System.Windows.Forms.Panel tryConnectPanel;
        public System.Windows.Forms.Label timeOutlb;
        private System.Windows.Forms.Panel controlPanel;
    }
}
