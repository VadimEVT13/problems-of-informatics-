using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class Jaro
    {
        public static double Func(string Str1, string Str2)
        {
            string str1 = Str1;
            string str2 = Str2;
            // первая строка по вертикали
            double[][] matrix = new double[str1.Count()][];
            for (int i = 0; i < str1.Count(); i++)
                matrix[i] = new double[str2.Count()];

            int dist = 0;
            if (str1.Count() >= str2.Count())
                dist = str1.Count() / 2 - 1;
            else
                dist = str2.Count() / 2 - 1;

            for (int i = 0; i < str1.Count(); i++)
            {
                for (int j = i - dist; j <= i + dist; j++)
                {
                    if (j >= 0 & j < str2.Count())
                    {
                        if (str1[i] == str2[j])
                            matrix[i][j] = 1;
                        else
                            matrix[i][j] = 0;
                    }
                }
            }

            double m = 0;
            int t = 0;
            List<char> t1 = new List<char>();
            List<char> t2 = new List<char>();

            for (int i = 0; i < str1.Count(); i++)
            {
                for (int j = 0; j < str2.Count(); j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        m++;
                    }
                }
            }

            for (int i = 0; i < str1.Count(); i++)
            {
                for (int j = 0; j < str2.Count(); j++)
                {
                    if (matrix[i][j] == 1 & i != j)
                        t1.Add(str1[i]);
                }
            }

            for (int i = 0; i < str2.Count(); i++)
            {
                for (int j = 0; j < str1.Count(); j++)
                {
                    if (matrix[j][i] == 1 & i != j)
                        t2.Add(str2[i]);
                }
            }

            for (int i = 0; i < t1.Count(); i++)
            {
                if (t1[i] != t2[i])
                    t++;
            }

            t = t / 2;

            if (m == 0)
                return 0;
            else
                return 1 / 3.0 * (m / str1.Count() + m / str2.Count() + (m - t) / m);
        }
    }
}
