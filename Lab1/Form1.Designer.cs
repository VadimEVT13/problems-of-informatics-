namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.JaroText1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JaroText2 = new System.Windows.Forms.TextBox();
            this.Jaro_button = new System.Windows.Forms.Button();
            this.JaroRez = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.JaroVinclerRez = new System.Windows.Forms.TextBox();
            this.JaroVincler_button = new System.Windows.Forms.Button();
            this.JaroVinclerText1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBJaroVinclerText2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LevensteinRez = new System.Windows.Forms.TextBox();
            this.Levenstein_button = new System.Windows.Forms.Button();
            this.LevensteinText1 = new System.Windows.Forms.TextBox();
            this.LevensteinText2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.JaroText1.Location = new System.Drawing.Point(9, 34);
            this.JaroText1.Name = "textBox1";
            this.JaroText1.Size = new System.Drawing.Size(249, 26);
            this.JaroText1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Строка 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Строка 2";
            // 
            // textBox2
            // 
            this.JaroText2.Location = new System.Drawing.Point(9, 86);
            this.JaroText2.Name = "textBox2";
            this.JaroText2.Size = new System.Drawing.Size(249, 26);
            this.JaroText2.TabIndex = 3;
            // 
            // Jaro_button
            // 
            this.Jaro_button.Location = new System.Drawing.Point(264, 34);
            this.Jaro_button.Name = "Jaro_button";
            this.Jaro_button.Size = new System.Drawing.Size(148, 78);
            this.Jaro_button.TabIndex = 4;
            this.Jaro_button.Text = "Вычислить";
            this.Jaro_button.UseVisualStyleBackColor = true;
            this.Jaro_button.Click += new System.EventHandler(this.Jaro_button_Click);
            // 
            // JaroRez
            // 
            this.JaroRez.Location = new System.Drawing.Point(418, 34);
            this.JaroRez.Multiline = true;
            this.JaroRez.Name = "JaroRez";
            this.JaroRez.ReadOnly = true;
            this.JaroRez.Size = new System.Drawing.Size(181, 78);
            this.JaroRez.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 173);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Jaro_button);
            this.tabPage1.Controls.Add(this.JaroRez);
            this.tabPage1.Controls.Add(this.JaroText1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.JaroText2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jaro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.JaroVinclerRez);
            this.tabPage2.Controls.Add(this.JaroVincler_button);
            this.tabPage2.Controls.Add(this.JaroVinclerText1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBJaroVinclerText2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "JaroVincler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.JaroVinclerRez.Location = new System.Drawing.Point(418, 36);
            this.JaroVinclerRez.Multiline = true;
            this.JaroVinclerRez.Name = "textBox6";
            this.JaroVinclerRez.ReadOnly = true;
            this.JaroVinclerRez.Size = new System.Drawing.Size(181, 78);
            this.JaroVinclerRez.TabIndex = 9;
            // 
            // JaroVincler_button
            // 
            this.JaroVincler_button.Location = new System.Drawing.Point(265, 36);
            this.JaroVincler_button.Name = "JaroVincler_button";
            this.JaroVincler_button.Size = new System.Drawing.Size(147, 78);
            this.JaroVincler_button.TabIndex = 8;
            this.JaroVincler_button.Text = "Выполнить";
            this.JaroVincler_button.UseVisualStyleBackColor = true;
            this.JaroVincler_button.Click += new System.EventHandler(this.JaroVincler_button_Click);
            // 
            // textBox4
            // 
            this.JaroVinclerText1.Location = new System.Drawing.Point(10, 36);
            this.JaroVinclerText1.Name = "textBox4";
            this.JaroVinclerText1.Size = new System.Drawing.Size(249, 26);
            this.JaroVinclerText1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Строка 1";
            // 
            // textBox5
            // 
            this.textBJaroVinclerText2.Location = new System.Drawing.Point(10, 88);
            this.textBJaroVinclerText2.Name = "textBox5";
            this.textBJaroVinclerText2.Size = new System.Drawing.Size(249, 26);
            this.textBJaroVinclerText2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Строка 2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LevensteinRez);
            this.tabPage3.Controls.Add(this.Levenstein_button);
            this.tabPage3.Controls.Add(this.LevensteinText1);
            this.tabPage3.Controls.Add(this.LevensteinText2);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(617, 140);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Levenstein";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.LevensteinRez.Location = new System.Drawing.Point(418, 36);
            this.LevensteinRez.Multiline = true;
            this.LevensteinRez.Name = "textBox9";
            this.LevensteinRez.ReadOnly = true;
            this.LevensteinRez.Size = new System.Drawing.Size(181, 78);
            this.LevensteinRez.TabIndex = 12;
            // 
            // Levenstein_button
            // 
            this.Levenstein_button.Location = new System.Drawing.Point(265, 36);
            this.Levenstein_button.Name = "Levenstein_button";
            this.Levenstein_button.Size = new System.Drawing.Size(147, 78);
            this.Levenstein_button.TabIndex = 11;
            this.Levenstein_button.Text = "Выполнить";
            this.Levenstein_button.UseVisualStyleBackColor = true;
            this.Levenstein_button.Click += new System.EventHandler(this.Levenstein_button_Click);
            // 
            // textBox7
            // 
            this.LevensteinText1.Location = new System.Drawing.Point(10, 36);
            this.LevensteinText1.Name = "textBox7";
            this.LevensteinText1.Size = new System.Drawing.Size(249, 26);
            this.LevensteinText1.TabIndex = 8;
            // 
            // textBox8
            // 
            this.LevensteinText2.Location = new System.Drawing.Point(10, 88);
            this.LevensteinText2.Name = "textBox8";
            this.LevensteinText2.Size = new System.Drawing.Size(249, 26);
            this.LevensteinText2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Строка 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Строка 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 202);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Методы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox JaroText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox JaroText2;
        private System.Windows.Forms.Button Jaro_button;
        private System.Windows.Forms.TextBox JaroRez;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox JaroVinclerRez;
        private System.Windows.Forms.Button JaroVincler_button;
        private System.Windows.Forms.TextBox JaroVinclerText1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBJaroVinclerText2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LevensteinRez;
        private System.Windows.Forms.Button Levenstein_button;
        private System.Windows.Forms.TextBox LevensteinText1;
        private System.Windows.Forms.TextBox LevensteinText2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

