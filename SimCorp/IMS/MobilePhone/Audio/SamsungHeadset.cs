using System;

namespace SimCorp.IMS.MobilePhone.Audio
{
    public class SamsungHeadset:IPlayback
    {
        private IOutput Output;

        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }

        public override string ToString()
        {
            return nameof(SamsungHeadset);
        }
    }
}
