namespace ScreenCameraServer
{
    partial class CameraFullScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraFullScreen));
            this.cameraView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimine_btt = new System.Windows.Forms.Button();
            this.close_btt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maxisize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraView
            // 
            this.cameraView.BackColor = System.Drawing.SystemColors.Control;
            this.cameraView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cameraView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraView.Location = new System.Drawing.Point(0, 0);
            this.cameraView.Name = "cameraView";
            this.cameraView.Size = new System.Drawing.Size(300, 261);
            this.cameraView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cameraView.TabIndex = 0;
            this.cameraView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.maxisize);
            this.panel1.Controls.Add(this.minimine_btt);
            this.panel1.Controls.Add(this.close_btt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 29);
            this.panel1.TabIndex = 1;
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
            this.minimine_btt.Location = new System.Drawing.Point(242, 0);
            this.minimine_btt.Name = "minimine_btt";
            this.minimine_btt.Size = new System.Drawing.Size(29, 29);
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
            this.close_btt.Location = new System.Drawing.Point(271, 0);
            this.close_btt.Name = "close_btt";
            this.close_btt.Size = new System.Drawing.Size(29, 29);
            this.close_btt.TabIndex = 1;
            this.close_btt.UseVisualStyleBackColor = true;
            this.close_btt.Click += new System.EventHandler(this.close_btt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "S C R E E N    S E R V E R";
            // 
            // maxisize
            // 
            this.maxisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maxisize.BackgroundImage")));
            this.maxisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxisize.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxisize.FlatAppearance.BorderSize = 0;
            this.maxisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxisize.Location = new System.Drawing.Point(214, 0);
            this.maxisize.Name = "maxisize";
            this.maxisize.Size = new System.Drawing.Size(28, 29);
            this.maxisize.TabIndex = 3;
            this.maxisize.UseVisualStyleBackColor = true;
            this.maxisize.Click += new System.EventHandler(this.maxisize_Click);
            // 
            // CameraFullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cameraView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraFullScreen";
            this.Text = "CameraFullScreen";
            ((System.ComponentModel.ISupportInitialize)(this.cameraView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimine_btt;
        private System.Windows.Forms.Button close_btt;
        private System.Windows.Forms.Button maxisize;
    }
}