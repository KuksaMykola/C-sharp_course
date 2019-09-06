using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    public class CarCharger:ICharger
    {
        private IOutput Output;

        public CarCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(CarCharger)} charg");
        }

        public override string ToString()
        {
            return nameof(CarCharger);
        }
    }
}
