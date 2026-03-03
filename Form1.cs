using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LB_15_v24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxx.Text);

            double result = x
                            - 10 * Math.Sin(x)
                            + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));

            labelResult1.Text = "Результат: " + result.ToString("F3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBoxX1.Text);
            double y1 = Convert.ToDouble(textBoxY1.Text);
            double x2 = Convert.ToDouble(textBoxX2.Text);
            double y2 = Convert.ToDouble(textBoxY2.Text);
            double x3 = Convert.ToDouble(textBoxX3.Text);
            double y3 = Convert.ToDouble(textBoxY3.Text);

            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            labelTask2.Text = "P = " + P.ToString("F2") +
                              "   S = " + S.ToString("F2");
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBoxN.Text);
            int a = N / 100;
            int b = (N / 10) % 10;
            int c = N % 10;
            bool even = (a % 2 == 0) || (b % 2 == 0) || (c % 2 == 0);
            labelTask3.Text = even.ToString();
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(textBoxA.Text);
            double B = Convert.ToDouble(textBoxB.Text);
            double C = Convert.ToDouble(textBoxC.Text);

            if (Math.Abs(A * A + B * B - C * C) < 1e-6 ||
                Math.Abs(A * A + C * C - B * B) < 1e-6 ||
                Math.Abs(B * B + C * C - A * A) < 1e-6)
            {
                labelTask4.Text = "Прямокутний трикутник";

            }
            else
            {
                double cosC = (A * A + B * B - C * C) / (2 * A * B);
                double angleC = Math.Acos(cosC) * 180 / Math.PI;
                labelTask4.Text = "Кут С = " + angleC.ToString("F2");
            }
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox5.Text);
            int temp = N;
            int maxDigit = 0;

            while(temp>0)
            {
                int digit = temp % 10;
                if (digit > maxDigit) maxDigit = digit;
                temp /= 10;
            }
            int M = (N / 10) * 10 + maxDigit;
            labelTask5.Text = M.ToString();
        }

        private void buttonTask6_Click(object sender, EventArgs e)
        {
           
            string[] numbers = textBoxNumbers.Text.Split(' ');
            int M = Convert.ToInt32(textBoxM.Text);

            long product = 1;
            bool found = false;

            foreach (string num in numbers)
            {
                int val = Convert.ToInt32(num);
                if (val > M)
                {
                    product *= val;
                    found = true;
                }
            }

            labelTask6.Text = found ? product.ToString() : "Чисел більших за M немає";
        }

        private void buttonTask7_Click(object sender, EventArgs e)
        {
            string word = textBoxWord.Text;
            string rev = "";

            for (int i = word.Length - 1; i >= 0; i--)
                rev += word[i];

            labelTask7.Text = (word == rev) ? "Паліндром" : "Не паліндром";
        }
    }
}
   