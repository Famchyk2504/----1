using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb_24
{
    public partial class Form1 : Form
    {
        Thread thread1;
        Thread thread2;
        Thread thread3;
        public Form1()
        {
            InitializeComponent();

            thread1 =
                new Thread(new ThreadStart(draw_rect));

            thread2 =
                new Thread(new ThreadStart(draw_eclips));

            thread3 =
                new Thread(new ThreadStart(Rnd_num));
        }

        private void draw_rect()
        {
            try
            {
                Random rnd = new Random();

                Graphics g =
                    panel1.CreateGraphics();

                while (true)
                {
                    Thread.Sleep(40);

                    g.DrawRectangle(
                        Pens.Pink,
                        0,
                        0,
                        rnd.Next(panel1.Width),
                        rnd.Next(panel1.Height));
                }
            }
            catch
            {

            }
        }

        private void draw_eclips()
        {
            try
            {
                Random rnd = new Random();

                Graphics g =
                    panel2.CreateGraphics();

                while (true)
                {
                    Thread.Sleep(40);

                    g.DrawEllipse(
                        Pens.Blue,
                        0,
                        0,
                        rnd.Next(panel2.Width),
                        rnd.Next(panel2.Height));
                }
            }
            catch
            {

            }
        }

        private void Rnd_num()
        {
            try
            {
                Random rnd = new Random();

                while (true)
                {
                    Thread.Sleep(50);

                    richTextBox1.Invoke(
                        (MethodInvoker)delegate
                        {
                            richTextBox1.AppendText(
                                rnd.Next().ToString()
                                + Environment.NewLine);
                        });
                }
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thread3.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (thread1 != null && thread1.IsAlive)
                    thread1.Suspend();
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (thread2 != null && thread2.IsAlive)
                    thread2.Suspend();
            }
            catch
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (thread3 != null && thread3.IsAlive)
                    thread3.Suspend();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (thread1 != null && thread1.IsAlive)
                    thread1.Suspend();

                if (thread2 != null && thread2.IsAlive)
                    thread2.Suspend();

                if (thread3 != null && thread3.IsAlive)
                    thread3.Suspend();
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (thread1 != null)
                {
                    if (thread1.ThreadState == ThreadState.Suspended)
                        thread1.Resume();

                    thread1.Abort();
                }

                if (thread2 != null)
                {
                    if (thread2.ThreadState == ThreadState.Suspended)
                        thread2.Resume();

                    thread2.Abort();
                }

                if (thread3 != null)
                {
                    if (thread3.ThreadState == ThreadState.Suspended)
                        thread3.Resume();

                    thread3.Abort();
                }
            }
            catch
            {

            }
        }
    }
}
