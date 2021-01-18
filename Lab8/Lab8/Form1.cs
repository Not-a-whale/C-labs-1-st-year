using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Goldenrod, 3);

            PointF p1, p2, p3, p4;

            float x1 = 50, y1 = 50;
            float x2 = 1050, y2 = 50;
            float x3 = 1050, y3 = 1050;
            float x4 = 50, y4 = 1050;
            float x11 = 50, y11 = 50;
            double P = 0.08;

            e.Graphics.DrawRectangle(pen, 50, 50, 1000, 1000);

            for (int i = 0; i < 50; i++)
            {
                x1 += (x2 - x1) * (float)P;
                y1 += (y2 - y1) * (float)P;

                x2 += (x3 - x2) * (float)P;
                y2 += (y3 - y2) * (float)P;

                x3 += (x4 - x3) * (float)P;
                y3 += (y4 - y3) * (float)P;

                x4 += (x11 - x4) * (float)P;
                y4 += (y11 - y4) * (float)P;

                x11 = x1;
                y11 = y1;

                p1 = new PointF(x1, y1);
                p2 = new PointF(x2, y2);
                p3 = new PointF(x3, y3);
                p4 = new PointF(x4, y4);

                e.Graphics.DrawLine(pen, p1, p2);
                e.Graphics.DrawLine(pen, p2, p3);
                e.Graphics.DrawLine(pen, p3, p4);
                e.Graphics.DrawLine(pen, p4, p1);
            }
        }
    }
}
