using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS
{
    internal class Keyboard
    {
        public Keyboard(uint numberOfKeys)
        {
            NumberOfKeys = numberOfKeys;
        }

        public Keyboard()
        {
            
        }

        public uint NumberOfKeys { get; private set; } = 10;
    }
}
