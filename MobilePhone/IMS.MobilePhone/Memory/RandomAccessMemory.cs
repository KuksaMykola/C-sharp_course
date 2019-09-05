using System;

namespace SimCorp.IMS.MobilePhone.Memory
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
