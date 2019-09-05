using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Audio
{
    class UnofficialPhoneHeadset:IPlayback
    {
        public void Play(object data)
        {
            System.Console.WriteLine($"{nameof(UnofficialPhoneHeadset)} sound");
        }
    }
}
