using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal enum ScreenType{ Monochrome,Colour }
    internal class Screen
    {
        public Screen(float diagonal, ScreenType type, bool touchSupport)
        {
            Diagonal = diagonal;
            Type = type;
            TouchSupport = touchSupport;
        }

        public Screen()
        {
            
        }
        public float Diagonal { get; private set; } = 4;
        public ScreenType Type { get; private set; }=ScreenType.Colour;
        public bool TouchSupport { get; private set; } = true;
    }  
}
