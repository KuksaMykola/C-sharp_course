using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    enum BatteryType { NickelCadmium, NickelMetalHydride, LithiumIon, LithiumPolymer}
    class Battery
    {
        public Battery(float length, float width, float thickness, float cpacity, float voltage, BatteryType type)
        {
            Length = length;
            Width = width;
            Thickness = thickness;
            Cpacity = cpacity;
            Voltage = voltage;
            Type = type;
        }
        public Battery()
        {

        }
        public float Length { get; private set; } = 10;
        public float Width { get; private set; } = 4.5f;
        public float Thickness { get; private set; } = 0.5f;
        public float Cpacity { get; private set; } = 3000;
        public float Voltage { get; private set; } = 2.5f;
        public BatteryType Type { get; private set; } = BatteryType.LithiumIon;
    }
}
