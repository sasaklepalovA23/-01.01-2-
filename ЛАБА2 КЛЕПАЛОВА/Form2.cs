using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБА2_КЛЕПАЛОВА
{
    public partial class Form2 : Form
    {
        private double yDivX;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "1,825 × 10²";
            textBox2.Text = "18,225";
            textBox3.Text = "-3.298 × 10⁻²";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine +
                "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine +
                "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine +
                "Z = " + z.ToString();
            double term1_pow = Math.Pow(x, y/x);
            double term1_cbrt = Math.Pow(y/x, 1.0 / 3.0);
            double part1_inner = term1_pow - (3 * term1_cbrt);
            double part1 = Math.Abs(part1_inner);
            double yMinusX = y - x;
            double fractionNumerator = Math.Cos(y) - (z / yMinusX);
            double fractionDenominator = 1 + Math.Pow(yMinusX, 2);
            double fractionResult = fractionNumerator / fractionDenominator;
            double part2 = yMinusX * fractionResult;
            textBox4.Text += Environment.NewLine +
                "1,2131 = " + part2.ToString();


        }
    }
}
