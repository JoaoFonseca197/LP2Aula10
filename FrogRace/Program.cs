using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        private static int end = 0 ;
        static object threadLock = new Object();
        
        static void Main(string[] args)
        {
            object threadLock = new Object();
            Thread t1 = new Thread(FrogJump);
            Thread t2 = new Thread(FrogJump);
            Thread t3 = new Thread(FrogJump);
            t1.Name = "T_One";
            t2.Name = "T_Two";
            t3.Name = "T_Three";
            t1.Start(1);
            t2.Start(2);
            t3.Start(3);
            t1.Join();
            t2.Join();
            t3.Join();
        }


        private static void FrogJump(object numbRã)
        {
            Random rnd = new Random();
            int nbr = (int)numbRã;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Rã {nbr} deu salto {i} (thread {Thread.CurrentThread.Name})");
                Thread.Sleep(rnd.Next(0,1000));
            }
            lock(threadLock)
            {
                
                end += 1;
                Console.WriteLine($"The frong {nbr} finished in {end}");
            }
            
        }
        
    }
}
