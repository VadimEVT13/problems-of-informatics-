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

        private void button1_Click(object sender, EventArgs e)
        {
            Method1 m = new Method1(textBox1.Text, textBox2.Text);
            textBox3.Text = "Формула: s = 2 * m / ( a + b )\nРезультат s = " + m.Func().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Method2 m = new Method2(textBox4.Text, textBox5.Text);
            if(m.Func())
                textBox6.Text = "Результат: совпадают";
            else
                textBox6.Text = "Результат: не совпадают";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Method3 m = new Method3(textBox7.Text, textBox8.Text);
            textBox9.Text = "Результат " + m.Func();
        }
    }
}
