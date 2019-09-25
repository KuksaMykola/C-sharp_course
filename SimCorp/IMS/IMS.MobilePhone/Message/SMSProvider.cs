using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace SimCorp.IMS.MobilePhone.Message
{
    public delegate void SMSReceivedDelegate(Message message);


    internal abstract class SMSProvider
    {
        public event SMSReceivedDelegate SMSReceived;

        public SMSProvider(int numberOfMessagesToSimulate)
        {
            NumberOfMessagesToSimulate = numberOfMessagesToSimulate;
        }

        public abstract void StartMessaging();

        public abstract void CloseAllThreadsAndTasks();

        public void SimulateSMS()
        {
            while (true)
            {
                if (IsRunning && (Counter <= NumberOfMessagesToSimulate))
                {
                    SMSReceived?.Invoke(GenrateNewMessage());
                }
                Thread.Sleep(TimeInterval);
            }
        }

        public void StopMessaging()
        {
            IsRunning = false;
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

        public int TimeInterval { get; set; } = 1000;
        public bool IsRunning { get; protected set; } = true;
    }
}
