using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Message
{
    class SMSProviderUseTasks:SMSProvider
    {
        public SMSProviderUseTasks(int numberOfMessagesToSimulate) : base(numberOfMessagesToSimulate)
        {
        }

        public override void StartMessaging()
        {
            IsRunning = true;
            ChargingTask();
        }

        public override void CloseAllThreadsAndTasks()
        {
        }

        private async Task ChargingTask()
        {
            await Task.Run(() => SimulateSMS());
        }
    }
}
