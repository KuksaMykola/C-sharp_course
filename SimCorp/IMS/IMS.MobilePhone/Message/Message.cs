using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone.Message
{
    public class Message
    {
        public Message(string user, string number, string text, DateTime receivingTime)
        {
            User = user;
            Number = number;
            Text = text;
            ReceivingTime = receivingTime;
        }

        public Message(string text)
        {
            User = "unknown_user";
            Number = "unknown_nuber";
            Text = text;
            ReceivingTime=new DateTime();
        }
        public override string ToString()
        {
            return Text;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Message m = (Message)obj;
            return (User == m.User) && (Number==m.Number) && (Text==m.Text) && (ReceivingTime.Equals(m.ReceivingTime));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string User { get; private set; }
        public string Number { get; private set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; private set; }
    }
}
