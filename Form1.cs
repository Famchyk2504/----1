using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Lab26
{
    public partial class Form1 : Form
    {
        private Word.Application wordApp;
        private Word.Document wordDoc;

        private string[] templates;
        private int documentsCreated = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string templateFolder =
    Path.Combine(
        Application.StartupPath,
        "Templates");

                templates =
                    Directory.GetFiles(
                        templateFolder,
                        "*.dotx");

                cmbTemplates.Items.Clear();

                foreach (string file in templates)
                {
                    cmbTemplates.Items.Add(
                        Path.GetFileNameWithoutExtension(file));
                }

                if (cmbTemplates.Items.Count > 0)
                    cmbTemplates.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Помилка завантаження шаблонів:\n" +
                    ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtVictim.Text) ||
                 string.IsNullOrWhiteSpace(txtPlace.Text) ||
                string.IsNullOrWhiteSpace(txtReason.Text) ||
               string.IsNullOrWhiteSpace(txtCompany.Text) ||
               string.IsNullOrWhiteSpace(txtInspector.Text))
            {
                MessageBox.Show(
                    "Заповніть усі поля!");

                return;
            }

            try
            {
                if (cmbTemplates.SelectedIndex < 0)
                {
                    MessageBox.Show(
                        "Оберіть шаблон!");

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtVictim.Text))
                {
                    MessageBox.Show(
                        "Введіть ПІБ потерпілого!");

                    return;
                }

                string template =
                    templates[cmbTemplates.SelectedIndex];

                wordApp = new Word.Application();

                wordDoc =
                    wordApp.Documents.Add(template);

                FillContentControl(
                    "Victim",
                    txtVictim.Text);

                FillContentControl(
                    "Date",
                    dtpDate.Value.ToShortDateString());

                FillContentControl(
                    "Place",
                    txtPlace.Text);

                FillContentControl(
                    "Reason",
                    txtReason.Text);

                FillContentControl(
                    "Company",
                    txtCompany.Text);

                FillContentControl(
                    "Inspector",
                    txtInspector.Text);

                documentsCreated++;

                lblCounter.Text =
                    "Створено документів: " +
                    documentsCreated;

                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Помилка створення документа:\n" +
                    ex.Message);
            }
        }

        private void FillContentControl(
            string title,
            string value)
        {
            foreach (Word.ContentControl cc
                in wordDoc.ContentControls)
            {
                if (cc.Title == title)
                {
                    cc.Range.Text = value;
                }
            }
        }

        private void btnPreview_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbTemplates.SelectedIndex < 0)
                {
                    MessageBox.Show(
                        "Оберіть шаблон!");

                    return;
                }

                Process.Start(
                    templates[cmbTemplates.SelectedIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (wordDoc == null)
            {
                MessageBox.Show(
                    "Спочатку створіть документ!");

                return;
            }

            SaveFileDialog sfd =
                new SaveFileDialog();

            sfd.Filter =
                "Word document (*.docx)|*.docx";

            if (sfd.ShowDialog() ==
                DialogResult.OK)
            {
                wordDoc.SaveAs2(
                    sfd.FileName);

                MessageBox.Show(
                    "Документ успішно збережено!");
            }
        }

        private void Form1_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            try
            {
                if (wordDoc != null)
                    wordDoc.Close(false);

                if (wordApp != null)
                    wordApp.Quit();
            }
            catch
            {
            }
        }

        private void lblTemplate_Click(
            object sender,
            EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVictim.Clear();
            txtPlace.Clear();
            txtReason.Clear();
            txtCompany.Clear();
            txtInspector.Clear();
            txtSearch.Clear();
            txtReplace.Clear();

            dtpDate.Value = DateTime.Now;

            cmbTemplates.SelectedIndex = 0;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (wordDoc == null)
            {
                MessageBox.Show("Документ не створено!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Введіть текст для пошуку!");
                return;
            }

            Word.Range range = wordDoc.Content;

            Word.Find find = range.Find;

            find.ClearFormatting();
            find.Replacement.ClearFormatting();

            bool result = find.Execute(
                FindText: txtSearch.Text,
                ReplaceWith: txtReplace.Text,
                Replace: Word.WdReplace.wdReplaceAll);

            if (result)
                MessageBox.Show("Заміну виконано.");
            else
                MessageBox.Show("Текст для заміни не знайдено.");
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemplates.SelectedIndex >= 0)
            {
                lblTemplatePath.Text =
                    templates[
                        cmbTemplates.SelectedIndex];
            }
        }
    }
}