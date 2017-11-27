namespace CPO3_Editter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.miniForm_btt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimine_btt = new System.Windows.Forms.Button();
            this.close_btt = new System.Windows.Forms.Button();
            this.nameOfSoftware = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.enemy4 = new CPO3_Editter.enemy();
            this.enemy3 = new CPO3_Editter.enemy();
            this.enemy2 = new CPO3_Editter.enemy();
            this.enemy1 = new CPO3_Editter.enemy();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.player_Status = new CPO3_Editter.Player_Status();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.miniForm_btt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.minimine_btt);
            this.panel1.Controls.Add(this.close_btt);
            this.panel1.Controls.Add(this.nameOfSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // miniForm_btt
            // 
            this.miniForm_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("miniForm_btt.BackgroundImage")));
            this.miniForm_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniForm_btt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.miniForm_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniForm_btt.Location = new System.Drawing.Point(505, 1);
            this.miniForm_btt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miniForm_btt.Name = "miniForm_btt";
            this.miniForm_btt.Size = new System.Drawing.Size(31, 28);
            this.miniForm_btt.TabIndex = 4;
            this.miniForm_btt.UseVisualStyleBackColor = true;
            this.miniForm_btt.Click += new System.EventHandler(this.miniForm_btt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // minimine_btt
            // 
            this.minimine_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimine_btt.BackgroundImage")));
            this.minimine_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimine_btt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.minimine_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimine_btt.Location = new System.Drawing.Point(544, 1);
            this.minimine_btt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimine_btt.Name = "minimine_btt";
            this.minimine_btt.Size = new System.Drawing.Size(31, 28);
            this.minimine_btt.TabIndex = 2;
            this.minimine_btt.UseVisualStyleBackColor = true;
            this.minimine_btt.Click += new System.EventHandler(this.minimine_btt_Click);
            // 
            // close_btt
            // 
            this.close_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btt.BackgroundImage")));
            this.close_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.close_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btt.Location = new System.Drawing.Point(583, 1);
            this.close_btt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_btt.Name = "close_btt";
            this.close_btt.Size = new System.Drawing.Size(31, 28);
            this.close_btt.TabIndex = 1;
            this.close_btt.UseVisualStyleBackColor = true;
            this.close_btt.Click += new System.EventHandler(this.close_btt_Click);
            // 
            // nameOfSoftware
            // 
            this.nameOfSoftware.AutoSize = true;
            this.nameOfSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfSoftware.Location = new System.Drawing.Point(48, 5);
            this.nameOfSoftware.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameOfSoftware.Name = "nameOfSoftware";
            this.nameOfSoftware.Size = new System.Drawing.Size(127, 25);
            this.nameOfSoftware.TabIndex = 0;
            this.nameOfSoftware.Text = "CPO3 Editter";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.enemy4);
            this.panel3.Controls.Add(this.enemy3);
            this.panel3.Controls.Add(this.enemy2);
            this.panel3.Controls.Add(this.enemy1);
            this.panel3.Location = new System.Drawing.Point(263, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 361);
            this.panel3.TabIndex = 4;
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.enemy4.Location = new System.Drawing.Point(3, 271);
            this.enemy4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(351, 92);
            this.enemy4.TabIndex = 3;
            this.enemy4.Tag = "3";
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.enemy3.Location = new System.Drawing.Point(3, 183);
            this.enemy3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(351, 87);
            this.enemy3.TabIndex = 2;
            this.enemy3.Tag = "3";
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.enemy2.Location = new System.Drawing.Point(3, 94);
            this.enemy2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(351, 90);
            this.enemy2.TabIndex = 1;
            this.enemy2.Tag = "2";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.enemy1.Location = new System.Drawing.Point(3, 4);
            this.enemy1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(351, 90);
            this.enemy1.TabIndex = 0;
            this.enemy1.Tag = "1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.player_Status);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 365);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 338);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 26);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(47, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // player_Status
            // 
            this.player_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.player_Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.player_Status.Ip_receiver = null;
            this.player_Status.Location = new System.Drawing.Point(0, 0);
            this.player_Status.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.player_Status.Name = "player_Status";
            this.player_Status.Size = new System.Drawing.Size(263, 365);
            this.player_Status.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(620, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private enemy enemy3;
        private enemy enemy2;
        private enemy enemy1;
        private System.Windows.Forms.Label nameOfSoftware;
        private System.Windows.Forms.Button minimine_btt;
        private System.Windows.Forms.Button close_btt;
        public Player_Status player_Status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private enemy enemy4;
        private System.Windows.Forms.Button miniForm_btt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}

