using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class ColorfulScreen : Screen
    {
        public ColorfulScreen(float diagonal) : base(diagonal)
        {
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
