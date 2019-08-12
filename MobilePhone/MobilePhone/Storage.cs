using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal class Storage
    {
        public Storage(float capacity)
        {
            Capacity = capacity;
        }
        public Storage()
        {

        }
        public float Capacity { get; private set; } = 8000;
    }
}
