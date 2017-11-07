using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Method1_Test()
        {
            // данные
            string s1 = "MacDonalds";
            string s2 = "mcdonalds";

            // действие
            Methods.Jaro m = new Methods.Jaro(s1, s2);
            double rez = m.Func();

            // сравнение
            Assert.AreEqual(0.74, rez);
        }

        [TestMethod]
        public void Method1_Null_Test()
        {
            // данные
            string s1 = "";
            string s2 = "";

            // действие
            Methods.Jaro m = new Methods.Jaro(s1, s2);
            double rez = m.Func();

            // сравнение
            Assert.AreEqual(1, rez);
        }

        [TestMethod]
        public void Method2_Test()
        {
            // данные
            string s1 = "MacDonalds";
            string s2 = "mcdonalds";

            // действие
            Methods.JaroVincler m = new Methods.JaroVincler(s1, s2);
            bool rez = m.Func();

            // сравнение
            Assert.AreEqual(true, rez);
        }

        [TestMethod]
        public void Method2_Null_Test()
        {
            // данные
            string s1 = "";
            string s2 = "";

            // действие
            Methods.JaroVincler m = new Methods.JaroVincler(s1, s2);
            bool rez = m.Func();

            // сравнение
            Assert.AreEqual(true, rez);
        }

        [TestMethod]
        public void Method3_Test()
        {
            // данные
            string s1 = "MacDonalds";
            string s2 = "mcdonalds";

            // действие
            Methods.Levenstein m = new Methods.Levenstein(s1, s2);
            double rez = m.Func();

            // сравнение
            Assert.AreEqual(0.145, Math.Round(rez, 3));
        }

        [TestMethod]
        public void Method3_Null_Test()
        {
            // данные
            string s1 = "";
            string s2 = "";

            // действие
            Methods.Levenstein m = new Methods.Levenstein(s1, s2);
            double rez = m.Func();

            // сравнение
            Assert.AreEqual(0, Math.Round(rez, 3));
        }
    }
}
