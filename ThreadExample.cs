using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace OopsConsoleApp
{
    class Game
    {
        public static void Palyer1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Player 1 Played {i} Time");
                Thread.Sleep(5000);
            }
        }
        public static void Palyer2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Player 2 Played {i} Time");
                Thread.Sleep(5000);
            }
        }
    }
    class ThreadExample
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(Game.Palyer1); // un started state
            Thread th2 = new Thread(Game.Palyer2);//
            th1.Name = "First Threaed";
            th2.Name = "Second Thread";
           
            th1.Start();
            th1.Join(20000);
            th2.Start();
            
        }
    }
}
