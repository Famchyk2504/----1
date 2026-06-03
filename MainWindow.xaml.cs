using System;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTextEditor
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbFontFamily.ItemsSource =
                Fonts.SystemFontFamilies
                .OrderBy(f => f.Source);

            cmbFontSize.ItemsSource =
                new List<double>()
                {
            8,9,10,11,12,
            14,16,18,20,
            22,24,26,28,
            36,48,72
                };

            CreateNewDocument();
        }

        private void cmbFontFamily_SelectionChanged(
    object sender,
    SelectionChangedEventArgs e)
        {
            RichTextBox editor =
                GetCurrentEditor();

            if (editor == null)
                return;

            if (cmbFontFamily.SelectedItem == null)
                return;

            FontFamily font =
                (FontFamily)cmbFontFamily.SelectedItem;

            editor.Selection.ApplyPropertyValue(
                TextElement.FontFamilyProperty,
                font);
        }

        private void cmbFontSize_SelectionChanged(
    object sender,
    SelectionChangedEventArgs e)
        {
            RichTextBox editor =
                GetCurrentEditor();

            if (editor == null)
                return;

            if (cmbFontSize.SelectedItem == null)
                return;

            double size =
                Convert.ToDouble(
                    cmbFontSize.SelectedItem);

            editor.Selection.ApplyPropertyValue(
                TextElement.FontSizeProperty,
                size);
        }

        private void CreateNewDocument()
        {
            TabItem tab = new TabItem();

            tab.Header =
                "Документ " +
                (tabDocuments.Items.Count + 1);

            RichTextBox editor =
                new RichTextBox();

            editor.VerticalScrollBarVisibility =
                ScrollBarVisibility.Auto;

            editor.AcceptsTab = true;

            tab.Content = editor;

            tabDocuments.Items.Add(tab);

            tabDocuments.SelectedItem = tab;
        }

        private RichTextBox GetCurrentEditor()
        {
            if (tabDocuments.SelectedItem == null)
                return null;

            TabItem tab =
                (TabItem)tabDocuments.SelectedItem;

            return tab.Content as RichTextBox;
        }

        private void miNew_Click(
    object sender,
    RoutedEventArgs e)
        {
            CreateNewDocument();
        }

        private void miExit_Click(
    object sender,
    RoutedEventArgs e)
        {
            Close();
        }

        private void miOpen_Click(
    object sender,
    RoutedEventArgs e)
        {
            OpenFileDialog dlg =
                new OpenFileDialog();

            dlg.Filter =
                "RTF Files (*.rtf)|*.rtf";

            if (dlg.ShowDialog() == true)
            {
                CreateNewDocument();

                RichTextBox editor =
                    GetCurrentEditor();

                TextRange range =
                    new TextRange(
                        editor.Document.ContentStart,
                        editor.Document.ContentEnd);

                using (FileStream fs =
                    new FileStream(
                        dlg.FileName,
                        FileMode.Open))
                {
                    range.Load(fs,
                        DataFormats.Rtf);
                }

                txtStatus.Text =
                    "Файл відкрито";
            }
        }

        private void miSave_Click(
    object sender,
    RoutedEventArgs e)
        {
            RichTextBox editor =
                GetCurrentEditor();

            if (editor == null)
                return;

            SaveFileDialog dlg =
                new SaveFileDialog();

            dlg.Filter =
                "RTF Files (*.rtf)|*.rtf";

            if (dlg.ShowDialog() == true)
            {
                TextRange range =
                    new TextRange(
                        editor.Document.ContentStart,
                        editor.Document.ContentEnd);

                using (FileStream fs =
                    new FileStream(
                        dlg.FileName,
                        FileMode.Create))
                {
                    range.Save(fs,
                        DataFormats.Rtf);
                }

                txtStatus.Text =
                    "Файл збережено";
            }
        }

            private void AlignLeft_Click(
    object sender,
    RoutedEventArgs e)
        {
            RichTextBox editor = GetCurrentEditor();

            if (editor == null) return;

            EditingCommands.AlignLeft.Execute(null, editor);
        }

        private void AlignCenter_Click(
            object sender,
            RoutedEventArgs e)
        {
            RichTextBox editor = GetCurrentEditor();

            if (editor == null) return;

            EditingCommands.AlignCenter.Execute(null, editor);
        }

        private void AlignRight_Click(
            object sender,
            RoutedEventArgs e)
        {
            RichTextBox editor = GetCurrentEditor();

            if (editor == null) return;

            EditingCommands.AlignRight.Execute(null, editor);
        }

        private void InsertImage_Click(
            object sender,
            RoutedEventArgs e)
        {
            RichTextBox editor = GetCurrentEditor();

            if (editor == null)
                return;

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter =
                "Images|*.png;*.jpg;*.jpeg;*.bmp";

            if (dlg.ShowDialog() == true)
            {
                Image img = new Image();

                img.Source =
                    new BitmapImage(
                        new Uri(dlg.FileName));

                img.Width = 300;

                InlineUIContainer container =
                    new InlineUIContainer(
                        img,
                        editor.CaretPosition);
            }
        }

        private void Ua_Click(
            object sender,
            RoutedEventArgs e)
        {
            txtStatus.Text =
        "Українська мова увімкнена";
        }

        private void En_Click(
            object sender,
            RoutedEventArgs e)
        {
            txtStatus.Text =
        "English language enabled";
        }

        private void btnBold_Click(
    object sender,
    RoutedEventArgs e)
        {
            RichTextBox editor = GetCurrentEditor();

            if (editor == null)
                return;

            EditingCommands.ToggleBold.Execute(
                null,
                editor);
        }

        private void btnItalic_Click(
    object sender,
    RoutedEventArgs e)
        {
            RichTextBox editor = GetCurrentEditor();

            if (editor == null)
                return;

            EditingCommands.ToggleItalic.Execute(
                null,
                editor);
        }

        private void btnUnderline_Click(
    object sender,
    RoutedEventArgs e)
        {
            RichTextBox editor = GetCurrentEditor();

            if (editor == null)
                return;

            EditingCommands.ToggleUnderline.Execute(
                null,
                editor);
        }

    }

    }

