using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimCorp.IMS.MobilePhone.Message;

namespace SimCorp.IMS.MobilePhone.Calls
{
    public class CallProviderUseThreads : CallProvider
    {
        private Thread TimeThread;

        public override void StartCalling()
        {
            IsRunning = true;
            if (TimeThread == null)
            {
                TimeThread = new Thread(new ThreadStart(SimulateCall));
                TimeThread.Start();
            }
        }


        public override void CloseThreads()
        {
            TimeThread.Abort();
        }

    }
}
