using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing.Drawing2D;
namespace WF_Quiz
{
    public partial class Form1 : Form
    {
        string filePath = Application.StartupPath +@"\Files\programData\profiles.txt";
        public Form1()
        {
            InitializeComponent();
            Paint += Form_Paint;
        } 
        private void Form1_Load(object sender, EventArgs e)
        {//загружает профили
            dataGridView1.Rows.Clear();
            char[] delimiterChars = { '\n' };
            foreach (var line in File.ReadAllLines(filePath))
            {
                string[] array = line.Split(delimiterChars);
                dataGridView1.Rows.Add(array);
            }
            dataGridView1.CurrentCell = null;
        }

        void Form_Paint(object sender, PaintEventArgs e)
        {//рисует закругленные рамки у объектов
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.FromArgb(242, 75, 27));
            Pen pen = new Pen(brush, 5);
            pen.LineJoin = LineJoin.Round;
            g.DrawRectangle(pen, new Rectangle(btn_addProfile.Location.X - 1, btn_addProfile.Location.Y - 1, btn_addProfile.Width + 1, btn_addProfile.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_delete.Location.X - 1, btn_delete.Location.Y - 1, btn_delete.Width + 1, btn_delete.Height + 1));
            g.DrawRectangle(pen, new Rectangle(textBox1.Location.X - 1, textBox1.Location.Y - 1, textBox1.Width + 1, textBox1.Height + 1));
            g.DrawRectangle(pen, new Rectangle(dataGridView1.Location.X - 1, dataGridView1.Location.Y - 1, dataGridView1.Width + 1, dataGridView1.Height + 1));
        }
        private void RowsCompare(object sender, EventArgs e)
        {//Поиск повторяющихся имён
            for (int currentRow = 0; currentRow < dataGridView1.Rows.Count - 1; currentRow++)
            {
                DataGridViewRow rowToCompare = dataGridView1.Rows[currentRow];

                for (int otherRow = currentRow + 1; otherRow < dataGridView1.Rows.Count; otherRow++)
                {
                    DataGridViewRow row = dataGridView1.Rows[otherRow];

                    bool duplicateRow = true;

                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
                        {
                            duplicateRow = false;
                            break;
                        }
                    }

                    if (duplicateRow)
                    {
                        dataGridView1.Rows.Remove(row);
                        otherRow--;
                        MessageBox.Show("Такое имя уже занято", "SharpQuiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btn_addProfile_Click(object sender, EventArgs e)
        {//добавить профиль
            if (textBox1.TextLength < 1)
            {
                {
                    MessageBox.Show("Длина имени меньше допустимой. Введите хотя бы один символ.");
                }
            }
            else if (textBox1.TextLength > 12)
            {
                MessageBox.Show("Длина имени превышает допустимую. Максимальная длина 12 символов.");
            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {//удалить профиль
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void btn_choise_Click(object sender, EventArgs e)
        {//выбрать профиль
            if (dataGridView1.CurrentCell != null)
            {
                FileStream file = new FileStream(filePath, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                for (int i=0; i<dataGridView1.RowCount; i++)
                {
                    writer.Write(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\n");
                }
                writer.Close();
                file.Close();
                Form5 form5 = new Form5();
                form5.Show();
                Hide();
                form5.lbl_name.Text = dataGridView1.CurrentCell.Value.ToString();
            }
            else
            {
                MessageBox.Show("Сначала выберите профиль!","SharpQuiz",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btn_choise_MouseEnter(object sender, EventArgs e)
        {
            btn_choise.ForeColor = Color.FromArgb(192, 64, 0);
        }

        private void btn_choise_MouseLeave(object sender, EventArgs e)
        {
            btn_choise.ForeColor = Color.FromArgb(242, 75, 27);
        }
    }
}

