using System;
using System.Threading;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let' s check thread:");
            var t = Thread.CurrentThread;
            t.Name = "The Thread";
            Console.WriteLine(t.Name);
        }
    }
}
