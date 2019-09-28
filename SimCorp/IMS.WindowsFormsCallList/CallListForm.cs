using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone.Calls;

namespace IMS.WindowsFormsCallList
{
    public partial class CallListForm : Form
    {
        private CallProvider CallProvider=new CallProviderUseThreads();
        private CallList CallList=new CallList();
        public CallListForm()
        {
            InitializeComponent();
            CallProvider.CallReceived += OnCallReceived;
            CallProvider.StartCalling();
            CallProvider.DateToGenerate = DateTimePicker.Value;
        }

        public void OnCallReceived(Call call)
        {
            if (CallListListView.InvokeRequired)
            {
                CallListListView.Invoke(new CallReceivedDelegate(OnCallReceived), call);
            }
            else
            {
                CallListListView.Items.Clear();
                CallList.AddCall(call);
                foreach (var curCall in CallList.Calls)
                {
                    var name = curCall.Contact.Name;
                    var number = curCall.Number;
                    var time = curCall.Time.ToString(CultureInfo.InvariantCulture);
                    var direction = curCall.Direction.ToString();
                    var count = curCall.CountCallsInRow.ToString();
                    string[] row =new string[] {name,number,time,direction,count};
                    CallListListView.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void CallListFormOnClosed(object sender, EventArgs e)
        {
            CallProvider.CloseThreads();
        }

        private void OffRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (OnRadioButton.Checked)
            {
                CallProvider.StartCalling();
            }
            else
            {
                CallProvider.StopCalling();
            }
        }

        private void CallListFormOnLoad(object sender, EventArgs e)
        {
            CallDirectionComboBox.Items.Add(CallDirection.Incoming);
            CallDirectionComboBox.Items.Add(CallDirection.Outgoing);
            CallDirectionComboBox.SelectedIndex = 0;
        }

        private void UserComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
        {
            CallProvider.UserNameToGenerate = UserComboBox.SelectedItem.ToString();
        }

        private void DateTimePickerOnValueChanged(object sender, EventArgs e)
        {
            CallProvider.DateToGenerate = DateTimePicker.Value;
        }

        private void CallDirectionComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
        {
            CallProvider.DirectionToGenerate=(CallDirection) CallDirectionComboBox.SelectedItem;
        }
    }
}
