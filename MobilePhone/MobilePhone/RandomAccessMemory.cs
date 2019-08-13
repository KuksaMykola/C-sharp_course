using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal class RandomAccessMemory:Memory
    {
        public RandomAccessMemory(float capacity):base(capacity)
        {
            
        }
        public RandomAccessMemory()
        {

        }

        public override void Read()
        {
            Console.WriteLine("Reading data from RAM...");
        }

        public override string ToString()
        {
            return $"RAM capacity is {Capacity}";
        }
    }
}
