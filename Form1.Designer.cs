namespace Lab16_v24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEval = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonGCD = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonDer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(40, 155);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 22);
            this.textBoxP.TabIndex = 0;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(201, 155);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 22);
            this.textBoxQ.TabIndex = 1;
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(373, 155);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(100, 22);
            this.textBoxX0.TabIndex = 2;
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(551, 155);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 22);
            this.textBoxK.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лабораторна робота №16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(689, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "P(x)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Q(x)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "x0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "k";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(517, 273);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(80, 16);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Результат:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(32, 240);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 49);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(32, 306);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(108, 49);
            this.buttonSub.TabIndex = 12;
            this.buttonSub.Text = "Відняти";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(180, 240);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(108, 49);
            this.buttonMul.TabIndex = 13;
            this.buttonMul.Text = "Множити";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(32, 364);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(108, 49);
            this.buttonDiv.TabIndex = 14;
            this.buttonDiv.Text = "Поділити";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonEval
            // 
            this.buttonEval.Location = new System.Drawing.Point(324, 364);
            this.buttonEval.Name = "buttonEval";
            this.buttonEval.Size = new System.Drawing.Size(133, 49);
            this.buttonEval.TabIndex = 15;
            this.buttonEval.Text = "Значення в точці";
            this.buttonEval.UseVisualStyleBackColor = true;
            this.buttonEval.Click += new System.EventHandler(this.buttonEval_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.Location = new System.Drawing.Point(180, 306);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(108, 49);
            this.buttonPow.TabIndex = 16;
            this.buttonPow.Text = "Степінь";
            this.buttonPow.UseVisualStyleBackColor = true;
            this.buttonPow.Click += new System.EventHandler(this.buttonPow_Click);
            // 
            // buttonGCD
            // 
            this.buttonGCD.Location = new System.Drawing.Point(180, 364);
            this.buttonGCD.Name = "buttonGCD";
            this.buttonGCD.Size = new System.Drawing.Size(108, 49);
            this.buttonGCD.TabIndex = 17;
            this.buttonGCD.Text = "НСД";
            this.buttonGCD.UseVisualStyleBackColor = true;
            this.buttonGCD.Click += new System.EventHandler(this.buttonGCD_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(324, 306);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(108, 49);
            this.buttonCompare.TabIndex = 18;
            this.buttonCompare.Text = "Порівняти";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // buttonDer
            // 
            this.buttonDer.Location = new System.Drawing.Point(324, 240);
            this.buttonDer.Name = "buttonDer";
            this.buttonDer.Size = new System.Drawing.Size(108, 49);
            this.buttonDer.TabIndex = 21;
            this.buttonDer.Text = "Похідна";
            this.buttonDer.UseVisualStyleBackColor = true;
            this.buttonDer.Click += new System.EventHandler(this.buttonDer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Оберіть дію";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDer);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonGCD);
            this.Controls.Add(this.buttonPow);
            this.Controls.Add(this.buttonEval);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEval;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonGCD;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonDer;
        private System.Windows.Forms.Label label7;
    }
}

