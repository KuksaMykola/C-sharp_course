using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.MobilePhone
{
    public delegate string FormatDelegate(string message);
    
    public class MessageFormater
    {
        public ITimeInfo TimeInfo { get; set;}=new TimeInfo();
        public MessageFormater()
        {
            FormaterMethod = NoFormat;
        }

        public FormatDelegate FormaterMethod { get; set; }

        public string NoFormat(string message)
        {
            return message+System.Environment.NewLine;
        }

        public string StartWithDateTimeFormat(string message)
        {
            return TimeInfo.GetCurrentTime()+message + Environment.NewLine;
        }

        public string EndWithDateTimeFormat(string message)
        {
            return message + TimeInfo.GetCurrentTime()+ Environment.NewLine;
        }

        public string UpperCaseFormat(string message)
        {
            return message.ToUpper() + Environment.NewLine;
        }

        public string LowerCaseFormat(string message)
        {
            return message.ToLower() + Environment.NewLine;
        }
    }
}
