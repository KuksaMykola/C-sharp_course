using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal class RandomAccessMemory
    {
        public RandomAccessMemory(float capacity)
        {
            Capacity = capacity;
        }
        public RandomAccessMemory()
        {

        }
        public float Capacity { get; private set; } = 1500;
}
}
