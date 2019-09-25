using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCorp.IMS.MobilePhone.Message;

namespace SimCorp.IMS.MobilePhone.Battery
{
    public class BatteryFactory
    {
        public static Battery Create(ParallelExectuionType type)
        {
            if (type == ParallelExectuionType.Thread)
            {
                return new BatteryUseThreads();
            }
            return new BatteryUseTasks();
                
        }
    }
}
