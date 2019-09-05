using System;

namespace SimCorp.IMS.MobilePhone.Audio
{
    class iPhoneHeadset:IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
    }
}
