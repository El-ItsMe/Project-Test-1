using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using TestingProject1;

namespace TestProject1.Tests
{
    public class CycleTests
    {
        //возведение в степень (циклы пример-1)
        [TestCase(2, 5, 32)]
        [TestCase(-2, 5, -32)]
        [TestCase(2, -3, 0.125)]
        public void GetPowerOfNumberTest(double number, int power, double expected)
        {
            double actual = Cycle.GetPowerOfNumber(number, power);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, -5)]
        [TestCase(0, -3)]
        public void GetPowerOfNumberTest_WhenPowerIsNegativeAndNumberEqualZero_ShouldThrowArgumentException(double number, int power)
        {
            Assert.Throws<ArgumentException>(() => Cycle.GetPowerOfNumber(number, power));
        }

        //числа от 1 до 1000, которые делятся на А (циклы-пример 2)
        [TestCase(100, new int[] {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000})]
        public void GetNumbersDivisionByATest(int numberA, int[] expected)
        {
            int[] actual = Cycle.GetNumbersDivisionByA(numberA);
            Assert.AreEqual(actual, expected);
        }


        //количество целых чисел, квадрат которых меньших заданного (циклы-пример 3)
        [TestCase(19, 4)]
        public void GetAmountOfNumberTest(int numberA, int expected)
        {
            int actual = Cycle.GetAmountOfNumber(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5)]
        public void GetAmoutOfNumberTest_WhenAEqualNegativeNumber_ShouldThrowArgumentException(int numberA)
        {
            Assert.Throws<ArgumentException>(() => Cycle.GetAmountOfNumber(numberA));
        }

        //Второй наибольший делитель (циклы-пример4)
        [TestCase(19, 1)]
        [TestCase(18, 9)]
        public void FindSecondLargestDivisorTest(int numberA, int expected) 
        {
            int actual = Cycle.FindSecondLargestDivisor(numberA);
            Assert.AreEqual(actual, expected);
        }

        //Вывести сумму чисел, нацело делящихся на 7 в диапозоне(циклы пример-5)
        [TestCase(10, 25, 35)]
        [TestCase(18, 1, 21)]

        public void GetTheSumOfNumbersDivisibleBy7Test(int numberA, int numberB, int expected)
        {
            int actual = Cycle.GetTheSumOfNumbersDivisibleBy7(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        public void GetTheSumOfNumbersDivisibleBy7_WhenAndBEqualZero_ShouldThrowArgumentException(int numberA, int numberB) 
        {
            Assert.Throws<ArgumentException>(() => Cycle.GetTheSumOfNumbersDivisibleBy7(numberA, numberB));
        }

        //Вывести N-ное число ряда Фибонначи (циклы-пример6)
        [TestCase(5, 5)]
        [TestCase(8, 21)]

        public void OutputNNumberValue(int numberN, int expected)
        {
            int actual = Cycle.OutputNNumberValue(numberN);
            Assert.AreEqual(expected, actual);
        }

        //Найти НОД (Алгоритм Эвклида) (циклы- пример7)
        [TestCase(12, 18, 6)]
        [TestCase(24, 21, 3)]

        public void GetGreatestCommonDivisorTest(int number1, int number2, int expected)
        {
            int actual = Cycle.GetGreatestCommonDivisor(number1, number2);
            Assert.AreEqual(expected, actual);
        }

        //Найти число методом половинного деления (циклы-пример8)
        [TestCase(125, 5)]
        [TestCase(216, 6)]

        public void FindNumberTest(int GiveNumber, int expected)
        {
            int actual = Cycle.FindNumber(GiveNumber);
            Assert.AreEqual(expected, actual);
        }

        //Найти количество нечётных цифр в числе (циклы-пример9)
        [TestCase(12831, 3)]
        [TestCase(10034, 2)]

        public void GetTheNumberOfOddDigitsTest(int number, int expected)
        {
            int actual = Cycle.GetTheNumberOfOddDigits(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22222)]
        public void GetTheNumberOfOddDigits_WhenNumberIsEven_ShouldArgumentException(int number)
        {
            Assert.Throws<ArgumentException>(() => Cycle.GetTheNumberOfOddDigits(number));
        }


        //Зеркальное отображение числа (циклы-пример10)
        [TestCase(10034, 43001)]
        [TestCase(10000, 1)]

        public void FindMirrorNumberTest(int number, int expected)
        {
            int actual = Cycle.FindMirrorNumber(number);
            Assert.AreEqual(expected, actual);
        }

        //Вывести числа, где сумма чёт цифр больше нечёт(циклы-пример11)
        [TestCase(110, 123, new int[] {114, 116, 118, 120, 122})]
        public void FindNSumEvenNumbersMoreThanOddTest(int number1, int number2, int[] expected)
        {
            int[] actual = Cycle.FindNSumEvenNumbersMoreThanOdd(number1, number2);
            Assert.AreEqual(actual, expected);
        }

        //Проверить совпадение цифр в числах (циклы-пример12)
        [TestCase(12831, 3333, "Да")]
        [TestCase(10034, 22222, "Нет")]

        public void WriteValueTest(int number1, int number2, string expected)
        {
            string actual = Cycle.WriteValue(number1, number2);
            Assert.AreEqual(expected, actual);
        }
    }
}

