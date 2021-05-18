using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public interface IQueueDataStructure
    {
        public void Enqueue(int value);
        public int Dequeue();
        public void Clear();
    }
}
