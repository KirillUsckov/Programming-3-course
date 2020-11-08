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

namespace Img
{
    public partial class Colors : Form
    {
        public static FolderBrowserDialog FBD = new FolderBrowserDialog();
        Bitmap imgForShow;

        public Colors()
        {
            InitializeComponent();
            //обеспечиваем автоматическое отображение scrollbars
            panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                // записываем в перемнную все фалы из выбранной папки с расширением .jpg
                string[] fileNames = Directory.GetFiles(FBD.SelectedPath, "*.jpg");
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
                // присваиваем panel начальное значение картинки
                imgForShow = new Bitmap(FBD.SelectedPath + "\\" + listBox1.Items[0]);
                pictureBox1.Image = imgForShow;
            }
            label2.Text = FBD.SelectedPath;
            listBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)//считывание выбранной позиции в листбоксе и обнуление значений в комбобоксах
        {
            imgForShow = new Bitmap(FBD.SelectedPath + "\\" + listBox1.SelectedItem.ToString());
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            pictureBox1.Image = imgForShow;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e) //подгон под окно
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)// полный размер изображения
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)//поворот
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    imgForShow.RotateFlip(RotateFlipType.Rotate180FlipX);
                    break;
                case 1:
                    imgForShow.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case 2:
                    imgForShow.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
            }
            pictureBox1.Image = imgForShow;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)//отражение
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    imgForShow.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case 1:
                    imgForShow.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
            }
            pictureBox1.Image = imgForShow;
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)//действия с цветами
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    imgForShow = negative(imgForShow);//негатив
                    break;
                case 1://ч-б
                    imgForShow = blackAndWhite(imgForShow);
                    break;
            }
            pictureBox1.Image = imgForShow;
        }

        private static Bitmap negative(Bitmap image) //негативное изображение
        {
            Color color;
            int r, g, b;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);
                    r = 255 - color.R;
                    g = 255 - color.G;
                    b = 255 - color.B;
                    color = Color.FromArgb(255, r, g, b);
                    image.SetPixel(i,j,color);
                }
            }
            return image;
        }

        private static Bitmap blackAndWhite(Bitmap image) //черно-белое изобрание
        {
            Color color, newImgColor;
            int newColor;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);
                    newColor = (color.R + color.G + color.B) / 3;
                    newImgColor = Color.FromArgb(255, newColor, newColor, newColor);
                    image.SetPixel(i, j, newImgColor);
                }
            }
            return image;
        }

        private void Button4_Click(object sender, EventArgs e)//добавить 1 элемент
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                String url = OFD.FileName.Substring(OFD.FileName.LastIndexOf("\\") + 1);
                listBox1.Items.Add(url);
            }
        }

        private void Button5_Click(object sender, EventArgs e)//удаить 1 элемент
        {
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void Button6_Click(object sender, EventArgs e)//очистить
        {
            listBox1.Items.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)//сохранение изображения
        {
            imgForShow.Save(FBD.SelectedPath + "\\" + listBox1.SelectedItem.ToString().Substring(0, listBox1.SelectedItem.ToString().LastIndexOf(".")) + "1" + ".jpg");
        }

        private void Button1_Click(object sender, EventArgs e)//закрыие формы, вызывающие открытие первой
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            GraphicPrimitiveMode gpm = new GraphicPrimitiveMode();
            gpm.Show();
            Hide();
        }

    }
}
