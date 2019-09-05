using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Charg
{
    public class ContactlessCharger:ICharger
    {
        private IOutput Output;

        public ContactlessCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(ContactlessCharger)} charg"); ;
        }

        public override string ToString()
        {
            return nameof(ContactlessCharger);
        }
    }
}
