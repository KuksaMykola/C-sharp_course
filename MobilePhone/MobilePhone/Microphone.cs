using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal class Microphone
    {
        public Microphone(float impedance, float sensitivity)
        {
            Impedance = impedance;
            Sensitivity = sensitivity;
        }
        public Microphone()
        {

        }
        public float Impedance { get; private set; }=100;
        public float Sensitivity { get; private set; }=150;
    }
}
