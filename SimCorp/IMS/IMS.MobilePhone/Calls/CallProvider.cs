using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimCorp.IMS.MobilePhone.Message;

namespace SimCorp.IMS.MobilePhone.Calls
{
    public delegate void CallReceivedDelegate(Call call);
    public abstract class CallProvider
    {
        public event CallReceivedDelegate CallReceived;

        public CallProvider()
        {            
            InitContacts();
        }

        private void InitContacts()
        {
            var bob=new Contact("Bob", "+380671234567");
            bob.AddNumber("+380987654321");
            var ann=new Contact("Ann", "+380661726354");
            var tom=new Contact("Tom", "+380987424342");
            AllContacts = new Contact[] { bob,ann,tom};
    }

        public abstract void StartCalling();

        public abstract void CloseThreads();

        public void SimulateCall()
        {
            while (true)
            {
                if (IsRunning)
                {
                    CallReceived?.Invoke(GenrateNewCall());
                }
                Thread.Sleep(TimeInterval);
            }
        }

        public void StopCalling()
        {
            IsRunning = false;
        }

        private Call GenrateNewCall()
        {
            Random rnd = new Random();
            Contact user;
            if (UserNameToGenerate != "")
            {
                user = AllContacts.ToList().Find(c => c.Name == UserNameToGenerate);
            }
            else
            {
                user = AllContacts[rnd.Next(0, AllContacts.Length)];
            }
            var number = user.Numbers[rnd.Next(0, user.Numbers.Count)];
            var time= new DateTime(DateToGenerate.Year,
                DateToGenerate.Month,
                DateToGenerate.Day,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second,
                DateTime.Now.Millisecond);
            return new Call(user,time,DirectionToGenerate,number,1);
        }

        private Contact[] AllContacts;

        public int TimeInterval { get; set; } = 1000;
        public bool IsRunning { get; protected set; } = true;
        public string UserNameToGenerate { get; set; } = "";
        public DateTime DateToGenerate { get; set; }
        public CallDirection DirectionToGenerate { get; set; }=CallDirection.Incoming;
    }
}
