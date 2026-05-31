using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTextEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorForm frm = new EditorForm();

            frm.MdiParent = this;

            frm.Text = "Новий документ";

            frm.Show();
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter =
                "RTF Files|*.rtf|Text Files|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                EditorForm frm = new EditorForm();

                frm.MdiParent = this;

                if (ofd.FileName.EndsWith(".rtf"))
                {
                    frm.GetEditor().LoadFile(ofd.FileName);
                }
                else
                {
                    frm.GetEditor().Text =
                        System.IO.File.ReadAllText(ofd.FileName);
                }

                frm.CurrentFile = ofd.FileName;

                frm.Text =
                    System.IO.Path.GetFileName(ofd.FileName);

                frm.Show();
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            EditorForm frm =
                (EditorForm)ActiveMdiChild;

            SaveFileDialog sfd =
                new SaveFileDialog();

            sfd.Filter =
                "RTF Files|*.rtf|Text Files|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName.EndsWith(".rtf"))
                {
                    frm.GetEditor().SaveFile(sfd.FileName);
                }
                else
                {
                    System.IO.File.WriteAllText(
                        sfd.FileName,
                        frm.GetEditor().Text);
                }
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            EditorForm frm =
                (EditorForm)ActiveMdiChild;

            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                frm.GetEditor().SelectionFont =
                    fd.Font;
            }
        }

        private void влівоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((EditorForm)ActiveMdiChild)
        .GetEditor()
        .SelectionAlignment =
            HorizontalAlignment.Left;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((EditorForm)ActiveMdiChild)
                    .GetEditor()
                    .SelectionAlignment =
                        HorizontalAlignment.Center;
        }

        private void вправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((EditorForm)ActiveMdiChild)
                    .GetEditor()
                    .SelectionAlignment =
                        HorizontalAlignment.Right;
        }

        private void зображенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            OpenFileDialog ofd =
                new OpenFileDialog();

            ofd.Filter =
                "Images|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetImage(
                    System.Drawing.Image.FromFile(
                        ofd.FileName));

                ((EditorForm)ActiveMdiChild)
                    .GetEditor()
                    .Paste();
            }
        }

        private void українськаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            файлToolStripMenuItem.Text = "Файл";
            форматToolStripMenuItem.Text = "Формат";
            вставкаToolStripMenuItem.Text = "Вставка";
            моваToolStripMenuItem.Text = "Мова";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            файлToolStripMenuItem.Text = "File";
            форматToolStripMenuItem.Text = "Format";
            вставкаToolStripMenuItem.Text = "Insert";
            моваToolStripMenuItem.Text = "Language";
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void вертикальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void закритиПоточнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void закритиВсіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
    }
}
