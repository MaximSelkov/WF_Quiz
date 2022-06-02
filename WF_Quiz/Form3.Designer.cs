namespace WF_Quiz
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.blb_mistaces = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_question = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_false2 = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_false = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_numOfQst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счёт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ошибок:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Segoe Print", 15F);
            this.lbl_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.lbl_score.Location = new System.Drawing.Point(84, 13);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(30, 35);
            this.lbl_score.TabIndex = 2;
            this.lbl_score.Text = "0";
            // 
            // blb_mistaces
            // 
            this.blb_mistaces.AutoSize = true;
            this.blb_mistaces.BackColor = System.Drawing.Color.Transparent;
            this.blb_mistaces.Font = new System.Drawing.Font("Segoe Print", 15F);
            this.blb_mistaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.blb_mistaces.Location = new System.Drawing.Point(108, 42);
            this.blb_mistaces.Name = "blb_mistaces";
            this.blb_mistaces.Size = new System.Drawing.Size(30, 35);
            this.blb_mistaces.TabIndex = 3;
            this.blb_mistaces.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.label5.Location = new System.Drawing.Point(340, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вопрос";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(194, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.BackColor = System.Drawing.Color.Transparent;
            this.label_question.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.label_question.Location = new System.Drawing.Point(199, 301);
            this.label_question.MaximumSize = new System.Drawing.Size(450, 0);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(70, 21);
            this.label_question.TabIndex = 7;
            this.label_question.Text = "question";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(764, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 77);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(112, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 236);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // btn_false2
            // 
            this.btn_false2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_false2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_false2.FlatAppearance.BorderSize = 0;
            this.btn_false2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_false2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_false2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_false2.Location = new System.Drawing.Point(482, 377);
            this.btn_false2.Name = "btn_false2";
            this.btn_false2.Size = new System.Drawing.Size(133, 41);
            this.btn_false2.TabIndex = 9;
            this.btn_false2.Text = "false2";
            this.btn_false2.UseVisualStyleBackColor = false;
            this.btn_false2.Click += new System.EventHandler(this.btn_false2_Click);
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_right.FlatAppearance.BorderSize = 0;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_right.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_right.Location = new System.Drawing.Point(328, 377);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(133, 41);
            this.btn_right.TabIndex = 8;
            this.btn_right.Text = "right";
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_false
            // 
            this.btn_false.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_false.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_false.FlatAppearance.BorderSize = 0;
            this.btn_false.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_false.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_false.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_false.Location = new System.Drawing.Point(173, 377);
            this.btn_false.Name = "btn_false";
            this.btn_false.Size = new System.Drawing.Size(133, 41);
            this.btn_false.TabIndex = 10;
            this.btn_false.Text = "false";
            this.btn_false.UseVisualStyleBackColor = false;
            this.btn_false.Click += new System.EventHandler(this.btn_false_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(774, 496);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 13);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "lbl_name";
            // 
            // lbl_numOfQst
            // 
            this.lbl_numOfQst.AutoSize = true;
            this.lbl_numOfQst.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numOfQst.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_numOfQst.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_numOfQst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.lbl_numOfQst.Location = new System.Drawing.Point(423, 59);
            this.lbl_numOfQst.Name = "lbl_numOfQst";
            this.lbl_numOfQst.Size = new System.Drawing.Size(30, 35);
            this.lbl_numOfQst.TabIndex = 13;
            this.lbl_numOfQst.Text = "1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 448);
            this.Controls.Add(this.lbl_numOfQst);
            this.Controls.Add(this.btn_false2);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_false);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.blb_mistaces);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SharpQuiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label blb_mistaces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_false2;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_false;
        public System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_numOfQst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}