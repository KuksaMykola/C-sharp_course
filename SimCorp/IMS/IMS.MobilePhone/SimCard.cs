﻿namespace SimCorp.IMS.MobilePhone
{
    public class SimCard
    {
        public SimCard(string number, string country)
        {
            Number = number;
            Country = country;
        }

        public SimCard(string number)
        {
            Number = number;
        }
        public string Number { get; private set; }
        public string Country { get; private set; } = "Ukraine";
    }
}
