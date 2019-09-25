using SimCorp.IMS.MobilePhone.Audio;
using SimCorp.IMS.MobilePhone.Display;

namespace SimCorp.IMS.MobilePhone
{
    public class SimcorpMobile : Mobile
    {
        public SimcorpMobile(string name, CircuitBoard circuitBoard, Battery.Battery battery, Antenna antenna,Keyboard keyboard, Microphone microphone, Speaker speaker) : base(name, circuitBoard, battery, antenna, keyboard, microphone, speaker)
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
