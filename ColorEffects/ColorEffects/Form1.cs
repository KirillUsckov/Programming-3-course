using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorEffects {
    public partial class ColorEffects_Form : Form {

        private OpenFileDialog OFD = new OpenFileDialog {
            Multiselect = false,
            Filter = "Image files (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg|All files (*.*)|*.*",
            Title = "Выбрать изображение"
        };

        private Bitmap TempImage;

        public ColorEffects_Form() {
            InitializeComponent();
        }

        private void ChoosePicture(object sender, EventArgs e) {
            if(OFD.ShowDialog() == DialogResult.OK) {
                Image Img = Image.FromStream(OFD.OpenFile());
                TempImage = new Bitmap(Img);
                Image_PictureBox.Image = new Bitmap(Img);

                MirrorHorizontallyOption_CheckBox.Enabled = true;
                MirrorVerticallyOption_CheckBox.Enabled = true;
                ColorEffect_ComboBox.Enabled = true;
                RotateClockwise_Button.Enabled = true;
                RotateCounterClockwise_Button.Enabled = true;
                SaveImage_Button.Enabled = true;
                ColorEffect_ComboBox.SelectedIndex = 0;
            }
        }

        private void ColorEffect_Form_Load(object sender, EventArgs e) {
            ColorEffect_ComboBox.SelectedIndex = 0;
        }

        private void ChangeSizeMode(object sender, EventArgs e) {
            if(sender == NormalSizeMode_RadioButton) {
                Image_PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            } else if(sender == ZoomSizeMode_RadioButton) {
                Panel.VerticalScroll.Value = 0;
                Panel.HorizontalScroll.Value = 0;
                Image_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                Image_PictureBox.Width = Panel.Width;
                Image_PictureBox.Height = Panel.Height;
            }
        }

        private void MirrorHorizontally(object sender, EventArgs e) {
            Image_PictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            TempImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Image_PictureBox.Invalidate();
        }

        private void MirrorVertically(object sender, EventArgs e) {
            Image_PictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            TempImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Image_PictureBox.Invalidate();
        }

        private void ChangeColorEffect(object sender, EventArgs e) {
            if(TempImage == null)
                return;
            switch(ColorEffect_ComboBox.SelectedIndex) {
                case 0:
                    Image_PictureBox.Image = (Bitmap)TempImage.Clone();
                    break;
                case 1:
                    InvertColor();
                    break;
                case 2:
                    MakeBlackWhite();
                    break;
            }
            Image_PictureBox.Invalidate();
        }

        private void InvertColor() {
            Bitmap BM = new Bitmap(TempImage);

            int Height = BM.Height;
            int Width = BM.Width;
            for(int y = 0; y < Height; y++) {
                for(int x = 0; x < Width; x++) {
                    Color p = BM.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    BM.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            Image_PictureBox.Image = BM;
        }

        private void MakeBlackWhite() {
            Bitmap BM = new Bitmap(TempImage);

            int Height = BM.Height;
            int Width = BM.Width;
            for(int y = 0; y < Height; y++) {
                for(int x = 0; x < Width; x++) {
                    Color p = BM.GetPixel(x, y);

                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    int gray = (r + g + b) / 3;
                    BM.SetPixel(x, y, Color.FromArgb(255, gray, gray, gray));
                }
            }
            Image_PictureBox.Image = BM;
        }

      

        private void RotateCounterClockwise(object sender, EventArgs e) {
            Image_PictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            TempImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            if(NormalSizeMode_RadioButton.Checked == true) {
                Image_PictureBox.Width = Image_PictureBox.Image.Width;
                Image_PictureBox.Height = Image_PictureBox.Image.Height;
            }
            Image_PictureBox.Invalidate();
        }

        private void RotateClockwise(object sender, EventArgs e) {
            Image_PictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            TempImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if(NormalSizeMode_RadioButton.Checked == true) {
                Image_PictureBox.Width = Image_PictureBox.Image.Width;
                Image_PictureBox.Height = Image_PictureBox.Image.Height;
            }
            Image_PictureBox.Invalidate();
        }

        private void SaveResult(object sender, EventArgs e) {
            SaveFileDialog Save = new SaveFileDialog() {
                Filter = "JPG Image|*.jpg|PNG Image|*.png|GIF Image|*.gif",
                Title = "Сохранить изображение"
            };

            Save.ShowDialog();
            if(Save.FileName != "") {
                System.IO.FileStream fs = (System.IO.FileStream)Save.OpenFile();

                switch(Save.FilterIndex) {
                    case 1:
                    this.Image_PictureBox.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                    case 2:
                    this.Image_PictureBox.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Png);
                    break;

                    case 3:
                    this.Image_PictureBox.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                }

                fs.Close();
            }
        }
    }
}
