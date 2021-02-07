using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace multithreading
{
    public class SemaphoreDemo
    {
        static Semaphore semaphore = new Semaphore(2, 4);

        public static void Run()
        {
            for (int i = 1; i <= 5; i++)
            {
                new Thread(Calculate).Start(i);
            }
        }

        public static void Calculate(object id)
        {
            Console.WriteLine($"{id} is in waiting hall");
            try
            {
                semaphore.WaitOne();
                Console.WriteLine($"OK, {id} entered");
                Thread.Sleep(2000);
                Console.WriteLine($"And {id} is leaving, bye");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
