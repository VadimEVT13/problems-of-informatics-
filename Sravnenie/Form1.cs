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
            SimMetricsMetricUtilities.Levenstein ex_l = new SimMetricsMetricUtilities.Levenstein();
            
            Stopwatch t = new Stopwatch();
            /*
                t.Start();
                t.Elapsed.ToString();

            */

            string s1 = "Vadim";
            string s2 = "Vidam";

            double rezj1 = Jaro.Func(s1, s2);
            double rezj3 = ExJaro.distance(s1, s2);


            double rezjv1 = JaroVincler.Func(s1, s2);
            double rezjv3 = ExJaroWincler.distance(s1, s2);

            double rezl1 = Levenstein.Func(s1, s2);
            double rezl2 = ex_l.GetSimilarity(s1, s2);
        }

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

                    SimMetricsMetricUtilities.Levenstein ex_l = new SimMetricsMetricUtilities.Levenstein();\

                    Stopwatch t = new Stopwatch();
                    t.Start();
                    double rj1 = Jaro.Func(str[0], str[1]);
                    string tj1 = t.Elapsed.ToString();

                    t = new Stopwatch();
                    t.Start();                                  
                    double rj2 = ExJaro.distance(str[0], str[1]);
                    string tj2 = t.Elapsed.ToString();
                                
                    // -----

                    t = new Stopwatch();
                    t.Start();
                    double rjv1 = JaroVincler.Func(str[0], str[1]);
                    string tjv1 = t.Elapsed.ToString();

                    t = new Stopwatch();
                    t.Start();
                    double rjv2 = ExJaroWincler.distance(str[0], str[1]);
                    string tjv2 = t.Elapsed.ToString();
                                        
                    // ----

                    t = new Stopwatch();
                    t.Start();
                    double rl1 = Levenstein.Func(str[0], str[1]);
                    string tl1 = t.Elapsed.ToString();

                    t = new Stopwatch();
                    t.Start();
                    double rl2 = ex_l.GetSimilarity(str[0], str[1]);
                    string tl2 = t.Elapsed.ToString();
                                        
                    rezlist.Add(new string[12] { rj1.ToString(), tj1, rj2.ToString(), tj2,
                        rjv1.ToString(), tjv1, rjv2.ToString(), tjv2,
                        rl1.ToString(), tl1, rl2.ToString(), tl2});
                }
            }

            return rezlist;
        }


    }
}
