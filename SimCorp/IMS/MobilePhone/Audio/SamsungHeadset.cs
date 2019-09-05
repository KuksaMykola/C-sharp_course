using System;

namespace SimCorp.IMS.MobilePhone.Audio
{
    public class SamsungHeadset:IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound");
        }

        public override string ToString()
        {
            return nameof(SamsungHeadset);
        }
    }
}
