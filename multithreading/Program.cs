using System;
using System.Threading;

namespace multithreading
{
    class Program
    {

        static void Main(string[] args)
        {
            RaceDemo.RunRaced(); // some chaotic unordered execution
            RaceDemo.RunLocked(); // some chaotic unordered execution
            //DeadlockExample.Run();
        }

    }
}
