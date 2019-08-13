using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class MonochromeScreen: Screen
    {
        public MonochromeScreen(float diagonal) : base(diagonal)
        {
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

    }
}
