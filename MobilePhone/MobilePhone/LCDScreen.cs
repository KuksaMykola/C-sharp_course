using System;

namespace MobilePhone
{
    internal class LCDScreen:ColorfulScreen
    {
        public LCDScreen(float diagonal) : base(diagonal)
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
