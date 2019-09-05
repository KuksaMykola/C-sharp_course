using System;

namespace SimCorp.IMS.MobilePhone.Display
{
    public class OLEDScreen: ColorfulScreen
    {
        public OLEDScreen(float diagonal,int colorDepth) : base(diagonal,colorDepth)
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
