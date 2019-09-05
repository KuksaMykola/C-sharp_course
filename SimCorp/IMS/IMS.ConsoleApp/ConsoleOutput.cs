using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.ConsoleApp
{
    internal class ConsoleOutput:IOutput
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
