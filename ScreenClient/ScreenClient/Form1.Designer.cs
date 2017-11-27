namespace ScreenClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.ipv4_tb = new System.Windows.Forms.TextBox();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ok_btt = new System.Windows.Forms.Button();
            this.close_btt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modeList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.infomation_tb = new System.Windows.Forms.TextBox();
            this.screenList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userIndexList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "S C R E E N    C L I E N T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "IPV4";
            // 
            // ipv4_tb
            // 
            this.ipv4_tb.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipv4_tb.Location = new System.Drawing.Point(61, 84);
            this.ipv4_tb.Name = "ipv4_tb";
            this.ipv4_tb.Size = new System.Drawing.Size(211, 27);
            this.ipv4_tb.TabIndex = 0;
            // 
            // port_tb
            // 
            this.port_tb.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_tb.Location = new System.Drawing.Point(61, 119);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(211, 27);
            this.port_tb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter IPV4 and PORT of server";
            // 
            // ok_btt
            // 
            this.ok_btt.FlatAppearance.BorderSize = 0;
            this.ok_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btt.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btt.Location = new System.Drawing.Point(0, 512);
            this.ok_btt.Name = "ok_btt";
            this.ok_btt.Size = new System.Drawing.Size(142, 42);
            this.ok_btt.TabIndex = 6;
            this.ok_btt.Text = "O K";
            this.ok_btt.UseVisualStyleBackColor = true;
            this.ok_btt.Click += new System.EventHandler(this.ok_btt_Click);
            // 
            // close_btt
            // 
            this.close_btt.FlatAppearance.BorderSize = 0;
            this.close_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btt.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btt.Location = new System.Drawing.Point(142, 512);
            this.close_btt.Name = "close_btt";
            this.close_btt.Size = new System.Drawing.Size(142, 42);
            this.close_btt.TabIndex = 7;
            this.close_btt.Text = "C L O S E";
            this.close_btt.UseVisualStyleBackColor = true;
            this.close_btt.Click += new System.EventHandler(this.close_btt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter MODE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "MODE";
            // 
            // modeList
            // 
            this.modeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeList.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeList.FormattingEnabled = true;
            this.modeList.Items.AddRange(new object[] {
            "USER",
            "MC",
            "LED"});
            this.modeList.Location = new System.Drawing.Point(61, 288);
            this.modeList.Name = "modeList";
            this.modeList.Size = new System.Drawing.Size(211, 27);
            this.modeList.TabIndex = 3;
            this.modeList.SelectedIndexChanged += new System.EventHandler(this.modeList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Enter INFOMATION ";
            // 
            // infomation_tb
            // 
            this.infomation_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infomation_tb.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infomation_tb.Location = new System.Drawing.Point(19, 423);
            this.infomation_tb.Multiline = true;
            this.infomation_tb.Name = "infomation_tb";
            this.infomation_tb.Size = new System.Drawing.Size(256, 83);
            this.infomation_tb.TabIndex = 5;
            // 
            // screenList
            // 
            this.screenList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenList.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenList.FormattingEnabled = true;
            this.screenList.Location = new System.Drawing.Point(64, 204);
            this.screenList.Name = "screenList";
            this.screenList.Size = new System.Drawing.Size(211, 27);
            this.screenList.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "INDEX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Screen INDEX";
            // 
            // userIndexList
            // 
            this.userIndexList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userIndexList.Enabled = false;
            this.userIndexList.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIndexList.FormattingEnabled = true;
            this.userIndexList.Location = new System.Drawing.Point(64, 359);
            this.userIndexList.Name = "userIndexList";
            this.userIndexList.Size = new System.Drawing.Size(211, 27);
            this.userIndexList.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "INDEX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(99, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Enter INDEX";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "CPO SCREEN CLIENT is running";
            this.notifyIcon.BalloonTipTitle = "CPO SCREEN CLIENT";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 554);
            this.Controls.Add(this.userIndexList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.screenList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.infomation_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modeList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.close_btt);
            this.Controls.Add(this.ok_btt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.port_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipv4_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipv4_tb;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ok_btt;
        private System.Windows.Forms.Button close_btt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox modeList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox infomation_tb;
        private System.Windows.Forms.ComboBox screenList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox userIndexList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

