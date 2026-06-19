namespace Lab27_FileSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.txtFileFilter = new System.Windows.Forms.TextBox();
            this.btnFileFilter = new System.Windows.Forms.Button();
            this.txtFolderFilter = new System.Windows.Forms.TextBox();
            this.btnFolderFilter = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tvDirectories = new System.Windows.Forms.TreeView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Каталоги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Файли:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Фільтр файлів:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Фільтр папок:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Перегляд текстового файлу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Перегляд зображення:";
            // 
            // cmbDrives
            // 
            this.cmbDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(80, 15);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(300, 28);
            this.cmbDrives.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(420, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 20;
            this.lstFiles.Location = new System.Drawing.Point(340, 160);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(300, 244);
            this.lstFiles.TabIndex = 22;
            // 
            // txtFileFilter
            // 
            this.txtFileFilter.Location = new System.Drawing.Point(168, 427);
            this.txtFileFilter.Name = "txtFileFilter";
            this.txtFileFilter.Size = new System.Drawing.Size(150, 28);
            this.txtFileFilter.TabIndex = 24;
            this.txtFileFilter.Text = "*.txt";
            // 
            // btnFileFilter
            // 
            this.btnFileFilter.Location = new System.Drawing.Point(340, 425);
            this.btnFileFilter.Name = "btnFileFilter";
            this.btnFileFilter.Size = new System.Drawing.Size(128, 30);
            this.btnFileFilter.TabIndex = 25;
            this.btnFileFilter.Text = "Застосувати";
            this.btnFileFilter.UseVisualStyleBackColor = true;
            this.btnFileFilter.Click += new System.EventHandler(this.btnFileFilter_Click);
            // 
            // txtFolderFilter
            // 
            this.txtFolderFilter.Location = new System.Drawing.Point(740, 439);
            this.txtFolderFilter.Name = "txtFolderFilter";
            this.txtFolderFilter.Size = new System.Drawing.Size(150, 28);
            this.txtFolderFilter.TabIndex = 26;
            this.txtFolderFilter.Text = "*";
            // 
            // btnFolderFilter
            // 
            this.btnFolderFilter.Location = new System.Drawing.Point(911, 437);
            this.btnFolderFilter.Name = "btnFolderFilter";
            this.btnFolderFilter.Size = new System.Drawing.Size(128, 30);
            this.btnFolderFilter.TabIndex = 27;
            this.btnFolderFilter.Text = "Застосувати";
            this.btnFolderFilter.UseVisualStyleBackColor = true;
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(20, 517);
            this.rtbText.Name = "rtbText";
            this.rtbText.ReadOnly = true;
            this.rtbText.Size = new System.Drawing.Size(550, 351);
            this.rtbText.TabIndex = 28;
            this.rtbText.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(617, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // tvDirectories
            // 
            this.tvDirectories.Location = new System.Drawing.Point(24, 160);
            this.tvDirectories.Name = "tvDirectories";
            this.tvDirectories.Size = new System.Drawing.Size(283, 244);
            this.tvDirectories.TabIndex = 30;
            this.tvDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDirectories_AfterSelect);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Location = new System.Drawing.Point(675, 148);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(330, 256);
            this.grpInfo.TabIndex = 31;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Властивості:";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(16, 42);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(283, 185);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Інформація буде відображена тут";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 899);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.tvDirectories);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnFolderFilter);
            this.Controls.Add(this.txtFolderFilter);
            this.Controls.Add(this.btnFileFilter);
            this.Controls.Add(this.txtFileFilter);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbDrives);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файловий менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.TextBox txtFileFilter;
        private System.Windows.Forms.Button btnFileFilter;
        private System.Windows.Forms.TextBox txtFolderFilter;
        private System.Windows.Forms.Button btnFolderFilter;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView tvDirectories;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblInfo;
    }
}

