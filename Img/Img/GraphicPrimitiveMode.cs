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
    public partial class GraphicPrimitiveMode : Form
    {
        public GraphicPrimitiveMode()
        {
            InitializeComponent();
        }

        private void AutoMode_Click(object sender, EventArgs e)
        {
            GraphicPrimitivesAuto gpaForm = new GraphicPrimitivesAuto();
            gpaForm.Show();
            gpaForm.FormClosed += formClose;
            this.Hide();
        }

        private void ManualMode_Click(object sender, EventArgs e)
        {
            GraphicPrimitiveManual gpmForm = new GraphicPrimitiveManual();
            gpmForm.Show();
            gpmForm.FormClosed += formClose;
            this.Hide();
        }
        private void formClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
            this.Close();
        }
    }
}
