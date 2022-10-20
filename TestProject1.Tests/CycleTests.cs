using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using TestingProject1;

namespace TestProject1.Tests
{
    public class CycleTests
    {
        [TestCase(2, 5, 32)]
        [TestCase(-2, 5, -32)]
        [TestCase(2, -3, 0.125)]
        public void GetPowerOfNumberTest(double number, int power, double expected) //1
        {
            double actual = Cycle.GetPowerOfNumber(number, power);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, -5)]
        [TestCase(0, -3)]
        public void GetPowerOfNumberTest_WhenPowerIsNegativeAndNumberEqualZero_SholdThrowArgumentException(double number, int power)
        {
            Assert.Throws<ArgumentException>(() => Cycle.GetPowerOfNumber(number, power));
        }

        [TestCase(19, 4)]
        public void GetAmountOfNumber(int A, int expected) //3
        {
            int actual = Cycle.GetAmountOfNumber(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5)]
        public void GetAmoutOfNumberTest_WhenAEqualNegativeNumber_SholdThrowArgumentException(int A)
        {
            Assert.Throws<ArgumentException>(() => Cycle.GetAmountOfNumber(A));
        }

        [TestCase(19, 1)]
        [TestCase(18, 9)]
        public void FindSecondLargestDivisorTest(int a, int expected)
        {
            int actual = Cycle.FindSecondLargestDivisor(a);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(10, 25, 35)]
        [TestCase(18, 1, 21)]

        public void GetTheSumOfNumbersDivisibleBy7Test(int a, int b, int expected)
        {
            int actual = Cycle.GetTheSumOfNumbersDivisibleBy7(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        public void GetTheSumOfNumbersDivisibleBy7_WhenAndBEqualZero_SholdThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Cycle.GetTheSumOfNumbersDivisibleBy7(a, b));
        }

        [TestCase(5, 5)]
        [TestCase(8, 21)]

        public void OutputNNumberValue(int n, int expected)
        {
            int actual = Cycle.OutputNNumberValue(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 18, 6)]
        [TestCase(24, 21, 3)]

        public void GetGreatestCommonDivisorTest(int number1, int number2, int expected)
        {
            int actual = Cycle.GetGreatestCommonDivisor(number1, number2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12831, 3)]
        [TestCase(10034, 2)]

        public void GetTheNumberOfOddDigitsTest(int number, int expected)
        {
            int actual = Cycle.GetTheNumberOfOddDigits(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22222)]
        public void GetTheNumberOfOddDigits_WhenNumberIsEven_SholdArgumentException(int number)
        {
            Assert.Throws<ArgumentException>(() => Cycle.GetTheNumberOfOddDigits(number));
        }
    }
}

