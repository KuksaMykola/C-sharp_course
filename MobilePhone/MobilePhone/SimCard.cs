using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    
    class SimCard
    {
        public SimCard(uint[] number, string country)
        {
            Number = number;
            Country = country;
        }
        public SimCard()
        {

        }
        public uint[] Number { get; private set; } = { 0, 9, 8, 2, 5, 6, 1, 4, 8, 9 };
        public string Country { get; private set; } = "Ukraine";
    }
}
