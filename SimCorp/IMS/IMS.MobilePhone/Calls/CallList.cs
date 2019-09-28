using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Calls
{
    public class CallList
    {
        public List<Call> Calls { get; private set;}=new List<Call>();

        public void AddCall(Call call)
        {
            if (Calls.Count != 0)
            {
                if (Calls.Last().Equals(call))
                {
                    var prevCount = Calls.Last().CountCallsInRow;
                    Calls.RemoveAt(Calls.Count-1);
                    Calls.Add(new Call(call.Contact,call.Time,call.Direction,call.Number,prevCount+1));
                }
                else
                {
                    Calls.Add(call);
                    Calls.Sort();
                }
            }
            else
            {
                Calls.Add(call);
            }

        }
    }
}
