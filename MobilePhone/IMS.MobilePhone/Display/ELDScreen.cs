using System;

namespace SimCorp.IMS.MobilePhone.Display
{
    internal class ELDScreen:ColorfulScreen
    {
        public ELDScreen(float diagonal,int colorDepth) : base(diagonal,colorDepth)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colourful image on ELD screen");
        }
        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Colourful image on ELD screen. Brightness: " + brightness.ToString());
        }

        public override string ToString()
        {
            return "ELD "+base.ToString();
        }
    }
}
