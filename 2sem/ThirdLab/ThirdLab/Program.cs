using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ThirdLab
{
    class Program
    {
        static string textForEncode = "цввяткоу ";
        static string secondTextForEncode = "мыкалай";
        static string text = "";
        
        static void Main(string[] args)
        {


           

            var startTime = System.Diagnostics.Stopwatch.StartNew();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
           
   
            try
            {
                using(StreamReader sr=new StreamReader(@"D:\3c2s\ЗИ_\2sem\ThirdLab\ThirdLab\bin\Debug\in.txt"))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }

            char[,] matrica=new char[text.Length,textForEncode.Length+2];
            int prov = 0;
            for (int i = 0; i < text.Length ; i++)
            {
                if (prov == 0)
                {
                    prov++;
                    for (int j = 0; j < textForEncode.Length +2; j++)
                    {
                        if (j < textForEncode.Length)
                        {
                            matrica[i, j] = textForEncode[j];
                        }
                        else
                        {
                            matrica[i, j] = text[0];
                            text = text.Remove(0, 1);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < textForEncode.Length + 2; j++)
                    {
                        matrica[i, j] = text[0];
                        text = text.Remove(0, 1);
                    }
                }
            }
            //for (int i = 0; i < textForEncode.Length + 2; i++)
            //{
            //    for (int j = 0; j < text.Length; j++)
            //    {
            //        Console.Write(matrica[j, i]);
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("_____________________________________________________________________");

            char[,] secondMatrica= new char[textForEncode.Length + 2,text.Length];
            for(int i = 0; i < textForEncode.Length + 2; i++)
            {
                for(int j = 0; j < text.Length; j++)
                {
                    secondMatrica[i, j] = matrica[j, i];
                }
            }
         

            for (int i = 0; i < textForEncode.Length + 2; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    Console.Write(secondMatrica[i, j]);
                }
                Console.WriteLine();
            }

            startTime.Stop();
            var resultTime = startTime.Elapsed;

            // elapsedTime - строка, которая будет содержать значение затраченного времени
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime.Hours,
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);
            Console.WriteLine();
            Console.WriteLine("Encode Time: " + elapsedTime.ToString());
            Console.WriteLine();


            var startTime1 = System.Diagnostics.Stopwatch.StartNew();
            char[,] thirdMatrica = new char[text.Length, textForEncode.Length + 2];
            for(int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < textForEncode.Length + 2; j++)
                {
                    thirdMatrica[i, j] = secondMatrica[j, i];
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < textForEncode.Length + 2; j++)
                {
                    Console.Write(thirdMatrica[i, j]);
                }
                Console.WriteLine();
            }

            startTime1.Stop();
            var resultTime1 = startTime1.Elapsed;

            // elapsedTime - строка, которая будет содержать значение затраченного времени
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime1.Hours,
                resultTime1.Minutes,
                resultTime1.Seconds,
                resultTime1.Milliseconds);
            Console.WriteLine();
            Console.WriteLine("Decode Time: " + elapsedTime1.ToString());
            Console.WriteLine();

            Console.WriteLine("_______________________________________________________________________________");

            // Первый ключ, количество столбцов
            string firstKey = "Цвяткоу";
            // Второй ключ, количество строк
            string secondKey = "Мыкалай";
            // Предложение которое шифруем
            string stringUser = "На бясконцым беразе, перад разгубленым малым застаюцца.";

            // Матрица в которой производим шифрование
            char[,] matrix = new char[secondKey.Length, firstKey.Length];

            // Счетчик символов в строке
            int countSymbols = 0;

            // Переводим строки в массивы типа char
            char[] charsFirstKey = firstKey.ToCharArray();
            char[] charsSecondKey = secondKey.ToCharArray();
            char[] charStringUser = stringUser.ToCharArray();

            // Создаем списки в которых будут храниться символы и порядковы номера символов
            List<CharNum> listCharNumFirst =
                new List<CharNum>(firstKey.Length);

            List<CharNum> listCharNumSecond =
                new List<CharNum>(secondKey.Length);

            // Заполняем символами из ключей
            listCharNumFirst = FillListKey(charsFirstKey);
            listCharNumSecond = FillListKey(charsSecondKey);

            // Заполняем порядковыми номерами
            listCharNumFirst = FillingSerialsNumber(listCharNumFirst);
            listCharNumSecond = FillingSerialsNumber(listCharNumSecond);

            ShowKey(listCharNumFirst, "Первый ключ: ");
            ShowKey(listCharNumSecond, "Второй ключ: ");

            // Заполнение матрицы строкой пользователя
            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {
                    matrix[i, j] = charStringUser[countSymbols++];
                }
            }

            ShowMatrix(matrix, "Первоначальное значение: ");

            countSymbols = 0;
            // Заполнение матрицы с учетом шифрования. 
            // Переставляем столбцы по порядку следования в первом ключе. 
            // Затем переставляем строки по порядку следования во втором ключа. 
            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {
                    matrix[listCharNumSecond[i].NumberInWord,
                       listCharNumFirst[j].NumberInWord] = charStringUser[countSymbols++];
                }
            }
            var startTime2 = System.Diagnostics.Stopwatch.StartNew();
            ShowMatrix(matrix, "Зашифрованное значение: ");
            startTime2.Stop();
            var resultTime2 = startTime2.Elapsed;

            // elapsedTime - строка, которая будет содержать значение затраченного времени
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime.Hours,
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);
            Console.WriteLine("Encode Time: " + elapsedTime2.ToString());
            Console.ReadKey();

        }
        public static int GetNumberInThealphabet(char s)
        {
            string str = @"АаБбВвГгДдЕеЁёЖжЗзІіЙйКкЛлМмНнОоПпРрСсТтУуЎўФфХхЦцЧчШшЫыЬьЭэЮюЯя";

            int number = str.IndexOf(s) / 2;

            return number;
        }

        /// <summary>
        /// Заполнение символами списка с ключом.
        /// </summary>
        /// <param name="chars">массив символов.</param>
        /// <returns>Список символов.</returns>
        public static List<CharNum> FillListKey(char[] chars)
        {
            List<CharNum> listKey = new List<CharNum>(chars.Length);

            for (int i = 0; i < chars.Length; i++)
            {
                CharNum charNum = new CharNum()
                {
                    Ch = chars[i],
                    NumberInWord = GetNumberInThealphabet(chars[i])
                };

                listKey.Add(charNum);
            }
            return listKey;
        }
        /// <summary>
        /// Отображение ключа.
        /// </summary>
        /// <param name="listCharNum">Список в котором содержатся символы с порядковыми номерами.</param>
        public static void ShowKey(List<CharNum> listCharNum, string message)
        {
            Console.WriteLine(message);

            foreach (var i in listCharNum)
            {
                Console.Write(i.Ch + " ");
            }
            Console.WriteLine();

            foreach (var i in listCharNum)
            {
                Console.Write(i.NumberInWord + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Заполнение символов ключей, порядковыми номерами.
        /// </summary>
        /// <param name="listCharNum"></param>
        /// <returns></returns>
        public static List<CharNum> FillingSerialsNumber(
            List<CharNum> listCharNum)
        {
            int count = 0;

            var result = listCharNum.OrderBy(a =>
                a.NumberInWord);

            foreach (var i in result)
            {
                i.NumberInWord = count++;
            }

            return listCharNum;
        }
        /// <summary>
        /// Отображение матрицы.
        /// </summary>
        /// <param name="matrix">Матрица с символами.</param>
        public static void ShowMatrix(char[,] matrix, string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    class CharNum
    {
        #region Fields
        /// <summary>
        /// Символ.
        /// </summary>
        private char _ch;
        /// <summary>
        /// Порядковый номер зависящий от алфавита.
        /// </summary>
        private int _numberInWord;
        #endregion Fieds

        #region Properties
        /// <summary>
        /// Символ.
        /// </summary>
        public char Ch
        {
            get { return _ch; }
            set
            {
                if (_ch == value)
                    return;
                _ch = value;
            }
        }
        /// <summary>
        /// Порядковый номер в строке, зависящий от алфавита.
        /// </summary>
        public int NumberInWord
        {
            get { return _numberInWord; }
            set
            {
                if (_numberInWord == value)
                    return;
                _numberInWord = value;
            }
        }
        #endregion Properties
    }
}
