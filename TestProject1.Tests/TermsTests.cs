using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using TestingProject1;

namespace TestProject1.Tests
{
    public class TermsTests
    {
        [TestCase(1.2, 1, 2.2)]
        [TestCase(5, 5, 25)]
        [TestCase(8, 10, -2)]

        public void FindResultTest(double a, double b, double expected) //dz2-primer1
        {
            double actual = Terms.FindResult(a, b);
            Assert.AreEqual(expected, actual);
        }

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

        [TestCase(21, "двадцать один")]
        [TestCase(18, "восемнадцать")]
        public void OutputNumberTest(int a, string expected)
        {
            string actual = Terms.OutputNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(221)]
        [TestCase(9)]
        public void OutputNumber_WhenAEqual_SholdThrowArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() => Terms.OutputNumber(a));
        }
    }
}
