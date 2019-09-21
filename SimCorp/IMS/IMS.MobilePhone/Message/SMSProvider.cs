using System;
using System.Diagnostics;
using System.Timers;

namespace SimCorp.IMS.MobilePhone.Message
{
    public delegate void SMSReceivedDelegate(Message message);
    internal class SMSProvider
    { 
        public SMSProvider(int numberOfMessagesToSimulate)
        {
            NumberOfMessagesToSimulate = numberOfMessagesToSimulate;
            Timer=new Timer(1000);
        }

        public event SMSReceivedDelegate SMSReceived;
        public void SimulateSMS()
        {

            if (SMSReceived != null)
            {
                Timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);
                Timer.Enabled = true;
            }
        }

        private void OnTimerElapsed(Object source, ElapsedEventArgs e)
        {
            OnSMSReceived(GenrateNewMessage());
            if (Counter > NumberOfMessagesToSimulate)
            {
                Timer.Elapsed -= OnTimerElapsed;
            }
        }
        protected virtual void OnSMSReceived(Message message)
        {
            SMSReceived?.Invoke(message);
        }

        private Message GenrateNewMessage()
        {
            Random rnd=new Random();
            var index = rnd.Next(0, AllUsers.Length);
            var userName = AllUsers[index];
            var userNumber = AllNumbers[index];
            var text = $"Message #{Counter++} received";
            DateTime time=DateTime.Now;
            return new Message(userName, userNumber, text, time);
        }

        private Timer Timer;
        private int Counter = 1;
        private readonly int NumberOfMessagesToSimulate;
        private readonly string[] AllUsers=new string[3] {"Bob","Ann","Tom"};
        private readonly string[] AllNumbers=new string[]
        {
            "+380671234567",
            "+380987654321",
            "+380661726354"
        };
    }
}
