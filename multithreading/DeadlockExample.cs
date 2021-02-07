using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace multithreading
{
    public class DeadlockExample
    {
        static object obj1 = new object();
        static object obj2 = new object();

        public static void Lock1Then2()
        {
            lock(obj1)
            {
                Console.WriteLine("A thread locked obj1");
                Thread.Sleep(500);
                lock(obj2)
                {
                    Console.WriteLine("Obj2 locked");
                }
            }
        }

        public static void Lock2Then1()
        {
            lock (obj2)
            {
                Console.WriteLine("Another thread locked obj2 first");
                Thread.Sleep(500);
                Console.WriteLine("Do we have a deadlock?");
                lock (obj1)
                {
                    Console.WriteLine("This will print if no deadlock - when obj1 locked by another thread");
                }
            }
        }

        static public void Run()
        {
            var thread1 = new Thread(new ThreadStart(Lock1Then2));
            var thread2 = new Thread(new ThreadStart(Lock2Then1));
            thread1.Start();
            thread2.Start();
            Console.WriteLine("And program went further");
        }
    }
}
