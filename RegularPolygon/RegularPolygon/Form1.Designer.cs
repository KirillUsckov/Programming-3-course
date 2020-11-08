namespace RegularPolygon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numberOfPolygonVertexes = new System.Windows.Forms.TextBox();
            this.radiusOfThePolygon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawPolygon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(46, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 359);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // numberOfPolygonVertexes
            // 
            this.numberOfPolygonVertexes.Location = new System.Drawing.Point(177, 21);
            this.numberOfPolygonVertexes.Name = "numberOfPolygonVertexes";
            this.numberOfPolygonVertexes.Size = new System.Drawing.Size(100, 22);
            this.numberOfPolygonVertexes.TabIndex = 2;
            // 
            // radiusOfThePolygon
            // 
            this.radiusOfThePolygon.Location = new System.Drawing.Point(177, 72);
            this.radiusOfThePolygon.Name = "radiusOfThePolygon";
            this.radiusOfThePolygon.Size = new System.Drawing.Size(100, 22);
            this.radiusOfThePolygon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Радиус";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiusOfThePolygon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberOfPolygonVertexes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(505, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // drawPolygon
            // 
            this.drawPolygon.Location = new System.Drawing.Point(647, 182);
            this.drawPolygon.Name = "drawPolygon";
            this.drawPolygon.Size = new System.Drawing.Size(135, 43);
            this.drawPolygon.TabIndex = 7;
            this.drawPolygon.Text = "Построить";
            this.drawPolygon.UseVisualStyleBackColor = true;
            this.drawPolygon.Click += new System.EventHandler(this.DrawPolygon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawPolygon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox numberOfPolygonVertexes;
        private System.Windows.Forms.TextBox radiusOfThePolygon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button drawPolygon;
    }
}

