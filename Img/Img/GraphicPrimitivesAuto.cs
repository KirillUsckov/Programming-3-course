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
    public partial class GraphicPrimitivesAuto : Form
    {
        Bitmap imgForShow; //буфер для Bitmap изображения
        static Graphics graphicImg; //графический объект
        static Random r = new Random();
        public GraphicPrimitivesAuto()
        {
            InitializeComponent();
        }
        //Переход на форму с просмотром фото
        private void PresentPhoto_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
        //Переход на форму с эффектами
        private void Effects_Click(object sender, EventArgs e)
        {
            Colors colorForm = new Colors();
            colorForm.Show();
            this.Close();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Нажатие на кнопку "применить"
        private void Button1_Click(object sender, EventArgs e)
        {
            imgForShow = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphicImg = pictureBox1.CreateGraphics();// дали возможность рисовать в pictureBox
            foreach (string el in checkedListBox1.CheckedItems)
            {
                if (el.Contains("Прямоугольники"))
                {
                    rectangleDraw(pictureBox1.Width, pictureBox1.Height);
                }
                else if (el.Contains("Эллипсы"))
                {
                    ellipseDraw(pictureBox1.Width, pictureBox1.Height);
                }
                else if (el.Contains("Линии"))
                {
                    lineDraw();
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e) //Очистка поля
        {
            graphicImg.Clear(Color.White);
        }
        private static void rectangleDraw(int width, int height) //Рисование прямоугольника
        {
            Rectangle rectangle = new Rectangle();
            for (int i = 0; i < 10; i++)
            {
                rectangle.X = r.Next(0, 210);
                rectangle.Y = r.Next(0, 140);
                rectangle.Width = r.Next(0, width);
                rectangle.Height = r.Next(0, height);
                graphicImg.FillRectangle(randomBrushForDraw(), rectangle);
            }
        }

        private static void lineDraw() //Рисование линии
        {
            for (int i = 0; i < 10; i++)
            {
                Point firstPoint = new Point(r.Next(0, 300), r.Next(0, 500));
                Point secondPoint = new Point(r.Next(0, 400), r.Next(0, 500));
                Pen pen = new Pen(randomBrushForDraw(), 2);
                graphicImg.DrawLine(pen, firstPoint, secondPoint);
            }
        }

        private static void ellipseDraw(int width, int height) //Рисование линии
        {
            Rectangle rectangle = new Rectangle();
            for (int i = 0; i < 10; i++)
            {
                rectangle.X = r.Next(0, 100);
                rectangle.Y = r.Next(0, 120);
                rectangle.Width = r.Next(0, width - 20);
                rectangle.Height = r.Next(0, height - 20);
                //Создали экземпляр класса Pen, конструкторе вызвали функцию рандомной генерации кисти
                Pen pen = new Pen(randomBrushForDraw(), 2); 
                graphicImg.DrawEllipse(pen, rectangle);
            }

        }

        private static SolidBrush randomBrushForDraw()//Рандомная генерация кисти
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(120, r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            return brush;
        }
    }
}
