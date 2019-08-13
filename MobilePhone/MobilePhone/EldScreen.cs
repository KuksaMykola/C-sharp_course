using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    internal class ELDScreen:ColorfulScreen
    {
        public ELDScreen(float diagonal) : base(diagonal)
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
