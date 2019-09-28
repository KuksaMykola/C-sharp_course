using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Calls
{
    public enum CallDirection { Incoming,Outgoing}
    public class Call:IComparable<Call>
    {
        public Call(Contact contact, DateTime time, CallDirection direction,string number,uint countCallsInRow)
        {
            Contact = contact;
            Time = time;
            Direction = direction;
            Number = number;
            CountCallsInRow = countCallsInRow;
        }
  
        public Contact Contact { get; set; }
        public DateTime Time { get; set; }
        public CallDirection Direction { get; set; }
        public string Number { get; set; }
        public uint CountCallsInRow { get; set; }

        public int CompareTo(Call otherCall)
        {
            if (otherCall == null) return 1;

            return Time.CompareTo(otherCall.Time);
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
            Call otherObj = obj as Call;
            var res = Contact.Equals(otherObj.Contact)
                      && Direction.Equals(otherObj.Direction)
                      && Number.Equals(otherObj.Number)
                      && 0>=Time.CompareTo(otherObj.Time);
            return res;
        }
    }
}
