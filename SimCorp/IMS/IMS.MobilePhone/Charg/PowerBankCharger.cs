using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    public class PowerBankCharger:ICharger
    {
        private IOutput Output;

        public PowerBankCharger(IOutput output)
        {
            Output = output;
        }

        public void Charge()
        {
            Output.WriteLine($"{nameof(PowerBankCharger)} charg");
        }

        public override string ToString()
        {
            return nameof(PowerBankCharger);
        }
    }
}
