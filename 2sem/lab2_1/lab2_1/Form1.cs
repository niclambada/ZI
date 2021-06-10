using LanguageExt;
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

namespace lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			StreamReader sr = new StreamReader("in.txt");
			StreamWriter sw = new StreamWriter("out.txt");

			string s; //String to hold words while looping
			var startTime = System.Diagnostics.Stopwatch.StartNew();
			while (!sr.EndOfStream) //Loop through br until s is null
			{
				s = sr.ReadLine();
				sw.WriteLine(encryptLine(s, textBox1.Text));
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
			sr.Close(); //Close the BufferedReader stream
			sw.Close(); //Close the PrintWriter stream
			graph2();
		}


		public static string encryptLine(string word, string key) //Encrypts word character by character and returns concatenated encrypted String
        {
			Dictionary<char, int> charMap = new Dictionary<char, int>();
			charMap.Add('A', 0);
			charMap.Add('B', 1);
			charMap.Add('C', 2);
			charMap.Add('D', 3);
			charMap.Add('E', 4);
			charMap.Add('F', 5);
			charMap.Add('G', 6);
			charMap.Add('H', 7);
			charMap.Add('I', 8);
			charMap.Add('J', 9);
			charMap.Add('K', 10);
			charMap.Add('L', 11);
			charMap.Add('M', 12);
			charMap.Add('N', 13);
			charMap.Add('O', 14);
			charMap.Add('P', 15);
			charMap.Add('Q', 16);
			charMap.Add('R', 17);
			charMap.Add('S', 18);
			charMap.Add('T', 19);
			charMap.Add('U', 20);
			charMap.Add('V', 21);
			charMap.Add('W', 22);
			charMap.Add('X', 23);
			charMap.Add('Y', 24);
			charMap.Add('Z', 25);

			Dictionary<char, int> charMapKey = new Dictionary<char, int>();

			charMapKey.Add('A', 0);
			charMapKey.Add('B', 0);
			charMapKey.Add('C', 1);
			charMapKey.Add('D', 1);
			charMapKey.Add('E', 2);
			charMapKey.Add('F', 2);
			charMapKey.Add('G', 3);
			charMapKey.Add('H', 3);
			charMapKey.Add('I', 4);
			charMapKey.Add('J', 4);
			charMapKey.Add('K', 5);
			charMapKey.Add('L', 5);
			charMapKey.Add('M', 6);
			charMapKey.Add('N', 6);
			charMapKey.Add('O', 7);
			charMapKey.Add('P', 7);
			charMapKey.Add('Q', 8);
			charMapKey.Add('R', 8);
			charMapKey.Add('S', 9);
			charMapKey.Add('T', 9);
			charMapKey.Add('U', 10);
			charMapKey.Add('V', 10);
			charMapKey.Add('W', 11);
			charMapKey.Add('X', 11);
			charMapKey.Add('Y', 12);
			charMapKey.Add('Z', 12);

			char[] encryptionArray = { 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; //Array to store first half of the cipher
			char[] encryptionArray2 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' }; //Array to store second half of the cipher

			 word = word.ToUpper();
			 key = key.ToUpper();

			StringBuilder builder = new StringBuilder(word.Length() + key.Length() - 1);

			while (builder.Length < word.Length())
			{
				builder.Append(key);
			}
			builder.Length = word.Length; //Sets length to word length

			string keyToUse = builder.ToString(); //Elongated key

			string encryptedLine = ""; //Encrypted word

			StringBuilder sb = new StringBuilder(); //New StringBuilder to create encrypted word from characters


			for (int i = 0; i < word.Length; i++) //Loop for the length of the word
			{
				int lookup = 0; //Used to look for the encrypted character
				char wordLetter = word[i]; //Word Character at position i
				char keyLetter = keyToUse[i]; //Key Character at position i

				if (wordLetter >= 'A' && wordLetter <= 'Z') //Only encrypt letters
				{

					if (charMap[word[i]] > 12 && charMap[word[i]] <= 25) //If word is in the second half of the cipher A-M
					{
						lookup = ((charMap[wordLetter] - charMapKey[keyLetter]) % 13); //Calculate position of encrypted character
						sb.Append(encryptionArray2[lookup]); //Search array 2 and append encrypted character to sb
					}

					else //Otherwise If word is in the first half of the cipher N-Z
					{
						lookup = ((charMap[wordLetter] + charMapKey[keyLetter]) % 13); //Calculate position of encrypted character
						sb.Append(encryptionArray[lookup]); //Search array and append encrypted character to sb
					}
				}

				else //Add non-letter characters to the encryptedWord
				{
					sb.Append(word[i]);
				}
			}

			encryptedLine = sb.ToString(); //Concatenated String

			return encryptedLine;
		}

        private void button2_Click(object sender, EventArgs e)
        {
			StreamReader sr = new StreamReader("out.txt");
			StreamWriter sw = new StreamWriter("decrypt.txt");

			string s; //String to hold words while looping
			var startTime = System.Diagnostics.Stopwatch.StartNew();
			while (!sr.EndOfStream) //Loop through br until s is null
			{
				s = sr.ReadLine();
				sw.WriteLine(decryptLine(s, textBox1.Text));
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
			sr.Close(); //Close the BufferedReader stream
			sw.Close(); //Close the PrintWriter stream
			graph1();
		}

		public static string decryptLine(string word, string key)
        {
			Dictionary<char, int> charMap = new Dictionary<char, int>();
			charMap.Add('A', 0);
			charMap.Add('B', 1);
			charMap.Add('C', 2);
			charMap.Add('D', 3);
			charMap.Add('E', 4);
			charMap.Add('F', 5);
			charMap.Add('G', 6);
			charMap.Add('H', 7);
			charMap.Add('I', 8);
			charMap.Add('J', 9);
			charMap.Add('K', 10);
			charMap.Add('L', 11);
			charMap.Add('M', 12);
			charMap.Add('N', 13);
			charMap.Add('O', 14);
			charMap.Add('P', 15);
			charMap.Add('Q', 16);
			charMap.Add('R', 17);
			charMap.Add('S', 18);
			charMap.Add('T', 19);
			charMap.Add('U', 20);
			charMap.Add('V', 21);
			charMap.Add('W', 22);
			charMap.Add('X', 23);
			charMap.Add('Y', 24);
			charMap.Add('Z', 25);

			Dictionary<char, int> charMapKey = new Dictionary<char, int>();

			charMapKey.Add('A', 0);
			charMapKey.Add('B', 0);
			charMapKey.Add('C', 1);
			charMapKey.Add('D', 1);
			charMapKey.Add('E', 2);
			charMapKey.Add('F', 2);
			charMapKey.Add('G', 3);
			charMapKey.Add('H', 3);
			charMapKey.Add('I', 4);
			charMapKey.Add('J', 4);
			charMapKey.Add('K', 5);
			charMapKey.Add('L', 5);
			charMapKey.Add('M', 6);
			charMapKey.Add('N', 6);
			charMapKey.Add('O', 7);
			charMapKey.Add('P', 7);
			charMapKey.Add('Q', 8);
			charMapKey.Add('R', 8);
			charMapKey.Add('S', 9);
			charMapKey.Add('T', 9);
			charMapKey.Add('U', 10);
			charMapKey.Add('V', 10);
			charMapKey.Add('W', 11);
			charMapKey.Add('X', 11);
			charMapKey.Add('Y', 12);
			charMapKey.Add('Z', 12);

			char[] decryptionArray = { 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; //Array to store first half of the cipher
			char[] decryptionArray2 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' }; //Array to store second half of the cipher

			word = word.ToUpper();
			key = key.ToUpper();

			StringBuilder builder = new StringBuilder(word.Length + key.Length - 1);

			while (builder.Length < word.Length)
			{
				builder.Append(key);
			}

			builder.Length = word.Length; //Sets length to word length
			string keyToUse = builder.ToString(); //Elongated key

			string decryptedLine = ""; //Decrypted word

			StringBuilder sb = new StringBuilder(); //New StringBuilder to create decrypted word from characters

			for (int i = 0; i < word.Length; i++) //Loop for length of the word
			{
				char wordLetter = word[i];  //Character at position i in the word
				char keyLetter = keyToUse[i]; //Character at position i in the key
				int lookup = 0; //Integer used to look up encrypted character in the decryption array

				if (wordLetter >= 'A' && wordLetter <= 'Z') //Only encrypt letters
				{
					if (charMap[wordLetter] > 12) //If word is in the second half of the cipher A-M
					{
						lookup = ((charMap[wordLetter] - charMapKey[keyLetter]) % 13); //Calculate position of decrypted character
						sb.Append(decryptionArray2[lookup]); //Search array 2 and append decrypted character to sb
					}

					else //Otherwise If word is in the first half of the cipher N-Z
					{
						lookup = ((charMap[wordLetter] + charMapKey[keyLetter]) % 13); //Calculate position of decrypted character
						sb.Append(decryptionArray[lookup]); //Search array and append decrypted character to sb
					}
				}

				else //Add non-letter characters to the decryptedWord
				{
					sb.Append(word[i]);
				}
			}

			decryptedLine = sb.ToString(); ////Add non-letter characters to the encryptedWord
            
			return decryptedLine;
		}

		void graph1()
		{
			chart1.Series[0].Points.Clear();
			string s = System.IO.File.ReadAllText("in.txt", Encoding.Default).Replace("\n", " ");
			string d = System.IO.File.ReadAllText("decrypt.txt", Encoding.Default).Replace("\n", " ");

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

		#region
		private void button3_Click(object sender, EventArgs e)
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
