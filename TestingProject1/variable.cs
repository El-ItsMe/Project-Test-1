using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject1
{
    public static class variable
    {
        public static double GetExpressionValue(double a, double b)
        {

            double res;
            
               res = (5 * a + b*b) / (b - a);
            if (a==b)
            {
                throw new ArgumentException("a==b");
            }
            return res;
        }

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
