﻿using System;
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
using SimCorp.IMS.MobilePhone.Battery;
using SimCorp.IMS.MobilePhone.Message;

namespace SimCorp.IMS.WindowsFormsAppSMS
{
    public partial class FormSMS : Form
    {
        private readonly Mobile MobilePhone;
        private readonly MessageFormater MessageFormater = new MessageFormater();

        public FormSMS()
        {
            MobilePhone = new SimcorpMobile("Nokia");
            InitializeComponent();
            FormattingComboBox.SelectedIndex = 0;
            UserComboBox.SelectedIndex = 0;

            MobilePhone.Battery.PowerDecreased += DecreaseChargeProgressBar;
            MobilePhone.Battery.PowerIncreased += IncreaseChargeProgressBar;
            ChargeProgressBar.Value = MobilePhone.Battery.Charge;
            MobilePhone.Battery.StartDischarging();

            MobilePhone.MessageStorage.SMSAdded+=new SMSReceivedDelegate(OnMessageReceivedHandler);
            MobilePhone.StartMessaging();
        }

        private void OnMessageReceivedHandler(MobilePhone.Message.Message message)
        {
            if (this.FilteredMessagesListView.InvokeRequired)
            {
                this.FilteredMessagesListView.Invoke(new SMSReceivedDelegate(OnMessageReceivedHandler), message);
            }
            else
            {
                string[] row=new string[] {message.User+message.Number, MessageFormater.FormaterMethod(message).ToString()};
                var item = new ListViewItem(row);
                FilteredMessagesListView.Items.Add(item);
            }
            
        }
        private void FormattingComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
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
            MobilePhone.Battery.CloseAllThreadsAndTasks();
            MobilePhone.CloseThreads();
        }

        private void UserComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
        {
            SetUpFilterParams();
        }

        private void SetUpFilterParams()
        {
            Func<bool, bool, bool> op = (a, b) => a || b;
            if (AndRadioButton.Checked)
            {
                op = (a, b) => a && b;
            }
            var user = UserComboBox.SelectedItem.ToString();
            var text = SearchTextBox.Text;
            var fromDate = FromDateTimePicker.Value;
            var toDate = ToDateTimePicker.Value;
            MobilePhone.MessageStorage.SetFilterParams(user, text, fromDate, toDate, op);
        }

        private void RefreshAllButtonOnClick(object sender, EventArgs e)
        {
            FilteredMessagesListView.Items.Clear();
            foreach (var message in MobilePhone.MessageStorage.GetFilteredMessages())
            {
                string[] row = new string[] { message.User + message.Number, MessageFormater.FormaterMethod(message).ToString() };
                var item = new ListViewItem(row);
                FilteredMessagesListView.Items.Add(item);
            }
        }

        private void OrRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            SetUpFilterParams();
        }

        private void AndRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            SetUpFilterParams();
        }

        private void SearchTextBoxOnTextChanged(object sender, EventArgs e)
        {
            SetUpFilterParams();
        }

        private void FromDateTimePickerOnValueChanged(object sender, EventArgs e)
        {
            SetUpFilterParams();
        }

        private void ToDateTimePickerOnValueChanged(object sender, EventArgs e)
        {
            SetUpFilterParams();
        }

        private void ChargeOffRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (ChargeOffRadioButton.Checked)
            {
                MobilePhone.Battery.PlugOutCharger();
            }
            else if (ChargeOnRadioButton.Checked)
            {
                MobilePhone.Battery.PlugInCharger();
            }
        }

        private void IncreaseChargeProgressBar()
        {
            if (ChargeProgressBar.InvokeRequired)
            {
                ChargeProgressBar.Invoke(new PowerChangeDelegate(IncreaseChargeProgressBar));
            }
            else
            {
                ChargeProgressBar.Value += 1;
            }         
        }

        private void DecreaseChargeProgressBar()
        {
            if (ChargeProgressBar.InvokeRequired)
            {
                ChargeProgressBar.Invoke(new PowerChangeDelegate(DecreaseChargeProgressBar));
            }
            else
            {
                ChargeProgressBar.Value -= 1;
            }
        }

        private void GenerateMessageOffRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (GenerateMessageOffRadioButton.Checked)
            {
               MobilePhone.StopMessaging(); 
            }else if(GenerateMessageOnRadioButton.Checked)
            {
                MobilePhone.StartMessaging();
            }
            
        }
    }
}
