using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Calls
{
    public class Contact
    {
        public Contact(string name,string number)
        {
            Name = name;
            Numbers.Add(number);
        }
        public string Name { get; private set; }
        public List<string> Numbers { get; private set;} = new List<string>();

        public void AddNumber(string number)
        {
            Numbers.Add(number);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            Contact otherObj=obj as Contact;
            return Name.Equals(otherObj.Name);
        }
    }
}
