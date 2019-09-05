using System;

namespace SimCorp.IMS.MobilePhone.Audio
{
    public class iPhoneHeadset:IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }

        public override string ToString()
        {
            return nameof(iPhoneHeadset);
        }
    }
}
