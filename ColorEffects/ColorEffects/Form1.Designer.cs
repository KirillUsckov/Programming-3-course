namespace ColorEffects {
    partial class ColorEffects_Form {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.ChoosePicture_Button = new System.Windows.Forms.Button();
            this.NormalSizeMode_RadioButton = new System.Windows.Forms.RadioButton();
            this.ZoomSizeMode_RadioButton = new System.Windows.Forms.RadioButton();
            this.SizeMode_Label = new System.Windows.Forms.Label();
            this.MirrorHorizontallyOption_CheckBox = new System.Windows.Forms.CheckBox();
            this.MirrorVerticallyOption_CheckBox = new System.Windows.Forms.CheckBox();
            this.Options_Label = new System.Windows.Forms.Label();
            this.ColorEffect_Label = new System.Windows.Forms.Label();
            this.ColorEffect_ComboBox = new System.Windows.Forms.ComboBox();
            this.SaveImage_Button = new System.Windows.Forms.Button();
            this.RotateClockwise_Button = new System.Windows.Forms.Button();
            this.RotateCounterClockwise_Button = new System.Windows.Forms.Button();
            this.Rotate_Label = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.Image_PictureBox = new System.Windows.Forms.PictureBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoosePicture_Button
            // 
            this.ChoosePicture_Button.Location = new System.Drawing.Point(660, 290);
            this.ChoosePicture_Button.Name = "ChoosePicture_Button";
            this.ChoosePicture_Button.Size = new System.Drawing.Size(136, 22);
            this.ChoosePicture_Button.TabIndex = 0;
            this.ChoosePicture_Button.Text = "Выбрать изображение";
            this.ChoosePicture_Button.UseVisualStyleBackColor = true;
            this.ChoosePicture_Button.Click += new System.EventHandler(this.ChoosePicture);
            // 
            // NormalSizeMode_RadioButton
            // 
            this.NormalSizeMode_RadioButton.AutoSize = true;
            this.NormalSizeMode_RadioButton.Checked = true;
            this.NormalSizeMode_RadioButton.Location = new System.Drawing.Point(660, 25);
            this.NormalSizeMode_RadioButton.Name = "NormalSizeMode_RadioButton";
            this.NormalSizeMode_RadioButton.Size = new System.Drawing.Size(117, 17);
            this.NormalSizeMode_RadioButton.TabIndex = 2;
            this.NormalSizeMode_RadioButton.TabStop = true;
            this.NormalSizeMode_RadioButton.Text = "Исходный размер";
            this.NormalSizeMode_RadioButton.UseVisualStyleBackColor = true;
            this.NormalSizeMode_RadioButton.Click += new System.EventHandler(this.ChangeSizeMode);
            // 
            // ZoomSizeMode_RadioButton
            // 
            this.ZoomSizeMode_RadioButton.AutoSize = true;
            this.ZoomSizeMode_RadioButton.Location = new System.Drawing.Point(660, 48);
            this.ZoomSizeMode_RadioButton.Name = "ZoomSizeMode_RadioButton";
            this.ZoomSizeMode_RadioButton.Size = new System.Drawing.Size(112, 17);
            this.ZoomSizeMode_RadioButton.TabIndex = 3;
            this.ZoomSizeMode_RadioButton.Text = "Масштабировать";
            this.ZoomSizeMode_RadioButton.UseVisualStyleBackColor = true;
            this.ZoomSizeMode_RadioButton.Click += new System.EventHandler(this.ChangeSizeMode);
            // 
            // SizeMode_Label
            // 
            this.SizeMode_Label.AutoSize = true;
            this.SizeMode_Label.Location = new System.Drawing.Point(657, 9);
            this.SizeMode_Label.Name = "SizeMode_Label";
            this.SizeMode_Label.Size = new System.Drawing.Size(112, 13);
            this.SizeMode_Label.TabIndex = 4;
            this.SizeMode_Label.Text = "Режим отображения";
            // 
            // MirrorHorizontallyOption_CheckBox
            // 
            this.MirrorHorizontallyOption_CheckBox.AutoSize = true;
            this.MirrorHorizontallyOption_CheckBox.Enabled = false;
            this.MirrorHorizontallyOption_CheckBox.Location = new System.Drawing.Point(660, 118);
            this.MirrorHorizontallyOption_CheckBox.Name = "MirrorHorizontallyOption_CheckBox";
            this.MirrorHorizontallyOption_CheckBox.Size = new System.Drawing.Size(107, 17);
            this.MirrorHorizontallyOption_CheckBox.TabIndex = 5;
            this.MirrorHorizontallyOption_CheckBox.Text = "По горизонтали";
            this.MirrorHorizontallyOption_CheckBox.UseVisualStyleBackColor = true;
            this.MirrorHorizontallyOption_CheckBox.CheckedChanged += new System.EventHandler(this.MirrorHorizontally);
            // 
            // MirrorVerticallyOption_CheckBox
            // 
            this.MirrorVerticallyOption_CheckBox.AutoSize = true;
            this.MirrorVerticallyOption_CheckBox.Enabled = false;
            this.MirrorVerticallyOption_CheckBox.Location = new System.Drawing.Point(660, 141);
            this.MirrorVerticallyOption_CheckBox.Name = "MirrorVerticallyOption_CheckBox";
            this.MirrorVerticallyOption_CheckBox.Size = new System.Drawing.Size(96, 17);
            this.MirrorVerticallyOption_CheckBox.TabIndex = 6;
            this.MirrorVerticallyOption_CheckBox.Text = "По вертикали";
            this.MirrorVerticallyOption_CheckBox.UseVisualStyleBackColor = true;
            this.MirrorVerticallyOption_CheckBox.CheckedChanged += new System.EventHandler(this.MirrorVertically);
            // 
            // Options_Label
            // 
            this.Options_Label.AutoSize = true;
            this.Options_Label.Location = new System.Drawing.Point(657, 102);
            this.Options_Label.Name = "Options_Label";
            this.Options_Label.Size = new System.Drawing.Size(85, 13);
            this.Options_Label.TabIndex = 7;
            this.Options_Label.Text = "Инвертировать";
            // 
            // ColorEffect_Label
            // 
            this.ColorEffect_Label.AutoSize = true;
            this.ColorEffect_Label.Location = new System.Drawing.Point(657, 244);
            this.ColorEffect_Label.Name = "ColorEffect_Label";
            this.ColorEffect_Label.Size = new System.Drawing.Size(104, 13);
            this.ColorEffect_Label.TabIndex = 8;
            this.ColorEffect_Label.Text = "Эффекты с цветом";
            // 
            // ColorEffect_ComboBox
            // 
            this.ColorEffect_ComboBox.Enabled = false;
            this.ColorEffect_ComboBox.FormattingEnabled = true;
            this.ColorEffect_ComboBox.Items.AddRange(new object[] {
            "Нет",
            "Негатив",
            "Черно-белый"});
            this.ColorEffect_ComboBox.Location = new System.Drawing.Point(660, 261);
            this.ColorEffect_ComboBox.Name = "ColorEffect_ComboBox";
            this.ColorEffect_ComboBox.Size = new System.Drawing.Size(136, 21);
            this.ColorEffect_ComboBox.TabIndex = 9;
            this.ColorEffect_ComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeColorEffect);
            // 
            // SaveImage_Button
            // 
            this.SaveImage_Button.Enabled = false;
            this.SaveImage_Button.Location = new System.Drawing.Point(660, 318);
            this.SaveImage_Button.Name = "SaveImage_Button";
            this.SaveImage_Button.Size = new System.Drawing.Size(137, 22);
            this.SaveImage_Button.TabIndex = 10;
            this.SaveImage_Button.Text = "Сохранить результат";
            this.SaveImage_Button.UseVisualStyleBackColor = true;
            this.SaveImage_Button.Click += new System.EventHandler(this.SaveResult);
            // 
            // RotateClockwise_Button
            // 
            this.RotateClockwise_Button.Enabled = false;
            this.RotateClockwise_Button.Location = new System.Drawing.Point(656, 212);
            this.RotateClockwise_Button.Name = "RotateClockwise_Button";
            this.RotateClockwise_Button.Size = new System.Drawing.Size(136, 22);
            this.RotateClockwise_Button.TabIndex = 14;
            this.RotateClockwise_Button.Text = "По часовой";
            this.RotateClockwise_Button.UseVisualStyleBackColor = true;
            this.RotateClockwise_Button.Click += new System.EventHandler(this.RotateClockwise);
            // 
            // RotateCounterClockwise_Button
            // 
            this.RotateCounterClockwise_Button.Enabled = false;
            this.RotateCounterClockwise_Button.Location = new System.Drawing.Point(656, 184);
            this.RotateCounterClockwise_Button.Name = "RotateCounterClockwise_Button";
            this.RotateCounterClockwise_Button.Size = new System.Drawing.Size(136, 22);
            this.RotateCounterClockwise_Button.TabIndex = 15;
            this.RotateCounterClockwise_Button.Text = "Против часовой";
            this.RotateCounterClockwise_Button.UseVisualStyleBackColor = true;
            this.RotateCounterClockwise_Button.Click += new System.EventHandler(this.RotateCounterClockwise);
            // 
            // Rotate_Label
            // 
            this.Rotate_Label.AutoSize = true;
            this.Rotate_Label.Location = new System.Drawing.Point(653, 168);
            this.Rotate_Label.Name = "Rotate_Label";
            this.Rotate_Label.Size = new System.Drawing.Size(61, 13);
            this.Rotate_Label.TabIndex = 16;
            this.Rotate_Label.Text = "Повернуть";
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.Controls.Add(this.Image_PictureBox);
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(640, 360);
            this.Panel.TabIndex = 13;
            // 
            // Image_PictureBox
            // 
            this.Image_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Image_PictureBox.Name = "Image_PictureBox";
            this.Image_PictureBox.Size = new System.Drawing.Size(640, 360);
            this.Image_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_PictureBox.TabIndex = 1;
            this.Image_PictureBox.TabStop = false;
            // 
            // ColorEffects_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 382);
            this.Controls.Add(this.Rotate_Label);
            this.Controls.Add(this.RotateCounterClockwise_Button);
            this.Controls.Add(this.RotateClockwise_Button);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.SaveImage_Button);
            this.Controls.Add(this.ColorEffect_ComboBox);
            this.Controls.Add(this.ColorEffect_Label);
            this.Controls.Add(this.Options_Label);
            this.Controls.Add(this.MirrorVerticallyOption_CheckBox);
            this.Controls.Add(this.MirrorHorizontallyOption_CheckBox);
            this.Controls.Add(this.SizeMode_Label);
            this.Controls.Add(this.ZoomSizeMode_RadioButton);
            this.Controls.Add(this.NormalSizeMode_RadioButton);
            this.Controls.Add(this.ChoosePicture_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ColorEffects_Form";
            this.ShowIcon = false;
            this.Text = "Цветовые эффекты";
            this.Load += new System.EventHandler(this.ColorEffect_Form_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChoosePicture_Button;
        private System.Windows.Forms.RadioButton NormalSizeMode_RadioButton;
        private System.Windows.Forms.RadioButton ZoomSizeMode_RadioButton;
        private System.Windows.Forms.Label SizeMode_Label;
        private System.Windows.Forms.CheckBox MirrorHorizontallyOption_CheckBox;
        private System.Windows.Forms.CheckBox MirrorVerticallyOption_CheckBox;
        private System.Windows.Forms.Label Options_Label;
        private System.Windows.Forms.Label ColorEffect_Label;
        private System.Windows.Forms.ComboBox ColorEffect_ComboBox;
        private System.Windows.Forms.Button SaveImage_Button;
        private System.Windows.Forms.Button RotateClockwise_Button;
        private System.Windows.Forms.Button RotateCounterClockwise_Button;
        private System.Windows.Forms.Label Rotate_Label;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.PictureBox Image_PictureBox;
    }
}

