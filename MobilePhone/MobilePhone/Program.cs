﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS
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
