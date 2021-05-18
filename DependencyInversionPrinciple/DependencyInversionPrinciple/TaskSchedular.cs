using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    class TaskSchedular
    {
        IQueueDataStructure queue=new PriorityQueue();
         public void Schedular()
        {
            int value=queue.Dequeue();
            //print value;
        }
    }
}
