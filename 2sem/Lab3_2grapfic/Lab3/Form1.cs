using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowGraph();
        }
        void ShowGraph()
        {
			//Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk-Ukrainian");
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			chart1.Series[0].Points.Clear();			
			string d = System.IO.File.ReadAllText("in.txt", System.Text.Encoding.UTF8).Replace("\n", " ");

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
    }
}
