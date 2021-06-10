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
namespace Lab2
{
    public partial class Form1 : Form
    {
        const string defaultAlphabet = "ABCDEFGHIIJKLMNOPQRSTUVWXYZ";
        readonly string letterrs = "ABCDEFGHIIJKLMNOPQRSTUVWXYZ";
      
        public Form1()
        {
            InitializeComponent();
        }

        //генерация повторяющегося пароля
        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }
            return p.Substring(0, n);
        }

        private string Vigenere(string text, string password, bool encrypting = true)
        {
            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var q = letterrs.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = letterrs.IndexOf(text[i]);
                var codeIndex = letterrs.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    //если буква не найдена, добавляем её в исходном виде
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += letterrs[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            return retValue;
        }

        //шифрование текста
        public string Encrypt(string plainMessage, string password)
            => Vigenere(plainMessage, password);

        //дешифрование текста
        public string Decrypt(string encryptedMessage, string password)
            => Vigenere(encryptedMessage, password, false);

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                string s;
               
                StreamReader sr = new StreamReader("in.txt");
                StreamWriter sw = new StreamWriter("out.txt");
                var startTime = System.Diagnostics.Stopwatch.StartNew();
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    sw.WriteLine(Encrypt(s, textBox1.Text));
                }
                startTime.Stop();
                var resultTime = startTime.Elapsed;

                // elapsedTime - строка, которая будет содержать значение затраченного времени
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                    resultTime.Hours,
                    resultTime.Minutes,
                    resultTime.Seconds,
                    resultTime.Milliseconds);
                label2.Text = elapsedTime.ToString();
                sr.Close();
                sw.Close();

                //передаем в конструктор класса буквы русского алфавита
                graph1();
            }
            else
            {
                MessageBox.Show("Key is empty!");
            }
           
        }
        
       
        void graph1()
        {
            chart1.Series[0].Points.Clear();
            string s = System.IO.File.ReadAllText("in.txt", Encoding.Default).Replace("\n", " ");
            string d = System.IO.File.ReadAllText("in.txt", Encoding.Default).Replace("\n", " ");
           
            StreamReader sr = new StreamReader("in.txt");
            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();
                          
            }
            sr.Close();
            var res = d
                   .GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            Dictionary<string, int> Data = new Dictionary<string, int>();
            foreach (var val in res)
            {
                Data.Add(val.Key.ToString(), val.Value);
            }
            foreach (var cc in Data)
            {
                chart1.Series[0].Points.AddXY(cc.Key, cc.Value);
                chart1.ChartAreas[0].AxisX.Interval = 1;
                //MessageBox.Show(cc.Key.ToString() + cc.Value.ToString());
            }
        }
        void graph2()
        {
            chart1.Series[0].Points.Clear();
            string d = System.IO.File.ReadAllText("decrypted.txt", Encoding.Default).Replace("\n", " ");
      
            var res = d
                   .GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            Dictionary<string, int> Data = new Dictionary<string, int>();
            foreach (var val in res)
            {
                Data.Add(val.Key.ToString(), val.Value);
            }
            foreach (var cc in Data)
            {
               chart1.Series[0].Points.AddXY(cc.Key, cc.Value);
               chart1.ChartAreas[0].AxisX.Interval = 1;
                //MessageBox.Show(cc.Key.ToString() + cc.Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string s;

                StreamReader sr = new StreamReader("out.txt");
                StreamWriter sw = new StreamWriter("decrypted.txt");
                var startTime = System.Diagnostics.Stopwatch.StartNew();
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    sw.WriteLine(Decrypt(s, textBox1.Text));
                }
                startTime.Stop();
                var resultTime = startTime.Elapsed;

                // elapsedTime - строка, которая будет содержать значение затраченного времени
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                    resultTime.Hours,
                    resultTime.Minutes,
                    resultTime.Seconds,
                    resultTime.Milliseconds);
                label3.Text = elapsedTime.ToString();
                sr.Close();
                sw.Close();
                graph2();
            }
            else
            {
                MessageBox.Show("Key is empty!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region
        private void button3_Click_1(object sender, EventArgs e)
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
