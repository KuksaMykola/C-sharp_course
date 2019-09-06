using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    public class LaptopCableCharger:ICharger
    {
        private IOutput Output;

        public LaptopCableCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(LaptopCableCharger)} charg");
        }

        public override string ToString()
        {
            return nameof(LaptopCableCharger);
        }
    }
}
