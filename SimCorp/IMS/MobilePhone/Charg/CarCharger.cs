using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    class CarCharger:ICharger
    {
        public void Charge()
        {
            System.Console.WriteLine($"{nameof(CarCharger)} charg");
        }
    }
}
