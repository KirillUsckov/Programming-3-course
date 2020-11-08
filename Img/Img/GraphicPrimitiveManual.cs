using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Img
{
    public partial class GraphicPrimitiveManual : Form
    {
        static Graphics graphicImg; //графический объект
        static Random r = new Random();
        public static Timer myTimer = new System.Windows.Forms.Timer();
        static int intervalForTimer = 1000;
        int clock = 0, count = 0;
        int maxValueOFClock = 1;
        public GraphicPrimitiveManual()
        {
            InitializeComponent();
        }
        private void PresentPhoto_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void Effects_Click(object sender, EventArgs e)
        {
            Colors colorForm = new Colors();
            colorForm.Show();
            this.Close();
        }
        //Остановка генерации
        private void Stop_button_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
        }
        //Очистка холста
        private void Clear_button_Click(object sender, EventArgs e)
        {
            graphicImg.Clear(Color.White);
        }
        //Запуск генерации
        private void Start_button_Click(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(Timer_Tick);
            myTimer.Interval = intervalForTimer;

            if (radioButtonOne.Checked == true)//задаем 1 объект
            {
                startTimer(1);
            }
            else if (radioButtonSome.Checked == true)//задаем количество объектов из текстБокса
            {
                count = int.Parse(primeAmount.Text);
                startTimer(count);
            }
            else if (radioButton1000.Checked == true)//Задаем 100 объектов
            {
                startTimer(1000);
            }
        }

        private void startTimer(int max)//Запускаем таймер
        {
            graphicImg = pictureBox1.CreateGraphics();//Даем возможность взаимодейтсвовать с pictureBox
            maxValueOFClock = max; //Определяем количество примитивов
            myTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedIndex) == "Null")
                MessageBox.Show("Примитив не выбран");
            else
            {
                if (clock < maxValueOFClock)//сравниваем количество уже созданных объектов с необходимым количеством
                {
                    if (comboBox1.Text.Contains("Линии"))
                    {
                        LineDraw();
                    }
                    else if (comboBox1.Text.Contains("Эллипсы"))
                    {
                        EllipseDraw(pictureBox1.Width, pictureBox1.Height);
                    }
                    else if (comboBox1.Text.Contains("Прямоугольники"))
                    {
                        rectangleDraw(pictureBox1.Width, pictureBox1.Height);
                    }
                    clock++;
                }
                else
                {
                    clock = 0;
                    myTimer.Stop();
                }
            }
        }

        private void rectangleDraw(int width, int height)//рисование прямоугольника
        {
            Rectangle rectangle = new Rectangle();
            rectangle.X = r.Next(0, 210);
            rectangle.Y = r.Next(0, 140);
            rectangle.Width = r.Next(0, width);
            rectangle.Height = r.Next(0, height);
            graphicImg.FillRectangle(randomBrushForDraw(), rectangle);
        }

        private void LineDraw()//рисвание линии
        {
            Point firstPoint = new Point(r.Next(0, 300), r.Next(0, 500));
            Point secondPoint = new Point(r.Next(0, 400), r.Next(0, 500));
            Pen pen = new Pen(randomBrushForDraw(), 2);
            graphicImg.DrawLine(pen, firstPoint, secondPoint);
        }

        private void EllipseDraw(int width, int height)//рисование эллипса
        {
            Rectangle rectangle = new Rectangle();
            rectangle.X = r.Next(0, 100);
            rectangle.Y = r.Next(0, 120);
            rectangle.Width = r.Next(0, width - 20);
            rectangle.Height = r.Next(0, height - 20);
            Pen pen = new Pen(randomBrushForDraw(), 2);
            graphicImg.DrawEllipse(pen, rectangle);
        }
        private SolidBrush randomBrushForDraw() //рандомная генерация кисти
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(120, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            return brush;
        }
       
        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e) // задание интервала
        {
            myTimer.Stop();
            intervalForTimer = trackBar1.Value;
            myTimer.Interval = intervalForTimer;
            myTimer.Start();
        }

        private void RadioButtonSome_CheckedChanged(object sender, EventArgs e)//Видимость ТекстБокса
        {
            if (radioButtonSome.Checked == true)
            {
                primeAmount.Visible = true;
            }
        }
    }
}
