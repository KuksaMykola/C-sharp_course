using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    public class CarCharger:ICharger
    {
        public void Charge()
        {
            System.Console.WriteLine($"{nameof(CarCharger)} charg");
        }

        public override string ToString()
        {
            return nameof(CarCharger);
        }
    }
}
