namespace Img
{
    partial class GraphicPrimitiveManual
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PresentPhoto = new System.Windows.Forms.Button();
            this.Effects = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.radioButtonSome = new System.Windows.Forms.RadioButton();
            this.radioButton1000 = new System.Windows.Forms.RadioButton();
            this.primeAmount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // PresentPhoto
            // 
            this.PresentPhoto.Location = new System.Drawing.Point(10, 16);
            this.PresentPhoto.Name = "PresentPhoto";
            this.PresentPhoto.Size = new System.Drawing.Size(153, 44);
            this.PresentPhoto.TabIndex = 1;
            this.PresentPhoto.Text = "Просмотр фото";
            this.PresentPhoto.UseVisualStyleBackColor = true;
            this.PresentPhoto.Click += new System.EventHandler(this.PresentPhoto_Click);
            // 
            // Effects
            // 
            this.Effects.Location = new System.Drawing.Point(181, 16);
            this.Effects.Name = "Effects";
            this.Effects.Size = new System.Drawing.Size(153, 44);
            this.Effects.TabIndex = 2;
            this.Effects.Text = "Эффекты";
            this.Effects.UseVisualStyleBackColor = true;
            this.Effects.Click += new System.EventHandler(this.Effects_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.Location = new System.Drawing.Point(350, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Фигуры";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(5, 12);
            this.trackBar1.Maximum = 10000;
            this.trackBar1.Minimum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интервал";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(651, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Прямоугольники",
            "Линии",
            "Эллипсы"});
            this.comboBox1.Location = new System.Drawing.Point(651, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Примитив";
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(651, 310);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(45, 43);
            this.start_button.TabIndex = 6;
            this.start_button.Text = ">";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_button.Location = new System.Drawing.Point(721, 310);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(45, 43);
            this.stop_button.TabIndex = 7;
            this.stop_button.Text = "I I";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(651, 370);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(116, 43);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "X";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.radioButton1000);
            this.groupBox3.Controls.Add(this.radioButtonSome);
            this.groupBox3.Controls.Add(this.radioButtonOne);
            this.groupBox3.Location = new System.Drawing.Point(651, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Location = new System.Drawing.Point(7, 22);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(64, 21);
            this.radioButtonOne.TabIndex = 0;
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.Text = "Один";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            // 
            // radioButtonSome
            // 
            this.radioButtonSome.AutoSize = true;
            this.radioButtonSome.Location = new System.Drawing.Point(7, 49);
            this.radioButtonSome.Name = "radioButtonSome";
            this.radioButtonSome.Size = new System.Drawing.Size(99, 21);
            this.radioButtonSome.TabIndex = 1;
            this.radioButtonSome.TabStop = true;
            this.radioButtonSome.Text = "Несколько";
            this.radioButtonSome.UseVisualStyleBackColor = true;
            this.radioButtonSome.CheckedChanged += new System.EventHandler(this.RadioButtonSome_CheckedChanged);
            // 
            // radioButton1000
            // 
            this.radioButton1000.AutoSize = true;
            this.radioButton1000.Location = new System.Drawing.Point(7, 76);
            this.radioButton1000.Name = "radioButton1000";
            this.radioButton1000.Size = new System.Drawing.Size(79, 21);
            this.radioButton1000.TabIndex = 2;
            this.radioButton1000.TabStop = true;
            this.radioButton1000.Text = "Тысяча";
            this.radioButton1000.UseVisualStyleBackColor = true;
            // 
            // primeAmount
            // 
            this.primeAmount.Location = new System.Drawing.Point(651, 559);
            this.primeAmount.Name = "primeAmount";
            this.primeAmount.Size = new System.Drawing.Size(116, 22);
            this.primeAmount.TabIndex = 9;
            this.primeAmount.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(77, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 461);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // GraphicPrimitiveManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.primeAmount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GraphicPrimitiveManual";
            this.Text = "GraphicPrimitiveManual";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PresentPhoto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Effects;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1000;
        private System.Windows.Forms.RadioButton radioButtonSome;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.TextBox primeAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
    }
}