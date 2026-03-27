using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_18_v24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Завдання 1
        private void btnCalculate1D_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text.Trim());
                double C = double.Parse(txtC.Text.Trim().Replace(',', '.'));

                // ФІКС: замінюємо кому на крапку перед парсингом
                string input = txtArray1D.Text.Trim()
                    .Replace(',', '.')                    // десяткова кома → крапка
                    .Replace("  ", " ");                  // прибираємо зайві пробіли

                double[] arr = input
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => double.Parse(x, System.Globalization.CultureInfo.InvariantCulture))
                    .ToArray();

                if (arr.Length != n)
                    throw new Exception($"Потрібно ввести рівно {n} елементів!");

                // а) кількість менших за C
                int countLessC = arr.Count(x => x < C);

                // б) сума цілих частин після останнього від’ємного
                int lastNeg = Array.FindLastIndex(arr, x => x < 0);
                double sumFloor = 0;
                if (lastNeg != -1 && lastNeg < n - 1)
                {
                    for (int i = lastNeg + 1; i < n; i++)
                        sumFloor += Math.Floor(arr[i]);
                }

                double max = arr.Max();
                double threshold = 0.2 * Math.Abs(max);

                var closeToMax = arr.Where(x => Math.Abs(x - max) <= threshold);
                var others = arr.Where(x => Math.Abs(x - max) > threshold);
                double[] newArray = closeToMax.Concat(others).ToArray();

                rtbResult1D.Text =
                    $"Кількість елементів < C ({C}): {countLessC}\n\n" +
                    $"Сума цілих частин після останнього від’ємного: {sumFloor}\n\n" +
                    $"Максимальний елемент: {max:F2}\n\n" +
                    $"Перетворений масив:\n" +
                    string.Join("   ", newArray.Select(x => x.ToString("F2")));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Завдання 2

        private double[,] ReadMatrix()
        {
            string text = txtMatrix.Text.Trim();
            if (string.IsNullOrEmpty(text))
                throw new Exception("Введіть двовимірний масив!");

            // ФІКС: замінюємо кому на крапку в усьому тексті
            text = text.Replace(',', '.');

            var lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = double.Parse(values[j], System.Globalization.CultureInfo.InvariantCulture);
            }
            return matrix;
        }

        private void btnShowFullMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] m = ReadMatrix();
                string result = "Двовимірний масив:\n\n";
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    for (int j = 0; j < m.GetLength(1); j++)
                        result += $"{m[i, j]:F2}\t";
                    result += "\n";
                }
                rtbResult2D.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowCol3Element_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] m = ReadMatrix();
                int row = int.Parse(txtRowCol3.Text.Trim());

                if (row < 0 || row >= m.GetLength(0) || m.GetLength(1) < 3)
                    throw new Exception("Неправильний рядок або немає 3-го стовпця!");

                rtbResult2D.Text = $"Елемент 3-го стовпця (рядок {row}) = {m[row, 2]:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAnyElement_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] m = ReadMatrix();
                int row = int.Parse(txtRowAny.Text.Trim());
                int col = int.Parse(txtColAny.Text.Trim());

                if (row < 0 || row >= m.GetLength(0) || col < 0 || col >= m.GetLength(1))
                    throw new Exception("Неправильні індекси!");

                rtbResult2D.Text = $"Елемент [{row}, {col}] = {m[row, col]:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
