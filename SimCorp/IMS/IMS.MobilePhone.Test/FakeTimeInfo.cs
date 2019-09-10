using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Test
{
    class FakeTimeInfo:ITimeInfo
    {
        private string FakedTimeInfo;

        public FakeTimeInfo(string fakedTimeInfo)
        {
            FakedTimeInfo = fakedTimeInfo;
        }
        public string GetCurrentTime()
        {
            return FakedTimeInfo;
        }
    }
}
