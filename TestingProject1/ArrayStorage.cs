using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject1
{
    public static class ArrayStorage
    {
        //найти минимальный элемент массива (массивы-пример1)
        public static int GetMinValue(int[] arrayNumbers) 
        {
            if (arrayNumbers.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }

            int min = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                int crnt = arrayNumbers[i];
                if (min > crnt)
                {
                    min = crnt;
                }
            }
            return min;
        }

        //найти максимальный элемент массива (массивы-пример2)
        public static int GetMaxValue(int[] arrayNumbers) 
        {
            int max = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (max < arrayNumbers[i])
                {
                    max = arrayNumbers[i];
                }
            }
            if (arrayNumbers.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }

            return max;
        }

        //найти индекс минимального элемента массива (массивы-пример3)
        public static int GetIndexMinValue(int[] arrayNumbers)
        {
            if (arrayNumbers.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }

            int min = arrayNumbers[0];
            int imin = 1;
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                ;
                if (min > arrayNumbers[i])
                {
                    min = arrayNumbers[i];
                    imin = i;
                }
            }
            return imin;
        }

        //найти индекс максимального элемента массива (массивы-пример4)
        public static int GetIndexMaxValue(int[] arrayNumbers) 
        {
            if (arrayNumbers.Length == 0)
            {
                throw new ArgumentException("Array length is zero");
            }

            int max = arrayNumbers[0];
            int imax = 0;
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (max < arrayNumbers[i])
                {
                    max = arrayNumbers[i];
                    imax = i;
                }
            }
            return imax;
        }

        // Найти сумму элементов массива с нечёткими индексами (массивы-пример5)
        public static int GetSumOfOddIndex(int[] arrayNumbers)
        {
            int sum = 0;
            for (int i=0; i<= arrayNumbers.Length; i++)
            {
                int k = i;
                if ((k+1)%2==0)
                {
                    sum = sum + arrayNumbers[i];
                }
            }
            return sum;
        }

        //Расстановка элемента массива в обратном порядке (массивы пример-6)
        public static int[] GetReverseArray(int[] arrayNumbers)
        {
            int emptyelement;
            int i = 0;
            int j = arrayNumbers.Length - 1;

            int middle = arrayNumbers.Length / 2;
            while (i != middle)
            {
                emptyelement = 0;
                emptyelement = arrayNumbers[i];
                arrayNumbers[i] = arrayNumbers[j];
                arrayNumbers[j] = emptyelement;
                i = i + 1;
                j = j - 1;
            }

            if (arrayNumbers.Length == 0)
            {
                throw new ArgumentException("Array length is Zero");
            }
            return arrayNumbers;
        }

        //Количество нечётных элементов массива (массивы-пример7)
        public static int GetNumbersCount(int[] arrayNumbers)
        {
            int count = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if ((arrayNumbers[i] + 2) % 2 == 1)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        //Поменять местами первую и вторую часть массива (массивы-пример8)
       /* public static int[] GetReverseFirstAndSecondPart(int[] a)
        {
            int j = a.Length/2;
            int c = 0;
            int i = 0;
            int l = a.Length / 2;
            while (j != a.Length)
            {
                c = a[i];
                a[i] = a[l];
                a[l] = a[i];
                i++;
                l++;

                
            }
            }
           /* else 
            {
                int j = a.Length / 2;
                while (i != middle)
                { 
                    c = 0;
                c = a[i];
                a[i] = a[j];
                a[j] = c;
                i = i + 1;
                j = j + 1;
                }
            }

            if (a.Length == 0)
            {
                throw new ArgumentException("Array length is Zero");
            } 
            return a;
        } */
    }
}
