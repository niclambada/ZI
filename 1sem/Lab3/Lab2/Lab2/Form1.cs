using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private string file = "";
        private string alfabet = "";
        private double entr;
        private double entrb;
        public Form1()
        {
            InitializeComponent();
            chart2.Visible = true;
            chart1.Visible = false;
        }

        private void buttonSF_Click(object sender, EventArgs e)
        {
            var form = new OpenFileDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                file = File.ReadAllText(form.FileName);

                checkBoxF.Checked = true;
            }
            else
            {
                checkBoxF.Checked = false;
            }
            CalcEntropy();
            CalcEntropyBin();
        }

        private void buttonAF_Click(object sender, EventArgs e)
        {
            var form = new OpenFileDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                alfabet = File.ReadAllText(form.FileName);

                alfabet = String.Join("", alfabet.Distinct());
                checkBoA.Checked = true;
            }
            else
            {
                checkBoA.Checked = false;
            }
            CalcEntropy();
        }

        private void CalcEntropy()
        {
            if (checkBoA.Checked && checkBoxF.Checked)
            {
                var dict = new Dictionary<char, int>();
                foreach(char c in alfabet.Concat(file.Distinct()).Distinct())
                {
                    dict.Add(c, 0);
                }
                foreach (char c in file)
                {
                    dict[c]++;
                }
                double n = file.Length;
                entr = 0d;
                int i = 0;
                foreach(var kv in dict)
                {
                    i++;
                    this.chart1.Series[0].Points.AddXY(i, kv.Value);
                    if (kv.Value != 0)
                    {
                        entr += (kv.Value / n) * Math.Log(kv.Value / n, 2);
                    }
                }
                entr *= -1;
                textBoxN.Text = dict.Count.ToString();
                textBoxEn.Text = entr.ToString();
                textBoxEnCh.Text = Math.Log(dict.Count, 2).ToString();
                textBoxRe.Text = ((1 - entr / Math.Log(dict.Count, 2)) * 100).ToString();
            }
        }

        private void CalcEntropyBin()
        {
            if (checkBoxF.Checked)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(file);
                double _1 = 0;
                foreach (var b in bytes)
                {
                    _1 += Convert.ToString(b, 2).Count(x => x == '1');
                }
                double n = bytes.Length * 8;
                this.chart2.Series[0].Points.AddXY(0, n - _1);
                this.chart2.Series[0].Points.AddXY(1, _1);
                entrb = (_1 / n) * Math.Log(_1 / n, 2) + ((n - _1) / n) * Math.Log((n - _1) / n, 2);
                entrb *= -1;
                textBoxEB.Text = entrb.ToString();
            }
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFIO.TextLength > 0 || entr != 0 || entrb != 0)
            { 
                textBoxT.Text = Convert.ToString(entr*textBoxFIO.TextLength);
                textBoxA.Text = Convert.ToString(entrb * textBoxFIO.TextLength * 8);
                double n = textBoxFIO.TextLength;
                double p = 0.1d;
                double h = 1 - (-p * Math.Log(p , 2) - (1 - p) * Math.Log((1 - p), 2));
                textBoxP01.Text = Convert.ToString(h * textBoxFIO.TextLength * 8);
                p = 0.5d;
                h = 1 - (-p * Math.Log(p, 2) - (1 - p) * Math.Log((1 - p), 2));
                textBoxP05.Text = Convert.ToString(h * textBoxFIO.TextLength * 8);
                h = 1;
                textBoxP1.Text = Convert.ToString(h * textBoxFIO.TextLength * 8);
            }
        }

        private void checkBoxF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxP01_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxP05_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lab3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lab2 = new Form2();
            lab2.Show();
        }

        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart2.Visible = true;
            chart1.Visible = false;
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = false;
        }
    }
}
