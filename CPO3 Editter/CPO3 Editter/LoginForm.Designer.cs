namespace CPO3_Editter
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_may_nhan_lb = new System.Windows.Forms.Label();
            this.ip_receiver_tb = new System.Windows.Forms.TextBox();
            this.close_btt = new System.Windows.Forms.Button();
            this.connect_btt = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ipCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userIndex = new System.Windows.Forms.ComboBox();
            this.line2 = new CPO3_Editter.line();
            this.line1 = new CPO3_Editter.line();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 71);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(167, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "THIẾT LẬP";
            // 
            // ip_may_nhan_lb
            // 
            this.ip_may_nhan_lb.AutoSize = true;
            this.ip_may_nhan_lb.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_may_nhan_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.ip_may_nhan_lb.Location = new System.Drawing.Point(12, 105);
            this.ip_may_nhan_lb.Name = "ip_may_nhan_lb";
            this.ip_may_nhan_lb.Size = new System.Drawing.Size(147, 29);
            this.ip_may_nhan_lb.TabIndex = 1;
            this.ip_may_nhan_lb.Text = "IP Máy Nhận";
            // 
            // ip_receiver_tb
            // 
            this.ip_receiver_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ip_receiver_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip_receiver_tb.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_receiver_tb.ForeColor = System.Drawing.SystemColors.Control;
            this.ip_receiver_tb.Location = new System.Drawing.Point(175, 110);
            this.ip_receiver_tb.Name = "ip_receiver_tb";
            this.ip_receiver_tb.Size = new System.Drawing.Size(337, 29);
            this.ip_receiver_tb.TabIndex = 2;
            // 
            // close_btt
            // 
            this.close_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.close_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btt.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.close_btt.Location = new System.Drawing.Point(319, 223);
            this.close_btt.Name = "close_btt";
            this.close_btt.Size = new System.Drawing.Size(193, 54);
            this.close_btt.TabIndex = 10;
            this.close_btt.Text = "Đóng";
            this.close_btt.UseVisualStyleBackColor = true;
            this.close_btt.Click += new System.EventHandler(this.close_btt_Click);
            // 
            // connect_btt
            // 
            this.connect_btt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.connect_btt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect_btt.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_btt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.connect_btt.Location = new System.Drawing.Point(120, 223);
            this.connect_btt.Name = "connect_btt";
            this.connect_btt.Size = new System.Drawing.Size(193, 54);
            this.connect_btt.TabIndex = 11;
            this.connect_btt.Text = "KẾT NỐI";
            this.connect_btt.UseVisualStyleBackColor = true;
            this.connect_btt.Click += new System.EventHandler(this.connect_btt_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.OwnerDraw = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ipCombobox
            // 
            this.ipCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ipCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ipCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ipCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ipCombobox.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipCombobox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ipCombobox.FormattingEnabled = true;
            this.ipCombobox.Location = new System.Drawing.Point(175, 102);
            this.ipCombobox.Name = "ipCombobox";
            this.ipCombobox.Size = new System.Drawing.Size(337, 37);
            this.ipCombobox.Sorted = true;
            this.ipCombobox.TabIndex = 12;
            this.toolTip.SetToolTip(this.ipCombobox, "Danh sách IP tìm thấy trong LAN");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số thứ tự";
            // 
            // userIndex
            // 
            this.userIndex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userIndex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.userIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIndex.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIndex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.userIndex.FormattingEnabled = true;
            this.userIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.userIndex.Location = new System.Drawing.Point(175, 155);
            this.userIndex.Name = "userIndex";
            this.userIndex.Size = new System.Drawing.Size(337, 37);
            this.userIndex.Sorted = true;
            this.userIndex.TabIndex = 15;
            this.toolTip.SetToolTip(this.userIndex, "Danh sách thứ tự các thí sinh\r\nCần cho việc backup lại nếu đường truyền có vấn đề" +
        "\r\nHay Server bị sập");
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(175, 193);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(337, 11);
            this.line2.TabIndex = 14;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(175, 140);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(337, 11);
            this.line1.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(524, 289);
            this.Controls.Add(this.userIndex);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipCombobox);
            this.Controls.Add(this.connect_btt);
            this.Controls.Add(this.close_btt);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.ip_receiver_tb);
            this.Controls.Add(this.ip_may_nhan_lb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ip_may_nhan_lb;
        private line line1;
        private System.Windows.Forms.Button close_btt;
        private System.Windows.Forms.Button connect_btt;
        public System.Windows.Forms.TextBox ip_receiver_tb;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox ipCombobox;
        private line line2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox userIndex;
    }
}