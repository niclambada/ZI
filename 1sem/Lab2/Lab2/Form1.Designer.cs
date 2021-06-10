namespace Lab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonSF = new System.Windows.Forms.Button();
            this.buttonSA = new System.Windows.Forms.Button();
            this.checkBoxF = new System.Windows.Forms.CheckBox();
            this.checkBoA = new System.Windows.Forms.CheckBox();
            this.textBoxEn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxP01 = new System.Windows.Forms.TextBox();
            this.textBoxP05 = new System.Windows.Forms.TextBox();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSF
            // 
            this.buttonSF.Location = new System.Drawing.Point(12, 12);
            this.buttonSF.Name = "buttonSF";
            this.buttonSF.Size = new System.Drawing.Size(117, 31);
            this.buttonSF.TabIndex = 0;
            this.buttonSF.Text = "Select File";
            this.buttonSF.UseVisualStyleBackColor = true;
            this.buttonSF.Click += new System.EventHandler(this.buttonSF_Click);
            // 
            // buttonSA
            // 
            this.buttonSA.Location = new System.Drawing.Point(136, 12);
            this.buttonSA.Name = "buttonSA";
            this.buttonSA.Size = new System.Drawing.Size(132, 31);
            this.buttonSA.TabIndex = 1;
            this.buttonSA.Text = "Select Alfabet";
            this.buttonSA.UseVisualStyleBackColor = true;
            this.buttonSA.Click += new System.EventHandler(this.buttonAF_Click);
            // 
            // checkBoxF
            // 
            this.checkBoxF.AutoSize = true;
            this.checkBoxF.Enabled = false;
            this.checkBoxF.Location = new System.Drawing.Point(2, 498);
            this.checkBoxF.Name = "checkBoxF";
            this.checkBoxF.Size = new System.Drawing.Size(52, 21);
            this.checkBoxF.TabIndex = 2;
            this.checkBoxF.Text = "File";
            this.checkBoxF.UseVisualStyleBackColor = true;
            // 
            // checkBoA
            // 
            this.checkBoA.AutoSize = true;
            this.checkBoA.Enabled = false;
            this.checkBoA.Location = new System.Drawing.Point(1, 526);
            this.checkBoA.Name = "checkBoA";
            this.checkBoA.Size = new System.Drawing.Size(74, 21);
            this.checkBoA.TabIndex = 3;
            this.checkBoA.Text = "Alfabet";
            this.checkBoA.UseVisualStyleBackColor = true;
            // 
            // textBoxEn
            // 
            this.textBoxEn.Location = new System.Drawing.Point(18, 82);
            this.textBoxEn.Name = "textBoxEn";
            this.textBoxEn.ReadOnly = true;
            this.textBoxEn.Size = new System.Drawing.Size(158, 22);
            this.textBoxEn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entropy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Entropy Bin";
            // 
            // textBoxEB
            // 
            this.textBoxEB.Location = new System.Drawing.Point(190, 81);
            this.textBoxEB.Name = "textBoxEB";
            this.textBoxEB.ReadOnly = true;
            this.textBoxEB.Size = new System.Drawing.Size(158, 22);
            this.textBoxEB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "FIO";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(344, 19);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(252, 22);
            this.textBoxFIO.TabIndex = 9;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // textBoxT
            // 
            this.textBoxT.Enabled = false;
            this.textBoxT.Location = new System.Drawing.Point(718, 16);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.ReadOnly = true;
            this.textBoxT.Size = new System.Drawing.Size(100, 22);
            this.textBoxT.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ASCII";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(824, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "P = 0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(824, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "P = 0.5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(824, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "P = 1.0";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(718, 48);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 16;
            // 
            // textBoxP01
            // 
            this.textBoxP01.Location = new System.Drawing.Point(918, 12);
            this.textBoxP01.Name = "textBoxP01";
            this.textBoxP01.ReadOnly = true;
            this.textBoxP01.Size = new System.Drawing.Size(100, 22);
            this.textBoxP01.TabIndex = 17;
            // 
            // textBoxP05
            // 
            this.textBoxP05.Location = new System.Drawing.Point(918, 40);
            this.textBoxP05.Name = "textBoxP05";
            this.textBoxP05.ReadOnly = true;
            this.textBoxP05.Size = new System.Drawing.Size(100, 22);
            this.textBoxP05.TabIndex = 18;
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(918, 73);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.ReadOnly = true;
            this.textBoxP1.Size = new System.Drawing.Size(100, 22);
            this.textBoxP1.TabIndex = 19;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(19, 137);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(1005, 309);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 458);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.textBoxP05);
            this.Controls.Add(this.textBoxP01);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEn);
            this.Controls.Add(this.checkBoA);
            this.Controls.Add(this.checkBoxF);
            this.Controls.Add(this.buttonSA);
            this.Controls.Add(this.buttonSF);
            this.Name = "Form1";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSF;
        private System.Windows.Forms.Button buttonSA;
        private System.Windows.Forms.CheckBox checkBoxF;
        private System.Windows.Forms.CheckBox checkBoA;
        private System.Windows.Forms.TextBox textBoxEn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxP01;
        private System.Windows.Forms.TextBox textBoxP05;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

