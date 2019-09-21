using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Message
{
    public class MessageStorage:IEnumerable
    {
        public event SMSReceivedDelegate SMSAdded;
        public event SMSReceivedDelegate SMSRemoved;

        public void AddMessage(Message message)
        {
            Messages.Add(message);

            if(!ORorAND(true, false))
            {
                
            }
            if (Filter(message))
            {
                SMSAdded?.Invoke(message);
            }
        }

        public void RemoveMessage(Message message)
        {
            Messages.Remove(message);
            SMSRemoved?.Invoke(message);
        }

        public List<Message> SearchByUser()
        {
            return Messages.Where(m=>FilterByUser(m)).ToList();
        }

        public List<Message> SearchByText()
        {
            return Messages.Where(m => FilterByText(m)).ToList();
        }

        public List<Message> SearchByDate()
        {
            return Messages.Where(m => FilterByDate(m)).ToList();
        }

        public IEnumerable<Message> GetFilteredMessages()
        {
            return Messages.Where(m => Filter(m));
        }

        public bool Filter(Message m)
        {
            var b = ORorAND(FilterByUser(m), FilterByText(m));
            b=ORorAND(b, FilterByDate(m));
            return b;
        }

        public bool FilterByUser(Message m)
        {
            return (UserFilter == "All") || (m.User == UserFilter);
        }

        public bool FilterByText(Message m)
        {
            return  m.Text.Contains(TextFilter);
        }

        public bool FilterByDate(Message m)
        {
            return (DateTime.Compare(FromDateFilter, m.ReceivingTime) <= 0) &&
                   (DateTime.Compare(m.ReceivingTime, ToDateFilter) <= 0);
        }

        public IEnumerator GetEnumerator()
        {
            return Messages.GetEnumerator();
        }

        public void SetFilterParams(string user, string text, DateTime from, DateTime to,Func<bool,bool,bool> boolOperator)
        {
            UserFilter = user;
            TextFilter = text;
            FromDateFilter = from;
            ToDateFilter = to;
            ORorAND = boolOperator;
        }

        public int Count()
        {
            return Messages.Count;
        }

        public int Capacity { get; set; } = 1000;
    
        private List<Message> Messages = new List<Message>();

        private string UserFilter="All";
        private string TextFilter="";
        private DateTime FromDateFilter=DateTime.MinValue;
        private DateTime ToDateFilter=DateTime.MaxValue;
        private Func<bool, bool, bool> ORorAND=(x,y)=>x||y;

    }
}
