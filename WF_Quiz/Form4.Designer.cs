
namespace WF_Quiz
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_records = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_addFromFile = new System.Windows.Forms.Button();
            this.btn_saveInFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.linkLabel1.Location = new System.Drawing.Point(-13, -35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 113);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.Text = "<";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click_1);
            this.linkLabel1.MouseEnter += new System.EventHandler(this.linkLabel1_MouseEnter_1);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.textBox1.Location = new System.Drawing.Point(92, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(628, 283);
            this.textBox1.TabIndex = 4;
            // 
            // lbl_records
            // 
            this.lbl_records.AutoSize = true;
            this.lbl_records.BackColor = System.Drawing.Color.Transparent;
            this.lbl_records.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_records.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.lbl_records.Location = new System.Drawing.Point(316, 20);
            this.lbl_records.Name = "lbl_records";
            this.lbl_records.Size = new System.Drawing.Size(135, 47);
            this.lbl_records.TabIndex = 9;
            this.lbl_records.Text = "Рекорды";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(772, 440);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 13);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "lbl_name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(764, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 21);
            this.panel1.TabIndex = 11;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(92, 386);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(83, 39);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_addFromFile
            // 
            this.btn_addFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_addFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addFromFile.FlatAppearance.BorderSize = 0;
            this.btn_addFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFromFile.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.btn_addFromFile.ForeColor = System.Drawing.Color.White;
            this.btn_addFromFile.Location = new System.Drawing.Point(436, 386);
            this.btn_addFromFile.Name = "btn_addFromFile";
            this.btn_addFromFile.Size = new System.Drawing.Size(136, 39);
            this.btn_addFromFile.TabIndex = 2;
            this.btn_addFromFile.Text = "Добавить из файла";
            this.btn_addFromFile.UseVisualStyleBackColor = false;
            this.btn_addFromFile.Click += new System.EventHandler(this.btn_addFromFile_Click);
            // 
            // btn_saveInFile
            // 
            this.btn_saveInFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(27)))));
            this.btn_saveInFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveInFile.FlatAppearance.BorderSize = 0;
            this.btn_saveInFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveInFile.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.btn_saveInFile.ForeColor = System.Drawing.Color.White;
            this.btn_saveInFile.Location = new System.Drawing.Point(596, 386);
            this.btn_saveInFile.Name = "btn_saveInFile";
            this.btn_saveInFile.Size = new System.Drawing.Size(124, 39);
            this.btn_saveInFile.TabIndex = 3;
            this.btn_saveInFile.Text = "Сохранить в файл";
            this.btn_saveInFile.UseVisualStyleBackColor = false;
            this.btn_saveInFile.Click += new System.EventHandler(this.btn_saveInFile_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 448);
            this.Controls.Add(this.btn_saveInFile);
            this.Controls.Add(this.btn_addFromFile);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_records);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SharpQuiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lbl_records;
        public System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_addFromFile;
        private System.Windows.Forms.Button btn_saveInFile;
    }
}