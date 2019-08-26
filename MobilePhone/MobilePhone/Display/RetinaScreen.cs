using System;

namespace SimCorp.IMS.Display
{
    class RetinaScreen: ColorfulScreen 
    {
        public RetinaScreen(float diagonal,int colorDepth,ScreenResolution resolution) : base(diagonal,colorDepth)
        {
            vResolution = resolution;
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colourful image on Retina screen");
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine("Colourful image on Retina screen. Brightness: " + brightness.ToString());
        }

        public override string ToString()
        {
            return "Retina " + base.ToString();
        }

        public override ScreenResolution Resolution {get { return vResolution; } }
        private ScreenResolution vResolution;
    }
}
