using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab19_Variant24_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            // Перевірка рядка
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введіть рядок!");
                return;
            }

            // Зчитування чисел
            int position, length;

            if (!int.TryParse(textBoxPosition.Text, out position) ||
                !int.TryParse(textBoxLength.Text, out length))
            {
                MessageBox.Show("Позиція і довжина мають бути числами!");
                return;
            }

            // Перевірка меж
            if (position < 0 || position >= input.Length)
            {
                MessageBox.Show("Позиція поза межами рядка!");
                return;
            }

            if (length < 0 || position + length > input.Length)
            {
                MessageBox.Show("Неправильна довжина!");
                return;
            }

            //  Видалення 
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i >= position && i < position + length)
                    continue;

                result += input[i];
            }

            textBoxResult.Text = result;
        }
    }
}
