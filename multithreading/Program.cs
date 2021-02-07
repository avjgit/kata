using System;
using System.Threading;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //RaceDemo.RunRaced(); // some chaotic unordered execution
            //RaceDemo.RunLocked(); 
            //DeadlockDemo.Run();
            MutexDemo.Run();
        }
    }
}
