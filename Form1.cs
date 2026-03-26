using Lab16;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16_v24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Polynomial ReadPoly(string input)
        {
            return new Polynomial(input.Split(' ')
                .Select(double.Parse).ToList());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);
            var q = ReadPoly(textBoxQ.Text);

            labelResult.Text = Polynomial.Add(p, q).ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);
            var q = ReadPoly(textBoxQ.Text);

            labelResult.Text = Polynomial.Subtract(p, q).ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);
            var q = ReadPoly(textBoxQ.Text);

            labelResult.Text = Polynomial.Multiply(p, q).ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);
            var q = ReadPoly(textBoxQ.Text);

            var result = Polynomial.Divide(p, q);

            labelResult.Text = "Частка: " + result.Item1 +
                               " Остача: " + result.Item2;
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);
            var q = ReadPoly(textBoxQ.Text);

            if (p.Equals(q))
                labelResult.Text = "Рівні";
            else
                labelResult.Text = "Не рівні";
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);
            int k = int.Parse(textBoxK.Text);

            labelResult.Text = Polynomial.Pow(p, k).ToString();
        }

        private void buttonDer_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);

            labelResult.Text = Polynomial.Derivative(p).ToString();
        }

        private void buttonEval_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);
            double x0 = double.Parse(textBoxX0.Text);

            labelResult.Text = p.Evaluate(x0).ToString();
        }

        private void buttonGCD_Click(object sender, EventArgs e)
        {
            var p = ReadPoly(textBoxP.Text);
            var q = ReadPoly(textBoxQ.Text);

            labelResult.Text = Polynomial.GCD(p, q).ToString();
        }
    }
}
