using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Security.AccessControl;

namespace Lab27_FileSystem
{
    public partial class Form1 : Form
    {
        private string currentPath = "";

        public Form1()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.Form1_Load);
            cmbDrives.SelectedIndexChanged += new System.EventHandler(this.cmbDrives_SelectedIndexChanged);

            tvDirectories.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvDirectories_BeforeExpand);
            tvDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDirectories_AfterSelect);

            lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);

            btnFileFilter.Click += new System.EventHandler(this.btnFileFilter_Click);
            btnFolderFilter.Click += new System.EventHandler(this.btnFolderFilter_Click);
            btnBack.Click += new System.EventHandler(this.btnBack_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                cmbDrives.Items.Clear();

                foreach (DriveInfo drive in drives)
                {
                    if (drive.IsReady)
                    {
                        cmbDrives.Items.Add(drive.Name);
                    }
                }

                if (cmbDrives.Items.Count > 0)
                    cmbDrives.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDrives.SelectedItem == null) return;

            string driveName = cmbDrives.SelectedItem.ToString();
            currentPath = driveName;

            tvDirectories.Nodes.Clear();

            TreeNode rootNode = new TreeNode(driveName);
            rootNode.Tag = driveName;
            rootNode.Nodes.Add(new TreeNode("Loading..."));

            tvDirectories.Nodes.Add(rootNode);
            rootNode.Expand();

            ShowDriveInfo(driveName);
            LoadFiles(driveName, txtFileFilter.Text);
        }

        private void tvDirectories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Tag == null) return;

            if (node.Nodes.Count == 1 && node.Nodes[0].Tag == null)
            {
                node.Nodes.Clear();
                LoadDirectories(node, txtFolderFilter.Text);
            }
        }

        private void tvDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null) return;

            string path = e.Node.Tag.ToString();
            currentPath = path;

            ShowDirectoryInfo(path);
            LoadFiles(path, txtFileFilter.Text);
        }

        private void LoadDirectories(TreeNode parentNode, string searchPattern = "*")
        {
            try
            {
                string path = parentNode.Tag.ToString();
                if (string.IsNullOrWhiteSpace(searchPattern)) searchPattern = "*";

                string[] dirs = Directory.GetDirectories(path, searchPattern);
                foreach (string dir in dirs)
                {
                    DirectoryInfo info = new DirectoryInfo(dir);
                    TreeNode child = new TreeNode(info.Name);
                    child.Tag = dir;

                    try
                    {
                        if (Directory.GetDirectories(dir).Length > 0)
                        {
                            child.Nodes.Add(new TreeNode("Loading..."));
                        }
                    }
                    catch { }

                    parentNode.Nodes.Add(child);
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }

        private void LoadFiles(string path, string searchPattern = "*.*")
        {
            lstFiles.Items.Clear();
            if (string.IsNullOrWhiteSpace(searchPattern)) searchPattern = "*.*";

            try
            {
                string[] files = Directory.GetFiles(path, searchPattern);
                foreach (string file in files)
                {
                    lstFiles.Items.Add(Path.GetFileName(file));
                }
            }
            catch (Exception ex)
            {
                lstFiles.Items.Add(ex.Message);
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null) return;

            string fileName = lstFiles.SelectedItem.ToString();
            if (fileName.StartsWith("Помилка доступу:")) return;

            string fullPath = Path.Combine(currentPath, fileName);
            if (!File.Exists(fullPath)) return;

            ShowFileInfo(fullPath);
            ShowTextFile(fullPath);
            ShowImage(fullPath);

            string ext = Path.GetExtension(fullPath).ToLower().Trim();
            if (ext == ".docx" || ext == ".doc" || ext == ".pdf")
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(fullPath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося відкрити файл зовнішньо: " + ex.Message);
                }
            }
        }

        private void ShowDriveInfo(string driveName)
        {
            try
            {
                DriveInfo drive = new DriveInfo(driveName);
                long totalGb = drive.TotalSize / 1024 / 1024 / 1024;
                long freeGb = drive.TotalFreeSpace / 1024 / 1024 / 1024;

                lblInfo.Text = "Назва: " + drive.Name + "\n" +
                               "Тип: " + drive.DriveType + "\n" +
                               "Файлова система: " + drive.DriveFormat + "\n" +
                               "Загальний розмір: " + totalGb + " GB\n" +
                               "Вільно місця: " + freeGb + " GB";
            }
            catch { }
        }

        private void ShowDirectoryInfo(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectorySecurity security = dir.GetAccessControl();
                string owner = security.GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();

                lblInfo.Text = "Назва: " + dir.Name + "\n" +
                               "Шлях: " + dir.FullName + "\n" +
                               "Створено: " + dir.CreationTime + "\n" +
                               "Змінено: " + dir.LastWriteTime + "\n" +
                               "Власник: " + owner;
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }

        private void ShowFileInfo(string path)
        {
            try
            {
                FileInfo fileInf = new FileInfo(path);
                FileSecurity security = fileInf.GetAccessControl();
                string owner = security.GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();

                lblInfo.Text = "Ім'я: " + fileInf.Name + "\n" +
                               "Розширення: " + fileInf.Extension + "\n" +
                               "Розмір: " + fileInf.Length + " bytes\n" +
                               "Створено: " + fileInf.CreationTime + "\n" +
                               "Власник: " + owner;
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }

        private void ShowTextFile(string path)
        {
            rtbText.Clear();
            try
            {
                string ext = Path.GetExtension(path).ToLower().Trim();

                if (ext == ".txt" || ext == ".log" || ext == ".ini" || ext == ".cs" || ext == ".json" || ext == ".xml")
                {
                    rtbText.Text = File.ReadAllText(path);
                }
                else if (ext == ".docx" || ext == ".doc" || ext == ".pdf")
                {
                    rtbText.Text = "Документ Word або PDF є бінарним файлом. Попередній перегляд підтримується лише для текстових форматів (*.txt, *.cs тощо).";
                }
                else
                {
                    rtbText.Text = "Попередній перегляд тексту недоступний для розширення: " + ext;
                }
            }
            catch (Exception ex)
            {
                rtbText.Text = "Не вдалося прочитати файл:\n" + ex.Message;
            }
        }

        private void ShowImage(string path)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            try
            {
                string ext = Path.GetExtension(path).ToLower();
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    using (Image img = Image.FromFile(path))
                    {
                        pictureBox1.Image = new Bitmap(img);
                    }
                }
            }
            catch { }
        }

        private void btnFileFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPath)) return;
            LoadFiles(currentPath, txtFileFilter.Text);
        }

        private void btnFolderFilter_Click(object sender, EventArgs e)
        {
            if (tvDirectories.SelectedNode == null) return;

            TreeNode selectedNode = tvDirectories.SelectedNode;
            selectedNode.Nodes.Clear();
            LoadDirectories(selectedNode, txtFolderFilter.Text);
            selectedNode.Expand();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPath)) return;

            try
            {
                DirectoryInfo parentDir = Directory.GetParent(currentPath);
                if (parentDir != null)
                {
                    if (tvDirectories.SelectedNode != null && tvDirectories.SelectedNode.Parent != null)
                    {
                        tvDirectories.SelectedNode = tvDirectories.SelectedNode.Parent;
                    }
                    else
                    {
                        currentPath = parentDir.FullName;
                        ShowDirectoryInfo(currentPath);
                        LoadFiles(currentPath, txtFileFilter.Text);
                    }
                }
            }
            catch { }
        }
    }
}