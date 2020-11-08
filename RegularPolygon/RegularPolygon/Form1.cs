using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularPolygon {

    public partial class Form1 : Form {

        private int vertexAmount = 0, radius = 0;
        Point [] points;
        Pen pen = new Pen(Color.Red);
        Graphics imgForShow;

        public Form1() {
            InitializeComponent();
        }

        private void DrawPolygon_Click(object sender, EventArgs e) {
            vertexAmount = int.Parse(numberOfPolygonVertexes.Text);
            radius = int.Parse(radiusOfThePolygon.Text);
            points = new Point[vertexAmount];

            if (vertexAmount <= 2) {
                MessageBox.Show("Количество вершин должно быть более 2!", "Неверное количество вершин",  MessageBoxButtons.OK);
            } else if (radius < 1) {
                MessageBox.Show("Радиус должен быть больше 0!", "Неверный радиус",  MessageBoxButtons.OK);
            } else {
                countCoordinates(); // вызывали метод подсчета координат

                imgForShow = pictureBox2.CreateGraphics();
                imgForShow.Clear(Color.White);
                pen.Width = 2;

                drawThePolygon(); //вызвали метод для рисования
            }
        }


        private void drawThePolygon() {
            for (int i = 0; i < vertexAmount; i++) {
                if ((i + 1) == vertexAmount) {
                    imgForShow.DrawLine(pen, points[i], points[0]);
                } else {
                    imgForShow.DrawLine(pen, points[i], points[i + 1]);
                }
            }
        }

        private void countCoordinates() {
            for (int i = 0; i < vertexAmount; i++) {
                points[i].X = (int)(pictureBox2.Width / 2 + radius * Math.Cos(2 * Math.PI * i / vertexAmount));
                points[i].Y = (int)(pictureBox2.Height / 2 + radius * Math.Sin(2 * Math.PI * i / vertexAmount));
            }
        }

    }
}
