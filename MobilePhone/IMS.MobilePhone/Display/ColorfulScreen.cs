using System;

namespace SimCorp.IMS.MobilePhone.Display
{
    class ColorfulScreen : Screen
    {
        public ColorfulScreen(float diagonal,int colorDepth) : base(diagonal)
        {
            ColorDepth = colorDepth;
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colourful image");
        }
        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Colourful image. Brightness: " + brightness.ToString());
        }
        public override string ToString()
        {
            return "Colorful Screen."+base.ToString();
        }
    }
}
