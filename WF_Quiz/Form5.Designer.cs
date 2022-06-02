
namespace WF_Quiz
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btn_profile = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_master = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_records = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Location = new System.Drawing.Point(647, 28);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(126, 27);
            this.btn_profile.TabIndex = 17;
            this.btn_profile.Text = "Выбрать профиль";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.lbl_name.Location = new System.Drawing.Point(645, 8);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(32, 13);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Имя";
            // 
            // btn_master
            // 
            this.btn_master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_master.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_master.FlatAppearance.BorderSize = 0;
            this.btn_master.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_master.Font = new System.Drawing.Font("Segoe Print", 15F);
            this.btn_master.ForeColor = System.Drawing.Color.White;
            this.btn_master.Location = new System.Drawing.Point(286, 224);
            this.btn_master.Name = "btn_master";
            this.btn_master.Size = new System.Drawing.Size(199, 42);
            this.btn_master.TabIndex = 14;
            this.btn_master.Text = "Мастер викторин";
            this.btn_master.UseVisualStyleBackColor = false;
            this.btn_master.Click += new System.EventHandler(this.btn_master_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe Print", 15F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(286, 348);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(199, 42);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_records
            // 
            this.btn_records.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_records.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_records.FlatAppearance.BorderSize = 0;
            this.btn_records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_records.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_records.ForeColor = System.Drawing.Color.White;
            this.btn_records.Location = new System.Drawing.Point(286, 286);
            this.btn_records.Name = "btn_records";
            this.btn_records.Size = new System.Drawing.Size(199, 42);
            this.btn_records.TabIndex = 12;
            this.btn_records.Text = "Рекорды";
            this.btn_records.UseVisualStyleBackColor = false;
            this.btn_records.Click += new System.EventHandler(this.btn_records_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Segoe Print", 15F);
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(286, 164);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(199, 42);
            this.btn_Start.TabIndex = 11;
            this.btn_Start.Text = "Начать";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.lbl_info.Location = new System.Drawing.Point(686, 426);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(86, 13);
            this.lbl_info.TabIndex = 18;
            this.lbl_info.Text = "О программе";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_info.Click += new System.EventHandler(this.lbl_info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WF_Quiz.Properties.Resources.SharpQuiz;
            this.pictureBox1.Location = new System.Drawing.Point(255, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.label1.Location = new System.Drawing.Point(664, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "🛈";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 448);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_master);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_records);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SharpQuiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_profile;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_master;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_records;
        public System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label label1;
    }
}