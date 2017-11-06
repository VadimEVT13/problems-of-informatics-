using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class JaroVincler
    {
        string str1;
        string str2;

        public JaroVincler() { }

        public double Func(string Str1, string Str2)
        {
            string str1 = Str1.ToLower();
            string str2 = Str2.ToLower();
            double p = 0.1; // по стандарту
            double l = 0;

            for (int i = 0; i < str1.Count() & i < str2.Count(); i++)
            {
                if (str1[i] == str2[i])
                    l++;
                else
                    break;
            }

            // первая строка по вертикали
            double[][] matrix = new double[str1.Count()][];
            for (int i = 0; i < str1.Count(); i++)
                matrix[i] = new double[str2.Count()];

            for (int i = 0; i < str1.Count(); i++)
            {
                for (int j = 0; j < str2.Count(); j++)
                {
                    if (str1[i] == str2[j])
                        matrix[i][j] = 1;
                    else
                        matrix[i][j] = 0;
                }
            }

            int dist = 0;
            if (str1.Count() >= str2.Count())
                dist = str1.Count() / 2 - 1;
            else
                dist = str2.Count() / 2 - 1;

            double m = 0;
            int t = 0;

            for (int i = 0; i < str1.Count() & i < str2.Count(); i++)
            {
                for (int k = i - (int)dist; k <= i + (int)dist; k++)
                {
                    if (k >= 0 & k < str2.Count())
                    {
                        if (matrix[k][i] == 1)
                        {
                            m++;
                            if (k != i)
                                t++;
                        }
                    }
                }
            }
            t = t / 2;

            double d = 0;

            // 0.7 порог винклера
            if (m != 0)
                d = 1 / 3.0 * (m / str1.Count() + m / str2.Count() + (m - t) / m);

            if (d < 0.7)
                return 1 - d;
            else
                return 1 - (d + l * p * (1 - d));
        }
    }
}
