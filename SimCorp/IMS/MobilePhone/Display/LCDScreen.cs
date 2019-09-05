using System;

namespace SimCorp.IMS.MobilePhone.Display
{
    internal class LCDScreen:ColorfulScreen
    {
        public LCDScreen(float diagonal,int colorDepth) : base(diagonal,colorDepth)
        {
        }
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colourful image on LCD screen");
        }
        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Colourful image on LCD screen. Brightness: " + brightness.ToString());
        }

        public override string ToString()
        {
            return "LCD "+base.ToString();
        }
    }
}
