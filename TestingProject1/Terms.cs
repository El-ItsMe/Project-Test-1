using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject1
{
    public static class Terms
    {
        public static double FindResult(double a, double b)
        {
            double res;

            if (a > b)
            {
                res = a + b;
            }
            else if (a == b)
            {
                res = a * b;
            }
            else
            {
                res = a - b;
            }

            return res;
        }

        public static string FindQuarter(double x, double y) //dz-2-primer2
        {
            string res;
            if (x > 0 && y > 0)
            {
                res = "1-ая четверть";
            }
            else if (x < 0 && y > 0)
            {
                res = "2-ая четверть";
            }
            else if (x < 0 && y < 0)
            {
                res = "3-я четверть";
            }
            else if (x > 0 && y < 0)
            {
                res = "4-ая четверть";
            }
            else
            {
                res = "0";
            }
            return res;
        }

          public static string OutputInAscendingOrder(double a, double b, double c) //dz-2-primer3
        {
            string AscendingOrder;
            if (a > b && b > c)
            {
                AscendingOrder = $"{c},{b},{a}";
            }
            else if (a > c && c > b)
            {
                AscendingOrder = $"{b},{c},{a}";
            }
            else if (b > a && a > c)
            {
                AscendingOrder = $"{c},{a},{b}";
            }
            else if (b > c && c > a)
            {
                AscendingOrder = $"{a},{c},{b}";
            }
            else if (c > b && b > a)
            {
                AscendingOrder = $"{a},{b},{c}";
            }
            else if (c > a && a > b)
            {
                AscendingOrder = $"{b},{a},{c}";

            }
            else
            {
                throw new ArgumentException("Same Numbers");
            }
            return AscendingOrder;
        }

        public static string GetRootOfTheEquation(double a, double b, double c) //primer4
        {
            string result;
            double D = b * b - 4 * a * c;
            double X1;
            double X2;
            if (D < 0)
            {
                throw new ArgumentException("Discriminant < 0");
            }
            else if (D == 0)
            {
                X1 = -b / (2 * a);
                X2 = X1;
            }
            else
            {
                X1 = (-b + Math.Sqrt(D)) / (2 * a);
                X2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            return result = ($"X1 = {X1}, X2 = {X2}");
        }


        

        public static string OutputNumber(int a) //dz2-primer5       
        {
            string res = "";
            string tens = "";
            string units = "";
            int castnoe = a / 10;
            if (castnoe == 1)
            {
                switch (a % 10)
                {
                    case 0:
                        tens = "десять";
                        units = "";
                        break;
                    case 1:
                        tens = "одиннадцать";
                        units = "";
                        break;
                    case 2:
                        tens = "двенадать";
                        units = "";
                        break;
                    case 3:
                        tens = "тринадцать";
                        units = "";
                        break;
                    case 4:
                        tens = "четырнадцать";
                        units = "";
                        break;
                    case 5:
                        tens = "пятнадцать";
                        units = "";
                        break;
                    case 6:
                        tens = "шестнадцать";
                        units = "";
                        break;
                    case 7:
                        tens = "семнадцать";
                        units = "";
                        break;
                    case 8:
                        tens = "восемнадцать";
                        units = "";
                        break;
                    case 9:
                        tens = "девятнадцать";
                        units = "";
                        break;
                }
            }
            
            else
            {
                switch (castnoe)
                {
                    case 2:
                        tens = "двадцать ";
                        break;
                    case 3:
                        tens = "тридцать ";
                        break;
                    case 4:
                        tens = "сорок ";
                        break;
                    case 5:
                        tens = "пятьдесят ";
                        break;
                    case 6:
                        tens = "шестьдесят ";
                        break;
                    case 7:
                        tens = "семьдесят ";
                        break;
                    case 8:
                        tens = "восемьдесят ";
                        break;
                    case 9:
                        tens = "девяносто ";
                        break;
                    default: break;
                }

                switch (a % 10)
                {
                    case 1:
                        units = "один";
                        break;
                    case 2:
                        units = "два";
                        break;
                    case 3:
                        units = "три";
                        break;
                    case 4:
                        units = "четыре";
                        break;
                    case 5:
                        units = "пять";
                        break;
                    case 6:
                        units = "шесть";
                        break;
                    case 7:
                        units = "семь";
                        break;
                    case 8:
                        units = "восемь";
                        break;
                    case 9:
                        units = "девять";
                        break;
                }
            }
            res = tens + units;
            
            if (a > 99)
            { 
                throw new ArgumentException("a > 99");
            }
            if (a < 10)
            {
                throw new ArgumentException("a < 10");
            }
            return res;
        }
    }
}
