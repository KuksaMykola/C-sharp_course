using System;

namespace SimCorp.IMS.MobilePhone.Memory
{
    internal class Storage:Memory
    {
        public Storage(float capacity):base(capacity)
        {
        }
        public Storage()
        {

        }
        public override void Read()
        {
            Console.WriteLine("Reading data from phone storage memory...");
        }

        public override string ToString()
        {
            return $"Storage memory capacity is {Capacity}";
        }
    }
}
