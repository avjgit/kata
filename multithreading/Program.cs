using System;
using System.Threading;

namespace multithreading
{
    class Program
    {

        static void Main(string[] args)
        {
            RaceConditionExample.Run(); // some chaotic unordered execution
        }

    }
}
