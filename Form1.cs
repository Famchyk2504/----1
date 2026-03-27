using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab17_v24_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBoxAmount.Text);

            Currency d = new Dollar(value);

            labelResult.Text = d.Print();
        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBoxAmount.Text);

            Currency e1 = new Euro(value);

            labelResult.Text = e1.Print();
        }
    }
}
