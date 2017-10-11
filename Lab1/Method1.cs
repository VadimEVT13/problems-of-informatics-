using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Method1
    {
        private string str1;
        private string str2;

        public Method1(string Str1, string Str2)
        {
            str1 = Str1.ToLower();
            str2 = Str2.ToLower();
        }

        public double Func()
        {
            string x = "  ";
            string y = "  ";

            x = x.Insert(1, str1);
            y = y.Insert(1, str2);

            double a = x.Count() - 2;
            double b = y.Count() - 2;

            int m = 0;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (x.Substring(i, 3) == y.Substring(j, 3))
                        m++;
                }
            }

            return 2.0 * m / (a + b);
        }
    }
}
