using System;

namespace SimCorp.IMS.MobilePhone.Audio
{
    public class iPhoneHeadset:IPlayback
    {
        private IOutput Output;

        public iPhoneHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }

        public override string ToString()
        {
            return nameof(iPhoneHeadset);
        }
    }
}
