using System;

namespace SimCorp.IMS.MobilePhone.Audio
{
    class SamsungHeadset:IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}
