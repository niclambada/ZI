using BKSystem.IO;
using System;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        private string Base64Code = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        private Encoding encoding = Encoding.UTF8;

        public Form2()
        {
            InitializeComponent();
        }

        private string toBase64(byte[] bytes)
        {
            string str = "";
            if (bytes.Length == 0) return "";
            using (BitStream bs = new BitStream())
            {
                bs.Write(bytes);
                while (bs.Length % 6 != 0)
                    bs.Write(false);
                bs.Position = 0;
                while (bs.Length != bs.Position)
                {
                    byte bt;
                    bs.Read(out bt, 0, 6);
                    str += Base64Code[bt];
                }
            }
            for(int i =0; i<(3-(bytes.Length % 3)) % 3; i++)
            {
                str += '=';
            }
            return str;
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            var bytes = encoding.GetBytes(textBoxUTF.Text);
            textBoxBase.Text = toBase64(bytes);
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            using (var bs = new BitStream())
            {
                foreach (char i in textBoxBase.Text.Trim(new char[] { '='}))
                {
                    bs.Write(Base64Code.IndexOf(i), 0, 6);
                }
                bs.Position = 0;
                var len = bs.Length8;
                if (len * 8 != bs.Length) len--;
                byte[] bt = new byte[len];
                bs.Read(bt, 0, (int)(len));
                textBoxUTF.Text = encoding.GetString(bt); 
            }
        }

        private void uTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encoding = Encoding.UTF8;
        }

        private void aNCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encoding = Encoding.ASCII;
        }

        private void unicodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encoding = Encoding.Unicode;
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            textBoxBytes.Text = "";

            var btA = Encoding.UTF8.GetBytes(textBoxA.Text != null ? textBoxA.Text : "");
            var btB = Encoding.UTF8.GetBytes(textBoxB.Text != null ? textBoxB.Text : "");
            
            var len = Math.Max(btA.Length, btB.Length);
            var btX = new byte[len];

            byte a;
            byte b;

            for(int i = 0; i < len; i++)
            {
                a = i < btA.Length ? btA[i] : (byte)0;
                b = i < btB.Length ? btB[i] : (byte)0;

                btX[i] = (byte)(a ^ b);
                textBoxBytes.Text += Convert.ToString(btX[i], 2).PadLeft(8, '0');
            }

            textBoxASCII.Text = Encoding.UTF8.GetString(btX);
            textBoxBs64.Text = toBase64(btX);

        }
    }
}
