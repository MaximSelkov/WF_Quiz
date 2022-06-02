using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
namespace WF_Quiz
{

    public partial class Form4 : Form
    {
        string path;
        string filePath = Application.StartupPath + @"\Files\programData";
        public Form4()
        {
            InitializeComponent();
            Paint += Form_Paint;
        }
        void Form_Paint(object sender, PaintEventArgs e)
        {//рисует закругленные рамки у элементов
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.FromArgb(242, 75, 27));
            Pen pen = new Pen(brush, 5);
            pen.LineJoin = LineJoin.Round;
            g.DrawRectangle(pen, new Rectangle(btn_addFromFile.Location.X - 1, btn_addFromFile.Location.Y - 1, btn_addFromFile.Width + 1, btn_addFromFile.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_clear.Location.X - 1, btn_clear.Location.Y - 1, btn_clear.Width + 1, btn_clear.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_saveInFile.Location.X - 1, btn_saveInFile.Location.Y - 1, btn_saveInFile.Width + 1, btn_saveInFile.Height + 1));
            g.DrawRectangle(pen, new Rectangle(textBox1.Location.X - 1, textBox1.Location.Y - 1, textBox1.Width + 1, textBox1.Height + 1));
        }
        private void linkLabel1_Click_1(object sender, EventArgs e)
        {//переход к главному меню
            File.WriteAllText(filePath +@"/records.txt", textBox1.Text);
            Form5 form5 = new Form5();
            form5.Show();
            form5.lbl_name.Text = lbl_name.Text;
            Hide();
        }

        private void linkLabel1_MouseEnter_1(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.FromArgb(192, 64, 0);
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.FromArgb(242, 75, 27);
        }

        private void Form4_Load(object sender, EventArgs e)
        {//загружает рекорды из файла
            textBox1.Text = File.ReadAllText(filePath + @"/records.txt");
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 0;
            textBox1.Cursor = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {//очищает рекорды
            if (textBox1.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите очистить рекорды?(Данные не сохранятся)", "Рекорды", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    textBox1.Text = "";
                    File.WriteAllText(filePath + @"/records.txt", "");
                }
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_addFromFile_Click(object sender, EventArgs e)
        {//добавляет рекорды из файла (бекап)
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = filePath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                if (File.ReadAllText(path).Contains("Имя:") && File.ReadAllText(path).Contains("Количество очков:") && File.ReadAllText(path).Contains("Количество ошибок:"))
                {
                    this.ActiveControl = btn_clear;
                    string[] text = File.ReadAllLines(path);
                    textBox1.Text ="";
                    for (int i = 0; i < text.Length; i++)
                    {
                        textBox1.Text += text[i]+ Environment.NewLine;
                    }
                }
                else
                {
                    MessageBox.Show("Файл не подходит", "SharpQuiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_saveInFile_Click(object sender, EventArgs e)
        {//сохраняет рекорды в файл (бекап)
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = filePath;
            sfd.Filter = "Текстовые файлы(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                FileStream file = new FileStream(path, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                try
                {
                    writer.Write(textBox1.Text);
                    writer.Close();
                    file.Close();
                    MessageBox.Show("Файл успешно сохранен","Сохранение файла",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить файл", "SharpQuiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
