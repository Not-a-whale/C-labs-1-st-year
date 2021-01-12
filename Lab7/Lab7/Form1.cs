using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Canvas(object sender, PaintEventArgs e)
        {
            Graphics gObject = Canvas.CreateGraphics();

            Brush gold = new SolidBrush(Color.Goldenrod);

            Pen goldPen = new Pen(gold, 8);

            gObject.DrawLine(goldPen, 10, 10, 400, 376);

        }
    }
}
