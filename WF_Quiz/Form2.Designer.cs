
namespace WF_Quiz
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_opnFile = new System.Windows.Forms.Button();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.btn_addQuestion = new System.Windows.Forms.Button();
            this.btn_dltQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nextQ = new System.Windows.Forms.Button();
            this.btn_previousQ = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 60F);
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.linkLabel1.Location = new System.Drawing.Point(-16, -29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 112);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.Text = "<";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            this.linkLabel1.MouseEnter += new System.EventHandler(this.linkLabel1_MouseEnter);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(185, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.label5.Location = new System.Drawing.Point(248, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 47);
            this.label5.TabIndex = 13;
            this.label5.Text = "Мастер викторин";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(771, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(69, 94);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Вопрос";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Правильный ответ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Неправильный ответ 1";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Неправильный ответ 2";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Фото";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(168, 290);
            this.textBox1.MaxLength = 120;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(168, 343);
            this.textBox2.MaxLength = 30;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 41);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(317, 343);
            this.textBox3.MaxLength = 30;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 41);
            this.textBox3.TabIndex = 4;
            this.textBox3.TabStop = false;
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(467, 343);
            this.textBox4.MaxLength = 30;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 41);
            this.textBox4.TabIndex = 5;
            this.textBox4.TabStop = false;
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // btn_opnFile
            // 
            this.btn_opnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_opnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_opnFile.FlatAppearance.BorderSize = 0;
            this.btn_opnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opnFile.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.btn_opnFile.ForeColor = System.Drawing.Color.White;
            this.btn_opnFile.Location = new System.Drawing.Point(100, 394);
            this.btn_opnFile.Name = "btn_opnFile";
            this.btn_opnFile.Size = new System.Drawing.Size(134, 34);
            this.btn_opnFile.TabIndex = 6;
            this.btn_opnFile.Text = "Открыть файл";
            this.btn_opnFile.UseVisualStyleBackColor = false;
            this.btn_opnFile.Click += new System.EventHandler(this.btn_opnFile_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_saveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveFile.FlatAppearance.BorderSize = 0;
            this.btn_saveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveFile.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.btn_saveFile.ForeColor = System.Drawing.Color.White;
            this.btn_saveFile.Location = new System.Drawing.Point(246, 394);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(134, 34);
            this.btn_saveFile.TabIndex = 7;
            this.btn_saveFile.Text = "Сохранить в файл";
            this.btn_saveFile.UseVisualStyleBackColor = false;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // btn_addQuestion
            // 
            this.btn_addQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_addQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addQuestion.FlatAppearance.BorderSize = 0;
            this.btn_addQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addQuestion.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.btn_addQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_addQuestion.Location = new System.Drawing.Point(391, 394);
            this.btn_addQuestion.Name = "btn_addQuestion";
            this.btn_addQuestion.Size = new System.Drawing.Size(134, 34);
            this.btn_addQuestion.TabIndex = 8;
            this.btn_addQuestion.Text = "Добавить вопрос";
            this.btn_addQuestion.UseVisualStyleBackColor = false;
            this.btn_addQuestion.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_dltQuestion
            // 
            this.btn_dltQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_dltQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dltQuestion.FlatAppearance.BorderSize = 0;
            this.btn_dltQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dltQuestion.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.btn_dltQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_dltQuestion.Location = new System.Drawing.Point(538, 394);
            this.btn_dltQuestion.Name = "btn_dltQuestion";
            this.btn_dltQuestion.Size = new System.Drawing.Size(134, 34);
            this.btn_dltQuestion.TabIndex = 15;
            this.btn_dltQuestion.Text = "Удалить вопрос";
            this.btn_dltQuestion.UseVisualStyleBackColor = false;
            this.btn_dltQuestion.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.label1.Location = new System.Drawing.Point(281, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Чтобы добавить  фото нажмите здесь";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(771, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 110);
            this.panel1.TabIndex = 17;
            // 
            // btn_nextQ
            // 
            this.btn_nextQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_nextQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextQ.FlatAppearance.BorderSize = 0;
            this.btn_nextQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextQ.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btn_nextQ.ForeColor = System.Drawing.Color.White;
            this.btn_nextQ.Location = new System.Drawing.Point(-2, -10);
            this.btn_nextQ.Name = "btn_nextQ";
            this.btn_nextQ.Size = new System.Drawing.Size(42, 47);
            this.btn_nextQ.TabIndex = 18;
            this.btn_nextQ.Text = ">";
            this.btn_nextQ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_nextQ.UseVisualStyleBackColor = false;
            this.btn_nextQ.Click += new System.EventHandler(this.btn_nextQ_Click);
            // 
            // btn_previousQ
            // 
            this.btn_previousQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_previousQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previousQ.FlatAppearance.BorderSize = 0;
            this.btn_previousQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previousQ.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btn_previousQ.ForeColor = System.Drawing.Color.White;
            this.btn_previousQ.Location = new System.Drawing.Point(-6, -10);
            this.btn_previousQ.Name = "btn_previousQ";
            this.btn_previousQ.Size = new System.Drawing.Size(50, 50);
            this.btn_previousQ.TabIndex = 19;
            this.btn_previousQ.Text = "<";
            this.btn_previousQ.UseVisualStyleBackColor = false;
            this.btn_previousQ.Click += new System.EventHandler(this.btn_previousQ_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.Color.Coral;
            this.lbl_name.Location = new System.Drawing.Point(775, 529);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 13);
            this.lbl_name.TabIndex = 20;
            this.lbl_name.Text = "lbl_name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_nextQ);
            this.panel2.Location = new System.Drawing.Point(619, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 36);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_previousQ);
            this.panel3.Location = new System.Drawing.Point(115, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 36);
            this.panel3.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 448);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dltQuestion);
            this.Controls.Add(this.btn_addQuestion);
            this.Controls.Add(this.btn_saveFile);
            this.Controls.Add(this.btn_opnFile);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SharpQuiz";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_opnFile;
        private System.Windows.Forms.Button btn_saveFile;
        private System.Windows.Forms.Button btn_addQuestion;
        private System.Windows.Forms.Button btn_dltQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nextQ;
        private System.Windows.Forms.Button btn_previousQ;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}