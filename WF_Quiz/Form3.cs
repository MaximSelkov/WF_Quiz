using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Drawing;
namespace WF_Quiz
{
    public partial class Form3 : Form
    {
        string path = "";
        string filePath = Application.StartupPath + @"/Files/programData";
        int[] randAnswer;
        int record;
        int mistakes;
        int questionCount;  
        int numOfQst=1;
        Random rnd = new Random();
        public Form3()
        {
            InitializeComponent();
            Paint += Form_Paint;
        }
        void Form_Paint(object sender, PaintEventArgs e)
        {//Рисует круглые рамки для элементов
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.FromArgb(242, 75, 27));
            Pen pen = new Pen(brush, 5);
            pen.LineJoin = LineJoin.Round;
            g.DrawRectangle(pen, new Rectangle(pictureBox1.Location.X - 1, pictureBox1.Location.Y - 1, pictureBox1.Width + 1, pictureBox1.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_false.Location.X - 1, btn_false.Location.Y - 1, btn_false.Width + 1, btn_false.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_false2.Location.X - 1, btn_false2.Location.Y - 1, btn_false2.Width + 1, btn_false2.Height + 1));
            g.DrawRectangle(pen, new Rectangle(btn_right.Location.X - 1, btn_right.Location.Y - 1, btn_right.Width + 1, btn_right.Height + 1));
        }
        void answerGenerate()
        {//Перемещивание вариантов ответов
            try
            {
                Button[] buttons = { btn_false, btn_false2, btn_right };//массив кнопок
                int n = buttons.Length;//длинна массива
                randAnswer = Enumerable.Range(1, 3).ToArray();//Перебор кнопок
                for (int i = n - 1; i >= 0; i--)
                {
                    int j = rnd.Next(i + 1);
                    int temp = randAnswer[j];
                    randAnswer[j] = randAnswer[i];
                    randAnswer[i] = temp;
                    buttons[i].Text = dataGridView1.CurrentRow.Cells[temp].Value.ToString();//Присваивание имени кнопке
                }
            }
            catch (System.NullReferenceException)
            {//Закрытие формы при заканчивании вопросов
                int result = questionCount - mistakes;
                lbl_score.Text = record.ToString();
                blb_mistaces.Text = mistakes.ToString();
                numOfQst -= 1;
                lbl_numOfQst.Text = numOfQst.ToString();
                DialogResult dialogResult = MessageBox.Show("Количество очков: " + record +
                                        "\nКоличество правильных ответов: " + result +
                                        " из " + questionCount,
                                        "Итоги игры",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Question);
                FileStream file = new FileStream(filePath+"/records.txt", FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine("Имя: " + lbl_name.Text + " | Количество очков: " + record + " | Количество ошибок: " + mistakes);
                writer.Close();
                Form5 form5 = new Form5();
                form5.lbl_name.Text = lbl_name.Text;//Передача имени профиля при переходе между формами
                Close();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Form5 form5 = this.Owner as Form5;
            path = form5.path;
            this.ActiveControl = label1;
            dataGridView1.Rows.Clear();
            char[] delimiterChars = { '*'};
            foreach (var line in File.ReadLines(path))
            {
                string[] array = line.Split(delimiterChars);
                dataGridView1.Rows.Add(array);
            }
            if (dataGridView1.RowCount > 1)
            {
                answerGenerate();//Перемешивание вариантов ответа
                for (int i=0; i<dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString()!= "")
                    {
                        questionCount += 1;//Количетсво вопросов
                    }
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {//Помещение вопроса в label и картинки в pictureBox
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                label_question.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch (System.NullReferenceException)
            {//MessageBox с рекордом при окончании игры
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {//Действия при правильном ответе
            if (btn_right.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString()) 
            {
                record += 100;
                numOfQst += 1;
                int index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
                lbl_score.Text = record.ToString();
                lbl_numOfQst.Text = numOfQst.ToString();
                answerGenerate();
            }
            else
            {
                mistakes += 1;
                numOfQst += 1;
                int index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
                blb_mistaces.Text = mistakes.ToString();
                lbl_numOfQst.Text = numOfQst.ToString();
                answerGenerate();
            }
              
        }
        private void btn_false_Click(object sender, EventArgs e)
        {//Действия при неправильном ответе
            if (btn_false.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                record += 100;
                numOfQst += 1;
                int index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);//Удаление строки для перехода к следующему вопросу
                lbl_score.Text = record.ToString();
                lbl_numOfQst.Text = numOfQst.ToString();
                answerGenerate();
            }
            else
            {
                mistakes += 1;
                numOfQst += 1;
                int index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
                blb_mistaces.Text = mistakes.ToString();
                lbl_numOfQst.Text = numOfQst.ToString();
                answerGenerate();
            }
        }

        private void btn_false2_Click(object sender, EventArgs e)
        {//Действия при неправильном ответе
            if (btn_false2.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                record += 100;
                numOfQst += 1;
                int index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
                lbl_score.Text = record.ToString();
                lbl_numOfQst.Text = numOfQst.ToString();
                answerGenerate();
            }
            else
            {
                mistakes += 1;
                numOfQst += 1;
                int index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
                blb_mistaces.Text = mistakes.ToString();
                lbl_numOfQst.Text = numOfQst.ToString();
                answerGenerate();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            form5.lbl_name.Text = lbl_name.Text;
            Hide();
        }
    }
}
