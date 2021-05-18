using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskSchedular tsk = new TaskSchedular();
            tsk.Schedular();
        }
    }
}
