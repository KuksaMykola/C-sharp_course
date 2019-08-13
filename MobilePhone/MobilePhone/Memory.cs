using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    internal abstract class Memory
    {
        protected Memory(float capacity)
        {
            Capacity = capacity;
        }

        protected Memory()
        {

        }

        public abstract void Read();
        public float Capacity { get; private set; } = 500;
    }
}
