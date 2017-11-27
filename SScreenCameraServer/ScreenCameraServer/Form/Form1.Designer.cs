namespace ScreenCameraServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.camera8 = new ScreenCameraServer.Camera();
            this.camera7 = new ScreenCameraServer.Camera();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.camera6 = new ScreenCameraServer.Camera();
            this.camera5 = new ScreenCameraServer.Camera();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.camera4 = new ScreenCameraServer.Camera();
            this.camera3 = new ScreenCameraServer.Camera();
            this.camera2 = new ScreenCameraServer.Camera();
            this.camera1 = new ScreenCameraServer.Camera();
            this.userCameraPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimine_btt = new System.Windows.Forms.Button();
            this.close_btt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.userCameraPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.userCameraPanel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1200, 745);
            this.mainPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 360);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(600, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 360);
            this.panel5.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.camera8);
            this.panel9.Controls.Add(this.camera7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 25);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(600, 335);
            this.panel9.TabIndex = 1;
            // 
            // camera8
            // 
            this.camera8.AccessibleDescription = "TV-LED";
            this.camera8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera8.Enabled = false;
            this.camera8.IndexOfUser = "2";
            this.camera8.Location = new System.Drawing.Point(300, 0);
            this.camera8.Mode = ScreenCameraServer.EnumManager.ModeOfCamera.LED;
            this.camera8.Name = "camera8";
            this.camera8.Size = new System.Drawing.Size(298, 333);
            this.camera8.SomeInfo = null;
            this.camera8.TabIndex = 1;
            this.camera8.Tag = "NULL";
            // 
            // camera7
            // 
            this.camera7.AccessibleDescription = "TV-LED";
            this.camera7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera7.Dock = System.Windows.Forms.DockStyle.Left;
            this.camera7.Enabled = false;
            this.camera7.IndexOfUser = "1";
            this.camera7.Location = new System.Drawing.Point(0, 0);
            this.camera7.Mode = ScreenCameraServer.EnumManager.ModeOfCamera.LED;
            this.camera7.Name = "camera7";
            this.camera7.Size = new System.Drawing.Size(300, 333);
            this.camera7.SomeInfo = null;
            this.camera7.TabIndex = 0;
            this.camera7.Tag = "NULL";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(208)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(600, 25);
            this.panel7.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(192, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "S C R E E N    O F    T V - L E D";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 360);
            this.panel4.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.camera6);
            this.panel8.Controls.Add(this.camera5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 25);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(600, 335);
            this.panel8.TabIndex = 1;
            // 
            // camera6
            // 
            this.camera6.AccessibleDescription = "MC";
            this.camera6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera6.Enabled = false;
            this.camera6.IndexOfUser = "2";
            this.camera6.Location = new System.Drawing.Point(300, 0);
            this.camera6.Mode = ScreenCameraServer.EnumManager.ModeOfCamera.MC;
            this.camera6.Name = "camera6";
            this.camera6.Size = new System.Drawing.Size(298, 333);
            this.camera6.SomeInfo = null;
            this.camera6.TabIndex = 1;
            this.camera6.Tag = "NULL";
            // 
            // camera5
            // 
            this.camera5.AccessibleDescription = "MC";
            this.camera5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera5.Dock = System.Windows.Forms.DockStyle.Left;
            this.camera5.Enabled = false;
            this.camera5.IndexOfUser = "1";
            this.camera5.Location = new System.Drawing.Point(0, 0);
            this.camera5.Mode = ScreenCameraServer.EnumManager.ModeOfCamera.MC;
            this.camera5.Name = "camera5";
            this.camera5.Size = new System.Drawing.Size(300, 333);
            this.camera5.SomeInfo = null;
            this.camera5.TabIndex = 0;
            this.camera5.Tag = "NULL";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(208)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 25);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(203, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "S C R E E N    O F    M C";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.camera4);
            this.panel2.Controls.Add(this.camera3);
            this.panel2.Controls.Add(this.camera2);
            this.panel2.Controls.Add(this.camera1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 335);
            this.panel2.TabIndex = 2;
            // 
            // camera4
            // 
            this.camera4.AccessibleDescription = "user";
            this.camera4.AccessibleName = "";
            this.camera4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera4.Enabled = false;
            this.camera4.IndexOfUser = "4";
            this.camera4.Location = new System.Drawing.Point(900, 0);
            this.camera4.Mode = ScreenCameraServer.EnumManager.ModeOfCamera.USER;
            this.camera4.Name = "camera4";
            this.camera4.Size = new System.Drawing.Size(300, 335);
            this.camera4.SomeInfo = null;
            this.camera4.TabIndex = 3;
            this.camera4.Tag = "NULL";
            // 
            // camera3
            // 
            this.camera3.AccessibleDescription = "user";
            this.camera3.AccessibleName = "";
            this.camera3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera3.Dock = System.Windows.Forms.DockStyle.Left;
            this.camera3.Enabled = false;
            this.camera3.IndexOfUser = "3";
            this.camera3.Location = new System.Drawing.Point(600, 0);
            this.camera3.Mode = ScreenCameraServer.EnumManager.ModeOfCamera.USER;
            this.camera3.Name = "camera3";
            this.camera3.Size = new System.Drawing.Size(300, 335);
            this.camera3.SomeInfo = null;
            this.camera3.TabIndex = 2;
            this.camera3.Tag = "NULL";
            // 
            // camera2
            // 
            this.camera2.AccessibleDescription = "user";
            this.camera2.AccessibleName = "";
            this.camera2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera2.Dock = System.Windows.Forms.DockStyle.Left;
            this.camera2.Enabled = false;
            this.camera2.IndexOfUser = "2";
            this.camera2.Location = new System.Drawing.Point(300, 0);
            this.camera2.Mode = ScreenCameraServer.EnumManager.ModeOfCamera.USER;
            this.camera2.Name = "camera2";
            this.camera2.Size = new System.Drawing.Size(300, 335);
            this.camera2.SomeInfo = null;
            this.camera2.TabIndex = 1;
            this.camera2.Tag = "NULL";
            // 
            // camera1
            // 
            this.camera1.AccessibleDescription = "user";
            this.camera1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camera1.Dock = System.Windows.Forms.DockStyle.Left;
            this.camera1.Enabled = false;
            this.camera1.IndexOfUser = "1";
            this.camera1.Location = new System.Drawing.Point(0, 0);
            this.camera1.Mode = ScreenCameraServer.EnumManager.ModeOfCamera.USER;
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(300, 335);
            this.camera1.SomeInfo = null;
            this.camera1.TabIndex = 0;
            this.camera1.Tag = "NULL";
            // 
            // userCameraPanel
            // 
            this.userCameraPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(208)))));
            this.userCameraPanel.Controls.Add(this.label2);
            this.userCameraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userCameraPanel.Location = new System.Drawing.Point(0, 25);
            this.userCameraPanel.Name = "userCameraPanel";
            this.userCameraPanel.Size = new System.Drawing.Size(1200, 25);
            this.userCameraPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(503, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "S C R E E N    O F    U S E R";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.minimine_btt);
            this.panel1.Controls.Add(this.close_btt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minimine_btt
            // 
            this.minimine_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimine_btt.BackgroundImage")));
            this.minimine_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimine_btt.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimine_btt.FlatAppearance.BorderSize = 0;
            this.minimine_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimine_btt.Location = new System.Drawing.Point(1150, 0);
            this.minimine_btt.Name = "minimine_btt";
            this.minimine_btt.Size = new System.Drawing.Size(25, 25);
            this.minimine_btt.TabIndex = 2;
            this.minimine_btt.UseVisualStyleBackColor = true;
            this.minimine_btt.Click += new System.EventHandler(this.minimine_btt_Click);
            // 
            // close_btt
            // 
            this.close_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btt.BackgroundImage")));
            this.close_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btt.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btt.FlatAppearance.BorderSize = 0;
            this.close_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btt.Location = new System.Drawing.Point(1175, 0);
            this.close_btt.Name = "close_btt";
            this.close_btt.Size = new System.Drawing.Size(25, 25);
            this.close_btt.TabIndex = 1;
            this.close_btt.UseVisualStyleBackColor = true;
            this.close_btt.Click += new System.EventHandler(this.close_btt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "S C R E E N    M A N A G E R";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(19, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 745);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.mainPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.userCameraPanel.ResumeLayout(false);
            this.userCameraPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private Camera camera8;
        private Camera camera7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private Camera camera6;
        private Camera camera5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Camera camera4;
        private Camera camera3;
        private Camera camera2;
        private Camera camera1;
        private System.Windows.Forms.Panel userCameraPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimine_btt;
        private System.Windows.Forms.Button close_btt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

