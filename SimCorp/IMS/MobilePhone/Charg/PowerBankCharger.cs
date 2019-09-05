using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    public class PowerBankCharger:ICharger
    {
        public void Charge()
        {
            System.Console.WriteLine($"{nameof(PowerBankCharger)} charg");
        }

        public override string ToString()
        {
            return nameof(PowerBankCharger);
        }
    }
}
