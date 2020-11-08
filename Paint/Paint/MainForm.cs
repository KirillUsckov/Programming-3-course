using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Paint {
    public partial class MainForm : Form {
        bool isPressed;
        int x0, y0, x, y;
        int dashStyleCode;
        Color color;
        Pen pen;
        Graphics imgForPictureBox;
        Bitmap snapshot, img;
        int lineWidth;
        string selectedTool;


        public MainForm() {
            InitializeComponent();
            //Дефолтные данные
            snapshot = new Bitmap(canvas.ClientRectangle.Width, 
                                  canvas.ClientRectangle.Height); 
            img = (Bitmap)snapshot.Clone();
            imgForPictureBox = canvas.CreateGraphics();
            color = Color.Black;
            lineWidth = 2;
            pencil.Checked = true;
            selectedTool = "Pencil";
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            unSelectAllItems();
            if (pencil.Selected) {
                pencil.Checked = true;
                selectedTool = "Pencil";
            } else if (line.Selected) {
                line.Checked = true;
                selectedTool = "Line";
            } else if (ellipse.Selected) {
                ellipse.Checked = true;
                selectedTool = "Ellipse";
            } else if (fillEllipse.Selected) {
                fillEllipse.Checked = true;
                selectedTool = "Fill ellipse";
            } else if (rectangle.Selected) {
                rectangle.Checked = true;
                selectedTool = "Rectangle";
            } else if (fillRectangle.Selected) {
                fillRectangle.Checked = true;
                selectedTool = "Fill rectangle";
            }
        }

        private void unSelectAllItems() {
            pencil.Checked = false;
            line.Checked = false;
            ellipse.Checked = false;
            fillEllipse.Checked = false;
            rectangle.Checked = false;
            fillRectangle.Checked = false;
        }

        private void ColorSelecter_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { //выбор цвета 
                colorSelecter.BackColor = colorDialog1.Color;
                color = colorDialog1.Color;
            }
        }

        private void WidthOfLine_Scroll(object sender, EventArgs e) {
            lineWidth = widthOfLine.Value;
        }

        private void ToolStripLabel6_Click(object sender, EventArgs e) { //СОХРАНЕНИЕ 
            string fileName;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                fileName = sfd.FileName;
                string ext = System.IO.Path.GetExtension(fileName);
                switch (ext) { //подбирается расширение 
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                img.Save(fileName, format);//процедура сохранения
                MessageBox.Show("Файл сохранен");

            }
        }

        private void ToolStripLabel7_Click(object sender, EventArgs e) { //ОТКРЫТЬ
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Открыть";
            open.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|ImageFiles(*.GIF)|" +
                "*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK) {
                try {
                    canvas.Image = Image.FromFile(open.FileName);//помещаем на холст файл
                    snapshot = (Bitmap)canvas.Image;
                    img = (Bitmap)snapshot.Clone();
                    this.Text = open.FileName;
                } catch {
                    MessageBox.Show("Impossible to open image", "FATAL ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RadioButtonSolid_CheckedChanged(object sender, EventArgs e) {
            dashStyleCode = 0;
        }

        private void RadioButtonDash_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonDash.Checked) {
                comboBoxDashStyle.Enabled = true;
            } else {
                comboBoxDashStyle.Enabled = false;
            }
        }

        private void ComboBoxDashStyle_SelectedIndexChanged(object sender, EventArgs e) {
            dashStyleCode = comboBoxDashStyle.SelectedIndex + 1;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e) {
            isPressed = false;
            snapshot = (Bitmap)img.Clone();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e) {
            isPressed = true;
            x0 = e.X;
            y0 = e.Y;
            img = (Bitmap)snapshot.Clone();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) {
            if (isPressed) {
                x = e.X;
                y = e.Y;
                canvas.Invalidate();
                canvas.Update();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e) {
            if (selectedTool != "Pencil") {
                img = (Bitmap)snapshot.Clone();
            }
            imgForPictureBox = Graphics.FromImage(img);
            pen = new Pen(color, lineWidth);
            switch (dashStyleCode) { // выбирается стиль линии 
                case 0:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
                case 1:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case 2:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case 3:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
            }
            //данные о выбранном инструменте и координатах заносятся в форму
            labelMode.Text = selectedTool;
            labelX.Text = x.ToString();
            labelY.Text = y.ToString();
            if (img != null) {
                switch (selectedTool) { //выбирается инструмент
                    case "Line":
                        imgForPictureBox.DrawLine(pen, x0, y0, x, y);
                        break;
                    case "Ellipse":
                        imgForPictureBox.DrawEllipse(pen, x0, y0, x - x0, y - y0);
                        break;
                    case "Fill ellipse":
                        imgForPictureBox.FillEllipse(new SolidBrush(color), x0, y0, x - x0, y - y0);
                        break;
                    case "Rectangle":
                        imgForPictureBox.DrawRectangle(pen, x0, y0, x - x0, y - y0);
                        break;
                    case "Fill rectangle":
                        imgForPictureBox.FillRectangle(new SolidBrush(color), x0, y0, x - x0, y - y0);
                        break;
                    case "Pencil":
                        imgForPictureBox.DrawLine(pen, x0, y0, x, y);
                        x0 = x;
                        y0 = y;
                        break;
                }
                e.Graphics.DrawImageUnscaled(img, 0, 0);
                imgForPictureBox.Dispose();
                pen.Dispose();
            }
         
        }

    }
}
