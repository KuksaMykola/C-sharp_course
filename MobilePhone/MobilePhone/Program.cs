using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Mobile mb = new Mobile("Nokia");
            Console.WriteLine("Mobile phone has been created: " + mb.Name);
            Console.ReadKey();
        }
    }
}
