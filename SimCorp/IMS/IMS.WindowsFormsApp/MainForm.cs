using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhone.Audio;
using SimCorp.IMS.MobilePhone.Charg;

namespace IMS.WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private IOutput Output;
        private Mobile MobilePhone = new SimcorpMobile("Samsung");
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            Output=new TextBoxOutput(this.OutTextBox);
        }

        private void PlaybackApplyButtonOnClick(object sender, EventArgs e)
        {           
            if (this.iPhoneHeadSetRadioButton.Checked)
            {
                MobilePhone.PlayBackComponent=new iPhoneHeadset(Output);
            }
            else if(this.SamsungHeadsetRadioButton.Checked)
            {
                MobilePhone.PlayBackComponent = new SamsungHeadset(Output);
            }
            else if(this.ExternalSpeakerRadioButton.Checked)
            {
                MobilePhone.PlayBackComponent = new ExternalPhoneSpeaker(Output);
            }
            else if(this.UnofficialHeadsetRadioButton.Checked)
            {
                MobilePhone.PlayBackComponent = new UnofficialPhoneHeadset(Output);
            }

            Output.WriteLine("Playback component has been set to the mobile. Play sound in mobile:");
            MobilePhone.Play("music");
            Output.WriteLine("");
        }

        private void ChargerApplyButtonOnClick(object sender, EventArgs e)
        {
            if (this.CarChargerRadioButton.Checked)
            {
                MobilePhone.ChargerDevice = new CarCharger(Output);
            }
            else if (this.ContactLessChargerRadioButton.Checked)
            {
                MobilePhone.ChargerDevice = new ContactlessCharger(Output);
            }
            else if (this.LaptopCableChargerRadioButton.Checked)
            {
                MobilePhone.ChargerDevice = new LaptopCableCharger(Output);
            }
            else if (this.PowerBankRadioButton.Checked)
            {
                MobilePhone.ChargerDevice = new PowerBankCharger(Output);
            }
            else if (this.SocetChargerRadioButton.Checked)
            {
                MobilePhone.ChargerDevice = new SocetCharger(Output);
            }

            Output.WriteLine("Charger device has been set to the mobile. Charging the mobile:");
            MobilePhone.Charge();
            Output.WriteLine("");
        }

        private void CleanButtonOnClick(object sender, EventArgs e)
        {
            ((TextBoxOutput)Output).Clear();
        }
    }
}
