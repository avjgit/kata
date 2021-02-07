using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace multithreading
{
    public class RaceDemo
    {

        public static void RunRaced()
        {
            Console.WriteLine("Run raced -----------------");
            var calc = new SomeHeavyCalculator();
            var threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(new ThreadStart(calc.CalculateRaced));
                threads[i].Name = $"thread #{i}";
            }
            foreach (var t in threads) t.Start();
        }

        public static void RunLocked()
        {
            Console.WriteLine("Run locked -----------------");
            var calc = new SomeHeavyCalculator();
            var threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(new ThreadStart(calc.CalculateLocked));
                threads[i].Name = $"thread #{i}";
            }
            foreach (var t in threads) t.Start();
        }

        class SomeHeavyCalculator
        {
            public object lockObj = new object();

            public void CalculateRaced()
            {
                Calculate("Raced");
            }

            public void CalculateLocked()
            {
                lock (lockObj)
                {
                    Calculate("Locked");
                }
            }

            private void Calculate(string lockedorRaced)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(new Random().Next(5));
                    Console.WriteLine($"{lockedorRaced} {Thread.CurrentThread.Name} performing calculation step {i}");
                }
            }
        }

    }
}
