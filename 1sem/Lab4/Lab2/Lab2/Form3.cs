using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Lab2
{

    public partial class Form3 : Form
    {
        private int k;
        private int r;

        private Matrix<double> H;
        private Matrix<double> Xn;
        private Matrix<double> Xr;
        private Matrix<double> Xk;
        private Matrix<double> Yn;

        Random rnd = new Random();

        bool IsPowerOfTwo(ulong x)
        {
            return (x & (x - 1)) == 0;
        }
        public static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxM.Text.Length > 0)
            {
                var bytes = Encoding.UTF8.GetBytes(textBoxM.Text);

                k = bytes.Length * 8;
                r = (int)Math.Ceiling(Math.Log(k, 2) + 1);

                double[,] g = new double[r, k];
                double[,] i = new double[r, r];

                for(int ii = 0; ii < r; ii++)
                {
                    i[ii, ii] = 1;
                }

                int f = 1;
                for(int j = 0; j < k; j++)
                {
                    while (IsPowerOfTwo((ulong)f)) f++;
                    int d = f;

                    int ff = 0;
                    while (d > 0)
                    {
                        g[ff, j] = d % 2;
                        d /= 2;
                        ff++;
                    }
                    f++;
                }

                H = DenseMatrix.OfArray(g).Append(DenseMatrix.OfArray(i));
                richTextBoxH.Text = H.ToString();

                var bar = new BitArray(bytes);
                var xr = new double[r];
                for(int ii = 0; ii < r; ii++)
                {
                    for(int j = 0; j < k; j++)
                    {
                        xr[ii] += (bar[j] ? 1 : 0) * H[ii, j];
                    }
                    xr[ii] %= 2;
                }

                Xr = Matrix<double>.Build.Dense(1, r, (ii, jj) => (double)xr[jj]);
                Xk = Matrix<double>.Build.Dense(1, bar.Length, (ii, jj) => bar[jj] ? 1 : 0);
                Xn = DenseMatrix.OfMatrix(Xk).Append(Xr);
                textBoxXr.Text = Xr.ToString().DelLine();
                textBoxXn.Text = Xn.ToString().DelLine();
                textBoxXk.Text = Xk.ToString().DelLine();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            Yn = DenseMatrix.OfMatrix(Xn);
            if (radioButton1.Checked)
            {
                textBoxEn.Text = String.Empty;
            }
            if (radioButton2.Checked)
            {
                int pos = rnd.Next(0, Yn.ColumnCount - 1);
                Yn[0, pos] = (Yn[0, pos] + 1) % 2;
                textBoxEP.Text = pos.ToString();
            }
            if (radioButton3.Checked)
            {
                int pos = rnd.Next(0, Yn.ColumnCount - 1);
                Yn[0, pos] = (Yn[0, pos] + 1) % 2;
                int pos2 = rnd.Next(0, Yn.ColumnCount - 1);
                while (pos == pos2) pos2 = rnd.Next(0, Yn.ColumnCount - 1);
                Yn[0, pos2] = (Yn[0, pos2] + 1) % 2;
                textBoxEP.Text = pos.ToString() + ", " + pos2.ToString();
            }

            textBoxYn.Text = Yn.ToString().DelLine();

            var S = H * Yn.Transpose();
            bool flag = false;
            for (int i = 0; i < S.RowCount; i++)
            {
                S[i, 0] %= 2;
                flag = flag || S[i, 0] != 0;
            }

            textBoxS.Text = S.Transpose().ToString().DelLine();
            var En = Matrix<double>.Build.Dense(1, H.ColumnCount, 0);

            if (flag)
            {
                for(int i = 0; i < H.ColumnCount; i++)
                {
                    if(H.Column(i).Equals(S.Column(0)))
                    {
                        En[0, i] = 1;
                    }
                }
            }

            var Y_n = DenseMatrix.OfMatrix(Yn) + En;
            for (int i = 0; i < Y_n.ColumnCount; i++)
            {
                Y_n[0, i] %= 2;
            }


            textBoxEn.Text = En.ToString().DelLine();
            textBoxY_n.Text = Y_n.ToString().DelLine();

            var bar = new BitArray(k);
            for(int i = 0; i < k; i++)
            {
                bar[i] = Y_n[0, i] == 1;
            }

            textBoxAns.Text = Encoding.UTF8.GetString(BitArrayToByteArray(bar));
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxYn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxXn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxXr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxXk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxH_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxY_n_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
