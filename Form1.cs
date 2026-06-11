using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab_23
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        double x0;
        double y0;
        double a;
        double b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            x0 = Convert.ToDouble(txtX0.Text);
            y0 = Convert.ToDouble(txtY0.Text);
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            panelGraph.Invalidate();
        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int W = panelGraph.Width;
            int H = panelGraph.Height;

            g.Clear(Color.White);

            g.DrawLine(
                Pens.Black,
                20,
                H / 2,
                W - 20,
                H / 2);

            g.DrawLine(
                Pens.Black,
                W / 2,
                20,
                W / 2,
                H - 20);

            g.DrawString(
                "X",
                Font,
                Brushes.Black,
                W - 30,
                H / 2 + 10);

            g.DrawString(
                "Y",
                Font,
                Brushes.Black,
                W / 2 + 10,
                20);

            for (int i = 50; i < W; i += 100)
            {
                g.DrawString(
                    (i - W / 2).ToString(),
                    Font,
                    Brushes.Black,
                    i,
                    H / 2 + 10);
            }

            for (int i = 50; i < H; i += 100)
            {
                g.DrawString(
                    (H / 2 - i).ToString(),
                    Font,
                    Brushes.Black,
                    W / 2 + 10,
                    i);
            }

            for (int i = 50; i < W; i += 50)
            {
                g.DrawLine(Pens.Black,
                    i,
                    H / 2 - 5,
                    i,
                    H / 2 + 5);
            }

            for (int i = 50; i < H; i += 50)
            {
                g.DrawLine(Pens.Black,
                    W / 2 - 5,
                    i,
                    W / 2 + 5,
                    i);
            }
            List<PointF> points = new List<PointF>();

            double xmin = double.MaxValue;
            double xmax = double.MinValue;

            double ymin = double.MaxValue;
            double ymax = double.MinValue;

            for (double t = -20; t <= 20; t += 0.05)
            {
                double x = x0 * t + a * Math.Cos(t);

                double y = y0 * t + b * Math.Sin(t);

                if (x < xmin) xmin = x;
                if (x > xmax) xmax = x;

                if (y < ymin) ymin = y;
                if (y > ymax) ymax = y;
            }
           
            double scaleX =
                (W - 100) / (xmax - xmin);

            double scaleY =
                (H - 100) / (ymax - ymin);

            double scale =
                Math.Min(scaleX, scaleY);

            for (double t = -20; t <= 20; t += 0.05)
            {
                double x = x0 * t + a * Math.Cos(t);

                double y = y0 * t + b * Math.Sin(t);

                float sx =
                    (float)((x - xmin) * scale + 50);

                float sy =
                    (float)(H - ((y - ymin) * scale + 50));

                points.Add(
                    new PointF(sx, sy));
            }

            if (points.Count > 1)
            {
                Pen graphPen =
                    new Pen(Color.Blue, 2);

                g.DrawLines(
                    graphPen,
                    points.ToArray());
            }
        }
        
    }
}
