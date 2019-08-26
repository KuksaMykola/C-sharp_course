using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS
{
    class Microprocessor
    {
        public Microprocessor(float frequency, uint numberOfCores)
        {
            Frequency = frequency;
            NumberOfCores = numberOfCores;
        }
        public Microprocessor()
        {

        }
        public float Frequency { get; private set; } = 1;
        public uint NumberOfCores { get; private set; } = 2;
    }
}
