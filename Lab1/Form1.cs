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

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Jaro_button_Click(object sender, EventArgs e)
        {
            Jaro m = new Jaro();
            JaroRez.Text = m.Func(JaroText1.Text, JaroText2.Text).ToString();
        }

        private void JaroVincler_button_Click(object sender, EventArgs e)
        {
            JaroVincler m = new JaroVincler();
            JaroVinclerRez.Text = m.Func(JaroVinclerText1.Text, textBJaroVinclerText2.Text).ToString();

        }

        private void Levenstein_button_Click(object sender, EventArgs e)
        {
            Levenstein m = new Levenstein();
            LevensteinRez.Text = m.Func(LevensteinText1.Text, LevensteinText2.Text).ToString();
        }
    }
}
