using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practich1
{
    public partial class Form1 : Form
    {
        public double x;
        public double y;
        public double z;
        public double t;
        public double PI = 3.1415926535897931;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z= Convert.ToDouble(textBox3.Text);
            t = (Math.Cos(x - PI / 6) * 2) / (0.5 + Math.Sin(y) * Math.Sin(y)) * (1+(z*z/((3-z*z)/5)));
            textBox4.Text = Convert.ToString(t);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
