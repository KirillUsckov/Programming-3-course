namespace Img
{
    partial class GraphicPrimitivesAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Effects = new System.Windows.Forms.Button();
            this.PresentPhoto = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Effects);
            this.groupBox1.Controls.Add(this.PresentPhoto);
            this.groupBox1.Location = new System.Drawing.Point(77, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.Location = new System.Drawing.Point(350, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Фигуры";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Effects
            // 
            this.Effects.Location = new System.Drawing.Point(181, 17);
            this.Effects.Name = "Effects";
            this.Effects.Size = new System.Drawing.Size(153, 44);
            this.Effects.TabIndex = 2;
            this.Effects.Text = "Эффекты";
            this.Effects.UseVisualStyleBackColor = true;
            this.Effects.Click += new System.EventHandler(this.Effects_Click);
            // 
            // PresentPhoto
            // 
            this.PresentPhoto.Location = new System.Drawing.Point(10, 17);
            this.PresentPhoto.Name = "PresentPhoto";
            this.PresentPhoto.Size = new System.Drawing.Size(153, 44);
            this.PresentPhoto.TabIndex = 1;
            this.PresentPhoto.Text = "Просмотр фото";
            this.PresentPhoto.UseVisualStyleBackColor = true;
            this.PresentPhoto.Click += new System.EventHandler(this.PresentPhoto_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Линии",
            "Прямоугольники",
            "Эллипсы"});
            this.checkedListBox1.Location = new System.Drawing.Point(609, 196);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(179, 70);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Примитивы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(77, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 444);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистить холст";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GraphicPrimitivesAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GraphicPrimitivesAuto";
            this.Text = "GraphicPrimitivesAuto";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PresentPhoto;
        private System.Windows.Forms.Button Effects;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}