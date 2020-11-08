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

namespace Img {
    public partial class Form1 : Form {
        public static int imageId, intervalForTimer = 1000, mode = 0;
        public static FolderBrowserDialog FBD = new FolderBrowserDialog();
        public static String url;
        public static Timer myTimer = new System.Windows.Forms.Timer();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            imageId = 0;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
        }

        // выбор пути к файлу
        private void Button8_Click(object sender, EventArgs e)  {
            if (FBD.ShowDialog() == DialogResult.OK) {
                // записываем в перемнную все фалы из выбранной папки с расширением .jpg
                string[] fileNames = Directory.GetFiles(FBD.SelectedPath, "*.jpg");
                label2.Text = FBD.SelectedPath;
                foreach (string element in fileNames)
                    listBox1.Items.Add(element.Substring(element.LastIndexOf("\\") + 1)); // Добавляем  в listBox только названия файлов
                // записываем в перемнную все фалы из выбранной папки с расширением .png
                fileNames = Directory.GetFiles(FBD.SelectedPath, "*.png");
                foreach (string element in fileNames)
                    listBox1.Items.Add(element.Substring(element.LastIndexOf("\\") + 1));// Добавляем  в listBox только названия файлов
                // записываем в перемнную все фалы из выбранной папки с расширением .jpeg
                fileNames = Directory.GetFiles(FBD.SelectedPath, "*.jpeg");
                foreach (string element in fileNames)
                    listBox1.Items.Add(element.Substring(element.LastIndexOf("\\") + 1)); // Добавляем  в listBox только названия файлов

                // присваиваем свойству ImageLocation всех PictureBox начальные значения картинок
                pictureBox1.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[imageId];
                pictureBox2.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[imageId + 1];
                pictureBox3.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[listBox1.Items.Count - 1];
            }
            listBox1.SelectedIndex = imageId;
        }

        // 1 up
        private void Button1_Click(object sender, EventArgs e) {
            // если мы находимся в начале списка
            if (imageId == 0) {
                imageId = listBox1.Items.Count - 1; // присваиваем индекс последнего изображения
                Form1.bottom(listBox1, pictureBox1, pictureBox2, pictureBox3, imageId);// вызываем метод перехода в конец списка
            }
            // если мы находимся на 2 пункте списка
            if (imageId == 1) {
                imageId = 0; //присваиваем индекс 1 элемента
                Form1.top(listBox1, pictureBox1, pictureBox2, pictureBox3); //вызываем метод перехода в начало списка
            } else {
                imageId--;//уменьшаем индекс на 1
                //присваиваем PB'ам индексы
                pictureBox1.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[imageId];
                pictureBox2.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[imageId + 1];
                pictureBox3.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[imageId - 1];
            }
            listBox1.SelectedIndex = imageId;
        }

        // 1 down
        private void Button3_Click(object sender, EventArgs e) {
            // если мы находимся в конце списка
            if (imageId == listBox1.Items.Count - 1) {
                imageId = 0; //присваиваем индекс 1 элемента
                Form1.top(listBox1, pictureBox1, pictureBox2, pictureBox3); //вызываем метод перехода в начало списка
            }
            // если мы находимся на предпоследнем пункте списка
            if (imageId == listBox1.Items.Count - 2) {
                imageId = listBox1.Items.Count - 1; // присваиваем индекс последнего изображения
                Form1.bottom(listBox1, pictureBox1, pictureBox2, pictureBox3, imageId); // вызываем метод перехода в конец списка
            } else {
                imageId++;//увеличиваем индекс на 1
                //присваиваем PB'ам индексы
                pictureBox1.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[imageId];
                pictureBox2.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[imageId + 1];
                pictureBox3.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[imageId - 1];
            }
            listBox1.SelectedIndex = imageId;
        }

        // top
        private void Button2_Click(object sender, EventArgs e) {
            imageId = 0;
            listBox1.SelectedIndex = imageId;
            Form1.top(listBox1, pictureBox1, pictureBox2, pictureBox3); // вызов функции переключения на верхний элемент
        }

        // bottom
        private void Button4_Click(object sender, EventArgs e) {
            imageId = listBox1.Items.Count - 1;
            listBox1.SelectedIndex = imageId;
            Form1.bottom(listBox1, pictureBox1, pictureBox2, pictureBox3, imageId); // вызов функции переключения на нижний элемент
        }
        //на дно
        public static void bottom(ListBox listBox1, PictureBox pictureBox1, 
                                                        PictureBox pictureBox2, PictureBox pictureBox3, int id) {
            pictureBox1.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[id];
            pictureBox2.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[0];
            pictureBox3.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[id - 1];
        }

        //на вершину
        public static void top(ListBox listBox1, PictureBox pictureBox1, 
                                                    PictureBox pictureBox2, PictureBox pictureBox3) {
            pictureBox1.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[0];
            pictureBox2.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[1];
            pictureBox3.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[listBox1.Items.Count - 1];
        }

        // добавить 1 файл
        private void Button5_Click(object sender, EventArgs e) {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK) {
                url = OFD.FileName.Substring(OFD.FileName.LastIndexOf("\\") + 1);
                listBox1.Items.Add(url);
            }
        }

        // удалить последний
        private void Button6_Click(object sender, EventArgs e) {
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        // очистить 
        private void Button7_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
        }


        //Переключение слайдов по таймеру
        public void timer1_Tick(object sender, EventArgs e) {
            if (this.listBox1.Items.Count == 0) {
                MessageBox.Show("Нет файлов в списке");
            } else {
                imageId++;                          //Номер текущей картинки
                if (imageId == listBox1.Items.Count) {
                    imageId = 0;                    //Начать с первой
                }
                listBox1.SelectedIndex = imageId;
                showTheImage(imageId);             //Вызов своей функции показа картинки
            }
        }
        public void showTheImage(int currentNumberOfPic) {
            // стандартное пролистывание сверху вниз
            if (mode == 0) {
                // вызываем метод пролистывания вниз по списку
                ShowImagesDown(currentNumberOfPic, listBox1, pictureBox1, pictureBox2, pictureBox3); 
            } else { //пролистывание снизу вверx
                ShowImagesUp(listBox1, pictureBox1, pictureBox2, pictureBox3);
            }
        }

        // изменение временного интервала по кнопке
        private void Button9_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Изменить интервал?", "На данный момент интерва = " + 
                                                        intervalForTimer, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                interval form = new interval();
                form.Show();
            }
            myTimer.Tick += new EventHandler(timer1_Tick);
            myTimer.Interval = intervalForTimer;
        }

        //при нажатии на кноку "Вниз"
        private void Button10_Click(object sender, EventArgs e) {
            mode = 0;
        }

        //при нажатии на кноку "Вверх"
        private void Button11_Click(object sender, EventArgs e) {
            mode = 1;
        }

        //показ фото снизу вверх по списку
        private static void ShowImagesUp(ListBox listBox1, PictureBox pictureBox1, 
                                                    PictureBox pictureBox2, PictureBox pictureBox3) {
            int currentNumberOfPic = imageId;
            //если индеккс текущей картинки меньше 0 - наименьшего индекса
            if (currentNumberOfPic < 0) {
                //текущм изображением становится изображение последнее в списке
                currentNumberOfPic = listBox1.Items.Count - 1; 
                imageId = currentNumberOfPic - 1;
            } else {
                imageId -= 2; // иначе вычитаем из индекса 2, т.к. потом 
                              // будет прибавлять 1 и получим уменьшение индекса на 1
            }

            int previousNumberOfPic, nextNumberOfPic;
            nextNumberOfPic = currentNumberOfPic - 1; // вычисляем индекс следующего изображения
            // если индекс следующего изображения выходит за пределы списка
            if (nextNumberOfPic == -1) {
                nextNumberOfPic = listBox1.Items.Count - 1; // присваиваем индекс последнего изображения в списке
            }
            previousNumberOfPic = currentNumberOfPic + 1; //вычисляем предыдущий индекс
            // если предыдущий индекс равен количеству элементов списка
            if (previousNumberOfPic == listBox1.Items.Count) {
                previousNumberOfPic = 0; //присваиваем ему значение первого элемента
            }
            pictureBox1.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[currentNumberOfPic];
            pictureBox2.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[previousNumberOfPic];
            pictureBox3.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[nextNumberOfPic];
        }

        //стандартный показ фото вниз по списку
        private static void ShowImagesDown(int currentNumberOfPic, ListBox listBox1, 
                                                PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3) {
            int previousNumberOfPic, nextNumberOfPic;
            previousNumberOfPic = currentNumberOfPic - 1; //вычисляем предыдущий индекс
            //если предыдущий индекс выходиз за границы массива в < сторону
            if (previousNumberOfPic == -1) {
                previousNumberOfPic = listBox1.Items.Count - 1;
            }
            nextNumberOfPic = currentNumberOfPic + 1; //вычисляем следующий индекс
            //если следующий индекс больше, чем последний индекс листБокса
            if (nextNumberOfPic == listBox1.Items.Count) {
                nextNumberOfPic = 0;
            }
            // помещаем в pictureBox текущее изобращение
            pictureBox1.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[currentNumberOfPic];
            // помещаем в PB предшествующее изображение
            pictureBox2.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[previousNumberOfPic];
            // помещаем в PB следующее изображение
            pictureBox3.ImageLocation = FBD.SelectedPath + "\\" + listBox1.Items[nextNumberOfPic];
        }

        //автоматический режим
        public void RadioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked == true) {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;

                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;

                DialogResult result = MessageBox.Show("Изменить интервал?", "На данный момент интерва = " 
                                                        + intervalForTimer, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    interval form = new interval();
                    form.Show();
                }
                myTimer.Tick += new EventHandler(timer1_Tick);
                myTimer.Interval = intervalForTimer;
                myTimer.Start();
            }
        }

        //Открытие формы для изменерия цветов
        private void Button13_Click(object sender, EventArgs e) {
            Colors formForColor = new Colors();
            formForColor.FormClosed += formClose;
            formForColor.Show();
            this.Hide();
        }

        //ручной режим
        private void RadioButton2_CheckedChanged(object sender, EventArgs e) {
            myTimer.Stop(); //остановка автоматического режима
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }

        private void Button14_Click(object sender, EventArgs e) {
            GraphicPrimitiveMode gpm = new GraphicPrimitiveMode();
            gpm.Show();
            gpm.FormClosed += formClose;
            this.Hide();
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e) {

        }
        private void formClose(object sender, FormClosedEventArgs e) {
            this.Show();
        }

    }
    
}
