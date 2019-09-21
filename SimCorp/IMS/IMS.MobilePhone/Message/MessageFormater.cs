using System;
using System.Globalization;

namespace SimCorp.IMS.MobilePhone.Message
{
    public class MessageFormater
    {
        public MessageFormater()
        {
            FormaterMethod = NoFormat;
        }

        public FormatDelegate FormaterMethod { get; set; }

        public Message NoFormat(Message message)
        {
            return message;
        }

        public Message StartWithDateTimeFormat(Message message)
        {
            var text=$"{message.ReceivingTime.ToString(CultureInfo.InvariantCulture)} {message.Text}";
            return new Message(message.User,message.Number,text,message.ReceivingTime);
        }

        public Message EndWithDateTimeFormat(Message message)
        {
            var text = $"{message.Text} {message.ReceivingTime.ToString(CultureInfo.InvariantCulture)}";
            return new Message(message.User, message.Number, text, message.ReceivingTime);
        }

        public Message UpperCaseFormat(Message message)
        {
            var text = message.Text.ToUpper();
            return new Message(message.User, message.Number, text, message.ReceivingTime);
        }

        public Message LowerCaseFormat(Message message)
        {
            var text = message.Text.ToLower();
            return new Message(message.User, message.Number, text, message.ReceivingTime);
        }
    }
}
