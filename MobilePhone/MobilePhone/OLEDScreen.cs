using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class OLEDScreen: ColorfulScreen
    {
        public OLEDScreen(float diagonal) : base(diagonal)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colourful image on OLED screen");
        }

      public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Colourful image on OLED screen. Brightness: "+brightness.ToString());
        }

        public override string ToString()
        {
            return "OLED "+base.ToString();
        }
    }
}
