using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using TestingProject1;

namespace TestProject1.Tests
{
    public class ArrayStorageTests
    {
        //найти минимальный элемент массива (массивы-пример1)
        [TestCase(new int[] { 1, 2, 5, 2 }, 1)]
        public void GetMinValueTest(int[] a, int expected)
        {
            int actual = ArrayStorage.GetMinValue(a);
            Assert.AreEqual(expected, actual);
        }

        //найти максимальный элемент массива (массивы-пример2)
        [TestCase(new int[] { 1, 2, 5, 2 }, 5)]
        public void GetMaxValueTest(int[] a, int expected)
        {
            int actual = ArrayStorage.GetMaxValue(a);
            Assert.AreEqual(expected, actual);
        }

        //найти индекс минимального элемента массива (массивы-пример3)
        [TestCase(new int[] { 8, 15, 3, 1, 20, 5 }, 3)]
        public void GetIndexMinValueTest(int[] a, int expected)
        {
            int actual = ArrayStorage.GetIndexMinValue(a);
            Assert.AreEqual(actual, expected);
        }

        //найти индекс максимального элемента массива (массивы-пример4)
        [TestCase(new int[] { 8, 15, 3, 1, 20, 5 }, 4)]
        public void GetIndexMaxValueTest(int[] a, int expected)
        {
            int actual = ArrayStorage.GetIndexMaxValue(a);
            Assert.AreEqual(actual, expected);
        }


        // Найти сумму элементов массива с нечёткими индексами (массивы-пример5)
        [TestCase(new int[] { 1, 8, 3, 9, 11, 5 }, 22)]
        public void GetSumOfOddIndexTest(int[] arrayNumbers, int expected)
        {
            int actual = ArrayStorage.GetSumOfOddIndex(arrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        //Расстановка элемента массива в обратном порядке (массивы пример-6)
        [TestCase(new int[] { -1, 8, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1, 8, -1 })]
        [TestCase(new int[] { -2, 0, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1, 0, -2 })]
        public void GetReverseArrayTest(int[] a, int[] expected)
        {
            int[] actual = ArrayStorage.GetReverseArray(a);
            Assert.AreEqual(actual, expected);
        }

        //Количество нечётных элементов массива (массивы-пример7)
        [TestCase(new int[] { 1, 8, 3, 9, 11, 5 }, 5)]
        public void GetNumbersCountTest(int[] arrayNumbers, int expected)
        {
            int actual = ArrayStorage.GetNumbersCount(arrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        
        [TestCase(new int[] { 10, 8, 5, 3, 2, 6 }, new int[] {3, 2, 6, 10, 8, 5 })]
        [TestCase(new int[] { -5, -6, -7, -8, 0, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, 0, -5, -6, -7, -8 })]
        public void GetReverseFirstAndSecondPartTest(int[] a, int[] expected)
        {
        int[] actual = ArrayStorage.GetReverseFirstAndSecondPart(a);
        Assert.AreEqual(actual, expected);
        }
    }
}
