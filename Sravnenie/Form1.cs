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
            Existing_Method ex_m = new Existing_Method();
            Method1 m1;
            Method2 m2;
            Method3 m3;

            Stopwatch t = new Stopwatch();
            double[] rez_mas = new double[20];

            if (System.IO.File.Exists("data.txt"))
            {
                string[] mass = System.IO.File.ReadAllLines("data.txt");
                System.IO.File.WriteAllText("ex_m.txt", "");

                // Существующий тест
                t.Start();
                foreach (string s in mass)
                {
                    string[] str = s.Split(' ');
                    System.IO.File.AppendAllText("ex_m.txt", ex_m.IndistinctMatching(4, str[0], str[1]).ToString() + Environment.NewLine);
                }
                t.Stop();
                System.IO.File.AppendAllText("ex_m.txt", t.Elapsed.ToString());

                
                System.IO.File.WriteAllText("m1.txt", "");

                // Метод 1
                t = new Stopwatch();
                t.Start();
                foreach (string s in mass)
                {
                    string[] str = s.Split(' ');
                    m1 = new Method1(str[0], str[1]);
                    System.IO.File.AppendAllText("m1.txt", (m1.Func()*100).ToString() + Environment.NewLine);
                }
                t.Stop();
                System.IO.File.AppendAllText("m1.txt", t.Elapsed.ToString());


                System.IO.File.WriteAllText("m2.txt", "");

                // Метод 2
                t = new Stopwatch();
                t.Start();
                foreach (string s in mass)
                {
                    string[] str = s.Split(' ');
                    m2 = new Method2(str[0], str[1]);
                    if (m2.Func())
                        System.IO.File.AppendAllText("m2.txt", "100" + Environment.NewLine);
                    else
                        System.IO.File.AppendAllText("m2.txt", "0" + Environment.NewLine);
                }
                t.Stop();
                System.IO.File.AppendAllText("m2.txt", t.Elapsed.ToString());
                
                // Метод 3
                System.IO.File.WriteAllText("m3.txt", "");

                t = new Stopwatch();
                t.Start();
                foreach (string s in mass)
                {
                    string[] str = s.Split(' ');
                    m3 = new Method3(str[0], str[1]);
                    System.IO.File.AppendAllText("m3.txt", (100-m3.Func()*100).ToString() + Environment.NewLine);
                }
                t.Stop();
                System.IO.File.AppendAllText("m3.txt", t.Elapsed.ToString());
                
                MessageBox.Show("Выполнено");
            }
        }
    }

    // Класс реализован на VBA, конвертирован в Delpfi и конвертирован в C#
    // Древняя реализация 

    class Existing_Method
    {   
        //------------------------------------------------------------------------------
        //MaxMatching - максимальная длина подстроки (достаточно 3-4)
        //strInputMatching - сравниваемая строка
        //strInputStandart - строка-образец
        // Сравнивание без учета регистра
        // if IndistinctMatching(4, "поисковая строка", "оригинальная строка  - эталон") > 40 then ...
        struct RetCount
        {
            public long lngSubRows;
            public long lngCountLike;
        }

        RetCount Matching(string strInputA, string strInputB, int lngLen)
        {
            RetCount TempRet;
            int PosStrA;
            int PosStrB;
            string strTempA;
            string strTempB;
            TempRet.lngCountLike = 0;
            TempRet.lngSubRows = 0;
            for (PosStrA = 0; PosStrA <= strInputA.Length - lngLen; PosStrA++)
            {
                strTempA = strInputA.Substring(PosStrA, lngLen);
                for (PosStrB = 0; PosStrB <= strInputB.Length - lngLen; PosStrB++)
                {
                    strTempB = strInputB.Substring(PosStrB, lngLen);
                    if ((string.Compare(strTempA, strTempB) == 0))
                    {
                        TempRet.lngCountLike = (TempRet.lngCountLike + 1);
                        break;
                    }
                }
                TempRet.lngSubRows = (TempRet.lngSubRows + 1);
            }
            return TempRet;
        }

        public float IndistinctMatching(int MaxMatching, string strInputMatching, string strInputStandart)
        {
            RetCount gret;
            RetCount tret;
            int lngCurLen; //текущая длина подстроки
            //если не передан какой-либо параметр, то выход
            if (MaxMatching == 0 || strInputMatching.Length == 0 || strInputStandart.Length == 0) return 0;
            gret.lngCountLike = 0;
            gret.lngSubRows = 0;
            // Цикл прохода по длине сравниваемой фразы
            for (lngCurLen = 1; lngCurLen <= MaxMatching; lngCurLen++)
            {
                //Сравниваем строку A со строкой B
                tret = Matching(strInputMatching, strInputStandart, lngCurLen);
                gret.lngCountLike = gret.lngCountLike + tret.lngCountLike;
                gret.lngSubRows = gret.lngSubRows + tret.lngSubRows;
                //Сравниваем строку B со строкой A
                tret = Matching(strInputStandart, strInputMatching, lngCurLen);
                gret.lngCountLike = gret.lngCountLike + tret.lngCountLike;
                gret.lngSubRows = gret.lngSubRows + tret.lngSubRows;
            }
            if (gret.lngSubRows == 0) return 0;
            return (float)(gret.lngCountLike * 100.0 / gret.lngSubRows);
        }
    }
}
