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

            Jaro our_j = new Jaro();
            JaroVincler our_jv = new JaroVincler();
            Levenstein our_l = new Levenstein();

            Stopwatch t = new Stopwatch();
            /*
                t.Start();
                t.Elapsed.ToString();

            */

            string s1 = "Vadim";
            string s2 = "Vidam";

            double rezj1 = our_j.Func(s1, s2);
            double rezj3 = ExJaro.distance(s1, s2);


            double rezjv1 = our_jv.Func(s1, s2);
            double rezjv3 = ExJaroWincler.distance(s1, s2);

            double rezl1 = our_l.Func(s1, s2);
            double rezl2 = ex_l.GetSimilarity(s1, s2);
        }
    }
}
