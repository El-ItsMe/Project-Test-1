using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using TestingProject1;

namespace TestProject1.Tests
{
    public class TermsTests
    {
        //обычное сравнение (условия-пример1)
        [TestCase(1.2, 1, 2.2)]
        [TestCase(5, 5, 25)]
        [TestCase(8, 10, -2)]

        public void FindResultTest(double number1, double number2, double expected) 
        {
            double actual = Terms.FindResult(number1, number2);
            Assert.AreEqual(expected, actual);
        }

        //определение четверти (условия-пример2)
        [TestCase(2.3, 8.1, "1-ая четверть")]
        [TestCase(2, -8.1, "4-ая четверть")]
        [TestCase(-3, 8.1, "2-ая четверть")]
        [TestCase(-2.3, -8.1, "3-я четверть")]
        [TestCase(0, 0, "0")]
        public void FindQuraterTest(double x, double y, string expected) 
        {
            string actual = Terms.FindQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        //в порядке возрастания(условия-пример3)
        [TestCase(new int[] { 3, 1, 8 }, new int[] { 1, 3, 8 })]
        [TestCase(new int[] { 4, 2, 3 }, new int[] { 2, 3, 4 })]
        public void OutputInAscendingOrderTest(int[] array, int[] expected)
        {
            int[] actual = Terms.OutputInAscendingOrder(array);
            Assert.AreEqual(expected, actual);
        }

        //корни квадратного уравнения (условия пример4)
        [TestCase(1, 2, -3, "X1 = 1, X2 = -3")]
        [TestCase(1, 4, 4, "X1 = -2, X2 = -2")]

        public void GetRootOfTheEquationTest(double a, double b, double c, string expected)
        {
            string actual = Terms.GetRootOfTheEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 1, 4)]
        public void GetRootOfTheEquation_DiscriminantEqual0_SholdThrowArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => Terms.GetRootOfTheEquation(a, b, c));
        }

        //вывод чисел в виде строки(условия-пример5)
        [TestCase(21, "двадцать один")]
        [TestCase(18, "восемнадцать")]
        public void OutputNumberTest(int a, string expected) 
        {
            string actual = Terms.OutputNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void OutputNumber_WhenAEqualLessthat10_SholdThrowArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() => Terms.OutputNumber(a));
        }

        [TestCase(221)]
        public void OutputNumber_WhenAEqualOver99_SholdThrowArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() => Terms.OutputNumber(a));
        }
    }
}
