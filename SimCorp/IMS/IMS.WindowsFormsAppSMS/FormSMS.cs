using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.WindowsFormsAppSMS
{
    public partial class FormSMS : Form
    {
        private readonly Thread mobilePhoneThread;
        private readonly MessageFormater MessageFormater = new MessageFormater();
        public FormSMS()
        {
            InitializeComponent();

            SMSProvider smsProvider=new SMSProvider(999);
            smsProvider.SMSReceived+=new SMSReceivedDelegate(OnMesssageReceivedHandler);
            mobilePhoneThread=new Thread(smsProvider.SimulateSMS);
            mobilePhoneThread.Start();
        }

        private void OnMesssageReceivedHandler(string message)
        {
            if (this.MessageRichTextBox.InvokeRequired)
            {
                this.MessageRichTextBox.Invoke(new SMSReceivedDelegate(OnMesssageReceivedHandler), message);
            }
            else
            {
               this.MessageRichTextBox.AppendText(MessageFormater.FormaterMethod(message)); 
            }
            
        }
        private void FormattingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatDelegate [] formatDelegates=new FormatDelegate[]
            {
                MessageFormater.NoFormat,
                MessageFormater.StartWithDateTimeFormat,
                MessageFormater.EndWithDateTimeFormat,
                MessageFormater.LowerCaseFormat,
                MessageFormater.UpperCaseFormat
            };
            MessageFormater.FormaterMethod = formatDelegates[FormattingComboBox.SelectedIndex];
        }

        private void FormSMSOnClosed(object sender, EventArgs e)
        {
            mobilePhoneThread.Abort();
        }
    }
}
