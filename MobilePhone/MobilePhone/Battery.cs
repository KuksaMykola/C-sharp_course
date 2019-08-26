using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS
{
    internal enum BatteryType { NickelCadmium, NickelMetalHydride, LithiumIon, LithiumPolymer}
    internal class Battery
    {
        public Battery(float length, float width, float thickness, float capacity, float voltage, BatteryType type)
        {
            Capacity = capacity;
            Voltage = voltage;
            Type = type;
        }
        public Battery()
        {

        }

        public override string ToString()
        {
            return $"Battery volume is {Capacity}";
        }

        public float Capacity { get; private set; } = 3000;
        public float Voltage { get; private set; } = 2.5f;
        public BatteryType Type { get; private set; } = BatteryType.LithiumIon;
    }
}
