using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone
{
    public delegate void SMSReceivedDelegate(string message);
    public class SMSProvider
    {
        public SMSProvider(int numberOfMessagesToSimulate)
        {
            NumberOfMessagesToSimulate = numberOfMessagesToSimulate;
        }

        public event SMSReceivedDelegate SMSReceived;
        public void SimulateSMS()
        {
            if (SMSReceived != null)
            {
                for(var i=1;i<=NumberOfMessagesToSimulate;i++)
                {
                    OnSMSReceived($"Message #{i} received");
                    System.Threading.Thread.Sleep(1000);
                }
            }

        }

        protected virtual void OnSMSReceived(string message)
        {
            var handler = SMSReceived;
            if (handler != null)
            {
                handler(message);
            }
        }

        private readonly int NumberOfMessagesToSimulate;
    }
}
