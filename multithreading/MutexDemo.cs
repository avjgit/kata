using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace multithreading
{
    public class MutexDemo
    {
        private static readonly Mutex mutex = new Mutex();

        public static void Run()
        {
            for (int i = 1; i <= 4; i++)
            {
                var t = new Thread(new ThreadStart(Calculate));
                t.Name = $"thread #{i}";
                t.Start();
            }
        }

        public static void Calculate()
        {
            try
            {
                mutex.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} started");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} finished");
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
