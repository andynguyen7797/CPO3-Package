namespace CPO3_Editter
{
    partial class Score_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score_Screen));
            this.name = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.name.Dock = System.Windows.Forms.DockStyle.Top;
            this.name.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(284, 35);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            this.name.UseVisualStyleBackColor = false;
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.score.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.score.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(0, 176);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(284, 85);
            this.score.TabIndex = 3;
            this.score.Text = "Score";
            this.score.UseVisualStyleBackColor = false;
            // 
            // Score_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.score);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Score_Screen";
            this.Text = "Score_Screen";
            this.Resize += new System.EventHandler(this.Score_Screen_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button name;
        public System.Windows.Forms.Button score;
    }
}