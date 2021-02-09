using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class GetMaxNumFromArray
    {
        public static int GetMaxNumber(int[] array)
        {
         return   ArrayToNum(SortArrayDesc(GetMaxDigitArray(array)));
        }

        private static int ArrayToNum(int[] array) //{ 5,7,8}
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)// i = 2
            {
                res = res * 10 + array[i];
            }
            return res;
        }

        private static int[] SortArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int copy = array[i];
                        array[i] = array[j];
                        array[j] = copy;
                    }
                }
            }
            return array;
        }

        private static int[] GetMaxDigitArray(int[] array)//{456,678,659}=>{6,8,9}
        {
            int[] mxdigitarray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                mxdigitarray[i] = GetMaxDigit(array[i]);
            }
            return mxdigitarray;
        }

        private static int GetMaxDigit(int num)
        {
            int max = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (max < digit)
                {
                    max = digit;
                }
                num = num / 10;
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] array = { 345, 456, 1024, 420, 520, 1634 };
            Console.WriteLine(GetMaxNumber(array));
        }
    }
}
