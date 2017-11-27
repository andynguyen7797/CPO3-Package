namespace ScreenCameraServer
{
    partial class Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camera));
            this.cameraView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.delay_tb = new System.Windows.Forms.TextBox();
            this.zoomOutCamera = new System.Windows.Forms.Button();
            this.infoOfCamera = new System.Windows.Forms.Button();
            this.setDelayTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraView
            // 
            this.cameraView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cameraView.Dock = System.Windows.Forms.DockStyle.Top;
            this.cameraView.Location = new System.Drawing.Point(0, 0);
            this.cameraView.Name = "cameraView";
            this.cameraView.Size = new System.Drawing.Size(300, 300);
            this.cameraView.TabIndex = 0;
            this.cameraView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.setDelayTime);
            this.panel1.Controls.Add(this.infoOfCamera);
            this.panel1.Controls.Add(this.zoomOutCamera);
            this.panel1.Controls.Add(this.delay_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delay";
            // 
            // delay_tb
            // 
            this.delay_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delay_tb.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delay_tb.Location = new System.Drawing.Point(57, 4);
            this.delay_tb.Name = "delay_tb";
            this.delay_tb.Size = new System.Drawing.Size(100, 27);
            this.delay_tb.TabIndex = 1;
            // 
            // zoomOutCamera
            // 
            this.zoomOutCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomOutCamera.BackgroundImage")));
            this.zoomOutCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomOutCamera.FlatAppearance.BorderSize = 0;
            this.zoomOutCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomOutCamera.Location = new System.Drawing.Point(224, 0);
            this.zoomOutCamera.Name = "zoomOutCamera";
            this.zoomOutCamera.Size = new System.Drawing.Size(35, 35);
            this.zoomOutCamera.TabIndex = 2;
            this.zoomOutCamera.UseVisualStyleBackColor = true;
            this.zoomOutCamera.Click += new System.EventHandler(this.zoomOutCamera_Click);
            // 
            // infoOfCamera
            // 
            this.infoOfCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoOfCamera.BackgroundImage")));
            this.infoOfCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoOfCamera.FlatAppearance.BorderSize = 0;
            this.infoOfCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoOfCamera.Location = new System.Drawing.Point(265, 0);
            this.infoOfCamera.Name = "infoOfCamera";
            this.infoOfCamera.Size = new System.Drawing.Size(35, 35);
            this.infoOfCamera.TabIndex = 3;
            this.infoOfCamera.UseVisualStyleBackColor = true;
            this.infoOfCamera.Click += new System.EventHandler(this.infoOfCamera_Click);
            // 
            // setDelayTime
            // 
            this.setDelayTime.FlatAppearance.BorderSize = 0;
            this.setDelayTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setDelayTime.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDelayTime.ForeColor = System.Drawing.SystemColors.Control;
            this.setDelayTime.Location = new System.Drawing.Point(163, 0);
            this.setDelayTime.Name = "setDelayTime";
            this.setDelayTime.Size = new System.Drawing.Size(55, 35);
            this.setDelayTime.TabIndex = 4;
            this.setDelayTime.Text = "OK";
            this.setDelayTime.UseVisualStyleBackColor = true;
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cameraView);
            this.Name = "Camera";
            this.Size = new System.Drawing.Size(300, 335);
            ((System.ComponentModel.ISupportInitialize)(this.cameraView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button infoOfCamera;
        private System.Windows.Forms.Button zoomOutCamera;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button setDelayTime;
        public System.Windows.Forms.TextBox delay_tb;
    }
}
