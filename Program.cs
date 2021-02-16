using System;

namespace RevisionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;//1,2,3,4,5
            int min = 1;
            int max = num;
           
            
            
            while (min<= max) // 1<=5  2<=5   3<=5    4<=5  5<=5  6<=5
            {
                Console.Write(min+"\n");//1   2    3    4   5
                min = min + 1;
            }
        }
    }
}
