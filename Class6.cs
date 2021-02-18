using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Class6
    {
        static void Main(string[] args)
        {
            int[,] array = { {1,2,3 },{ 3, 4, 5 },{ 6, 7, 8 } };
           for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(array[i,j]+"\t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Diagonal elemetns of the array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   if(i==j || i+j == 2)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine("Other than Diagonal elemetns of the array");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j || i + j == 2)
                    {
                        Console.Write("\t");
                        
                    }
                    else
                    {
                        Console.Write(array[i, j] + "\t");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
