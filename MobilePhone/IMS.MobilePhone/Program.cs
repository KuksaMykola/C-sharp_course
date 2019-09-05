using System;

namespace SimCorp.IMS.MobilePhone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Mobile mb = new SimcorpMobile("Nokia");
            Console.WriteLine(mb);
            Console.ReadKey();
        }
    }
}
