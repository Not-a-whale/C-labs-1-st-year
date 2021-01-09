using Lab_3.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = new List<City>();
            list.Add(new City() {  Id = 1, Name = "Kyiv" });
            list.Add(new City() { Id = 3, Name = "Moscow" });
            list.Add(new City() { Id = 2, Name = "Minsk" });

            this.dataGridView1.DataSource = list;
        }
    }
}
