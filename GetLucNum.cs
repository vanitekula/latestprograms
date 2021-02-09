using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{//1+9+6+1+9+9+6=>41=>5      19+6+1996=>2021=>5
    class GetLucNum
    {
        public static int GetLuckyNumber(string Dob) // "19-Jun-1996"
        {
            string[] res = Dob.Split('-');
            int date = int.Parse(res[0]);
            int mon = ConvertMonToNum(res[1]);
            int year = int.Parse(res[2]);
            int sum = date + mon + year;
            while (sum > 9)
            {
                sum = GetSumOfDigits(sum);
            }
            return sum;

        }

        public static int ConvertMonToNum(string month) //March
        {
            month = month.ToLower();//march
            string[] months = {"jan","feb","mar","apr","may","jun","jul","aug","sep","oct","nov","dec" };
            for (int i = 0; i < months.Length; i++)
            {
                if(month.Contains(months[i]))
                {
                    return i + 1;
                }
            }
            return 0;
        
        }

        public static int GetSumOfDigits(int num)//2021
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetLuckyNumber("19-Jun-1996"));
            Console.WriteLine(ConvertMonToNum("January"));
            Console.WriteLine(GetSumOfDigits(123));
        }
    }
}
