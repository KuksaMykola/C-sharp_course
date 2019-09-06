using System;

namespace SimCorp.IMS.MobilePhone.Display
{
    public class MonochromeScreen: Screen
    {
        public MonochromeScreen(float diagonal) : base(diagonal)
        {
            ColorDepth = 1;
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Monochrome image");
        }
        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Monochrome image. Brightness: " + brightness.ToString());
        }

        public override string ToString()
        {
            return "Monochrome Screen."+base.ToString();
        }

        public override ScreenResolution Resolution {
            get { return vResolution; } 
        }

        private readonly ScreenResolution vResolution= new ScreenResolution(480, 800);

    }
}
