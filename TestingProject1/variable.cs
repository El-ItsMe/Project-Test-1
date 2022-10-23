using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject1
{

    public static class variable
    {
        //Найти результат деления и его остаток (оформлено в два метода: переменные-пример1)
        public static double GetRemainder(double a, double b)
        {
            double remainder;
            remainder = a % b;
            return remainder;
        }

        public static double GetDivisionResult(double a, double b)
        {
            double DivisionResult;
            DivisionResult = a % b;
            return DivisionResult;
        }

        //найти значение выражения (переменные пример2)
        public static double GetExpressionValue(double divisible, double divisor)
        {
            double res;
            
               res = (5 * divisible + divisor* divisor) / (divisor - divisible);
            if (divisible == divisor)
            {
                throw new ArgumentException("a==b");
            }
            return res;
        }

        //Вывести значение линейного уравнения (переменные пример-4)
        public static double GetValueX(double a, double b, double c)
        {
            double res;
            res = ((c - b) / a);

            if (a == 0)
            {
                throw new ArgumentException("a==0");
            }
            return res;
        }

        //Вывести уравнение прямой (переменные пример-5)
        public static string FindStraightLineEquation(double x1, double y1, double x2, double y2)
        {
            double k;
            double b;
            string res;
            k = (x1 - x2) / (y1 - y2);
            b = y1 - k * x1;

            if (x1 == x2 && y1 == y2)
            {
                throw new ArgumentException("x1==x2 and y1==y2");
            }
            if (y1 == y2)
            {
                throw new ArgumentException("y1==y2");
            }

            return res = ($"y = {k}*x + {b}");
        }

    }
}
