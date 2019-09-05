using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    class SocetCharger:ICharger
    {
        public void Charge()
        {
            System.Console.WriteLine($"{nameof(SocetCharger)} charg"); 
        }
    }
}
