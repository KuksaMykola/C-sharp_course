using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone
{
    class TimeInfo:ITimeInfo
    {
        public string GetCurrentTime()
        {
            return string.Format(" {0:HH:mm:ss tt} ", DateTime.Now);
        }
    }
}
