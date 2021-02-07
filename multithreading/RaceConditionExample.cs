using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace multithreading
{
    public class RaceConditionExample
    {
        static public void Run()
        {
            var calc = new SomeHeavyCalculator();
            var threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(new ThreadStart(calc.Calculate));
                threads[i].Name = $"thread #{i}";
            }

            foreach (var t in threads)
            {
                t.Start();
            }
        }

        class SomeHeavyCalculator
        {
            public void Calculate()
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(new Random().Next(5));
                    Console.WriteLine($"Performing calculation step {i}");
                }
            }
        }

    }
}
