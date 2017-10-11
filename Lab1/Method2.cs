using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Method2
    {
        string str1;
        string str2;

        char[] one = { 'B', 'F', 'P', 'V' };
        char[] two = { 'C', 'G', 'J', 'K', 'Q', 'S', 'X', 'Z' };
        char[] three = { 'D', 'T' };
        char[] four = { 'L' };
        char[] five = { 'M', 'N' };
        char[] six = { 'R' };

        char[] del = { 'A', 'E', 'I', 'O', 'U', 'Y', 'W', 'H' };

        public Method2(string Str1, string Str2)
        {
            str1 = Str1.ToUpper();
            str2 = Str2.ToUpper();
        }

        public bool Func()
        {
            Char[] t1 = str1.ToArray();
            Char[] t2 = str2.ToArray();

            for (int i = 1; i < t1.Count(); i++)
            {
                foreach (char p in one)
                {
                    if (p == t1[i])
                    {
                        t1[i] = '1';
                        break;
                    }
                }
                if (t1[i] == '1')
                    continue;

                foreach (char p in two)
                {
                    if (p == t1[i])
                    {
                        t1[i] = '2';
                        break;
                    }
                }
                if (t1[i] == '2')
                    continue;

                foreach (char p in three)
                {
                    if (p == t1[i])
                    {
                        t1[i] = '3';
                        break;
                    }
                }
                if (t1[i] == '3')
                    continue;

                foreach (char p in four)
                {
                    if (p == t1[i])
                    {
                        t1[i] = '4';
                        break;
                    }
                }
                if (t1[i] == '4')
                    continue;

                foreach (char p in five)
                {
                    if (p == t1[i])
                    {
                        t1[i] = '5';
                        break;
                    }
                }
                if (t1[i] == '5')
                    continue;
          
                foreach (char p in six)
                {
                    if (p == t1[i])
                    {
                        t1[i] = '6';
                        break;
                    }
                }
            }

            for (int i = 1; i < t2.Count(); i++)
            {
                foreach (char p in one)
                {
                    if (p == t2[i])
                    {
                        t2[i] = '1';
                        break;
                    }
                }
                if (t2[i] == '1')
                    continue;

                foreach (char p in two)
                {
                    if (p == t2[i])
                    {
                        t2[i] = '2';
                        break;
                    }
                }
                if (t2[i] == '2')
                    continue;

                foreach (char p in three)
                {
                    if (p == t2[i])
                    {
                        t2[i] = '3';
                        break;
                    }
                }
                if (t2[i] == '3')
                    continue;

                foreach (char p in four)
                {
                    if (p == t2[i])
                    {
                        t2[i] = '4';
                        break;
                    }
                }
                if (t2[i] == '4')
                    continue;

                foreach (char p in five)
                {
                    if (p == t2[i])
                    {
                        t2[i] = '5';
                        break;
                    }
                }
                if (t2[i] == '5')
                    continue;

                foreach (char p in six)
                {
                    if (p == t2[i])
                    {
                        t2[i] = '6';
                        break;
                    }
                }
            }
            //глупый код выше


            //замена одинаковых цифр
            string new_str1 = "";
            new_str1 += t1[0];
            for (int i = 1; i < t1.Count(); i++)
            {
                if (t1[i] != new_str1[new_str1.Count() - 1])
                    new_str1 += t1[i];
            }

            string new_str2 = "";
            new_str2 += t2[0];
            for (int i = 1; i < t2.Count(); i++)
            {
                if (t2[i] != new_str2[new_str2.Count() - 1])
                    new_str2 += t2[i];
            }

            t1 = new_str1.ToArray();
            t2 = new_str2.ToArray();
            new_str1 = ""+t1[0];
            new_str2 = ""+t2[0];

            for (int i = 1; i < t1.Count(); i++)
            {
                bool flag = false;
                foreach (char p in del)
                {
                    if (t1[i] == p)
                        flag = true;
                }
                if (!flag)
                    new_str1 += t1[i];                
            }

            for (int i = 1; i < t2.Count(); i++)
            {
                bool flag = false;
                foreach (char p in del)
                {
                    if (t2[i] == p)
                        flag = true;
                }
                if (!flag)
                    new_str2 += t2[i];

            }

            while (new_str1.Count() < 4)
                new_str1 += " ";
            while (new_str2.Count() < 4)
                new_str2 += " ";

            if (new_str1.Substring(0, 4) == new_str2.Substring(0, 4))
                return true;
            else
                return false;
        }

    }
}
