namespace Lab_18_v24
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1D = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArray1D = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnCalculate1D = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbResult1D = new System.Windows.Forms.RichTextBox();
            this.groupBox2D = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.btnShowFullMatrix = new System.Windows.Forms.Button();
            this.btnShowCol3Element = new System.Windows.Forms.Button();
            this.txtRowCol3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowAnyElement = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRowAny = new System.Windows.Forms.TextBox();
            this.txtColAny = new System.Windows.Forms.TextBox();
            this.rtbResult2D = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1D.SuspendLayout();
            this.groupBox2D.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(457, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Масиви в С#";
            // 
            // groupBox1D
            // 
            this.groupBox1D.Controls.Add(this.rtbResult1D);
            this.groupBox1D.Controls.Add(this.label5);
            this.groupBox1D.Controls.Add(this.btnCalculate1D);
            this.groupBox1D.Controls.Add(this.txtC);
            this.groupBox1D.Controls.Add(this.label4);
            this.groupBox1D.Controls.Add(this.txtArray1D);
            this.groupBox1D.Controls.Add(this.label3);
            this.groupBox1D.Controls.Add(this.txtN);
            this.groupBox1D.Controls.Add(this.label2);
            this.groupBox1D.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1D.Location = new System.Drawing.Point(44, 71);
            this.groupBox1D.Name = "groupBox1D";
            this.groupBox1D.Size = new System.Drawing.Size(415, 658);
            this.groupBox1D.TabIndex = 1;
            this.groupBox1D.TabStop = false;
            this.groupBox1D.Text = "Завдання 1. Одновимірний масив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кількість елементів ( n ):";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(215, 64);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(124, 30);
            this.txtN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Елементи масиву\r\n(через кому або пробіл):";
            // 
            // txtArray1D
            // 
            this.txtArray1D.Location = new System.Drawing.Point(215, 113);
            this.txtArray1D.Name = "txtArray1D";
            this.txtArray1D.Size = new System.Drawing.Size(124, 30);
            this.txtArray1D.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Число C:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(215, 156);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(124, 30);
            this.txtC.TabIndex = 5;
            // 
            // btnCalculate1D
            // 
            this.btnCalculate1D.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate1D.Location = new System.Drawing.Point(31, 241);
            this.btnCalculate1D.Name = "btnCalculate1D";
            this.btnCalculate1D.Size = new System.Drawing.Size(323, 37);
            this.btnCalculate1D.TabIndex = 6;
            this.btnCalculate1D.Text = "Обчислити та перетворити масив";
            this.btnCalculate1D.UseVisualStyleBackColor = true;
            this.btnCalculate1D.Click += new System.EventHandler(this.btnCalculate1D_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(123, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Результат завдання 1:";
            // 
            // rtbResult1D
            // 
            this.rtbResult1D.Location = new System.Drawing.Point(31, 373);
            this.rtbResult1D.Name = "rtbResult1D";
            this.rtbResult1D.Size = new System.Drawing.Size(323, 265);
            this.rtbResult1D.TabIndex = 8;
            this.rtbResult1D.Text = "";
            // 
            // groupBox2D
            // 
            this.groupBox2D.Controls.Add(this.label10);
            this.groupBox2D.Controls.Add(this.rtbResult2D);
            this.groupBox2D.Controls.Add(this.txtColAny);
            this.groupBox2D.Controls.Add(this.txtRowAny);
            this.groupBox2D.Controls.Add(this.label9);
            this.groupBox2D.Controls.Add(this.label8);
            this.groupBox2D.Controls.Add(this.btnShowAnyElement);
            this.groupBox2D.Controls.Add(this.label7);
            this.groupBox2D.Controls.Add(this.txtRowCol3);
            this.groupBox2D.Controls.Add(this.btnShowCol3Element);
            this.groupBox2D.Controls.Add(this.btnShowFullMatrix);
            this.groupBox2D.Controls.Add(this.txtMatrix);
            this.groupBox2D.Controls.Add(this.label6);
            this.groupBox2D.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2D.Location = new System.Drawing.Point(606, 71);
            this.groupBox2D.Name = "groupBox2D";
            this.groupBox2D.Size = new System.Drawing.Size(490, 658);
            this.groupBox2D.TabIndex = 2;
            this.groupBox2D.TabStop = false;
            this.groupBox2D.Text = "Завдання 2. Двовимірний масив";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(95, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Введіть матрицю (кожен рядок з нового рядка):";
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(99, 74);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix.Size = new System.Drawing.Size(339, 102);
            this.txtMatrix.TabIndex = 1;
            // 
            // btnShowFullMatrix
            // 
            this.btnShowFullMatrix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowFullMatrix.Location = new System.Drawing.Point(170, 182);
            this.btnShowFullMatrix.Name = "btnShowFullMatrix";
            this.btnShowFullMatrix.Size = new System.Drawing.Size(190, 31);
            this.btnShowFullMatrix.TabIndex = 2;
            this.btnShowFullMatrix.Text = "Вивести весь масив";
            this.btnShowFullMatrix.UseVisualStyleBackColor = true;
            this.btnShowFullMatrix.Click += new System.EventHandler(this.btnShowFullMatrix_Click);
            // 
            // btnShowCol3Element
            // 
            this.btnShowCol3Element.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowCol3Element.Location = new System.Drawing.Point(285, 230);
            this.btnShowCol3Element.Name = "btnShowCol3Element";
            this.btnShowCol3Element.Size = new System.Drawing.Size(190, 31);
            this.btnShowCol3Element.TabIndex = 3;
            this.btnShowCol3Element.Text = "Елемент 3-го стовпця";
            this.btnShowCol3Element.UseVisualStyleBackColor = true;
            this.btnShowCol3Element.Click += new System.EventHandler(this.btnShowCol3Element_Click);
            // 
            // txtRowCol3
            // 
            this.txtRowCol3.Location = new System.Drawing.Point(150, 231);
            this.txtRowCol3.Name = "txtRowCol3";
            this.txtRowCol3.Size = new System.Drawing.Size(83, 30);
            this.txtRowCol3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hомер рядка";
            // 
            // btnShowAnyElement
            // 
            this.btnShowAnyElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAnyElement.Location = new System.Drawing.Point(285, 286);
            this.btnShowAnyElement.Name = "btnShowAnyElement";
            this.btnShowAnyElement.Size = new System.Drawing.Size(190, 70);
            this.btnShowAnyElement.TabIndex = 6;
            this.btnShowAnyElement.Text = "Будь-який елемент";
            this.btnShowAnyElement.UseVisualStyleBackColor = true;
            this.btnShowAnyElement.Click += new System.EventHandler(this.btnShowAnyElement_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(65, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Рядок :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(39, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Стовпець :";
            // 
            // txtRowAny
            // 
            this.txtRowAny.Location = new System.Drawing.Point(150, 286);
            this.txtRowAny.Name = "txtRowAny";
            this.txtRowAny.Size = new System.Drawing.Size(83, 30);
            this.txtRowAny.TabIndex = 9;
            // 
            // txtColAny
            // 
            this.txtColAny.Location = new System.Drawing.Point(150, 326);
            this.txtColAny.Name = "txtColAny";
            this.txtColAny.Size = new System.Drawing.Size(83, 30);
            this.txtColAny.TabIndex = 10;
            // 
            // rtbResult2D
            // 
            this.rtbResult2D.Location = new System.Drawing.Point(43, 407);
            this.rtbResult2D.Name = "rtbResult2D";
            this.rtbResult2D.Size = new System.Drawing.Size(432, 231);
            this.rtbResult2D.TabIndex = 11;
            this.rtbResult2D.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(182, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Результат завдання 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 741);
            this.Controls.Add(this.groupBox2D);
            this.Controls.Add(this.groupBox1D);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №18 - Вараніт 24(4)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1D.ResumeLayout(false);
            this.groupBox1D.PerformLayout();
            this.groupBox2D.ResumeLayout(false);
            this.groupBox2D.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1D;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResult1D;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate1D;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArray1D;
        private System.Windows.Forms.GroupBox groupBox2D;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowAnyElement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRowCol3;
        private System.Windows.Forms.Button btnShowCol3Element;
        private System.Windows.Forms.Button btnShowFullMatrix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbResult2D;
        private System.Windows.Forms.TextBox txtColAny;
        private System.Windows.Forms.TextBox txtRowAny;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

