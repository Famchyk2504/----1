using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int hours = int.Parse(txtHours.Text);
                int minutes = int.Parse(txtMinutes.Text);
                int totalSeconds = ConvertTimeToSeconds(hours, minutes);

                lblResult.Text = $"Результат: {totalSeconds} сек.";
                lblResult.ForeColor = Color.Green;
            }
            catch (FormatException)
            {
                lblResult.Text = "Помилка: будь ласка, введіть лише цілі числа!";
                lblResult.ForeColor = Color.Red;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lblResult.Text = $"Помилка діапазону: {ex.Message}";
                lblResult.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Щось пішло не так: {ex.Message}";
                lblResult.ForeColor = Color.Red;
            }
            finally
            {
                System.Diagnostics.Debug.WriteLine("Обробку натискання кнопки завершено.");
            }
        }
        private int ConvertTimeToSeconds(int hours, int minutes)
        {
            if (hours < 0 || minutes < 0)
            {
                throw new ArgumentOutOfRangeException("Час не може бути від'ємним!");
            }
            if (minutes >= 60)
            {
                throw new ArgumentOutOfRangeException("Хвилини не можуть бути 60 або більше!");
            }
            return (hours * 3600) + (minutes * 60);

        }
    }
}
