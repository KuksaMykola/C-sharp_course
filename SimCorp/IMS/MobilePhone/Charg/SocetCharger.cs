using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    public class SocetCharger:ICharger
    {
        public void Charge()
        {
            System.Console.WriteLine($"{nameof(SocetCharger)} charg"); 
        }

        public override string ToString()
        {
            return nameof(SocetCharger);
        }
    }
}
