using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MultiTextEditor
{
    public partial class EditorForm : Form
    {
        public string CurrentFile = "";

        public EditorForm()
        {
            InitializeComponent();
            richTextBox1.TextChanged += HighlightCode;
        }

        private void HighlightCode(
    object sender,
    EventArgs e)
        {
            int pos =
                richTextBox1.SelectionStart;

            string[] keywords =
            {
        "int",
        "float",
        "double",
        "for",
        "while",
        "if",
        "else",
        "return",
        "class",
        "public",
        "private",
        "void"
    };

            richTextBox1.SelectAll();

            richTextBox1.SelectionColor =
                Color.Black;

            foreach (string word in keywords)
            {
                MatchCollection matches =
                    Regex.Matches(
                        richTextBox1.Text,
                        "\\b" + word + "\\b");

                foreach (Match m in matches)
                {
                    richTextBox1.Select(
                        m.Index,
                        m.Length);

                    richTextBox1.SelectionColor =
                        Color.Blue;
                }
            }

            richTextBox1.SelectionStart = pos;

            richTextBox1.SelectionLength = 0;

            richTextBox1.SelectionColor =
                Color.Black;
        }

        public RichTextBox GetEditor()
        {
            return richTextBox1;
        }
    }
}
