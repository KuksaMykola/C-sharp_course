﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal class ReadOnlyMemory:Memory
    {
        public ReadOnlyMemory(float capacity):base(capacity)
        {
        }
        public ReadOnlyMemory()
        {

        }
        public override void Read()
        {
            Console.WriteLine("Reading data from ROM...");
        }

        public override string ToString()
        {
            return $"ROM capacity is {Capacity}";
        }
    }
}
