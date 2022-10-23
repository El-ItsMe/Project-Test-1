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
        public void GetMinValueTest(int[] arrayNumbers, int expected)
        {
            int actual = ArrayStorage.GetMinValue(arrayNumbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {})]
        public void GetMinValueTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] arrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetMinValue(arrayNumbers));
        }

        //найти максимальный элемент массива (массивы-пример2)
        [TestCase(new int[] { 1, 2, 5, 2 }, 5)]
        public void GetMaxValueTest(int[] arrayNumbers, int expected)
        {
            int actual = ArrayStorage.GetMaxValue(arrayNumbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetMaxValueTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] arrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetMaxValue(arrayNumbers));
        }

        //найти индекс минимального элемента массива (массивы-пример3)
        [TestCase(new int[] { 8, 15, 3, 1, 20, 5 }, 3)]
        public void GetIndexMinValueTest(int[] arrayNumbers, int expected)
        {
            int actual = ArrayStorage.GetIndexMinValue(arrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetIndexMinValueTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] arrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetIndexMinValue(arrayNumbers));
        }

        //найти индекс максимального элемента массива (массивы-пример4)
        [TestCase(new int[] { 8, 15, 3, 1, 20, 5 }, 4)]
        public void GetIndexMaxValueTest(int[] arrayNumbers, int expected)
        {
            int actual = ArrayStorage.GetIndexMaxValue(arrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetIndexMaxValueTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] arrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetIndexMaxValue(arrayNumbers));
        }


        // Найти сумму элементов массива с нечёткими индексами (массивы-пример5)
        [TestCase(new int[] { 1, 8, 3, 9, 11, 5 }, 22)]
        public void GetSumOfOddIndexTest(int[] arrayNumbers, int expected)
        {
            int actual = ArrayStorage.GetSumOfOddIndex(arrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetSumOfOddIndexTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] arrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetSumOfOddIndex(arrayNumbers));
        }

        //Расстановка элемента массива в обратном порядке (массивы пример-6)
        [TestCase(new int[] { -1, 8, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1, 8, -1 })]
        [TestCase(new int[] { -2, 0, 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1, 0, -2 })]
        public void GetReverseArrayTest(int[] arrayNumbers, int[] expected)
        {
            int[] actual = ArrayStorage.GetReverseArray(arrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetReverseArrayTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] arrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetReverseArray(arrayNumbers));
        }

        //Количество нечётных элементов массива (массивы-пример7)
        [TestCase(new int[] { 1, 8, 3, 9, 11, 5 }, 5)]
        public void GetNumbersCountTest(int[] arrayNumbers, int expected)
        {
            int actual = ArrayStorage.GetNumbersCount(arrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetNumbersCountTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] arrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetReverseArray(arrayNumbers));
        }

        //Поменять местами первую и вторую половину массива (массивы-пример8)
        [TestCase(new int[] { 10, 8, 5, 3, 2, 6 }, new int[] {3, 2, 6, 10, 8, 5 })]
        [TestCase(new int[] { -5, -6, -7, -8, 0, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, 0, -5, -6, -7, -8, })]
        public void GetReverseFirstAndSecondPartTest(int[] arrayNumbers, int[] expected)
        {
        int[] actual = ArrayStorage.GetReverseFirstAndSecondPart(arrayNumbers);
        Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetReverseFirstAndSecondPartTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] arrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetReverseArray(arrayNumbers));
        }

        //Сортировка методом пузырька (массивы-пример9)
        [TestCase(new int[] { 15, 1, 5, 31, 2, 6 }, new int[] {1, 2, 5, 6, 15, 31 })]
        public void GetBumbleSortTest(int[] ArrayNumbers, int[] expected)
        {
            int[] actual = ArrayStorage.GetBumbleSort(ArrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetBumbleSortTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] ArrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetBumbleSort(ArrayNumbers));
        }

        //Сортировка методом вставки (массивы-пример10)
        [TestCase(new int[] { 1, 8, 9, 3, 18, 15 }, new int[] {18, 15, 9, 8, 3, 1})]
        public void GetSelectIncreseSort(int[] ArrayNumbers, int[] expected)
        {
            int[] actual = ArrayStorage.GetSelectIncreseSort(ArrayNumbers);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { })]
        public void GetSelectSortTest_WhenLengthIsEquaZero_ShouldThrowArgumentExpection(int[] ArrayNumbers)
        {
            Assert.Throws<ArgumentException>(() => ArrayStorage.GetReverseArray(ArrayNumbers));
        }
    }
}
