using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    internal class SimcorpMobile : Mobile
    {
        public SimcorpMobile(string name, CircuitBoard circuitBoard, Battery battery, Antenna antenna,Keyboard keyboard, Microphone microphone, Speaker speaker) : base(name, circuitBoard, battery, antenna, keyboard, microphone, speaker)
        {
        }

        public SimcorpMobile()
        {
        }

        public SimcorpMobile(string name) : base(name)
        {
        }


        public override Screen Screen { get { return lcdScreen; }}
        private readonly LCDScreen lcdScreen = new LCDScreen(6);
    }
}
