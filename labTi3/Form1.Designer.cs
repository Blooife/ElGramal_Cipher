namespace labTi3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.ButCalcG = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxG = new System.Windows.Forms.ComboBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxXC = new System.Windows.Forms.TextBox();
            this.textBoxPC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lNum = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tabControl1.Location = new System.Drawing.Point(54, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lNum);
            this.tabPage1.Controls.Add(this.textBoxX);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxY);
            this.tabPage1.Controls.Add(this.ButCalcG);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.comboBoxG);
            this.tabPage1.Controls.Add(this.textBoxK);
            this.tabPage1.Controls.Add(this.textBoxP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(140, 184);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(132, 20);
            this.textBoxX.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите x < p-1:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(300, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "y:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(330, 184);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 12;
            // 
            // ButCalcG
            // 
            this.ButCalcG.Location = new System.Drawing.Point(291, 50);
            this.ButCalcG.Name = "ButCalcG";
            this.ButCalcG.Size = new System.Drawing.Size(78, 23);
            this.ButCalcG.TabIndex = 11;
            this.ButCalcG.Text = "Посчитать g";
            this.ButCalcG.UseVisualStyleBackColor = true;
            this.ButCalcG.Click += new System.EventHandler(this.ButCalcG_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Сохранить в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Открыть файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите k взаимнопростое с p-1:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите первообразную g";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите простое p:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(34, 421);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(630, 96);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 278);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(630, 84);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // comboBoxG
            // 
            this.comboBoxG.FormattingEnabled = true;
            this.comboBoxG.Location = new System.Drawing.Point(140, 92);
            this.comboBoxG.Name = "comboBoxG";
            this.comboBoxG.Size = new System.Drawing.Size(132, 21);
            this.comboBoxG.TabIndex = 2;
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(140, 136);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(132, 20);
            this.textBoxK.TabIndex = 1;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(140, 52);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(132, 20);
            this.textBoxP.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox4);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.richTextBox3);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBoxXC);
            this.tabPage2.Controls.Add(this.textBoxPC);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифрование";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(37, 420);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(630, 96);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Дешифровать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(37, 282);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(630, 84);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(551, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Сохранить в файл";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(551, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Открыть файл";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxXC
            // 
            this.textBoxXC.Location = new System.Drawing.Point(164, 124);
            this.textBoxXC.Name = "textBoxXC";
            this.textBoxXC.Size = new System.Drawing.Size(148, 20);
            this.textBoxXC.TabIndex = 3;
            // 
            // textBoxPC
            // 
            this.textBoxPC.Location = new System.Drawing.Point(164, 79);
            this.textBoxPC.Name = "textBoxPC";
            this.textBoxPC.Size = new System.Drawing.Size(148, 20);
            this.textBoxPC.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(37, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Введите x < p-1:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(37, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Введите простое p:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lNum
            // 
            this.lNum.Location = new System.Drawing.Point(292, 99);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(100, 23);
            this.lNum.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lNum;

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxPC;
        private System.Windows.Forms.TextBox textBoxXC;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.TextBox textBoxX;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button ButCalcG;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.ComboBox comboBoxG;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBoxK;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxP;

        private System.Windows.Forms.MenuStrip miniToolStrip;

        #endregion
    }
}