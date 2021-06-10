using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    static class Aditions
    {
        public static string DelLine(this string oldText)
        {
            int index = oldText.IndexOf(System.Environment.NewLine);
            return oldText.Substring(index + System.Environment.NewLine.Length);
        }
    }
}
