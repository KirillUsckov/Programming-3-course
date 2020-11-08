namespace Paint
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pencil = new System.Windows.Forms.ToolStripButton();
            this.line = new System.Windows.Forms.ToolStripButton();
            this.rectangle = new System.Windows.Forms.ToolStripButton();
            this.fillRectangle = new System.Windows.Forms.ToolStripButton();
            this.ellipse = new System.Windows.Forms.ToolStripButton();
            this.fillEllipse = new System.Windows.Forms.ToolStripButton();
            this.pipette = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorSelecter = new System.Windows.Forms.PictureBox();
            this.widthOfLine = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labelX = new System.Windows.Forms.ToolStripLabel();
            this.labelY = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.labelMode = new System.Windows.Forms.ToolStripLabel();
            this.radioButtonSolid = new System.Windows.Forms.RadioButton();
            this.radioButtonDash = new System.Windows.Forms.RadioButton();
            this.comboBoxDashStyle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorSelecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthOfLine)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvas.Location = new System.Drawing.Point(121, 36);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(749, 500);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(6, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 244);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencil,
            this.line,
            this.rectangle,
            this.fillRectangle,
            this.ellipse,
            this.fillEllipse,
            this.pipette});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 244);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // pencil
            // 
            this.pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pencil.Image = ((System.Drawing.Image)(resources.GetObject("pencil.Image")));
            this.pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(27, 24);
            this.pencil.Text = "toolStripButton3";
            // 
            // line
            // 
            this.line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(27, 24);
            this.line.Text = "toolStripButton1";
            // 
            // rectangle
            // 
            this.rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(27, 24);
            this.rectangle.Text = "toolStripButton2";
            // 
            // fillRectangle
            // 
            this.fillRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillRectangle.Image = ((System.Drawing.Image)(resources.GetObject("fillRectangle.Image")));
            this.fillRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillRectangle.Name = "fillRectangle";
            this.fillRectangle.Size = new System.Drawing.Size(27, 24);
            this.fillRectangle.Text = "toolStripButton1";
            // 
            // ellipse
            // 
            this.ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipse.Image = ((System.Drawing.Image)(resources.GetObject("ellipse.Image")));
            this.ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(27, 24);
            this.ellipse.Text = "toolStripButton1";
            // 
            // fillEllipse
            // 
            this.fillEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillEllipse.Image = ((System.Drawing.Image)(resources.GetObject("fillEllipse.Image")));
            this.fillEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillEllipse.Name = "fillEllipse";
            this.fillEllipse.Size = new System.Drawing.Size(27, 24);
            this.fillEllipse.Text = "toolStripButton1";
            // 
            // pipette
            // 
            this.pipette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pipette.Image = ((System.Drawing.Image)(resources.GetObject("pipette.Image")));
            this.pipette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pipette.Name = "pipette";
            this.pipette.Size = new System.Drawing.Size(27, 24);
            this.pipette.Text = "toolStripButton1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.colorSelecter);
            this.panel2.Controls.Add(this.widthOfLine);
            this.panel2.Location = new System.Drawing.Point(4, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 132);
            this.panel2.TabIndex = 4;
            // 
            // colorSelecter
            // 
            this.colorSelecter.BackColor = System.Drawing.Color.Black;
            this.colorSelecter.Location = new System.Drawing.Point(8, 6);
            this.colorSelecter.Name = "colorSelecter";
            this.colorSelecter.Size = new System.Drawing.Size(30, 30);
            this.colorSelecter.TabIndex = 6;
            this.colorSelecter.TabStop = false;
            this.colorSelecter.Click += new System.EventHandler(this.ColorSelecter_Click);
            // 
            // widthOfLine
            // 
            this.widthOfLine.Location = new System.Drawing.Point(0, 42);
            this.widthOfLine.Maximum = 100;
            this.widthOfLine.Name = "widthOfLine";
            this.widthOfLine.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.widthOfLine.Size = new System.Drawing.Size(56, 90);
            this.widthOfLine.TabIndex = 0;
            this.widthOfLine.Scroll += new System.EventHandler(this.WidthOfLine_Scroll);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.toolStripLabel7,
            this.toolStripLabel1,
            this.labelX,
            this.labelY,
            this.toolStripLabel4,
            this.labelMode});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(882, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel6.Text = "Сохранить";
            this.toolStripLabel6.Click += new System.EventHandler(this.ToolStripLabel6_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel7.Text = "Открыть";
            this.toolStripLabel7.Click += new System.EventHandler(this.ToolStripLabel7_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(165, 22);
            this.toolStripLabel1.Text = "Текущие координаты:";
            // 
            // labelX
            // 
            this.labelX.Enabled = false;
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(31, 22);
            this.labelX.Text = "x: 0";
            // 
            // labelY
            // 
            this.labelY.Enabled = false;
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(31, 22);
            this.labelY.Text = "y: 0";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Enabled = false;
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel4.Text = "Режим:";
            // 
            // labelMode
            // 
            this.labelMode.Enabled = false;
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(47, 22);
            this.labelMode.Text = "Pencil";
            // 
            // radioButtonSolid
            // 
            this.radioButtonSolid.AutoSize = true;
            this.radioButtonSolid.Location = new System.Drawing.Point(5, 456);
            this.radioButtonSolid.Name = "radioButtonSolid";
            this.radioButtonSolid.Size = new System.Drawing.Size(60, 21);
            this.radioButtonSolid.TabIndex = 7;
            this.radioButtonSolid.TabStop = true;
            this.radioButtonSolid.Text = "Solid";
            this.radioButtonSolid.UseVisualStyleBackColor = true;
            this.radioButtonSolid.CheckedChanged += new System.EventHandler(this.RadioButtonSolid_CheckedChanged);
            // 
            // radioButtonDash
            // 
            this.radioButtonDash.AutoSize = true;
            this.radioButtonDash.Location = new System.Drawing.Point(5, 483);
            this.radioButtonDash.Name = "radioButtonDash";
            this.radioButtonDash.Size = new System.Drawing.Size(62, 21);
            this.radioButtonDash.TabIndex = 8;
            this.radioButtonDash.TabStop = true;
            this.radioButtonDash.Text = "Dash";
            this.radioButtonDash.UseVisualStyleBackColor = true;
            this.radioButtonDash.CheckedChanged += new System.EventHandler(this.RadioButtonDash_CheckedChanged);
            // 
            // comboBoxDashStyle
            // 
            this.comboBoxDashStyle.Enabled = false;
            this.comboBoxDashStyle.FormattingEnabled = true;
            this.comboBoxDashStyle.Items.AddRange(new object[] {
            "Dot",
            "Dash",
            "DashDot"});
            this.comboBoxDashStyle.Location = new System.Drawing.Point(0, 510);
            this.comboBoxDashStyle.Name = "comboBoxDashStyle";
            this.comboBoxDashStyle.Size = new System.Drawing.Size(115, 24);
            this.comboBoxDashStyle.TabIndex = 9;
            this.comboBoxDashStyle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDashStyle_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.comboBoxDashStyle);
            this.Controls.Add(this.radioButtonDash);
            this.Controls.Add(this.radioButtonSolid);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canvas);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorSelecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthOfLine)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton line;
        private System.Windows.Forms.ToolStripButton rectangle;
        private System.Windows.Forms.ToolStripButton pencil;
        private System.Windows.Forms.ToolStripButton ellipse;
        private System.Windows.Forms.ToolStripButton fillRectangle;
        private System.Windows.Forms.ToolStripButton fillEllipse;
        private System.Windows.Forms.ToolStripButton pipette;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar widthOfLine;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox colorSelecter;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel labelX;
        private System.Windows.Forms.ToolStripLabel labelY;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel labelMode;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.RadioButton radioButtonSolid;
        private System.Windows.Forms.RadioButton radioButtonDash;
        private System.Windows.Forms.ComboBox comboBoxDashStyle;
    }
}

