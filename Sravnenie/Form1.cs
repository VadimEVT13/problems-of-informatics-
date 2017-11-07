using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Methods;
using System.Diagnostics;
using System.IO;

namespace Sravnenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string pathdata = @"..\..\data\data.txt";
            string pathrez = @"..\..\data\rez.txt";

            string[][] data = readFile(pathdata);
            List<string[]> rez = Sravn(data);
            writeFile(pathrez, rez);
        }

        // сравнение
        private List<string[]> Sravn(string[][] data)
        {
            List<string[]> rezlist = new List<string[]>();

            foreach (string[] str in data)
            {
                // количество слов в строке
                if (str.Count() != 2)
                    continue;
                else
                {
                    string[] mass;

                    SimMetricsMetricUtilities.Levenstein ex_l = new SimMetricsMetricUtilities.Levenstein();

                    Stopwatch t = new Stopwatch();
                    t.Start();
                    double rj1 = Math.Round(Jaro.Func(str[0], str[1]), 2);
                    string tj1 = Math.Round(t.Elapsed.TotalMilliseconds, 2).ToString();

                    t = new Stopwatch();
                    t.Start();                                  
                    double rj2 = Math.Round(ExJaro.distance(str[0], str[1]), 2);
                    string tj2 = Math.Round(t.Elapsed.TotalMilliseconds, 2).ToString();

                    // -----

                    t = new Stopwatch();
                    t.Start();
                    double rjv1 = Math.Round(JaroVincler.Func(str[0], str[1]), 2);
                    string tjv1 = Math.Round(t.Elapsed.TotalMilliseconds, 2).ToString();

                    t = new Stopwatch();
                    t.Start();
                    double rjv2 = Math.Round(ExJaroWincler.distance(str[0], str[1]), 2);
                    string tjv2 = Math.Round(t.Elapsed.TotalMilliseconds, 2).ToString();

                    // ----

                    t = new Stopwatch();
                    t.Start();
                    double rl1 = Math.Round(Levenstein.Func(str[0], str[1]), 2);
                    string tl1 = Math.Round(t.Elapsed.TotalMilliseconds, 2).ToString();

                    t = new Stopwatch();
                    t.Start();
                    double rl2 = Math.Round(ex_l.GetSimilarity(str[0], str[1]), 2);
                    string tl2 = Math.Round(t.Elapsed.TotalMilliseconds, 2).ToString();
                                        
                    rezlist.Add(new string[14] { rj1.ToString(), tj1, rj2.ToString(), tj2,
                        rjv1.ToString(), tjv1, rjv2.ToString(), tjv2,
                        rl1.ToString(), tl1, rl2.ToString(), tl2, str[0], str[1]});
                }
            }

            return rezlist;
        }

        // получение данных
        private string[][] readFile(string filename)
        {
            Stack<string[]> words = new Stack<string[]>();
            string[][] rez;

            // считывание строк и запись в стек
            filename = filename.Split(' ')[0];
            try
            {
                foreach (string line in File.ReadLines(filename))
                    words.Push(line.Split(' '));

                rez = new string[words.Count][];
                for (int i = words.Count - 1; i >= 0; i--)
                    rez[i] = words.Pop();
            }
            catch (Exception ex) { return null; }

            return rez;
        }

        // запись данных
        private void writeFile(string filename, List<string[]> data)
        {
            string[] lines = new string[data.Count()];

            // считывание строк и запись в стек
            filename = filename.Split(' ')[0];
            try
            {
                for (int i = 0; i < lines.Count(); i++)
                {
                    foreach (string word in data[i])
                        lines[i] += word + "\r\n";
                }

                File.WriteAllLines(filename, lines);
            }
            catch (Exception ex) { };
        }
    }
}
