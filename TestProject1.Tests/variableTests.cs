using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using TestingProject1;

namespace TestProject1.Tests
{
    public class variableTests
    {
        //найти значение выражения (переменные пример2)
        [TestCase(2, 4, 13)]
        [TestCase(-1, 3, 1)]
        [TestCase(0, 5, 5)]
        [TestCase(2, 0, -5)]

        public void GetExpressionValueTest(double divisible, double divisor, double expected)
        {
            double actual = variable.GetExpressionValue(divisible, divisor);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(0, 0)]
        public void GetExpressionValueTest_WhenaIsEqualb_ShouldThrowArgumentExpection(int divisible, int divisor)
        {
            Assert.Throws<ArgumentException>(() => variable.GetExpressionValue(divisible, divisor));
        }

        //Вывести значение линейного уравнения (переменные пример-4)
        [TestCase(10, 4, 2, -0.2)]
        [TestCase(2, 4, 10, 3)]

        public void GetValueXTest(double a, double b, double c, double expected) 
        {
            double actual = variable.GetValueX(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 8)]
        [TestCase(0, 4, 6)]
        public void GetValueXTest_WhenaEqual0_ShouldThrowArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => variable.GetValueX(a, b, c));
        }

        //Вывести уравнение прямой (переменные пример-5)
        [TestCase(-2, 4, -6, 2, "y = 2*x + 8")]
        public void FindStraightLineEquationTest(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = variable.FindStraightLineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase (-2, 4, -2, 4)]
        [TestCase (8, 3, 6, 3)]
        public void FindStraightLineEquation_Whenx1Equalx2andy1Equaly2_ShouldThrowArgumentException(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<ArgumentException>(() => variable.FindStraightLineEquation(x1, y1, x2, y2));
        }
    }
}