namespace SeaBattle
{
    partial class FormMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupPlayer = new System.Windows.Forms.GroupBox();
            this.groupComputer = new System.Windows.Forms.GroupBox();
            this.dgvComputer = new System.Windows.Forms.DataGridView();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.btnPlaceShips = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.groupPlayer.SuspendLayout();
            this.groupComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(621, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(327, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Гра \"МОРСЬКИЙ БІЙ\"";
            // 
            // groupPlayer
            // 
            this.groupPlayer.Controls.Add(this.dgvPlayer);
            this.groupPlayer.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupPlayer.Location = new System.Drawing.Point(30, 203);
            this.groupPlayer.Name = "groupPlayer";
            this.groupPlayer.Size = new System.Drawing.Size(580, 503);
            this.groupPlayer.TabIndex = 1;
            this.groupPlayer.TabStop = false;
            this.groupPlayer.Text = "Поле гравця";
            // 
            // groupComputer
            // 
            this.groupComputer.Controls.Add(this.dgvComputer);
            this.groupComputer.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupComputer.Location = new System.Drawing.Point(946, 203);
            this.groupComputer.Name = "groupComputer";
            this.groupComputer.Size = new System.Drawing.Size(601, 503);
            this.groupComputer.TabIndex = 2;
            this.groupComputer.TabStop = false;
            this.groupComputer.Text = "Поле комп\'ютера";
            // 
            // dgvComputer
            // 
            this.dgvComputer.AllowUserToAddRows = false;
            this.dgvComputer.AllowUserToDeleteRows = false;
            this.dgvComputer.AllowUserToResizeColumns = false;
            this.dgvComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputer.Location = new System.Drawing.Point(23, 21);
            this.dgvComputer.MultiSelect = false;
            this.dgvComputer.Name = "dgvComputer";
            this.dgvComputer.ReadOnly = true;
            this.dgvComputer.RowHeadersWidth = 51;
            this.dgvComputer.RowTemplate.Height = 24;
            this.dgvComputer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvComputer.Size = new System.Drawing.Size(538, 457);
            this.dgvComputer.TabIndex = 0;
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.AllowUserToAddRows = false;
            this.dgvPlayer.AllowUserToDeleteRows = false;
            this.dgvPlayer.AllowUserToResizeColumns = false;
            this.dgvPlayer.AllowUserToResizeRows = false;
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Location = new System.Drawing.Point(15, 21);
            this.dgvPlayer.MultiSelect = false;
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.ReadOnly = true;
            this.dgvPlayer.RowHeadersWidth = 51;
            this.dgvPlayer.RowTemplate.Height = 24;
            this.dgvPlayer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPlayer.Size = new System.Drawing.Size(537, 457);
            this.dgvPlayer.TabIndex = 0;
            this.dgvPlayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayer_CellContentClick);
            // 
            // btnPlaceShips
            // 
            this.btnPlaceShips.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceShips.Location = new System.Drawing.Point(30, 31);
            this.btnPlaceShips.Name = "btnPlaceShips";
            this.btnPlaceShips.Size = new System.Drawing.Size(257, 40);
            this.btnPlaceShips.TabIndex = 3;
            this.btnPlaceShips.Text = "Розставити кораблі";
            this.btnPlaceShips.UseVisualStyleBackColor = true;
            this.btnPlaceShips.Click += new System.EventHandler(this.btnPlaceShips_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.Location = new System.Drawing.Point(30, 77);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(257, 40);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Почати гру";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewGame.Location = new System.Drawing.Point(30, 123);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(257, 40);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "Нова гра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(636, 203);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(257, 503);
            this.rtbInfo.TabIndex = 6;
            this.rtbInfo.Text = "";
            // 
            // lblStatistics
            // 
            this.lblStatistics.BackColor = System.Drawing.Color.AliceBlue;
            this.lblStatistics.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatistics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatistics.Location = new System.Drawing.Point(636, 97);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(257, 94);
            this.lblStatistics.TabIndex = 7;
            this.lblStatistics.Text = "Статистика";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1559, 739);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.groupComputer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnPlaceShips);
            this.Controls.Add(this.groupPlayer);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МОРСЬКИЙ БІЙ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupPlayer.ResumeLayout(false);
            this.groupComputer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupPlayer;
        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.GroupBox groupComputer;
        private System.Windows.Forms.DataGridView dgvComputer;
        private System.Windows.Forms.Button btnPlaceShips;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label lblStatistics;
    }
}

