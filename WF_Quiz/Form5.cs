using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace WF_Quiz
{
    public partial class Form5 : Form
    {
        public string path;
        string filePath = Application.StartupPath + @"\Files\quiz";
        public Form5()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Paint += new PaintEventHandler(Form_Paint);
            
        }
        void Form_Paint(object sender, PaintEventArgs e)
        {//рисует закруглённые рамки у элементов
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.FromArgb(242, 75, 27));
            Pen pen = new Pen(brush, 7);
            pen.LineJoin = LineJoin.Round;
            g.DrawRectangle(pen, new Rectangle(btn_records.Location.X-1, btn_records.Location.Y-1, btn_records.Width + 1, btn_records.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_Start.Location.X - 1, btn_Start.Location.Y - 1, btn_Start.Width + 1, btn_Start.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_master.Location.X - 1, btn_master.Location.Y - 1, btn_master.Width + 1, btn_master.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_exit.Location.X - 1, btn_exit.Location.Y - 1, btn_exit.Width + 1, btn_exit.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_profile.Location.X - 1, btn_profile.Location.Y - 1, btn_profile.Width + 1, btn_profile.Height + 1));
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();//Загрузка викторины из файла
                ofd.Filter = "Текстовые файлы(*.txt)|*.txt";
                ofd.InitialDirectory = filePath;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                    if (File.ReadAllText(path).Length > 1 && File.ReadAllText(path).Contains("*"))
                    {
                        Form3 form3 = new Form3();
                        form3.Owner = this;
                        form3.Show();
                        Hide();
                        form3.lbl_name.Text = lbl_name.Text;
                    }
                    else
                    {
                        MessageBox.Show("Файл не подходит", "SharpQuiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } 
            }
            catch
            { }
        }

        private void btn_records_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 form4 = new Form4();
                form4.Owner = this;
                form4.Show();
                Hide();
                form4.lbl_name.Text = lbl_name.Text;
            }
            catch { }
        }

        private void btn_master_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                form2.Owner = this;
                form2.Show();
                Hide();
                form2.lbl_name.Text = lbl_name.Text;
            }
            catch { }
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Owner = this;
                form1.Show();
                Hide();
            }
            catch { }
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_info_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.StartPosition = FormStartPosition.CenterParent;
            form6.ShowDialog();
        }
    }
}
