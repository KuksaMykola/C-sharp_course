using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.Audio;
using SimCorp.IMS.Display;

namespace SimCorp.IMS
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

        public override Screen Screen { get { return vRetinaScreen; }}
        private readonly RetinaScreen vRetinaScreen = new RetinaScreen(6,16,new ScreenResolution(1080,1920));
    }
}
