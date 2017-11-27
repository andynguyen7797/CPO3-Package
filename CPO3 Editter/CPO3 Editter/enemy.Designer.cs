namespace CPO3_Editter
{
    partial class enemy
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
            this.enemy_pic = new System.Windows.Forms.PictureBox();
            this.enemy_current_score = new System.Windows.Forms.Label();
            this.enemy_name_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // enemy_pic
            // 
            this.enemy_pic.BackColor = System.Drawing.SystemColors.Control;
            this.enemy_pic.Location = new System.Drawing.Point(0, 0);
            this.enemy_pic.Name = "enemy_pic";
            this.enemy_pic.Size = new System.Drawing.Size(150, 73);
            this.enemy_pic.TabIndex = 0;
            this.enemy_pic.TabStop = false;
            // 
            // enemy_current_score
            // 
            this.enemy_current_score.AutoSize = true;
            this.enemy_current_score.Font = new System.Drawing.Font("TimeBurner", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_current_score.ForeColor = System.Drawing.SystemColors.Control;
            this.enemy_current_score.Location = new System.Drawing.Point(169, 17);
            this.enemy_current_score.Name = "enemy_current_score";
            this.enemy_current_score.Size = new System.Drawing.Size(85, 61);
            this.enemy_current_score.TabIndex = 1;
            this.enemy_current_score.Text = "00";
            // 
            // enemy_name_lb
            // 
            this.enemy_name_lb.AutoSize = true;
            this.enemy_name_lb.BackColor = System.Drawing.SystemColors.Control;
            this.enemy_name_lb.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_name_lb.Location = new System.Drawing.Point(12, 25);
            this.enemy_name_lb.Name = "enemy_name_lb";
            this.enemy_name_lb.Size = new System.Drawing.Size(129, 23);
            this.enemy_name_lb.TabIndex = 2;
            this.enemy_name_lb.Text = "ENEMY NAME";
            // 
            // enemy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.enemy_name_lb);
            this.Controls.Add(this.enemy_current_score);
            this.Controls.Add(this.enemy_pic);
            this.Name = "enemy";
            this.Size = new System.Drawing.Size(268, 73);
            ((System.ComponentModel.ISupportInitialize)(this.enemy_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemy_pic;
        public System.Windows.Forms.Label enemy_name_lb;
        public System.Windows.Forms.Label enemy_current_score;
    }
}
