using System;
using System.Threading;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(SomeFunction);
            t.Name = "foreground thread";
            t.IsBackground = false;
            t.Start();

            Console.WriteLine("Main thread running");
        }

        static void SomeFunction()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} started") ;
            Thread.Sleep(3000);
            Console.WriteLine($"{Thread.CurrentThread.Name} finished") ;
        }
    }
}
