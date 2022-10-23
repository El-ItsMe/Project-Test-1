using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject1
{
    public static class Cycle
    {
        //возведение в степень (циклы пример-1)
        public static double GetPowerOfNumber(double number, int power) 
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

        //числа от 1 до 1000, которые делятся на А (циклы-пример 2)
        public static int[] GetNumbersDivisionByA(int numberA) 
        {
            int i;
            int j=0;
            int amount=0;
            for (i = 1; i <= 1000; i++)
            {
                if ((i+numberA) % numberA == 0)
                {
                    amount = amount + 1;
                }
            }

            int[] NumberArray = new int[amount];
            for (i = 1; i <= 1000; i++)
            {
                if (i % numberA == 0)
                {
                    NumberArray[j] = i;
                    j = j + 1;
                }
            }
            return NumberArray;
        }

        //количество целых чисел, квадрат которых меньших заданного (циклы-пример 3)
        public static int GetAmountOfNumber(int numberA) 
        {
            if (numberA < 0)
            {
                throw new ArgumentException("Write wrong arguments");
            }
            else
            {
                int i = 1;
                int amount = 0;
                for (i = 1; i * i < numberA; i++)
                {
                    amount = amount + 1;
                }
                return amount;
            }
        }

        //Второй наибольший делитель (циклы-пример4)
        public static int FindSecondLargestDivisor(int numberA) 
        {
            int nod = 0;
            for (int i = numberA-1; i < numberA; i--)
            {
                if (numberA % i == 0)
                {
                    nod = i;
                    break;
                }
            }
            return nod;
        }

        //Вывести сумму чисел, нацело делящихся на 7 в диапозоне(циклы пример-5)
        public static int GetTheSumOfNumbersDivisibleBy7(int numberA, int numberB)
        {
            int sum = 0;
            if (numberA == numberB)
            {
                throw new ArgumentException("a==b");
            }
            else if (numberB > numberA)
            {
                for (int i = numberA; i <= numberB; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }
            else if (numberB < numberA)
            {
                for (int i = numberB; i <= numberA; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }

            return sum;
        }

        //Вывести N-ное число ряда Фибонначи (циклы-пример6)
        public static int OutputNNumberValue(int numberN) 
        {
            int firstnumber = 1;
            int secondnumber = 1;
            int sum = 0;
            int i;
            for (i = 1; i <= numberN - 2; i++)
            {
                sum = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = sum;
            }
            return secondnumber;
        }

        //Найти НОД (Алгоритм Эвклида) (циклы- пример7)
        public static int GetGreatestCommonDivisor(int number1, int number2)
        {
            int gcd; //greatest common divisor
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

        //Найти число методом половинного деления (циклы-пример8)
        public static int FindNumber(int GiveNumber) 
        {
            int left=0;
            int right = GiveNumber;
            int N = (left+right)/2;
            while (Math.Pow(N, 3) != GiveNumber)
            {
                if (Math.Pow(N, 3) > GiveNumber)
                {
                    right = N;
                }
                else
                { 
                    left = N;
                }
                N = (left+right)/2;
            }
            return N;
        
        }

        //Найти количество нечётных цифр в числе (циклы-пример9)
        public static int GetTheNumberOfOddDigits(int number)
        {
            int i = number;
            int l;
            int amount = 0;
            for (i = number; i > 0; i = i / 10)
            {
                l = i % 10;
                if ((l + 2) % 2 == 1)
                {
                    amount = amount + 1;
                }
            }
            if (amount == 0)
            {
                throw new ArgumentException("This is an even number");
            }
            return amount;
        }

        //Зеркальное отображение числа (циклы-пример10)
        public static int FindMirrorNumber(int number)
        {
            int PartOfNumber = number;
            int result = 0;
            while (number % 10 > 0 || number / 10 > 0)
            {
                PartOfNumber = number % 10;
                result = result * 10 + PartOfNumber;
                number = number / 10;
            }
            return result;
        }

        //Вывести числа, где сумма чёт цифр больше нечёт(циклы-пример11)
        /*Небольшое пояснение к решению. Задачу решила в два цикла, где в первом произвожу счёт
        элементов, в котором сумма чёт цифр больше нечёт. Во втором цикле, провожу работу с новым созданым массивом
        размера того счёта, котрый получила в прошлом цикле. Далее заполнение и вывод.*/
        public static int [] FindNSumEvenNumbersMoreThanOdd(int number1, int number2)
        {
            int i;
            int j;
            int amount = 0;
            int sum_even_numbers;
            int sum_odd_numbers;
            int remainder;
            
            for (i = number1; i <= number2; i++)
            {
                remainder = 0;
                sum_even_numbers = 0;
                sum_odd_numbers = 0;
                for (j = i; j > 0; j = j / 10)
                {
                    remainder = j % 10;
                    if ((remainder + 2) % 2 == 0)
                    {
                        sum_even_numbers = sum_even_numbers + remainder;
                    }
                    else
                    {
                        sum_odd_numbers = sum_odd_numbers + remainder;
                    }
                }
                if (sum_even_numbers > sum_odd_numbers)
                {
                    amount = amount + 1;
                }
            }
                
            i = 0;
            j = 0;
            int l = 0;
            int[] ArrayOfEvenNumbers = new int[amount];
            for (i = number1; i <= number2; i++)
            {
                remainder = 0;
                sum_even_numbers = 0;
                sum_odd_numbers = 0;
                for (j = i; j > 0; j = j / 10)
                {
                    remainder = j % 10;
                    if ((remainder + 2) % 2 == 0)
                    {
                        sum_even_numbers = sum_even_numbers + remainder;
                    }
                    else
                    {
                        sum_odd_numbers = sum_odd_numbers + remainder;
                    }
                }
                if (sum_even_numbers > sum_odd_numbers)
                {
                    ArrayOfEvenNumbers[l] = i;
                    l = l + 1;
                }
            }
            return ArrayOfEvenNumbers;

        }

        //Проверить совпадение цифр в числах (циклы-пример12)
        public static string WriteValue(int number1, int number2) 
        {
            bool IsEqual = false;
            int i = number1;
            int j;
            int remainder_number1;
            int remainder_number2;
            string value;
            for (i = number1; i > 0; i = i / 10)
            {
                j = number2;
                remainder_number1 = i % 10;
                for (j = number2; j > 0; j = j / 10)
                {
                    remainder_number2 = j % 10;

                    if (remainder_number1 == remainder_number2)
                    {
                        IsEqual = true;
                        break;
                    }
                }
            }
            if (IsEqual)
            {
                value = "Да";
            }
            else
            {
                value = "Нет";
            }
            return value;
        }
    }
}
