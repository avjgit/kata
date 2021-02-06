using System;
using System.Threading;

namespace multithreading
{
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

    class Program
    {

        static void Main(string[] args)
        {
            var calc = new SomeHeavyCalculator();
            var threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(new ThreadStart(calc.Calculate));
                threads[i].Name = $"thread #{i}";
            }

            foreach(var t in threads)
            {
                t.Start();
            }

        }

        static void SomeFunction()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} started") ;
            Thread.Sleep(3000);
            Console.WriteLine($"{Thread.CurrentThread.Name} finished") ;
        }
    }
}
