using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(GCD((int)numericUpDown1.Value, (int)numericUpDown2.Value).ToString());
                 SieveEratosthenes((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                //textBox2.Text = string.Join(", ", primeNumbers);
            }
            else if (checkBox2.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add( GCD((int)numericUpDown1.Value, GCD((int)numericUpDown2.Value, (int)numericUpDown3.Value)).ToString());
                //SieveEratosthenes((int)numericUpDown1.Value, (int)numericUpDown2.Value);
               
            }
            else
            {
                listBox1.Items.Add ("Wrong!");
            }
           
        }

        public int GCD(int a, int b)
        {
            if(a == 0)
            {
                return b;
            }
            else
            {
                while (b != 0)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
            }
            return a;
        }
        public void SieveEratosthenes(int val1, int val2)
        {
            int a = 1;
            int g = 0;
            List<int> arr = new List<int>();
            for (int i = 1; i < val2; i++)
            {
                a++;
                for (int z = 2; z < val2; z++)
                {
                    if (a == z) { }
                    else if (a % z != 0) { }
                    //123 :)
                    else if (a % z == 0) { g++; }
                }
                if (a > val1)
                {
                    if (g == 0) { arr.Add(a); }
                }
                g = 0;
            }
            listBox2.Items.Clear();
            listBox2.Items.Add (string.Join(",", arr));
            listBox2.Items.Add ("Count of numbers: " + arr.Count +"\n" + "n/ln(n) ~" + val2/Math.Log(val2));
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
            }
            if (checkBox1.Checked == false)
            {
                checkBox2.Enabled = true;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
            }
        }


        #region
        private void button2_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img.jpg");
            string audiopath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "x.wav");
            Image myimg = new Bitmap(path);
            this.BackgroundImage = myimg;

            SoundPlayer player = new SoundPlayer(audiopath);
            player.Play();

        }
        #endregion
    }
}
