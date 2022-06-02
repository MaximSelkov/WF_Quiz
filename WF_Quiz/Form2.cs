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
    public partial class Form2 : Form
    {
        string filePath = Application.StartupPath + @"\Files";
        string path = "";
        public Form2()
        {
            InitializeComponent();
            Paint += Form_Paint;
            toolTip1.SetToolTip(btn_previousQ, "Предыдущий вопрос");
            toolTip1.SetToolTip(btn_nextQ, "Следующий вопрос");
        }
        void Form_Paint(object sender, PaintEventArgs e)
        {//рисует закругленные рамки у объектов
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.FromArgb(242, 75, 27));
            Pen pen = new Pen(brush, 5);
            pen.LineJoin = LineJoin.Round;
            g.DrawRectangle(pen, new Rectangle(btn_addQuestion.Location.X - 1, btn_addQuestion.Location.Y - 1, btn_addQuestion.Width + 1, btn_addQuestion.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_dltQuestion.Location.X - 1, btn_dltQuestion.Location.Y - 1, btn_dltQuestion.Width + 1, btn_dltQuestion.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_saveFile.Location.X - 1, btn_saveFile.Location.Y - 1, btn_saveFile.Width + 1, btn_saveFile.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_opnFile.Location.X - 1, btn_opnFile.Location.Y - 1, btn_opnFile.Width + 1, btn_opnFile.Height + 1));
            g.DrawRectangle(pen, new Rectangle(textBox1.Location.X - 1, textBox1.Location.Y - 1, textBox1.Width + 1, textBox1.Height + 1));
            g.DrawRectangle(pen, new Rectangle(textBox2.Location.X - 1, textBox2.Location.Y - 1, textBox2.Width + 1, textBox2.Height + 1));
            g.DrawRectangle(pen, new Rectangle(textBox3.Location.X - 1, textBox3.Location.Y - 1, textBox3.Width + 1, textBox3.Height + 1));
            g.DrawRectangle(pen, new Rectangle(textBox4.Location.X - 1, textBox4.Location.Y - 1, textBox4.Width + 1, textBox4.Height + 1));
            g.DrawRectangle(pen, new Rectangle(pictureBox1.Location.X - 1, pictureBox1.Location.Y - 1, pictureBox1.Width + 1, pictureBox1.Height + 1));
            g.DrawRectangle(pen, new Rectangle(panel2.Location.X - 1, panel2.Location.Y - 1, panel2.Width + 1, panel2.Height + 1));
            g.DrawRectangle(pen, new Rectangle(panel3.Location.X - 1, panel3.Location.Y - 1, panel3.Width + 1, panel3.Height + 1));
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Введите вопрос";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Введите правильный ответ";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Введите неправильный ответ 1";
            textBox3.ForeColor = Color.Gray;
            textBox4.Text = "Введите неправильный ответ 2";
            textBox4.ForeColor = Color.Gray;
            Form5 form5 = new Form5();
            form5.Owner = this;
            lbl_name.Text = form5.lbl_name.Text;
            btn_addQuestion.Click += RowsCompare;
        }
        private void RowsCompare(object sender, EventArgs e)
        {//Поиск повторяющихся строк
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
                        MessageBox.Show("Такой вопрос уже есть", "SharpQuiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {//изменения элементов при нажатии и при покидании их ***
            if (textBox1.Text == "" || textBox1.Text == "Введите вопрос")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "Введите правильный ответ")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox3.Text == "Введите неправильный ответ 1")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox4.Text == "Введите неправильный ответ 2")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Введите вопрос";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Введите правильный ответ";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "Введите неправильный ответ 1";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                textBox4.Text = "Введите неправильный ответ 2";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            Hide();
            form5.lbl_name.Text = lbl_name.Text;
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.FromArgb(192, 64, 0);
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.FromArgb(242, 75, 27);
        }
        //***заканчивается здесь
        private void pictureBox1_Click(object sender, EventArgs e)
        {//загрузка фото
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture files (*.PNG; *.JPG; *.BMP; *.GIF) | *.PNG; *.JPG; *.BMP; *.GIF | All Files (*.*) | *.*";
            ofd.InitialDirectory = filePath + @"\photo";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                pictureBox1.ImageLocation = path;
                label1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//добавление или изменение вопроса
            if (btn_addQuestion.Text == "Добавить вопрос")
            {
                if (textBox1.Text == "" || textBox1.Text == "Введите вопрос" &&
                    textBox2.Text == "" || textBox2.Text == "Введите правильный ответ" &&
                    textBox3.Text == "" || textBox3.Text == "Введите неправильный ответ 1" &&
                    textBox4.Text == "" || textBox4.Text == "Введите неправильный ответ 2" && pictureBox1 == null || pictureBox1.Image == null)
                {
                    MessageBox.Show("Занесите все данные\n(Не забудьте про фото)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, pictureBox1.ImageLocation);
                        textBox1.Text = "Введите вопрос";
                        textBox1.ForeColor = Color.Gray;
                        textBox2.Text = "Введите правильный ответ";
                        textBox2.ForeColor = Color.Gray;
                        textBox3.Text = "Введите неправильный ответ 1";
                        textBox3.ForeColor = Color.Gray;
                        textBox4.Text = "Введите неправильный ответ 2";
                        textBox4.ForeColor = Color.Gray;
                        pictureBox1.ImageLocation = null;
                        int index = dataGridView1.CurrentRow.Index;
                        dataGridView1.Rows[index].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[0, index + 1];
                    }
                    catch { }
                }
            }
            else if (btn_addQuestion.Text == "Изменить вопрос")
            {
                dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
                dataGridView1.CurrentRow.Cells[4].Value = pictureBox1.ImageLocation;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//удаление вопроса
            try
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("Невозможно удалить пустую строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_previousQ_Click(object sender, EventArgs e)
        {//переход к предыдущему вопросу
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                if (index >= 0)
                {
                    dataGridView1.Rows[index].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, index - 1];
                }
            }
            catch
            {
            }
        }

        private void btn_nextQ_Click(object sender, EventArgs e)
        {//переход к следующему вопросу
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                if (index >= 0)
                {
                    dataGridView1.Rows[index].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, index + 1];
                }
            }
            catch { }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {//данные в текстбоксах и пикчурбоксе при изменении вопроса
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.ForeColor = Color.Black;
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.ForeColor = Color.Black;
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.ForeColor = Color.Black;
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.ForeColor = Color.Black;
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                btn_addQuestion.Text = "Изменить вопрос";
            }
            catch (System.NullReferenceException)
            {
                textBox1.Text = "Введите вопрос";
                textBox1.ForeColor = Color.Gray;
                textBox2.Text = "Введите правильный ответ";
                textBox2.ForeColor = Color.Gray;
                textBox3.Text = "Введите неправильный ответ 1";
                textBox3.ForeColor = Color.Gray;
                textBox4.Text = "Введите неправильный ответ 2";
                textBox4.ForeColor = Color.Gray;
                pictureBox1.ImageLocation = null;
                btn_addQuestion.Text = "Добавить вопрос";
            }
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {//сохранение викторины
            if (dataGridView1.Rows.Count > 5)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = filePath + @"\quiz";
                sfd.Filter = "Текстовые файлы(*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.AllowUserToAddRows = false;
                    path = sfd.FileName;
                    FileStream file = new FileStream(path, FileMode.Create);
                    StreamWriter writer = new StreamWriter(file);
                    try
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                            {
                                writer.Write(dataGridView1.Rows[i].Cells[j].Value + "*");
                            }
                            writer.WriteLine();
                        }
                        writer.Close();
                        file.Close();
                        MessageBox.Show("Файл успешно сохранен","Сохранение файла",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        dataGridView1.AllowUserToAddRows = true;
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить файл", "SharpQuiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("В викторине должно быть не менее 5 вопросов", "SharpQuiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_opnFile_Click(object sender, EventArgs e)
        {//открытие викторины для просмотра или редактирования
            label1.Visible = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = filePath + @"\quiz";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                if (File.ReadAllText(path).Length > 1 && File.ReadAllText(path).Contains("*"))
                {
                    this.ActiveControl = label1;
                    dataGridView1.Rows.Clear();
                    char[] delimiterChars = { '*' };
                    foreach (var line in File.ReadAllLines(path))
                    {
                        string[] array = line.Split(delimiterChars);
                        dataGridView1.Rows.Add(array);
                    }
                }
                else
                {
                    MessageBox.Show("Файл не подходит", "SharpQuiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

