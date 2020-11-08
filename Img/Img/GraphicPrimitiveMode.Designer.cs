namespace Img
{
    partial class GraphicPrimitiveMode
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
            this.AutoMode = new System.Windows.Forms.Button();
            this.ManualMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AutoMode
            // 
            this.AutoMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoMode.Location = new System.Drawing.Point(182, 189);
            this.AutoMode.Name = "AutoMode";
            this.AutoMode.Size = new System.Drawing.Size(190, 67);
            this.AutoMode.TabIndex = 0;
            this.AutoMode.Text = "Автоматический";
            this.AutoMode.UseVisualStyleBackColor = true;
            this.AutoMode.Click += new System.EventHandler(this.AutoMode_Click);
            // 
            // ManualMode
            // 
            this.ManualMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManualMode.Location = new System.Drawing.Point(434, 189);
            this.ManualMode.Name = "ManualMode";
            this.ManualMode.Size = new System.Drawing.Size(190, 67);
            this.ManualMode.TabIndex = 1;
            this.ManualMode.Text = "Ручной";
            this.ManualMode.UseVisualStyleBackColor = true;
            this.ManualMode.Click += new System.EventHandler(this.ManualMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать режим работы с фигурами";
            // 
            // GraphicPrimitiveMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManualMode);
            this.Controls.Add(this.AutoMode);
            this.Name = "GraphicPrimitiveMode";
            this.Text = "GraphicPrimitiveMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AutoMode;
        private System.Windows.Forms.Button ManualMode;
        private System.Windows.Forms.Label label1;
    }
}