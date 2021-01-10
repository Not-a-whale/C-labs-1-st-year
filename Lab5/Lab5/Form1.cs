using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xText = x.Text;
            var xResult = calculate(xText);
            result.Text = Convert.ToString(xResult);
        }

        private double calculate (string input)
        {
            double z = Convert.ToDouble(input);
            z = Math.Abs((3 * Math.Cos(z * 4)) / Math.Pow(Math.Exp(2), Math.Sin(z))) + 4*Math.Log(Math.Sqrt(Math.Pow(Math.Exp(2), Math.Sin(z)) + Math.Pow(Math.Exp(2), z))) - Math.Abs(10*z + Math.Pow(Math.Exp(2), (z+5)));
            return z;
        }
    }
}
