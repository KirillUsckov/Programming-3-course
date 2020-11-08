using System;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabAssignmentWatch {

    public partial class Form1 : Form {

        Graphics graphicForPictureBox;
        DateTime currentTime;
        Pen blackPen = new Pen(new SolidBrush(Color.Black), 2);
        Pen redPen = new Pen(new SolidBrush(Color.Red), 2);
        Point startPoint, endPoint;
        const double HOUR = Math.PI / 6;
        const double MIN_AND_SEC = Math.PI / 30;
        double Lenght = 100;
        Color bkColor = Color.Azure;
        Boolean alarm = false;
        DateTime alarmTime;
        string pattern = @"\D+";
        //SoundPlayer player;
        //string soundLocation = @"D:\Text\GachiRemixLittleBigUno.wav";

        public Form1() {
            InitializeComponent();
            clock.Start();
            //player = new SoundPlayer(soundLocation);
            //player.Load();
        }
        
        private void Clock_Tick(object sender, EventArgs e) {
            currentTime = DateTime.Now;
            paintClock(currentTime);
            labelTime.Text = currentTime.Hour + ":" + currentTime.Minute + ":" + currentTime.Second;

            if (alarmTime.Hour == currentTime.Hour && alarmTime.Minute == currentTime.Minute && alarm) {
                //player.Play();
                alarm = false;
                checkBoxAlarm.Checked = false;
                MessageBox.Show("Будильник сработал, пора работать!", 
                    "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*if (alarmTime.Minute + 1 == currentTime.Minute) {
                player.Stop();
            }*/
        }

        private void paintClock(DateTime time) {
            //циферблат
            paintCircle();
            //стрелки
            paintArrows(time);
        }

        private void paintCircle() {
            int halfOfWifth = pictureBox1.Width / 2;
            int halfOfHeight = pictureBox1.Height / 2;
            //прорисовка внешней окружности
            graphicForPictureBox.DrawEllipse(new Pen(new SolidBrush(Color.CornflowerBlue), 2),
                new Rectangle(new Point((int)(halfOfWifth - Lenght), (int)(halfOfHeight - Lenght)), 
                new Size((int)Lenght * 2, (int)Lenght * 2)));
            //прорисовка секундных делений
            for (int i = 0; i < 60; i++) {
                graphicForPictureBox.DrawLine(new Pen(new SolidBrush(Color.Orchid), 2),
                new Point((int)(halfOfWifth + (Lenght - 3) * Math.Cos(MIN_AND_SEC * i)), 
                (int)(halfOfHeight + (Lenght - 3) * Math.Sin(MIN_AND_SEC * i))),
                new Point((int)(halfOfWifth + Lenght * Math.Cos(MIN_AND_SEC * i)), 
                (int)(halfOfHeight + Lenght * Math.Sin(MIN_AND_SEC * i))));
            }

            int hour = 4;
            //прорисовка часовых делений
            for (int i = 1; i < 13; i++) {
                startPoint = new Point((int)(halfOfWifth + (Lenght - 10) * Math.Cos(HOUR * i)), 
                    (int)(halfOfHeight + (Lenght - 10) * Math.Sin(HOUR * i)));
                endPoint = new Point((int)(halfOfWifth + Lenght * Math.Cos(HOUR * i)), 
                    (int)(halfOfHeight + Lenght * Math.Sin(HOUR * i)));
                graphicForPictureBox.DrawLine(new Pen(new SolidBrush(Color.CornflowerBlue), 2), startPoint, endPoint);
                if (i < 3) {
                    graphicForPictureBox.DrawString((hour).ToString(), new Font("Mono", 14), Brushes.Blue, endPoint.X + 5, endPoint.Y - 5);
                    hour++;
                } else if (i < 7) {
                    graphicForPictureBox.DrawString((hour).ToString(), new Font("Mono", 14), Brushes.Blue, endPoint.X - 15, endPoint.Y - 5);
                    hour++;
                } else if (i < 9) {
                    graphicForPictureBox.DrawString((hour).ToString(), new Font("Mono", 14), Brushes.Blue, endPoint.X - 30, endPoint.Y - 15);
                    hour++;
                } else if (i == 10) {
                    graphicForPictureBox.DrawString((hour).ToString(), new Font("Mono", 14), Brushes.Blue, endPoint.X - 60, endPoint.Y - 35);
                    hour = 1;
                } else if (hour == 1) {
                    graphicForPictureBox.DrawString((hour).ToString(), new Font("Mono", 14), Brushes.Blue, endPoint.X - 30, endPoint.Y - 60);
                    hour++;
                } else if (hour == 2) {
                    graphicForPictureBox.DrawString("2", new Font("Mono", 14), Brushes.Blue, endPoint.X - 10, endPoint.Y - 65);
                    graphicForPictureBox.DrawString("3", new Font("Mono", 14), Brushes.Blue, endPoint.X, endPoint.Y - 15);   
                }   
            }
            //прорисовка круга, который закрывает внутреннюю часть линий чтобы остались только черточки
            graphicForPictureBox.FillEllipse(new SolidBrush(bkColor), new Rectangle(new Point((int)(halfOfWifth - Lenght + 5), 
                        (int)(halfOfHeight - Lenght + 5)), new Size((int)(Lenght - 5) * 2, (int)(Lenght - 5) * 2)));
        }

        private void paintArrows(DateTime time) {
            int radius = pictureBox1.Width / 2; //т.к. pictureBox - квадрат, достаточно 1 радиуса
            int x0 = radius, y0 = radius + 10;
            //прорисовка минутной стрелки
            startPoint = new Point(x0, y0);
            endPoint = new Point(x0 + (int)((Lenght - 20) * Math.Sin(MIN_AND_SEC * time.Minute)), 
                y0 - (int)((Lenght - 20) * Math.Cos(MIN_AND_SEC * time.Minute)));
            graphicForPictureBox.DrawLine(blackPen, startPoint, endPoint);
            //определения количества часов, прошедших после полудня или после полуночи, перевод 23=>11 и так далее
            int hour;
            if (time.Hour <= 12) {
                hour = time.Hour;
            }
            else {
                hour = time.Hour - 12;
            }
            //прорисовка часовой стрелки
            startPoint = new Point(x0, y0);
            endPoint = new Point(x0 + (int)((Lenght - 40) * Math.Sin(HOUR * hour + 2 * Math.PI / (12 * 60) * time.Minute)), 
                y0 - (int)((Lenght - 40) * Math.Cos(HOUR * hour + 2 * Math.PI / (12 * 60) * time.Minute)));
            graphicForPictureBox.DrawLine(blackPen, startPoint, endPoint);
            //прорисовка секундной стелки
            startPoint = new Point(x0, y0);
            endPoint = new Point(x0 + (int)((Lenght - 10) * Math.Sin(MIN_AND_SEC * time.Second + MIN_AND_SEC * (time.Millisecond / 1000))), 
                y0 - (int)((Lenght - 10) * Math.Cos(MIN_AND_SEC * time.Second + MIN_AND_SEC * (time.Millisecond / 1000) )));
            graphicForPictureBox.DrawLine(redPen, startPoint, endPoint);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e) {
            graphicForPictureBox = pictureBox1.CreateGraphics();
        }

        private void CheckBoxAlarm_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxAlarm.Checked == true) {
                //проверка введенных данных на корректность: соедржатся только цифры, длина не болье 2
                if (Regex.IsMatch(textBox1.Text, pattern) || Regex.IsMatch(textBox2.Text, pattern) 
                                                            || textBox1.Text.Length > 2 || textBox2.Text.Length > 2 ) {
                    MessageBox.Show("Введены неверные значения в поля будильника", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 
                        int.Parse(textBox1.Text), int.Parse(textBox2.Text), 00);
                    alarm = true;
                    MessageBox.Show("Будильник создан", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
