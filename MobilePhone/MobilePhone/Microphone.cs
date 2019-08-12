using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    class Microphone
    {
        public Microphone(float impedance, float sensitivity)
        {
            this.impedance = impedance;
            this.sensitivity = sensitivity;
        }
        public Microphone()
        {

        }
        public float impedance { get; private set; }=100;
        public float sensitivity { get; private set; }=150;
    }
}
