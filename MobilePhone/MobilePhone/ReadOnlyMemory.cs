using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal class ReadOnlyMemory
    {
        public ReadOnlyMemory(float capacity)
        {
            Capacity = capacity;
        }
        public ReadOnlyMemory()
        {

        }
        public float Capacity { get; private set; } = 500;
    }
}
