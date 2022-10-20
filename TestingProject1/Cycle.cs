using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject1
{
    public static class Cycle
    {
        public static double GetPowerOfNumber(double number, int power) //возведение в степень
        {
            int i;
            double result = 1;
            double result1 = 1;
            if (power > 0)
            {
                for (i = 1; i <= power;)
                {
                    result = result * number;
                    i = i + 1;
                }
            }
            else if (power < 0)
            {
                for (i = power; i < 0;)
                {
                    result1 = result1 * number;
                    i = i + 1;
                }
                result = 1 / result1;
            }
            else
            {
                result = 0;
            }

            if (power < 0 && number == 0)
            {
                throw new ArgumentException("division by zero"); 
            }
            return result;
        }

        public static int GetAmountOfNumber(int A) //количество целых чисел, квадрат которых меньших заданного
        {
            if (A < 0)
            {
                throw new ArgumentException("Write wrong arguments");
            }
            else
            {
                int i = 1;
                int amount = 0;
                for (i = 1; i * i < A; i++)
                {
                    amount = amount + 1;
                }
                return amount;
            }
        }

        public static int FindSecondLargestDivisor(int a) //Второй наибольший делитель
        {
            int nod = 0;
            for (int i = a-1; i < a; i--)
            {
                if (a % i == 0)
                {
                    nod = i;
                    break;
                }
            }
            return nod;
        }

        public static int GetTheSumOfNumbersDivisibleBy7(int a, int b)//Сумму чисел, нацело делящихся на 7
        {
            int sum = 0;
            if (a == b)
            {
                throw new ArgumentException("a==b");
            }
            else if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }
            else if (b < a)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }

            return sum;
        }

        public static int OutputNNumberValue(int n) //Вывести N-ное число ряда Фибонначи
        {
            int firstnumber = 1;
            int secondnumber = 1;
            int sum = 0;
            int i;
            for (i = 1; i <= n - 2; i++)
            {
                sum = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = sum;
            }
            return secondnumber;
        }

        public static int GetGreatestCommonDivisor(int number1, int number2)//Найти НОД
        {
            int gcd;
            int remaider;
            while (number1 % number2 != 0)
            {
                remaider = number1 % number2;
                number1 = number2;
                number2 = remaider;
            }
            gcd = number2;
            return gcd;
        }

        public static int GetTheNumberOfOddDigits(int number)//Найти количество нечётных цифр в числе
        {
            int i = number;
            int l;
            int k = 0;
            for (i = number; i > 0; i = i / 10)
            {
                l = i % 10;
                if ((l + 2) % 2 == 1)
                {
                    k = k + 1;
                }
            }
            if (k == 0)
            {
                throw new ArgumentException("This is an even number");
            }
            return k;
        }
    }
}
