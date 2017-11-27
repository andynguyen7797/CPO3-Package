namespace CPO3_Remaker
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.local_ipV4 = new System.Windows.Forms.TextBox();
            this.line3 = new CPO3_Remaker.Line();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_btt = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.close_btt = new System.Windows.Forms.Button();
            this.minisize_btt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.local_ipV4);
            this.panel1.Controls.Add(this.line3);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.login_btt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 715);
            this.panel1.TabIndex = 0;
            // 
            // local_ipV4
            // 
            this.local_ipV4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.local_ipV4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.local_ipV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.local_ipV4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.local_ipV4.Location = new System.Drawing.Point(1013, 290);
            this.local_ipV4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.local_ipV4.Name = "local_ipV4";
            this.local_ipV4.Size = new System.Drawing.Size(327, 23);
            this.local_ipV4.TabIndex = 2;
            this.local_ipV4.Text = "Enter local ipV4";
            this.local_ipV4.Click += new System.EventHandler(this.local_ipV4_Click);
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(1013, 311);
            this.line3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(327, 22);
            this.line3.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.richTextBox1.Location = new System.Drawing.Point(68, 336);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(704, 172);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(59, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 52);
            this.label2.TabIndex = 8;
            this.label2.Text = "WelCome To Ban Ki Thuat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // login_btt
            // 
            this.login_btt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.login_btt.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.login_btt.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.login_btt.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btt.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.login_btt.Appearance.Options.UseBackColor = true;
            this.login_btt.Appearance.Options.UseBorderColor = true;
            this.login_btt.Appearance.Options.UseFont = true;
            this.login_btt.Appearance.Options.UseForeColor = true;
            this.login_btt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.login_btt.Location = new System.Drawing.Point(1013, 340);
            this.login_btt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_btt.Name = "login_btt";
            this.login_btt.Size = new System.Drawing.Size(147, 44);
            this.login_btt.TabIndex = 3;
            this.login_btt.Text = "Start Server";
            this.login_btt.Click += new System.EventHandler(this.login_btt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(1007, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Local IPV4";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(960, 715);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // close_btt
            // 
            this.close_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btt.BackgroundImage")));
            this.close_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.close_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btt.Location = new System.Drawing.Point(1341, 4);
            this.close_btt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_btt.Name = "close_btt";
            this.close_btt.Size = new System.Drawing.Size(27, 25);
            this.close_btt.TabIndex = 1;
            this.close_btt.UseVisualStyleBackColor = true;
            this.close_btt.Click += new System.EventHandler(this.close_btt_Click);
            // 
            // minisize_btt
            // 
            this.minisize_btt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minisize_btt.BackgroundImage")));
            this.minisize_btt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minisize_btt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.minisize_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minisize_btt.Location = new System.Drawing.Point(1307, 4);
            this.minisize_btt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minisize_btt.Name = "minisize_btt";
            this.minisize_btt.Size = new System.Drawing.Size(27, 25);
            this.minisize_btt.TabIndex = 2;
            this.minisize_btt.UseVisualStyleBackColor = true;
            this.minisize_btt.Click += new System.EventHandler(this.minisize_btt_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 746);
            this.Controls.Add(this.minisize_btt);
            this.Controls.Add(this.close_btt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login_Form";
            this.Text = " ";
            this.Activated += new System.EventHandler(this.Login_Form_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_Form_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraEditors.SimpleButton login_btt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close_btt;
        private System.Windows.Forms.Button minisize_btt;
        private System.Windows.Forms.TextBox local_ipV4;
        private Line line3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}