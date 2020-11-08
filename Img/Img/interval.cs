using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Img
{
    public partial class interval : Form
    {
        public interval()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1.intervalForTimer = int.Parse(textBox1.Text);
            MessageBox.Show(Form1.intervalForTimer.ToString());
            this.Close();
        }
    }
}
