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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lab3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEnCh = new System.Windows.Forms.TextBox();
            this.textBoxRe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSF
            // 
            this.buttonSF.Location = new System.Drawing.Point(13, 37);
            this.buttonSF.Name = "buttonSF";
            this.buttonSF.Size = new System.Drawing.Size(117, 31);
            this.buttonSF.TabIndex = 0;
            this.buttonSF.Text = "Select File";
            this.buttonSF.UseVisualStyleBackColor = true;
            this.buttonSF.Click += new System.EventHandler(this.buttonSF_Click);
            // 
            // buttonSA
            // 
            this.buttonSA.Location = new System.Drawing.Point(137, 37);
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
            this.checkBoxF.Location = new System.Drawing.Point(14, 75);
            this.checkBoxF.Name = "checkBoxF";
            this.checkBoxF.Size = new System.Drawing.Size(52, 21);
            this.checkBoxF.TabIndex = 2;
            this.checkBoxF.Text = "File";
            this.checkBoxF.UseVisualStyleBackColor = true;
            this.checkBoxF.CheckedChanged += new System.EventHandler(this.checkBoxF_CheckedChanged);
            // 
            // checkBoA
            // 
            this.checkBoA.AutoSize = true;
            this.checkBoA.Enabled = false;
            this.checkBoA.Location = new System.Drawing.Point(13, 103);
            this.checkBoA.Name = "checkBoA";
            this.checkBoA.Size = new System.Drawing.Size(74, 21);
            this.checkBoA.TabIndex = 3;
            this.checkBoA.Text = "Alfabet";
            this.checkBoA.UseVisualStyleBackColor = true;
            this.checkBoA.CheckedChanged += new System.EventHandler(this.checkBoA_CheckedChanged);
            // 
            // textBoxEn
            // 
            this.textBoxEn.Location = new System.Drawing.Point(111, 91);
            this.textBoxEn.Name = "textBoxEn";
            this.textBoxEn.ReadOnly = true;
            this.textBoxEn.Size = new System.Drawing.Size(158, 22);
            this.textBoxEn.TabIndex = 4;
            this.textBoxEn.TextChanged += new System.EventHandler(this.textBoxEn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entropy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Entropy Bin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxEB
            // 
            this.textBoxEB.Location = new System.Drawing.Point(111, 139);
            this.textBoxEB.Name = "textBoxEB";
            this.textBoxEB.ReadOnly = true;
            this.textBoxEB.Size = new System.Drawing.Size(158, 22);
            this.textBoxEB.TabIndex = 7;
            this.textBoxEB.TextChanged += new System.EventHandler(this.textBoxEB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "FIO";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(345, 44);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(252, 22);
            this.textBoxFIO.TabIndex = 9;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // textBoxT
            // 
            this.textBoxT.Enabled = false;
            this.textBoxT.Location = new System.Drawing.Point(402, 76);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.ReadOnly = true;
            this.textBoxT.Size = new System.Drawing.Size(100, 22);
            this.textBoxT.TabIndex = 10;
            this.textBoxT.TextChanged += new System.EventHandler(this.textBoxT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Text";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ASCII";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "P = 0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "P = 0.5";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "P = 1.0";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(402, 108);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 16;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxP01
            // 
            this.textBoxP01.Location = new System.Drawing.Point(402, 139);
            this.textBoxP01.Name = "textBoxP01";
            this.textBoxP01.ReadOnly = true;
            this.textBoxP01.Size = new System.Drawing.Size(100, 22);
            this.textBoxP01.TabIndex = 17;
            this.textBoxP01.TextChanged += new System.EventHandler(this.textBoxP01_TextChanged);
            // 
            // textBoxP05
            // 
            this.textBoxP05.Location = new System.Drawing.Point(402, 167);
            this.textBoxP05.Name = "textBoxP05";
            this.textBoxP05.ReadOnly = true;
            this.textBoxP05.Size = new System.Drawing.Size(100, 22);
            this.textBoxP05.TabIndex = 18;
            this.textBoxP05.TextChanged += new System.EventHandler(this.textBoxP05_TextChanged);
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(402, 200);
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 260);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(583, 234);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lab3ToolStripMenuItem,
            this.chartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lab3ToolStripMenuItem
            // 
            this.lab3ToolStripMenuItem.Name = "lab3ToolStripMenuItem";
            this.lab3ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.lab3ToolStripMenuItem.Text = "Lab3";
            this.lab3ToolStripMenuItem.Click += new System.EventHandler(this.lab3ToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Entropy Ch";
            // 
            // textBoxEnCh
            // 
            this.textBoxEnCh.Location = new System.Drawing.Point(111, 187);
            this.textBoxEnCh.Name = "textBoxEnCh";
            this.textBoxEnCh.ReadOnly = true;
            this.textBoxEnCh.Size = new System.Drawing.Size(158, 22);
            this.textBoxEnCh.TabIndex = 23;
            // 
            // textBoxRe
            // 
            this.textBoxRe.Location = new System.Drawing.Point(111, 232);
            this.textBoxRe.Name = "textBoxRe";
            this.textBoxRe.ReadOnly = true;
            this.textBoxRe.Size = new System.Drawing.Size(158, 22);
            this.textBoxRe.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Redundancy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "N";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(14, 160);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ReadOnly = true;
            this.textBoxN.Size = new System.Drawing.Size(73, 22);
            this.textBoxN.TabIndex = 27;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(16, 260);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(581, 234);
            this.chart2.TabIndex = 28;
            this.chart2.Text = "chart";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem,
            this.textToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binToolStripMenuItem.Text = "Bin";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.binToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 506);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRe);
            this.Controls.Add(this.textBoxEnCh);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lab3ToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEnCh;
        private System.Windows.Forms.TextBox textBoxRe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
    }
}

