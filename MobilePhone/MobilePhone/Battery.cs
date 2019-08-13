using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal enum BatteryType { NickelCadmium, NickelMetalHydride, LithiumIon, LithiumPolymer}
    internal class Battery
    {
        public Battery(float length, float width, float thickness, float capacity, float voltage, BatteryType type)
        {
            Length = length;
            Width = width;
            Thickness = thickness;
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

        public float Length { get; private set; } = 10;
        public float Width { get; private set; } = 4.5f;
        public float Thickness { get; private set; } = 0.5f;
        public float Capacity { get; private set; } = 3000;
        public float Voltage { get; private set; } = 2.5f;
        public BatteryType Type { get; private set; } = BatteryType.LithiumIon;
    }
}
