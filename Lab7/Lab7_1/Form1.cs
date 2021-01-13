using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gObject = Canvas.CreateGraphics();

            // H - goldenrod

            Brush brush = new SolidBrush(Color.Goldenrod);

            Pen pen = new Pen(brush, 8);

            gObject.DrawLine(pen, 10, 10, 10, 80);
            gObject.DrawLine(pen, 10, 40, 40, 40);
            gObject.DrawLine(pen, 40, 10, 40, 80);

            // И - black

            brush = new SolidBrush(Color.Black);

            pen.Brush = brush;

            gObject.DrawLine(pen, 60, 10, 60, 80);
            gObject.DrawLine(pen, 60, 80, 80, 10);
            gObject.DrawLine(pen, 80, 10, 80, 80);

            // K - red

            brush = new SolidBrush(Color.Red);

            pen.Brush = brush;

            gObject.DrawLine(pen, 100, 10, 100, 80);
            gObject.DrawLine(pen, 100, 35, 120, 10);
            gObject.DrawLine(pen, 100, 35, 120, 80);

            // И - black

            brush = new SolidBrush(Color.Black);

            pen.Brush = brush;

            gObject.DrawLine(pen, 140, 10, 140, 80);
            gObject.DrawLine(pen, 140, 80, 160, 10);
            gObject.DrawLine(pen, 160, 10, 160, 80);

            // Т - teal

            brush = new SolidBrush(Color.Teal);

            pen.Brush = brush;

            gObject.DrawLine(pen, 175, 10, 205, 10);
            gObject.DrawLine(pen, 190, 10, 190, 80);

            // A - green 

            brush = new SolidBrush(Color.Green);

            pen.Brush = brush;

            gObject.DrawLine(pen, 230, 10, 220, 80);
            gObject.DrawLine(pen, 225, 60, 240, 60);
            gObject.DrawLine(pen, 230, 10, 240, 80);


            // K - red

            brush = new SolidBrush(Color.Red);

            pen.Brush = brush;

            gObject.DrawLine(pen, 10, 100, 10, 160);

            gObject.DrawLine(pen, 10, 130, 30, 100);
            gObject.DrawLine(pen, 10, 130, 30, 160);

            // O - Orange

            brush = new SolidBrush(Color.Orange);

            pen.Brush = brush;

            e.Graphics.DrawArc(pen, new Rectangle(50, 105, 25, 50), 0, 500);

            // P - Pink

            pen.Color = Color.HotPink;
            e.Graphics.DrawLine(pen, 100, 100, 100, 160);
            e.Graphics.DrawArc(pen, new Rectangle(100, 102, 10, 25), 250, 250);

            // H - goldenrod

            pen.Color = Color.Goldenrod;

            gObject.DrawLine(pen, 140, 100, 140, 160);
            gObject.DrawLine(pen, 140, 130, 160, 130);
            gObject.DrawLine(pen, 160, 100, 160, 160);

            // И - black

            pen.Color = Color.Black;

            gObject.DrawLine(pen, 190, 100, 190, 160);
            gObject.DrawLine(pen, 190, 160, 210, 100);
            gObject.DrawLine(pen, 210, 100, 210, 160);


            // E - yellow 

            pen.Color = Color.Yellow;

            gObject.DrawLine(pen, 240, 100, 240, 160);
            gObject.DrawLine(pen, 240, 100, 260, 100);
            gObject.DrawLine(pen, 240, 130, 260, 130);
            gObject.DrawLine(pen, 240, 160, 260, 160);


            // H - goldenrod

            pen.Color = Color.Goldenrod;

            gObject.DrawLine(pen, 280, 100, 280, 160);
            gObject.DrawLine(pen, 280, 130, 300, 130);
            gObject.DrawLine(pen, 300, 100, 300, 160);


            // K - red

            pen.Color = Color.Red;

            gObject.DrawLine(pen, 320, 100, 320, 160);

            gObject.DrawLine(pen, 320, 130, 340, 100);
            gObject.DrawLine(pen, 320, 130, 340, 160);


            // O - Orange

            brush = new SolidBrush(Color.Orange);

            pen.Brush = brush;

            e.Graphics.DrawArc(pen, new Rectangle(360, 100, 25, 50), 0, 500);
        }
    }
}
