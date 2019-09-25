using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Message
{
    class SMSProviderUseThreads:SMSProvider
    {
        private Thread TimeThread;

        public override void StartMessaging()
        {
            IsRunning = true;
            if (TimeThread == null)
            {
                TimeThread=new Thread(new ThreadStart(SimulateSMS));
                TimeThread.Start();
            }
        }


        public override void CloseAllThreadsAndTasks()
        {
            TimeThread.Abort();
        }

        public SMSProviderUseThreads(int numberOfMessagesToSimulate) : base(numberOfMessagesToSimulate)
        {
        }
    }
}
