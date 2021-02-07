using System;
using System.Threading;

namespace multithreading
{
    class Program
    {

        static void Main(string[] args)
        {
            RaceConditionExample.RunRaced(); // some chaotic unordered execution
            RaceConditionExample.RunLocked(); // some chaotic unordered execution
            //DeadlockExample.Run();
        }

    }
}
