using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    internal interface IScreenImage
    {
        double Width { get; set; }
        double Height { get; set; }
        string Colour { get; set; }
    }
}
