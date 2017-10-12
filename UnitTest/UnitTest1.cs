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
            Methods.Method1 m = new Methods.Method1(s1, s2);
            double rez = m.Func();

            // сравнение
            Assert.AreEqual(0.74, rez);
        }

        [TestMethod]
        public void Method2_Test()
        {
            // данные
            string s1 = "MacDonalds";
            string s2 = "mcdonalds";

            // действие
            Methods.Method2 m = new Methods.Method2(s1, s2);
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
            Methods.Method3 m = new Methods.Method3(s1, s2);
            double rez = m.Func();

            // сравнение
            Assert.AreEqual(0.045, Math.Round(rez, 3));
        }
    }
}
