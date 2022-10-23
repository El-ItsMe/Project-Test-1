using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject1
{
    public static class Terms
    {
        //обычное сравнение (условия-пример1)
        public static double FindResult(double number1, double number2)
        {
            double res;

            if (number1 > number2)
            {
                res = number1 + number2;
            }
            else if (number1 == number2)
            {
                res = number1 * number2;
            }
            else
            {
                res = number1 - number2;
            }

            return res;
        }


        //определение четверти (условия-пример2)
        public static string FindQuarter(double x, double y)
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

        //в порядке возрастания(условия-пример3)
        public static int[] OutputInAscendingOrder(int[] array)
        {
                int[] arrayreverse = new int[3];
                for (int i = 0; i < 2; i++)
                {
                    int indexmin = i;
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (array[j] < array[indexmin])
                        {
                            indexmin = j;
                        }
                    }
                    int tmp = array[indexmin];
                    array[indexmin] = array[i];
                    array[i] = tmp;
                }
                return array;
        }

        //корни квадратного уравнения (условия пример4)

        public static string GetRootOfTheEquation(double a, double b, double c)
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



        //вывод чисел в виде строки(условия-пример5)
        public static string OutputNumber(int numberA)      
        {
            string res = "";
            string tens = "";
            string units = "";
            int castnoe = numberA / 10;
            if (castnoe == 1)
            {
                switch (numberA % 10)
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

                switch (numberA % 10)
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
            
            if (numberA > 99)
            { 
                throw new ArgumentException("a > 99");
            }
            if (numberA < 10)
            {
                throw new ArgumentException("a < 10");
            }
            return res;
        }
    }
}
